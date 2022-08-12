namespace GsoFdDemo
{
    partial class GsoFdRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public GsoFdRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GsoFdRibbonTab = this.Factory.CreateRibbonTab();
            this.GsoFdApiGroup = this.Factory.CreateRibbonGroup();
            this.GsoFdRbnBtnDisplayForm = this.Factory.CreateRibbonButton();
            this.GsoFdRibbonTab.SuspendLayout();
            this.GsoFdApiGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // GsoFdRibbonTab
            // 
            this.GsoFdRibbonTab.Groups.Add(this.GsoFdApiGroup);
            this.GsoFdRibbonTab.Label = "GSO FD API Demo";
            this.GsoFdRibbonTab.Name = "GsoFdRibbonTab";
            // 
            // GsoFdApiGroup
            // 
            this.GsoFdApiGroup.Items.Add(this.GsoFdRbnBtnDisplayForm);
            this.GsoFdApiGroup.Label = "_   Access the API   _";
            this.GsoFdApiGroup.Name = "GsoFdApiGroup";
            // 
            // GsoFdRbnBtnDisplayForm
            // 
            this.GsoFdRbnBtnDisplayForm.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.GsoFdRbnBtnDisplayForm.Label = "API Dialog";
            this.GsoFdRbnBtnDisplayForm.Name = "GsoFdRbnBtnDisplayForm";
            this.GsoFdRbnBtnDisplayForm.OfficeImageId = "DataFormExcel";
            this.GsoFdRbnBtnDisplayForm.ShowImage = true;
            this.GsoFdRbnBtnDisplayForm.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.GsoFdRbnBtnDisplayForm_Click);
            // 
            // GsoFdRibbon
            // 
            this.Name = "GsoFdRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.GsoFdRibbonTab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.GsoFdRibbon_Load);
            this.GsoFdRibbonTab.ResumeLayout(false);
            this.GsoFdRibbonTab.PerformLayout();
            this.GsoFdApiGroup.ResumeLayout(false);
            this.GsoFdApiGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab GsoFdRibbonTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup GsoFdApiGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton GsoFdRbnBtnDisplayForm;
    }

    partial class ThisRibbonCollection
    {
        internal GsoFdRibbon GsoFdRibbon
        {
            get { return this.GetRibbon<GsoFdRibbon>(); }
        }
    }
}
