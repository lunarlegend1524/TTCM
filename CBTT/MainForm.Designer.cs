namespace TTCM {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._dgvListCustomers = new System.Windows.Forms.DataGridView();
            this._btnCreate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmĐồUốngvậtDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaGiáBánRaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiểmTraHàngTồnTrongKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnTiềnBànđồUốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêTheoNgàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._btnUpdate = new System.Windows.Forms.Button();
            this._btnCheckout = new System.Windows.Forms.Button();
            this.TTCMDataSet = new TTCM.TTCMDataSet();
            this.TTCMDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCustomerTableAdapter = new TTCM.TTCMDataSetTableAdapters.tblCustomerTableAdapter();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._txtCustomerInfo = new System.Windows.Forms.TextBox();
            this._txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._btnChangeTableRent = new System.Windows.Forms.Button();
            this._btnDelete = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this._btnUpdateTimePlayed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dgvListCustomers)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TTCMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTCMDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _dgvListCustomers
            // 
            this._dgvListCustomers.AllowUserToAddRows = false;
            this._dgvListCustomers.AllowUserToDeleteRows = false;
            this._dgvListCustomers.AllowUserToResizeColumns = false;
            this._dgvListCustomers.AllowUserToResizeRows = false;
            this._dgvListCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._dgvListCustomers.Location = new System.Drawing.Point(12, 63);
            this._dgvListCustomers.MultiSelect = false;
            this._dgvListCustomers.Name = "_dgvListCustomers";
            this._dgvListCustomers.ReadOnly = true;
            this._dgvListCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this._dgvListCustomers.Size = new System.Drawing.Size(446, 333);
            this._dgvListCustomers.TabIndex = 0;
            this._dgvListCustomers.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this._dgvListCustomers_CellMouseClick);
            this._dgvListCustomers.SelectionChanged += new System.EventHandler(this._dgvListCustomers_SelectionChanged);
            // 
            // _btnCreate
            // 
            this._btnCreate.Location = new System.Drawing.Point(12, 406);
            this._btnCreate.Name = "_btnCreate";
            this._btnCreate.Size = new System.Drawing.Size(96, 52);
            this._btnCreate.TabIndex = 1;
            this._btnCreate.Text = "Khách hàng mới";
            this._btnCreate.UseVisualStyleBackColor = true;
            this._btnCreate.Click += new System.EventHandler(this._btnCreate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(683, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmĐồUốngvậtDụngToolStripMenuItem,
            this.chỉnhSửaGiáBánRaToolStripMenuItem,
            this.kiểmTraHàngTồnTrongKhoToolStripMenuItem,
            this.chuyểnTiềnBànđồUốngToolStripMenuItem,
            this.thốngKêTheoNgàyToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.thốngKêToolStripMenuItem.Text = "Menu";
            // 
            // thêmĐồUốngvậtDụngToolStripMenuItem
            // 
            this.thêmĐồUốngvậtDụngToolStripMenuItem.Name = "thêmĐồUốngvậtDụngToolStripMenuItem";
            this.thêmĐồUốngvậtDụngToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.thêmĐồUốngvậtDụngToolStripMenuItem.Text = "Nhập/xuất đồ uống/vật dụng";
            this.thêmĐồUốngvậtDụngToolStripMenuItem.Click += new System.EventHandler(this.thêmĐồUốngvậtDụngToolStripMenuItem_Click);
            // 
            // chỉnhSửaGiáBánRaToolStripMenuItem
            // 
            this.chỉnhSửaGiáBánRaToolStripMenuItem.Name = "chỉnhSửaGiáBánRaToolStripMenuItem";
            this.chỉnhSửaGiáBánRaToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.chỉnhSửaGiáBánRaToolStripMenuItem.Text = "Thay đổi giá đồ uống/vật dụng bán ra";
            this.chỉnhSửaGiáBánRaToolStripMenuItem.Click += new System.EventHandler(this.chỉnhSửaGiáBánRaToolStripMenuItem_Click);
            // 
            // kiểmTraHàngTồnTrongKhoToolStripMenuItem
            // 
            this.kiểmTraHàngTồnTrongKhoToolStripMenuItem.Name = "kiểmTraHàngTồnTrongKhoToolStripMenuItem";
            this.kiểmTraHàngTồnTrongKhoToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.kiểmTraHàngTồnTrongKhoToolStripMenuItem.Text = "Kiểm tra hàng tồn trong kho";
            this.kiểmTraHàngTồnTrongKhoToolStripMenuItem.Click += new System.EventHandler(this.kiểmTraHàngTồnTrongKhoToolStripMenuItem_Click);
            // 
            // chuyểnTiềnBànđồUốngToolStripMenuItem
            // 
            this.chuyểnTiềnBànđồUốngToolStripMenuItem.Name = "chuyểnTiềnBànđồUốngToolStripMenuItem";
            this.chuyểnTiềnBànđồUốngToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.chuyểnTiềnBànđồUốngToolStripMenuItem.Text = "Chuyển tiền bàn/đồ uống";
            this.chuyểnTiềnBànđồUốngToolStripMenuItem.Click += new System.EventHandler(this.chuyểnTiềnBànđồUốngToolStripMenuItem_Click);
            // 
            // thốngKêTheoNgàyToolStripMenuItem
            // 
            this.thốngKêTheoNgàyToolStripMenuItem.Name = "thốngKêTheoNgàyToolStripMenuItem";
            this.thốngKêTheoNgàyToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.thốngKêTheoNgàyToolStripMenuItem.Text = "Thống kê theo ngày";
            this.thốngKêTheoNgàyToolStripMenuItem.Click += new System.EventHandler(this.thốngKêTheoNgàyToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // _btnUpdate
            // 
            this._btnUpdate.Location = new System.Drawing.Point(470, 406);
            this._btnUpdate.Name = "_btnUpdate";
            this._btnUpdate.Size = new System.Drawing.Size(89, 52);
            this._btnUpdate.TabIndex = 2;
            this._btnUpdate.Text = "Thêm/bớt đồ uống";
            this._btnUpdate.UseVisualStyleBackColor = true;
            this._btnUpdate.Click += new System.EventHandler(this._btnUpdate_Click);
            // 
            // _btnCheckout
            // 
            this._btnCheckout.Location = new System.Drawing.Point(571, 406);
            this._btnCheckout.Name = "_btnCheckout";
            this._btnCheckout.Size = new System.Drawing.Size(100, 52);
            this._btnCheckout.TabIndex = 6;
            this._btnCheckout.Text = "Thanh toán";
            this._btnCheckout.UseVisualStyleBackColor = true;
            this._btnCheckout.Click += new System.EventHandler(this._btnCheckout_Click);
            // 
            // TTCMDataSet
            // 
            this.TTCMDataSet.DataSetName = "TTCMDataSet";
            this.TTCMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TTCMDataSetBindingSource
            // 
            this.TTCMDataSetBindingSource.DataSource = this.TTCMDataSet;
            this.TTCMDataSetBindingSource.Position = 0;
            // 
            // tblCustomerBindingSource
            // 
            this.tblCustomerBindingSource.DataMember = "tblCustomer";
            this.tblCustomerBindingSource.DataSource = this.TTCMDataSetBindingSource;
            // 
            // tblCustomerTableAdapter
            // 
            this.tblCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._txtCustomerInfo);
            this.groupBox1.Location = new System.Drawing.Point(464, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 352);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đã lấy";
            // 
            // _txtCustomerInfo
            // 
            this._txtCustomerInfo.Location = new System.Drawing.Point(6, 19);
            this._txtCustomerInfo.Multiline = true;
            this._txtCustomerInfo.Name = "_txtCustomerInfo";
            this._txtCustomerInfo.ReadOnly = true;
            this._txtCustomerInfo.Size = new System.Drawing.Size(195, 327);
            this._txtCustomerInfo.TabIndex = 0;
            this._txtCustomerInfo.TabStop = false;
            // 
            // _txtSearchCustomer
            // 
            this._txtSearchCustomer.Location = new System.Drawing.Point(114, 417);
            this._txtSearchCustomer.Name = "_txtSearchCustomer";
            this._txtSearchCustomer.Size = new System.Drawing.Size(133, 20);
            this._txtSearchCustomer.TabIndex = 3;
            this._txtSearchCustomer.TextChanged += new System.EventHandler(this._txtSearchCustomer_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tìm khách hàng";
            // 
            // _btnChangeTableRent
            // 
            this._btnChangeTableRent.Location = new System.Drawing.Point(375, 406);
            this._btnChangeTableRent.Name = "_btnChangeTableRent";
            this._btnChangeTableRent.Size = new System.Drawing.Size(83, 52);
            this._btnChangeTableRent.TabIndex = 5;
            this._btnChangeTableRent.Text = "Tray đổi tiền bàn";
            this._btnChangeTableRent.UseVisualStyleBackColor = true;
            this._btnChangeTableRent.Click += new System.EventHandler(this._btnChangeTableRent_Click);
            // 
            // _btnDelete
            // 
            this._btnDelete.Location = new System.Drawing.Point(259, 406);
            this._btnDelete.Name = "_btnDelete";
            this._btnDelete.Size = new System.Drawing.Size(110, 25);
            this._btnDelete.TabIndex = 4;
            this._btnDelete.Text = "Xóa khách hàng";
            this._btnDelete.UseVisualStyleBackColor = true;
            this._btnDelete.Click += new System.EventHandler(this._btnDelete_Click);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 60000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // _btnUpdateTimePlayed
            // 
            this._btnUpdateTimePlayed.Location = new System.Drawing.Point(259, 434);
            this._btnUpdateTimePlayed.Name = "_btnUpdateTimePlayed";
            this._btnUpdateTimePlayed.Size = new System.Drawing.Size(110, 25);
            this._btnUpdateTimePlayed.TabIndex = 9;
            this._btnUpdateTimePlayed.Text = "Thay đổi giờ chơi";
            this._btnUpdateTimePlayed.UseVisualStyleBackColor = true;
            this._btnUpdateTimePlayed.Click += new System.EventHandler(this._btnUpdateTimePlayed_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 466);
            this.Controls.Add(this._btnUpdateTimePlayed);
            this.Controls.Add(this._btnDelete);
            this.Controls.Add(this._btnChangeTableRent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtSearchCustomer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._btnCheckout);
            this.Controls.Add(this._btnUpdate);
            this.Controls.Add(this._btnCreate);
            this.Controls.Add(this._dgvListCustomers);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TTClub Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dgvListCustomers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TTCMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTCMDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _dgvListCustomers;
        private System.Windows.Forms.Button _btnCreate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêTheoNgàyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Button _btnUpdate;
        private System.Windows.Forms.Button _btnCheckout;
        private System.Windows.Forms.BindingSource TTCMDataSetBindingSource;
        private TTCMDataSet TTCMDataSet;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private TTCMDataSetTableAdapters.tblCustomerTableAdapter tblCustomerTableAdapter;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox _txtCustomerInfo;
        private System.Windows.Forms.TextBox _txtSearchCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem thêmĐồUốngvậtDụngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyểnTiềnBànđồUốngToolStripMenuItem;
        private System.Windows.Forms.Button _btnChangeTableRent;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaGiáBánRaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiểmTraHàngTồnTrongKhoToolStripMenuItem;
        private System.Windows.Forms.Button _btnDelete;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button _btnUpdateTimePlayed;
    }
}

