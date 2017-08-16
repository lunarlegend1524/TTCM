namespace TTCM
{
    partial class UpdateCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCustomer));
            this.label1 = new System.Windows.Forms.Label();
            this._txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._numQuantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this._cbxDrink = new System.Windows.Forms.ComboBox();
            this._btnCancel = new System.Windows.Forms.Button();
            this._btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên KH:";
            // 
            // _txtCustomerName
            // 
            this._txtCustomerName.Location = new System.Drawing.Point(95, 34);
            this._txtCustomerName.Multiline = true;
            this._txtCustomerName.Name = "_txtCustomerName";
            this._txtCustomerName.ReadOnly = true;
            this._txtCustomerName.Size = new System.Drawing.Size(188, 20);
            this._txtCustomerName.TabIndex = 1;
            this._txtCustomerName.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lấy thêm:";
            // 
            // _numQuantity
            // 
            this._numQuantity.Location = new System.Drawing.Point(95, 129);
            this._numQuantity.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this._numQuantity.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this._numQuantity.Name = "_numQuantity";
            this._numQuantity.Size = new System.Drawing.Size(43, 20);
            this._numQuantity.TabIndex = 1;
            this._numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số lượng";
            // 
            // _cbxDrink
            // 
            this._cbxDrink.FormattingEnabled = true;
            this._cbxDrink.Location = new System.Drawing.Point(95, 84);
            this._cbxDrink.Name = "_cbxDrink";
            this._cbxDrink.Size = new System.Drawing.Size(153, 21);
            this._cbxDrink.TabIndex = 0;
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(198, 179);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 42);
            this._btnCancel.TabIndex = 3;
            this._btnCancel.Text = "Bỏ qua";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // _btnOK
            // 
            this._btnOK.Location = new System.Drawing.Point(63, 179);
            this._btnOK.Name = "_btnOK";
            this._btnOK.Size = new System.Drawing.Size(75, 42);
            this._btnOK.TabIndex = 2;
            this._btnOK.Text = "Lưu";
            this._btnOK.UseVisualStyleBackColor = true;
            this._btnOK.Click += new System.EventHandler(this._btnOK_Click);
            // 
            // UpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 260);
            this.Controls.Add(this._btnOK);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._numQuantity);
            this.Controls.Add(this._cbxDrink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._txtCustomerName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin KH";
            this.Load += new System.EventHandler(this.UpdateCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this._numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown _numQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _cbxDrink;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Button _btnOK;
    }
}