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
using Excel = Microsoft.Office.Interop.Excel;

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

            LblLimitRecords.Enabled = false;
            TxtLimitRecords.Enabled = false;

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls13 | SecurityProtocolType.Tls12;     // | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            // Initialize HttpClient.
            ApiHelper.InitializeClient();

            dt = new DataTable();

            Dictionary<string, string> queryData = new Dictionary<string, string>();
            DisplayData(queryData, true, 0);
        }


        /// <summary>
        /// Retrieve sample dataset, display in DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLoadSampleData_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> queryData = new Dictionary<string, string>();
            int totalRequested = (int)NbrTotalRequested.Value;
            DisplayData(queryData, true, totalRequested);
        }


        /// <summary>
        /// Retrieve data from API, display in DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadGsoFdData_Click(object sender, EventArgs e)
        {
            bool limit = ChkLimitRecords.Checked;
            int totalRequested;
            bool success = Int32.TryParse(TxtLimitRecords.Text, out totalRequested);

            if (ChkLimitRecords.Checked)
            {
                if (success)
                {
                    if (totalRequested > 0)
                    {
                        Dictionary<string, string> queryData = new Dictionary<string, string>()
                        {
                            ["Year"] = "'2022'",
                            ["Month"] = "'01'",
                            ["Day"] = "01",
                            ["station"] = "'07'"
                        };

                        DisplayData(queryData, limit, totalRequested);
                    }
                    else
                    {
                        MessageBox.Show("Maximum records requested must be a whole number, greater than zero.");
                    }
                }
                else
                {
                    MessageBox.Show("Maximum records requested must be a whole number.");
                }
            }
            else
            {
                Dictionary<string, string> queryData = new Dictionary<string, string>()
                {
                    ["Year"] = "'2022'",
                    ["Month"] = "'01'",
                    ["Day"] = "01",
                    ["station"] = "'07'"
                };

                DisplayData(queryData, limit, totalRequested);
            }
        }


        /// <summary>
        /// Display retrieved data in DataGridView.
        /// </summary>
        /// <param name="queryData">Query parameters</param>
        /// <param name="totalRequested">Maximum records to sample</param>
        private async void DisplayData(Dictionary<string,string> queryData, bool limit, int totalRequested)
        {
            // Retrieve data from API.
            GsoFdRootobject gsoFdRootobject = await GetGsoFdDataAsync(queryData, limit, totalRequested);

            // Load datatable.
            dt = ToDataTable(gsoFdRootobject.features);

            // Bind bsDgvGsoFd to datatable to display data.
            btnLoadGsoFdData.Invoke((MethodInvoker)(() => bsDgvGsoFd.DataSource = dt));
        }


        /// <summary>
        /// Retrieve data from API.
        /// </summary>
        /// <returns></returns>
        private async Task<GsoFdRootobject> GetGsoFdDataAsync(Dictionary<string,string> queryData, bool limit, int totalRequested)
        {
            String GsoFdRootobjectData = await Task.Run(() => GsoFdProcessor.LoadGsoFdData(queryData, limit, totalRequested));

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

            if (features != null)
            {
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


        /// <summary>
        /// Insert data from DataTable into Excel Activesheet.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPushDataToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Worksheet ws = (Excel.Worksheet)Globals.ThisWorkbook.ActiveSheet;

                // Insert column headers.
                foreach (DataColumn dataColumn in dt.Columns)
                {
                    ws.Cells[2, dataColumn.Ordinal + 1] = dataColumn.ColumnName;
                }

                // Insert data from DataTable.
                int currentRow = 3;
                foreach (DataRow dataRow in dt.Rows)
                {
                    // Loop through all columns in DataTable.
                    for (int currentColumn = 1; currentColumn <= dt.Columns.Count; currentColumn++)
                    {
                        ws.Cells[currentRow, currentColumn] = dataRow[currentColumn - 1].ToString();
                    }
                    currentRow++;
                }

                // Insert ListObject.
                Excel.Range range = (Excel.Range)ws.Range["A2"];
                Excel.ListObject listObject = (Excel.ListObject)ws.ListObjects.AddEx(XlListObjectHasHeaders: Excel.XlYesNoGuess.xlYes, Destination: range);

                // Insert total/displayed records count.
                ws.Range["A1"].Formula = "= COUNTA(Table1[IncidentNumber]) & \" records / \" & SUBTOTAL(103, Table1[IncidentNumber]) & \" shown\"";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ChkLimitRecords_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkLimitRecords.Checked)
            {
                LblLimitRecords.Enabled = true;
                TxtLimitRecords.Enabled = true;
            }
            else
            {
                LblLimitRecords.Enabled = false;
                TxtLimitRecords.Enabled = false;
            }

            TxtLimitRecords.Clear();
        }

    }
}
