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
            ((System.ComponentModel.ISupportInitialize)(this.dgvGsoFd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDgvGsoFd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbrTotalRequested)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGsoFd
            // 
            this.dgvGsoFd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGsoFd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGsoFd.Location = new System.Drawing.Point(12, 70);
            this.dgvGsoFd.Name = "dgvGsoFd";
            this.dgvGsoFd.RowHeadersWidth = 62;
            this.dgvGsoFd.RowTemplate.Height = 28;
            this.dgvGsoFd.Size = new System.Drawing.Size(1404, 388);
            this.dgvGsoFd.TabIndex = 0;
            // 
            // btnLoadGsoFdData
            // 
            this.btnLoadGsoFdData.Location = new System.Drawing.Point(760, 12);
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
            this.btnPushDataToExcel.Location = new System.Drawing.Point(1222, 12);
            this.btnPushDataToExcel.Name = "btnPushDataToExcel";
            this.btnPushDataToExcel.Size = new System.Drawing.Size(194, 52);
            this.btnPushDataToExcel.TabIndex = 2;
            this.btnPushDataToExcel.Text = "Push data to Excel";
            this.btnPushDataToExcel.UseVisualStyleBackColor = true;
            this.btnPushDataToExcel.Click += new System.EventHandler(this.btnPushDataToExcel_Click);
            // 
            // NbrTotalRequested
            // 
            this.NbrTotalRequested.Location = new System.Drawing.Point(151, 26);
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
            this.LblTotalRequested.Location = new System.Drawing.Point(8, 12);
            this.LblTotalRequested.Name = "LblTotalRequested";
            this.LblTotalRequested.Size = new System.Drawing.Size(137, 52);
            this.LblTotalRequested.TabIndex = 5;
            this.LblTotalRequested.Text = "Maximum records to sample";
            this.LblTotalRequested.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnLoadSampleData
            // 
            this.BtnLoadSampleData.Location = new System.Drawing.Point(277, 12);
            this.BtnLoadSampleData.Name = "BtnLoadSampleData";
            this.BtnLoadSampleData.Size = new System.Drawing.Size(194, 52);
            this.BtnLoadSampleData.TabIndex = 6;
            this.BtnLoadSampleData.Text = "Sample the data";
            this.BtnLoadSampleData.UseVisualStyleBackColor = true;
            // 
            // ChkLimitRecords
            // 
            this.ChkLimitRecords.AutoSize = true;
            this.ChkLimitRecords.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkLimitRecords.Location = new System.Drawing.Point(510, 12);
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
            this.LblLimitRecords.Location = new System.Drawing.Point(512, 41);
            this.LblLimitRecords.Name = "LblLimitRecords";
            this.LblLimitRecords.Size = new System.Drawing.Size(133, 20);
            this.LblLimitRecords.TabIndex = 8;
            this.LblLimitRecords.Text = "Maximum records";
            // 
            // TxtLimitRecords
            // 
            this.TxtLimitRecords.Enabled = false;
            this.TxtLimitRecords.Location = new System.Drawing.Point(654, 38);
            this.TxtLimitRecords.Name = "TxtLimitRecords";
            this.TxtLimitRecords.Size = new System.Drawing.Size(100, 26);
            this.TxtLimitRecords.TabIndex = 9;
            this.TxtLimitRecords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmGsoFd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 470);
            this.Controls.Add(this.TxtLimitRecords);
            this.Controls.Add(this.LblLimitRecords);
            this.Controls.Add(this.ChkLimitRecords);
            this.Controls.Add(this.BtnLoadSampleData);
            this.Controls.Add(this.LblTotalRequested);
            this.Controls.Add(this.NbrTotalRequested);
            this.Controls.Add(this.btnPushDataToExcel);
            this.Controls.Add(this.btnLoadGsoFdData);
            this.Controls.Add(this.dgvGsoFd);
            this.MinimumSize = new System.Drawing.Size(1450, 500);
            this.Name = "frmGsoFd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GSO Fire Dept API demo";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmGsoFd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGsoFd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDgvGsoFd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbrTotalRequested)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}