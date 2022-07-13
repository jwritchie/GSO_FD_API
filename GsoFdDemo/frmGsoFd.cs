using GsoFdLibrary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GsoFdLibrary.GsoFdModels;

namespace GsoFdDemo
{
    /// <summary>
    /// WinForm for accessing API.
    /// </summary>
    public partial class frmGsoFd : Form
    {
        private DataTable dt;


        /// <summary>
        /// Form constructor.
        /// </summary>
        public frmGsoFd()
        {
            InitializeComponent();

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls13 | SecurityProtocolType.Tls12;     // | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            // Initialize HttpClient.
            ApiHelper.InitializeClient();

            dt = new DataTable();
        }


        /// <summary>
        /// Retrieve data from API, display in DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnLoadGsoFdData_Click(object sender, EventArgs e)
        {
            // Retrieve data from API.
            GsoFdRootobject gsoFdRootobject = await GetGsoFdDataAsync();

            // Load datatable.
            dt = ToDataTable(gsoFdRootobject.features);

            // Bind bsDgvGsoFd to datatable to display data.
            btnLoadGsoFdData.Invoke((MethodInvoker)(() => bsDgvGsoFd.DataSource = dt));
        }


        /// <summary>
        /// Retrieve data from API.
        /// </summary>
        /// <returns></returns>
        private async Task<GsoFdRootobject> GetGsoFdDataAsync()
        {
            String GsoFdRootobjectData = await Task.Run(() => GsoFdProcessor.LoadGsoFdData());

            GsoFdRootobject gsoFdRootobject = JsonConvert.DeserializeObject<GsoFdRootobject>(GsoFdRootobjectData, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            return gsoFdRootobject;
        }


        /// <summary>
        /// Populate datatable with data from GsoFdModel.Features.
        /// </summary>
        /// <param name="features"></param>
        /// <returns></returns>
        public static DataTable ToDataTable(IList<Feature> features)
        {
            DataTable table = new DataTable();

            // Set column names and data type (Retrieve from GsoFdModel.Attributes).
            PropertyInfo[] Properties = typeof(Attributes).GetProperties();
            foreach (PropertyInfo property in Properties)
            {
                DataColumn col = new DataColumn(property.Name, property.PropertyType);
                table.Columns.Add(col);
            }

            // Insert property values into the datatable's rows.
            foreach (Feature feature in features)
            {
                var item = feature.attributes;

                var values = new object[Properties.Length];
                for (int i = 0; i < Properties.Length; i++)
                {
                    if (Properties[i].PropertyType == typeof(string))
                    {
                        values[i] = Properties[i].GetValue(item, null).ToString().Trim();
                    }
                    else
                    {
                        values[i] = Properties[i].GetValue(item, null);
                    }
                }
                table.Rows.Add(values);
            }

            return table;
        }


        /// <summary>
        /// Bind dgvFsoFd.DataSource to BindingSource.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmGsoFd_Load(object sender, EventArgs e)
        {
            dgvGsoFd.DataSource = bsDgvGsoFd;
        }
    }
}
