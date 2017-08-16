namespace TTCM
{
    partial class AddNewCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewCustomer));
            this.label1 = new System.Windows.Forms.Label();
            this._txtCustomerName = new System.Windows.Forms.TextBox();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._groupByHead = new System.Windows.Forms.GroupBox();
            this._radioBtnOther = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this._txtTableRentByHead = new System.Windows.Forms.TextBox();
            this._radioBtn0 = new System.Windows.Forms.RadioButton();
            this._radioBtn15 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this._radioBtn12 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._chkByHead = new System.Windows.Forms.CheckBox();
            this._chkByHour = new System.Windows.Forms.CheckBox();
            this._groupByHour = new System.Windows.Forms.GroupBox();
            this._radioBtnOther2 = new System.Windows.Forms.RadioButton();
            this._radioBtn22 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._txtTableRentByHour = new System.Windows.Forms.TextBox();
            this._startTime = new System.Windows.Forms.DateTimePicker();
            this._radioBtn18 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this._groupByHead.SuspendLayout();
            this._groupByHour.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên KH:";
            // 
            // _txtCustomerName
            // 
            this._txtCustomerName.Location = new System.Drawing.Point(87, 31);
            this._txtCustomerName.Name = "_txtCustomerName";
            this._txtCustomerName.Size = new System.Drawing.Size(184, 20);
            this._txtCustomerName.TabIndex = 0;
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(68, 268);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 37);
            this._btnSave.TabIndex = 11;
            this._btnSave.Text = "Lưu";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(167, 268);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 37);
            this._btnCancel.TabIndex = 12;
            this._btnCancel.Text = "Bỏ qua";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // _groupByHead
            // 
            this._groupByHead.Controls.Add(this._radioBtnOther);
            this._groupByHead.Controls.Add(this.label8);
            this._groupByHead.Controls.Add(this._txtTableRentByHead);
            this._groupByHead.Controls.Add(this._radioBtn0);
            this._groupByHead.Controls.Add(this._radioBtn15);
            this._groupByHead.Controls.Add(this.label3);
            this._groupByHead.Controls.Add(this._radioBtn12);
            this._groupByHead.Controls.Add(this.label2);
            this._groupByHead.Location = new System.Drawing.Point(37, 121);
            this._groupByHead.Name = "_groupByHead";
            this._groupByHead.Size = new System.Drawing.Size(234, 122);
            this._groupByHead.TabIndex = 4;
            this._groupByHead.TabStop = false;
            // 
            // _radioBtnOther
            // 
            this._radioBtnOther.AutoSize = true;
            this._radioBtnOther.Location = new System.Drawing.Point(99, 90);
            this._radioBtnOther.Name = "_radioBtnOther";
            this._radioBtnOther.Size = new System.Drawing.Size(14, 13);
            this._radioBtnOther.TabIndex = 13;
            this._radioBtnOther.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tùy chọn";
            // 
            // _txtTableRentByHead
            // 
            this._txtTableRentByHead.Location = new System.Drawing.Point(119, 87);
            this._txtTableRentByHead.Name = "_txtTableRentByHead";
            this._txtTableRentByHead.Size = new System.Drawing.Size(84, 20);
            this._txtTableRentByHead.TabIndex = 6;
            this._txtTableRentByHead.Text = "15000";
            this._txtTableRentByHead.TextChanged += new System.EventHandler(this._txtTableRentByHead_TextChanged);
            this._txtTableRentByHead.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtTableRentByHead_KeyPress);
            // 
            // _radioBtn0
            // 
            this._radioBtn0.AutoSize = true;
            this._radioBtn0.Location = new System.Drawing.Point(99, 64);
            this._radioBtn0.Name = "_radioBtn0";
            this._radioBtn0.Size = new System.Drawing.Size(31, 17);
            this._radioBtn0.TabIndex = 5;
            this._radioBtn0.Text = "0";
            this._radioBtn0.UseVisualStyleBackColor = true;
            // 
            // _radioBtn15
            // 
            this._radioBtn15.AutoSize = true;
            this._radioBtn15.Location = new System.Drawing.Point(99, 41);
            this._radioBtn15.Name = "_radioBtn15";
            this._radioBtn15.Size = new System.Drawing.Size(58, 17);
            this._radioBtn15.TabIndex = 4;
            this._radioBtn15.Text = "15.000";
            this._radioBtn15.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tối";
            // 
            // _radioBtn12
            // 
            this._radioBtn12.AutoSize = true;
            this._radioBtn12.Checked = true;
            this._radioBtn12.Location = new System.Drawing.Point(99, 18);
            this._radioBtn12.Name = "_radioBtn12";
            this._radioBtn12.Size = new System.Drawing.Size(58, 17);
            this._radioBtn12.TabIndex = 3;
            this._radioBtn12.TabStop = true;
            this._radioBtn12.Text = "12.000";
            this._radioBtn12.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sáng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tiền bàn:";
            // 
            // _chkByHead
            // 
            this._chkByHead.AutoSize = true;
            this._chkByHead.Location = new System.Drawing.Point(87, 68);
            this._chkByHead.Name = "_chkByHead";
            this._chkByHead.Size = new System.Drawing.Size(102, 17);
            this._chkByHead.TabIndex = 1;
            this._chkByHead.Text = "Theo đầu người";
            this._chkByHead.UseVisualStyleBackColor = true;
            this._chkByHead.CheckedChanged += new System.EventHandler(this._chkByHead_CheckedChanged);
            // 
            // _chkByHour
            // 
            this._chkByHour.AutoSize = true;
            this._chkByHour.Location = new System.Drawing.Point(87, 91);
            this._chkByHour.Name = "_chkByHour";
            this._chkByHour.Size = new System.Drawing.Size(68, 17);
            this._chkByHour.TabIndex = 2;
            this._chkByHour.Text = "Theo giờ";
            this._chkByHour.UseVisualStyleBackColor = true;
            this._chkByHour.CheckedChanged += new System.EventHandler(this._chkByHour_CheckedChanged);
            // 
            // _groupByHour
            // 
            this._groupByHour.Controls.Add(this._radioBtnOther2);
            this._groupByHour.Controls.Add(this._radioBtn22);
            this._groupByHour.Controls.Add(this.label7);
            this._groupByHour.Controls.Add(this.label6);
            this._groupByHour.Controls.Add(this._txtTableRentByHour);
            this._groupByHour.Controls.Add(this._startTime);
            this._groupByHour.Controls.Add(this._radioBtn18);
            this._groupByHour.Controls.Add(this.label5);
            this._groupByHour.Location = new System.Drawing.Point(37, 121);
            this._groupByHour.Name = "_groupByHour";
            this._groupByHour.Size = new System.Drawing.Size(234, 122);
            this._groupByHour.TabIndex = 8;
            this._groupByHour.TabStop = false;
            // 
            // _radioBtnOther2
            // 
            this._radioBtnOther2.AutoSize = true;
            this._radioBtnOther2.Location = new System.Drawing.Point(94, 87);
            this._radioBtnOther2.Name = "_radioBtnOther2";
            this._radioBtnOther2.Size = new System.Drawing.Size(14, 13);
            this._radioBtnOther2.TabIndex = 18;
            this._radioBtnOther2.UseVisualStyleBackColor = true;
            // 
            // _radioBtn22
            // 
            this._radioBtn22.AutoSize = true;
            this._radioBtn22.Location = new System.Drawing.Point(94, 64);
            this._radioBtn22.Name = "_radioBtn22";
            this._radioBtn22.Size = new System.Drawing.Size(58, 17);
            this._radioBtn22.TabIndex = 9;
            this._radioBtn22.Text = "22.000";
            this._radioBtn22.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "/ h";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tùy chọn";
            // 
            // _txtTableRentByHour
            // 
            this._txtTableRentByHour.Location = new System.Drawing.Point(110, 84);
            this._txtTableRentByHour.Name = "_txtTableRentByHour";
            this._txtTableRentByHour.Size = new System.Drawing.Size(84, 20);
            this._txtTableRentByHour.TabIndex = 10;
            this._txtTableRentByHour.Text = "18000";
            this._txtTableRentByHour.TextChanged += new System.EventHandler(this._txtTableRentByHour_TextChanged);
            this._txtTableRentByHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtTableRentByHour_KeyPress);
            // 
            // _startTime
            // 
            this._startTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this._startTime.Location = new System.Drawing.Point(94, 19);
            this._startTime.Name = "_startTime";
            this._startTime.ShowUpDown = true;
            this._startTime.Size = new System.Drawing.Size(111, 20);
            this._startTime.TabIndex = 7;
            // 
            // _radioBtn18
            // 
            this._radioBtn18.AutoSize = true;
            this._radioBtn18.Checked = true;
            this._radioBtn18.Location = new System.Drawing.Point(94, 43);
            this._radioBtn18.Name = "_radioBtn18";
            this._radioBtn18.Size = new System.Drawing.Size(58, 17);
            this._radioBtn18.TabIndex = 8;
            this._radioBtn18.TabStop = true;
            this._radioBtn18.Text = "18.000";
            this._radioBtn18.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Bắt đầu từ";
            // 
            // AddNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 335);
            this.Controls.Add(this._chkByHour);
            this.Controls.Add(this._chkByHead);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._txtCustomerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._groupByHour);
            this.Controls.Add(this._groupByHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng mới";
            this.Load += new System.EventHandler(this.AddNew_Load);
            this._groupByHead.ResumeLayout(false);
            this._groupByHead.PerformLayout();
            this._groupByHour.ResumeLayout(false);
            this._groupByHour.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtCustomerName;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.GroupBox _groupByHead;
        private System.Windows.Forms.RadioButton _radioBtn15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton _radioBtn12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox _chkByHead;
        private System.Windows.Forms.CheckBox _chkByHour;
        private System.Windows.Forms.GroupBox _groupByHour;
        private System.Windows.Forms.RadioButton _radioBtn0;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker _startTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _txtTableRentByHour;
        private System.Windows.Forms.TextBox _txtTableRentByHead;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton _radioBtnOther;
        private System.Windows.Forms.RadioButton _radioBtnOther2;
        private System.Windows.Forms.RadioButton _radioBtn22;
        private System.Windows.Forms.RadioButton _radioBtn18;
    }
}