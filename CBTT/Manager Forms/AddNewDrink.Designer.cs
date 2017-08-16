namespace TTCM
{
    partial class AddNewDrink
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewDrink));
            this.label1 = new System.Windows.Forms.Label();
            this._txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._btnRemove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this._importDate = new System.Windows.Forms.DateTimePicker();
            this._chkToday = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this._numQuantity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this._cbxDrinkName = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đồ uống/ Vật dụng:";
            // 
            // _txtPrice
            // 
            this._txtPrice.Location = new System.Drawing.Point(149, 50);
            this._txtPrice.Name = "_txtPrice";
            this._txtPrice.Size = new System.Drawing.Size(95, 20);
            this._txtPrice.TabIndex = 1;
            this._txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtPrice_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giá nhập:";
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(22, 239);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(81, 48);
            this._btnSave.TabIndex = 2;
            this._btnSave.Text = "Nhập mặt hàng";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(256, 239);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(79, 48);
            this._btnCancel.TabIndex = 4;
            this._btnCancel.Text = "Bỏ qua";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // _btnRemove
            // 
            this._btnRemove.Location = new System.Drawing.Point(146, 239);
            this._btnRemove.Name = "_btnRemove";
            this._btnRemove.Size = new System.Drawing.Size(75, 48);
            this._btnRemove.TabIndex = 3;
            this._btnRemove.Text = "Xóa mặt hàng";
            this._btnRemove.UseVisualStyleBackColor = true;
            this._btnRemove.Click += new System.EventHandler(this._btnRemove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số lượng:";
            // 
            // _importDate
            // 
            this._importDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._importDate.Location = new System.Drawing.Point(144, 58);
            this._importDate.Name = "_importDate";
            this._importDate.Size = new System.Drawing.Size(82, 20);
            this._importDate.TabIndex = 7;
            this._importDate.Enter += new System.EventHandler(this._importDate_Enter);
            // 
            // _chkToday
            // 
            this._chkToday.AutoSize = true;
            this._chkToday.Location = new System.Drawing.Point(16, 28);
            this._chkToday.Name = "_chkToday";
            this._chkToday.Size = new System.Drawing.Size(68, 17);
            this._chkToday.TabIndex = 8;
            this._chkToday.Text = "Hôm nay";
            this._chkToday.UseVisualStyleBackColor = true;
            this._chkToday.CheckedChanged += new System.EventHandler(this._chkToday_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this._importDate);
            this.groupBox1.Controls.Add(this._chkToday);
            this.groupBox1.Location = new System.Drawing.Point(45, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 114);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ngày nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hoặc chọn ngày nhập:";
            // 
            // _numQuantity
            // 
            this._numQuantity.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this._numQuantity.Location = new System.Drawing.Point(149, 77);
            this._numQuantity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this._numQuantity.Name = "_numQuantity";
            this._numQuantity.Size = new System.Drawing.Size(43, 20);
            this._numQuantity.TabIndex = 11;
            this._numQuantity.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "/ đơn vị";
            // 
            // _cbxDrinkName
            // 
            this._cbxDrinkName.FormattingEnabled = true;
            this._cbxDrinkName.Location = new System.Drawing.Point(150, 24);
            this._cbxDrinkName.Name = "_cbxDrinkName";
            this._cbxDrinkName.Size = new System.Drawing.Size(165, 21);
            this._cbxDrinkName.TabIndex = 13;
            this._cbxDrinkName.TextChanged += new System.EventHandler(this._cbxDrinkName_TextChanged);
            // 
            // AddNewDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 299);
            this.Controls.Add(this._cbxDrinkName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._numQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._btnRemove);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._txtPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewDrink";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhập/xuất đồ uống/vật dụng mới";
            this.Load += new System.EventHandler(this.AddNewDrink_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Button _btnRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker _importDate;
        private System.Windows.Forms.CheckBox _chkToday;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown _numQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox _cbxDrinkName;
    }
}