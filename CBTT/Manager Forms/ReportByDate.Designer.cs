namespace TTCM
{
    partial class ReportByDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportByDate));
            this._fromDate = new System.Windows.Forms.DateTimePicker();
            this._dgvExport = new System.Windows.Forms.DataGridView();
            this._btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._txtCustomerInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._txtSearchCustomer = new System.Windows.Forms.TextBox();
            this._lblExportTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._toDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._dgvImport = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this._lblImportTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this._lblFinalInterest = new System.Windows.Forms.Label();
            this._btnContinuePlaying = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dgvExport)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvImport)).BeginInit();
            this.SuspendLayout();
            // 
            // _fromDate
            // 
            this._fromDate.Location = new System.Drawing.Point(52, 32);
            this._fromDate.Name = "_fromDate";
            this._fromDate.Size = new System.Drawing.Size(200, 20);
            this._fromDate.TabIndex = 0;
            this._fromDate.ValueChanged += new System.EventHandler(this._dateTimePicker_ValueChanged);
            // 
            // _dgvExport
            // 
            this._dgvExport.AllowUserToAddRows = false;
            this._dgvExport.AllowUserToDeleteRows = false;
            this._dgvExport.AllowUserToResizeColumns = false;
            this._dgvExport.AllowUserToResizeRows = false;
            this._dgvExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._dgvExport.Location = new System.Drawing.Point(440, 113);
            this._dgvExport.MultiSelect = false;
            this._dgvExport.Name = "_dgvExport";
            this._dgvExport.ReadOnly = true;
            this._dgvExport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this._dgvExport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this._dgvExport.Size = new System.Drawing.Size(230, 350);
            this._dgvExport.TabIndex = 3;
            this._dgvExport.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this._dgvReport_CellMouseClick);
            this._dgvExport.SelectionChanged += new System.EventHandler(this._dgvReport_SelectionChanged);
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(732, 469);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 37);
            this._btnCancel.TabIndex = 5;
            this._btnCancel.Text = "Thoát";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._txtCustomerInfo);
            this.groupBox1.Location = new System.Drawing.Point(678, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 369);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đã lấy";
            // 
            // _txtCustomerInfo
            // 
            this._txtCustomerInfo.Location = new System.Drawing.Point(6, 19);
            this._txtCustomerInfo.Multiline = true;
            this._txtCustomerInfo.Name = "_txtCustomerInfo";
            this._txtCustomerInfo.ReadOnly = true;
            this._txtCustomerInfo.Size = new System.Drawing.Size(168, 344);
            this._txtCustomerInfo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tìm khách hàng";
            // 
            // _txtSearchCustomer
            // 
            this._txtSearchCustomer.Location = new System.Drawing.Point(537, 469);
            this._txtSearchCustomer.Name = "_txtSearchCustomer";
            this._txtSearchCustomer.Size = new System.Drawing.Size(133, 20);
            this._txtSearchCustomer.TabIndex = 4;
            this._txtSearchCustomer.TextChanged += new System.EventHandler(this._txtSearchCustomer_TextChanged);
            // 
            // _lblExportTotal
            // 
            this._lblExportTotal.AutoSize = true;
            this._lblExportTotal.Location = new System.Drawing.Point(505, 83);
            this._lblExportTotal.Name = "_lblExportTotal";
            this._lblExportTotal.Size = new System.Drawing.Size(13, 13);
            this._lblExportTotal.TabIndex = 11;
            this._lblExportTotal.Text = "0";
            this._lblExportTotal.TextChanged += new System.EventHandler(this._lblExportTotal_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Xuất:";
            // 
            // _toDate
            // 
            this._toDate.CustomFormat = "";
            this._toDate.Location = new System.Drawing.Point(337, 32);
            this._toDate.Name = "_toDate";
            this._toDate.Size = new System.Drawing.Size(200, 20);
            this._toDate.TabIndex = 1;
            this._toDate.ValueChanged += new System.EventHandler(this._dateTimePicker_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Từ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Đến";
            // 
            // _dgvImport
            // 
            this._dgvImport.AllowUserToAddRows = false;
            this._dgvImport.AllowUserToDeleteRows = false;
            this._dgvImport.AllowUserToResizeColumns = false;
            this._dgvImport.AllowUserToResizeRows = false;
            this._dgvImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._dgvImport.Location = new System.Drawing.Point(29, 113);
            this._dgvImport.MultiSelect = false;
            this._dgvImport.Name = "_dgvImport";
            this._dgvImport.ReadOnly = true;
            this._dgvImport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this._dgvImport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this._dgvImport.Size = new System.Drawing.Size(385, 393);
            this._dgvImport.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nhập:";
            // 
            // _lblImportTotal
            // 
            this._lblImportTotal.AutoSize = true;
            this._lblImportTotal.Location = new System.Drawing.Point(91, 83);
            this._lblImportTotal.Name = "_lblImportTotal";
            this._lblImportTotal.Size = new System.Drawing.Size(13, 13);
            this._lblImportTotal.TabIndex = 17;
            this._lblImportTotal.Text = "0";
            this._lblImportTotal.TextChanged += new System.EventHandler(this._lblImportTotal_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(587, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "VND";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "VND";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(758, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "VND";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(610, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Doanh thu:";
            // 
            // _lblFinalInterest
            // 
            this._lblFinalInterest.AutoSize = true;
            this._lblFinalInterest.Location = new System.Drawing.Point(676, 35);
            this._lblFinalInterest.Name = "_lblFinalInterest";
            this._lblFinalInterest.Size = new System.Drawing.Size(13, 13);
            this._lblFinalInterest.TabIndex = 21;
            this._lblFinalInterest.Text = "0";
            // 
            // _btnContinuePlaying
            // 
            this._btnContinuePlaying.Location = new System.Drawing.Point(554, 495);
            this._btnContinuePlaying.Name = "_btnContinuePlaying";
            this._btnContinuePlaying.Size = new System.Drawing.Size(99, 34);
            this._btnContinuePlaying.TabIndex = 24;
            this._btnContinuePlaying.Text = "Đưa về mục chưa thanh toán";
            this._btnContinuePlaying.UseVisualStyleBackColor = true;
            this._btnContinuePlaying.Click += new System.EventHandler(this._btnContinuePlaying_Click);
            // 
            // ReportByDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 541);
            this.Controls.Add(this._btnContinuePlaying);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this._lblFinalInterest);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._lblImportTotal);
            this.Controls.Add(this._dgvImport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._toDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._lblExportTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtSearchCustomer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._dgvExport);
            this.Controls.Add(this._fromDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportByDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thống kê theo ngày";
            this.Load += new System.EventHandler(this.ReportByDate_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dgvExport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvImport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker _fromDate;
        private System.Windows.Forms.DataGridView _dgvExport;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox _txtCustomerInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtSearchCustomer;
        private System.Windows.Forms.Label _lblExportTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker _toDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView _dgvImport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _lblImportTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label _lblFinalInterest;
        private System.Windows.Forms.Button _btnContinuePlaying;
    }
}