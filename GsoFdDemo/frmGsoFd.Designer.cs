namespace GsoFdDemo
{
    partial class frmGsoFd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvGsoFd = new System.Windows.Forms.DataGridView();
            this.bsDgvGsoFd = new System.Windows.Forms.BindingSource(this.components);
            this.btnLoadGsoFdData = new System.Windows.Forms.Button();
            this.btnPushDataToExcel = new System.Windows.Forms.Button();
            this.NbrTotalRequested = new System.Windows.Forms.NumericUpDown();
            this.LblTotalRequested = new System.Windows.Forms.Label();
            this.BtnLoadSampleData = new System.Windows.Forms.Button();
            this.ChkLimitRecords = new System.Windows.Forms.CheckBox();
            this.LblLimitRecords = new System.Windows.Forms.Label();
            this.TxtLimitRecords = new System.Windows.Forms.TextBox();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.Chk01IncidentNumber = new System.Windows.Forms.CheckBox();
            this.PnlFields = new System.Windows.Forms.Panel();
            this.Chk02Month = new System.Windows.Forms.CheckBox();
            this.Chk03Day = new System.Windows.Forms.CheckBox();
            this.Chk04DayOfWeek = new System.Windows.Forms.CheckBox();
            this.Chk05Week = new System.Windows.Forms.CheckBox();
            this.Chk06Year = new System.Windows.Forms.CheckBox();
            this.Chk07TotalResponseTime = new System.Windows.Forms.CheckBox();
            this.Chk08P911CenterReceived = new System.Windows.Forms.CheckBox();
            this.Chk09AlarmDate = new System.Windows.Forms.CheckBox();
            this.Chk10UnderControlTime = new System.Windows.Forms.CheckBox();
            this.Chk11IncidentClearTime = new System.Windows.Forms.CheckBox();
            this.Chk12FireDistrict = new System.Windows.Forms.CheckBox();
            this.Chk13station = new System.Windows.Forms.CheckBox();
            this.Chk14shift = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.LblFieldsToInclude = new System.Windows.Forms.Label();
            this.BtnSelectAllFields = new System.Windows.Forms.Button();
            this.BtnSelectNoFields = new System.Windows.Forms.Button();
            this.Cbo02Month = new System.Windows.Forms.ComboBox();
            this.Cbo13Station = new System.Windows.Forms.ComboBox();
            this.Cbo06Year = new System.Windows.Forms.ComboBox();
            this.NbrDay = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGsoFd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDgvGsoFd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbrTotalRequested)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.PnlFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NbrDay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGsoFd
            // 
            this.dgvGsoFd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGsoFd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGsoFd.Location = new System.Drawing.Point(23, 78);
            this.dgvGsoFd.Name = "dgvGsoFd";
            this.dgvGsoFd.RowHeadersWidth = 62;
            this.dgvGsoFd.RowTemplate.Height = 28;
            this.dgvGsoFd.Size = new System.Drawing.Size(1295, 592);
            this.dgvGsoFd.TabIndex = 0;
            // 
            // btnLoadGsoFdData
            // 
            this.btnLoadGsoFdData.Location = new System.Drawing.Point(771, 20);
            this.btnLoadGsoFdData.Name = "btnLoadGsoFdData";
            this.btnLoadGsoFdData.Size = new System.Drawing.Size(194, 52);
            this.btnLoadGsoFdData.TabIndex = 1;
            this.btnLoadGsoFdData.Text = "Load GSO FD data";
            this.btnLoadGsoFdData.UseVisualStyleBackColor = true;
            this.btnLoadGsoFdData.Click += new System.EventHandler(this.btnLoadGsoFdData_Click);
            // 
            // btnPushDataToExcel
            // 
            this.btnPushDataToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPushDataToExcel.Location = new System.Drawing.Point(1124, 20);
            this.btnPushDataToExcel.Name = "btnPushDataToExcel";
            this.btnPushDataToExcel.Size = new System.Drawing.Size(194, 52);
            this.btnPushDataToExcel.TabIndex = 2;
            this.btnPushDataToExcel.Text = "Push data to Excel";
            this.btnPushDataToExcel.UseVisualStyleBackColor = true;
            this.btnPushDataToExcel.Click += new System.EventHandler(this.btnPushDataToExcel_Click);
            // 
            // NbrTotalRequested
            // 
            this.NbrTotalRequested.Location = new System.Drawing.Point(162, 34);
            this.NbrTotalRequested.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NbrTotalRequested.Name = "NbrTotalRequested";
            this.NbrTotalRequested.Size = new System.Drawing.Size(120, 26);
            this.NbrTotalRequested.TabIndex = 4;
            this.NbrTotalRequested.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NbrTotalRequested.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // LblTotalRequested
            // 
            this.LblTotalRequested.Location = new System.Drawing.Point(19, 20);
            this.LblTotalRequested.Name = "LblTotalRequested";
            this.LblTotalRequested.Size = new System.Drawing.Size(137, 52);
            this.LblTotalRequested.TabIndex = 5;
            this.LblTotalRequested.Text = "Maximum records to sample";
            this.LblTotalRequested.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnLoadSampleData
            // 
            this.BtnLoadSampleData.Location = new System.Drawing.Point(288, 20);
            this.BtnLoadSampleData.Name = "BtnLoadSampleData";
            this.BtnLoadSampleData.Size = new System.Drawing.Size(194, 52);
            this.BtnLoadSampleData.TabIndex = 6;
            this.BtnLoadSampleData.Text = "Sample the data";
            this.BtnLoadSampleData.UseVisualStyleBackColor = true;
            this.BtnLoadSampleData.Click += new System.EventHandler(this.BtnLoadSampleData_Click);
            // 
            // ChkLimitRecords
            // 
            this.ChkLimitRecords.AutoSize = true;
            this.ChkLimitRecords.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkLimitRecords.Location = new System.Drawing.Point(521, 20);
            this.ChkLimitRecords.Name = "ChkLimitRecords";
            this.ChkLimitRecords.Size = new System.Drawing.Size(165, 24);
            this.ChkLimitRecords.TabIndex = 7;
            this.ChkLimitRecords.Text = "Limit # of records?";
            this.ChkLimitRecords.UseVisualStyleBackColor = true;
            this.ChkLimitRecords.CheckedChanged += new System.EventHandler(this.ChkLimitRecords_CheckedChanged);
            // 
            // LblLimitRecords
            // 
            this.LblLimitRecords.AutoSize = true;
            this.LblLimitRecords.Enabled = false;
            this.LblLimitRecords.Location = new System.Drawing.Point(523, 49);
            this.LblLimitRecords.Name = "LblLimitRecords";
            this.LblLimitRecords.Size = new System.Drawing.Size(133, 20);
            this.LblLimitRecords.TabIndex = 8;
            this.LblLimitRecords.Text = "Maximum records";
            // 
            // TxtLimitRecords
            // 
            this.TxtLimitRecords.Enabled = false;
            this.TxtLimitRecords.Location = new System.Drawing.Point(665, 46);
            this.TxtLimitRecords.Name = "TxtLimitRecords";
            this.TxtLimitRecords.Size = new System.Drawing.Size(100, 26);
            this.TxtLimitRecords.TabIndex = 9;
            this.TxtLimitRecords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SplitContainer
            // 
            this.SplitContainer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.AutoScroll = true;
            this.SplitContainer.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.SplitContainer.Panel1.Controls.Add(this.BtnSelectNoFields);
            this.SplitContainer.Panel1.Controls.Add(this.BtnSelectAllFields);
            this.SplitContainer.Panel1.Controls.Add(this.LblFieldsToInclude);
            this.SplitContainer.Panel1.Controls.Add(this.PnlFields);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.SplitContainer.Panel2.Controls.Add(this.dgvGsoFd);
            this.SplitContainer.Panel2.Controls.Add(this.btnPushDataToExcel);
            this.SplitContainer.Panel2.Controls.Add(this.TxtLimitRecords);
            this.SplitContainer.Panel2.Controls.Add(this.btnLoadGsoFdData);
            this.SplitContainer.Panel2.Controls.Add(this.LblLimitRecords);
            this.SplitContainer.Panel2.Controls.Add(this.NbrTotalRequested);
            this.SplitContainer.Panel2.Controls.Add(this.ChkLimitRecords);
            this.SplitContainer.Panel2.Controls.Add(this.LblTotalRequested);
            this.SplitContainer.Panel2.Controls.Add(this.BtnLoadSampleData);
            this.SplitContainer.Size = new System.Drawing.Size(1658, 682);
            this.SplitContainer.SplitterDistance = 318;
            this.SplitContainer.SplitterWidth = 10;
            this.SplitContainer.TabIndex = 10;
            // 
            // Chk01IncidentNumber
            // 
            this.Chk01IncidentNumber.AutoSize = true;
            this.Chk01IncidentNumber.Location = new System.Drawing.Point(21, 18);
            this.Chk01IncidentNumber.Name = "Chk01IncidentNumber";
            this.Chk01IncidentNumber.Size = new System.Drawing.Size(148, 24);
            this.Chk01IncidentNumber.TabIndex = 0;
            this.Chk01IncidentNumber.Text = "IncidentNumber";
            this.Chk01IncidentNumber.UseVisualStyleBackColor = true;
            // 
            // PnlFields
            // 
            this.PnlFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlFields.AutoScroll = true;
            this.PnlFields.Controls.Add(this.NbrDay);
            this.PnlFields.Controls.Add(this.Cbo06Year);
            this.PnlFields.Controls.Add(this.Cbo13Station);
            this.PnlFields.Controls.Add(this.Cbo02Month);
            this.PnlFields.Controls.Add(this.checkBox20);
            this.PnlFields.Controls.Add(this.checkBox19);
            this.PnlFields.Controls.Add(this.checkBox18);
            this.PnlFields.Controls.Add(this.checkBox17);
            this.PnlFields.Controls.Add(this.checkBox16);
            this.PnlFields.Controls.Add(this.checkBox15);
            this.PnlFields.Controls.Add(this.Chk14shift);
            this.PnlFields.Controls.Add(this.Chk13station);
            this.PnlFields.Controls.Add(this.Chk12FireDistrict);
            this.PnlFields.Controls.Add(this.Chk11IncidentClearTime);
            this.PnlFields.Controls.Add(this.Chk10UnderControlTime);
            this.PnlFields.Controls.Add(this.Chk09AlarmDate);
            this.PnlFields.Controls.Add(this.Chk08P911CenterReceived);
            this.PnlFields.Controls.Add(this.Chk07TotalResponseTime);
            this.PnlFields.Controls.Add(this.Chk06Year);
            this.PnlFields.Controls.Add(this.Chk05Week);
            this.PnlFields.Controls.Add(this.Chk04DayOfWeek);
            this.PnlFields.Controls.Add(this.Chk03Day);
            this.PnlFields.Controls.Add(this.Chk02Month);
            this.PnlFields.Controls.Add(this.Chk01IncidentNumber);
            this.PnlFields.Location = new System.Drawing.Point(3, 78);
            this.PnlFields.Name = "PnlFields";
            this.PnlFields.Size = new System.Drawing.Size(312, 601);
            this.PnlFields.TabIndex = 1;
            // 
            // Chk02Month
            // 
            this.Chk02Month.AutoSize = true;
            this.Chk02Month.Location = new System.Drawing.Point(21, 48);
            this.Chk02Month.Name = "Chk02Month";
            this.Chk02Month.Size = new System.Drawing.Size(80, 24);
            this.Chk02Month.TabIndex = 1;
            this.Chk02Month.Text = "Month";
            this.Chk02Month.UseVisualStyleBackColor = true;
            // 
            // Chk03Day
            // 
            this.Chk03Day.AutoSize = true;
            this.Chk03Day.Location = new System.Drawing.Point(21, 78);
            this.Chk03Day.Name = "Chk03Day";
            this.Chk03Day.Size = new System.Drawing.Size(63, 24);
            this.Chk03Day.TabIndex = 2;
            this.Chk03Day.Text = "Day";
            this.Chk03Day.UseVisualStyleBackColor = true;
            // 
            // Chk04DayOfWeek
            // 
            this.Chk04DayOfWeek.AutoSize = true;
            this.Chk04DayOfWeek.Location = new System.Drawing.Point(21, 108);
            this.Chk04DayOfWeek.Name = "Chk04DayOfWeek";
            this.Chk04DayOfWeek.Size = new System.Drawing.Size(121, 24);
            this.Chk04DayOfWeek.TabIndex = 3;
            this.Chk04DayOfWeek.Text = "DayOfWeek";
            this.Chk04DayOfWeek.UseVisualStyleBackColor = true;
            // 
            // Chk05Week
            // 
            this.Chk05Week.AutoSize = true;
            this.Chk05Week.Location = new System.Drawing.Point(21, 138);
            this.Chk05Week.Name = "Chk05Week";
            this.Chk05Week.Size = new System.Drawing.Size(76, 24);
            this.Chk05Week.TabIndex = 4;
            this.Chk05Week.Text = "Week";
            this.Chk05Week.UseVisualStyleBackColor = true;
            // 
            // Chk06Year
            // 
            this.Chk06Year.AutoSize = true;
            this.Chk06Year.Location = new System.Drawing.Point(21, 168);
            this.Chk06Year.Name = "Chk06Year";
            this.Chk06Year.Size = new System.Drawing.Size(69, 24);
            this.Chk06Year.TabIndex = 5;
            this.Chk06Year.Text = "Year";
            this.Chk06Year.UseVisualStyleBackColor = true;
            // 
            // Chk07TotalResponseTime
            // 
            this.Chk07TotalResponseTime.AutoSize = true;
            this.Chk07TotalResponseTime.Location = new System.Drawing.Point(21, 198);
            this.Chk07TotalResponseTime.Name = "Chk07TotalResponseTime";
            this.Chk07TotalResponseTime.Size = new System.Drawing.Size(177, 24);
            this.Chk07TotalResponseTime.TabIndex = 6;
            this.Chk07TotalResponseTime.Text = "TotalResponseTime";
            this.Chk07TotalResponseTime.UseVisualStyleBackColor = true;
            // 
            // Chk08P911CenterReceived
            // 
            this.Chk08P911CenterReceived.AutoSize = true;
            this.Chk08P911CenterReceived.Location = new System.Drawing.Point(21, 228);
            this.Chk08P911CenterReceived.Name = "Chk08P911CenterReceived";
            this.Chk08P911CenterReceived.Size = new System.Drawing.Size(186, 24);
            this.Chk08P911CenterReceived.TabIndex = 7;
            this.Chk08P911CenterReceived.Text = "P911CenterReceived";
            this.Chk08P911CenterReceived.UseVisualStyleBackColor = true;
            // 
            // Chk09AlarmDate
            // 
            this.Chk09AlarmDate.AutoSize = true;
            this.Chk09AlarmDate.Location = new System.Drawing.Point(21, 258);
            this.Chk09AlarmDate.Name = "Chk09AlarmDate";
            this.Chk09AlarmDate.Size = new System.Drawing.Size(111, 24);
            this.Chk09AlarmDate.TabIndex = 8;
            this.Chk09AlarmDate.Text = "AlarmDate";
            this.Chk09AlarmDate.UseVisualStyleBackColor = true;
            // 
            // Chk10UnderControlTime
            // 
            this.Chk10UnderControlTime.AutoSize = true;
            this.Chk10UnderControlTime.Location = new System.Drawing.Point(21, 288);
            this.Chk10UnderControlTime.Name = "Chk10UnderControlTime";
            this.Chk10UnderControlTime.Size = new System.Drawing.Size(164, 24);
            this.Chk10UnderControlTime.TabIndex = 9;
            this.Chk10UnderControlTime.Text = "UnderControlTime";
            this.Chk10UnderControlTime.UseVisualStyleBackColor = true;
            // 
            // Chk11IncidentClearTime
            // 
            this.Chk11IncidentClearTime.AutoSize = true;
            this.Chk11IncidentClearTime.Location = new System.Drawing.Point(21, 318);
            this.Chk11IncidentClearTime.Name = "Chk11IncidentClearTime";
            this.Chk11IncidentClearTime.Size = new System.Drawing.Size(163, 24);
            this.Chk11IncidentClearTime.TabIndex = 10;
            this.Chk11IncidentClearTime.Text = "IncidentClearTime";
            this.Chk11IncidentClearTime.UseVisualStyleBackColor = true;
            // 
            // Chk12FireDistrict
            // 
            this.Chk12FireDistrict.AutoSize = true;
            this.Chk12FireDistrict.Location = new System.Drawing.Point(21, 348);
            this.Chk12FireDistrict.Name = "Chk12FireDistrict";
            this.Chk12FireDistrict.Size = new System.Drawing.Size(111, 24);
            this.Chk12FireDistrict.TabIndex = 11;
            this.Chk12FireDistrict.Text = "FireDistrict";
            this.Chk12FireDistrict.UseVisualStyleBackColor = true;
            // 
            // Chk13station
            // 
            this.Chk13station.AutoSize = true;
            this.Chk13station.Location = new System.Drawing.Point(21, 378);
            this.Chk13station.Name = "Chk13station";
            this.Chk13station.Size = new System.Drawing.Size(83, 24);
            this.Chk13station.TabIndex = 12;
            this.Chk13station.Text = "station";
            this.Chk13station.UseVisualStyleBackColor = true;
            // 
            // Chk14shift
            // 
            this.Chk14shift.AutoSize = true;
            this.Chk14shift.Location = new System.Drawing.Point(21, 408);
            this.Chk14shift.Name = "Chk14shift";
            this.Chk14shift.Size = new System.Drawing.Size(65, 24);
            this.Chk14shift.TabIndex = 13;
            this.Chk14shift.Text = "shift";
            this.Chk14shift.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(21, 438);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(122, 24);
            this.checkBox15.TabIndex = 14;
            this.checkBox15.Text = "checkBox15";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(21, 468);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(122, 24);
            this.checkBox16.TabIndex = 15;
            this.checkBox16.Text = "checkBox16";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Location = new System.Drawing.Point(21, 498);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(122, 24);
            this.checkBox17.TabIndex = 16;
            this.checkBox17.Text = "checkBox17";
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Location = new System.Drawing.Point(21, 528);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(122, 24);
            this.checkBox18.TabIndex = 17;
            this.checkBox18.Text = "checkBox18";
            this.checkBox18.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.Location = new System.Drawing.Point(21, 558);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(122, 24);
            this.checkBox19.TabIndex = 18;
            this.checkBox19.Text = "checkBox19";
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.Location = new System.Drawing.Point(21, 588);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(122, 24);
            this.checkBox20.TabIndex = 11;
            this.checkBox20.Text = "checkBox20";
            this.checkBox20.UseVisualStyleBackColor = true;
            // 
            // LblFieldsToInclude
            // 
            this.LblFieldsToInclude.AutoSize = true;
            this.LblFieldsToInclude.Location = new System.Drawing.Point(96, 10);
            this.LblFieldsToInclude.Name = "LblFieldsToInclude";
            this.LblFieldsToInclude.Size = new System.Drawing.Size(127, 20);
            this.LblFieldsToInclude.TabIndex = 10;
            this.LblFieldsToInclude.Text = "Fields to include:";
            // 
            // BtnSelectAllFields
            // 
            this.BtnSelectAllFields.Location = new System.Drawing.Point(3, 40);
            this.BtnSelectAllFields.Name = "BtnSelectAllFields";
            this.BtnSelectAllFields.Size = new System.Drawing.Size(150, 32);
            this.BtnSelectAllFields.TabIndex = 10;
            this.BtnSelectAllFields.Text = "Select ALL";
            this.BtnSelectAllFields.UseVisualStyleBackColor = true;
            this.BtnSelectAllFields.Click += new System.EventHandler(this.BtnSelectAllFields_Click);
            // 
            // BtnSelectNoFields
            // 
            this.BtnSelectNoFields.Location = new System.Drawing.Point(165, 40);
            this.BtnSelectNoFields.Name = "BtnSelectNoFields";
            this.BtnSelectNoFields.Size = new System.Drawing.Size(150, 32);
            this.BtnSelectNoFields.TabIndex = 11;
            this.BtnSelectNoFields.Text = "Select NONE";
            this.BtnSelectNoFields.UseVisualStyleBackColor = true;
            this.BtnSelectNoFields.Click += new System.EventHandler(this.BtnSelectNoFields_Click);
            // 
            // Cbo02Month
            // 
            this.Cbo02Month.FormattingEnabled = true;
            this.Cbo02Month.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.Cbo02Month.Location = new System.Drawing.Point(110, 46);
            this.Cbo02Month.Name = "Cbo02Month";
            this.Cbo02Month.Size = new System.Drawing.Size(121, 28);
            this.Cbo02Month.TabIndex = 19;
            // 
            // Cbo13Station
            // 
            this.Cbo13Station.FormattingEnabled = true;
            this.Cbo13Station.Location = new System.Drawing.Point(110, 376);
            this.Cbo13Station.Name = "Cbo13Station";
            this.Cbo13Station.Size = new System.Drawing.Size(121, 28);
            this.Cbo13Station.TabIndex = 20;
            // 
            // Cbo06Year
            // 
            this.Cbo06Year.FormattingEnabled = true;
            this.Cbo06Year.Location = new System.Drawing.Point(110, 166);
            this.Cbo06Year.Name = "Cbo06Year";
            this.Cbo06Year.Size = new System.Drawing.Size(121, 28);
            this.Cbo06Year.TabIndex = 21;
            // 
            // NbrDay
            // 
            this.NbrDay.Location = new System.Drawing.Point(111, 77);
            this.NbrDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.NbrDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NbrDay.Name = "NbrDay";
            this.NbrDay.Size = new System.Drawing.Size(120, 26);
            this.NbrDay.TabIndex = 22;
            this.NbrDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NbrDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmGsoFd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1658, 682);
            this.Controls.Add(this.SplitContainer);
            this.MinimumSize = new System.Drawing.Size(1680, 500);
            this.Name = "frmGsoFd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GSO Fire Dept API demo";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmGsoFd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGsoFd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDgvGsoFd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbrTotalRequested)).EndInit();
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel1.PerformLayout();
            this.SplitContainer.Panel2.ResumeLayout(false);
            this.SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.PnlFields.ResumeLayout(false);
            this.PnlFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NbrDay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGsoFd;
        private System.Windows.Forms.BindingSource bsDgvGsoFd;
        private System.Windows.Forms.Button btnLoadGsoFdData;
        private System.Windows.Forms.Button btnPushDataToExcel;
        private System.Windows.Forms.NumericUpDown NbrTotalRequested;
        private System.Windows.Forms.Label LblTotalRequested;
        private System.Windows.Forms.Button BtnLoadSampleData;
        private System.Windows.Forms.CheckBox ChkLimitRecords;
        private System.Windows.Forms.Label LblLimitRecords;
        private System.Windows.Forms.TextBox TxtLimitRecords;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.Label LblFieldsToInclude;
        private System.Windows.Forms.Panel PnlFields;
        private System.Windows.Forms.CheckBox checkBox20;
        private System.Windows.Forms.CheckBox checkBox19;
        private System.Windows.Forms.CheckBox checkBox18;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox Chk14shift;
        private System.Windows.Forms.CheckBox Chk13station;
        private System.Windows.Forms.CheckBox Chk12FireDistrict;
        private System.Windows.Forms.CheckBox Chk11IncidentClearTime;
        private System.Windows.Forms.CheckBox Chk10UnderControlTime;
        private System.Windows.Forms.CheckBox Chk09AlarmDate;
        private System.Windows.Forms.CheckBox Chk08P911CenterReceived;
        private System.Windows.Forms.CheckBox Chk07TotalResponseTime;
        private System.Windows.Forms.CheckBox Chk06Year;
        private System.Windows.Forms.CheckBox Chk05Week;
        private System.Windows.Forms.CheckBox Chk04DayOfWeek;
        private System.Windows.Forms.CheckBox Chk03Day;
        private System.Windows.Forms.CheckBox Chk02Month;
        private System.Windows.Forms.CheckBox Chk01IncidentNumber;
        private System.Windows.Forms.Button BtnSelectNoFields;
        private System.Windows.Forms.Button BtnSelectAllFields;
        private System.Windows.Forms.NumericUpDown NbrDay;
        private System.Windows.Forms.ComboBox Cbo06Year;
        private System.Windows.Forms.ComboBox Cbo13Station;
        private System.Windows.Forms.ComboBox Cbo02Month;
    }
}