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
            ((System.ComponentModel.ISupportInitialize)(this.dgvGsoFd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDgvGsoFd)).BeginInit();
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
            this.dgvGsoFd.Size = new System.Drawing.Size(776, 368);
            this.dgvGsoFd.TabIndex = 0;
            // 
            // btnLoadGsoFdData
            // 
            this.btnLoadGsoFdData.Location = new System.Drawing.Point(12, 12);
            this.btnLoadGsoFdData.Name = "btnLoadGsoFdData";
            this.btnLoadGsoFdData.Size = new System.Drawing.Size(194, 52);
            this.btnLoadGsoFdData.TabIndex = 1;
            this.btnLoadGsoFdData.Text = "Load GSO FD data";
            this.btnLoadGsoFdData.UseVisualStyleBackColor = true;
            this.btnLoadGsoFdData.Click += new System.EventHandler(this.btnLoadGsoFdData_Click);
            // 
            // frmGsoFd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoadGsoFdData);
            this.Controls.Add(this.dgvGsoFd);
            this.Name = "frmGsoFd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GSO Fire Dept API demo";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmGsoFd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGsoFd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDgvGsoFd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGsoFd;
        private System.Windows.Forms.BindingSource bsDgvGsoFd;
        private System.Windows.Forms.Button btnLoadGsoFdData;
    }
}