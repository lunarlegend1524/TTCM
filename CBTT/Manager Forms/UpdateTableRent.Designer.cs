namespace TTCM
{
    partial class UpdateTableRent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateTableRent));
            this._btnOK = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._cbxTableRent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this._txtCustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _btnOK
            // 
            this._btnOK.Location = new System.Drawing.Point(62, 137);
            this._btnOK.Name = "_btnOK";
            this._btnOK.Size = new System.Drawing.Size(75, 34);
            this._btnOK.TabIndex = 1;
            this._btnOK.Text = "Lưu";
            this._btnOK.UseVisualStyleBackColor = true;
            this._btnOK.Click += new System.EventHandler(this._btnOK_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(187, 137);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 34);
            this._btnCancel.TabIndex = 2;
            this._btnCancel.Text = "Bỏ qua";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // _cbxTableRent
            // 
            this._cbxTableRent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this._cbxTableRent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this._cbxTableRent.FormattingEnabled = true;
            this._cbxTableRent.Items.AddRange(new object[] {
            "0",
            "13000",
            "15000",
            "18000",
            "22000"});
            this._cbxTableRent.Location = new System.Drawing.Point(82, 89);
            this._cbxTableRent.Name = "_cbxTableRent";
            this._cbxTableRent.Size = new System.Drawing.Size(94, 21);
            this._cbxTableRent.TabIndex = 0;
            this._cbxTableRent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._cbxTableRent_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tiền bàn";
            // 
            // _txtCustomerName
            // 
            this._txtCustomerName.Location = new System.Drawing.Point(82, 39);
            this._txtCustomerName.Multiline = true;
            this._txtCustomerName.Name = "_txtCustomerName";
            this._txtCustomerName.ReadOnly = true;
            this._txtCustomerName.Size = new System.Drawing.Size(218, 20);
            this._txtCustomerName.TabIndex = 1;
            this._txtCustomerName.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên KH:";
            // 
            // UpdateTableRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 194);
            this.Controls.Add(this._btnOK);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._cbxTableRent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._txtCustomerName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateTableRent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sửa tiền bàn";
            this.Load += new System.EventHandler(this.UpdateTableRent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnOK;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.ComboBox _cbxTableRent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtCustomerName;
        private System.Windows.Forms.Label label1;
    }
}