namespace TTCM
{
    partial class Checkout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkout));
            this._btnOK = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this._txtCustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._txtFeePaid = new System.Windows.Forms.TextBox();
            this._txtCustomerPaid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._txtRemainingFee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _btnOK
            // 
            this._btnOK.Location = new System.Drawing.Point(79, 157);
            this._btnOK.Name = "_btnOK";
            this._btnOK.Size = new System.Drawing.Size(75, 34);
            this._btnOK.TabIndex = 2;
            this._btnOK.Text = "Lưu";
            this._btnOK.UseVisualStyleBackColor = true;
            this._btnOK.Click += new System.EventHandler(this._btnOK_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(204, 157);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 34);
            this._btnCancel.TabIndex = 3;
            this._btnCancel.Text = "Bỏ qua";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Đã trả";
            // 
            // _txtCustomerName
            // 
            this._txtCustomerName.Location = new System.Drawing.Point(120, 26);
            this._txtCustomerName.Multiline = true;
            this._txtCustomerName.Name = "_txtCustomerName";
            this._txtCustomerName.ReadOnly = true;
            this._txtCustomerName.Size = new System.Drawing.Size(200, 20);
            this._txtCustomerName.TabIndex = 18;
            this._txtCustomerName.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tên KH:";
            // 
            // _txtFeePaid
            // 
            this._txtFeePaid.Location = new System.Drawing.Point(120, 52);
            this._txtFeePaid.Name = "_txtFeePaid";
            this._txtFeePaid.ReadOnly = true;
            this._txtFeePaid.Size = new System.Drawing.Size(110, 20);
            this._txtFeePaid.TabIndex = 0;
            this._txtFeePaid.TabStop = false;
            // 
            // _txtCustomerPaid
            // 
            this._txtCustomerPaid.Location = new System.Drawing.Point(120, 91);
            this._txtCustomerPaid.Name = "_txtCustomerPaid";
            this._txtCustomerPaid.Size = new System.Drawing.Size(110, 20);
            this._txtCustomerPaid.TabIndex = 0;
            this._txtCustomerPaid.TextChanged += new System.EventHandler(this._txtCustomerPaid_TextChanged);
            this._txtCustomerPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtCustomerPaid_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Kháng hàng đưa";
            // 
            // _txtRemainingFee
            // 
            this._txtRemainingFee.Location = new System.Drawing.Point(120, 117);
            this._txtRemainingFee.Name = "_txtRemainingFee";
            this._txtRemainingFee.ReadOnly = true;
            this._txtRemainingFee.Size = new System.Drawing.Size(110, 20);
            this._txtRemainingFee.TabIndex = 1;
            this._txtRemainingFee.TextChanged += new System.EventHandler(this._txtRemainingFee_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Còn lại";
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 224);
            this.Controls.Add(this._txtRemainingFee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._txtCustomerPaid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._txtFeePaid);
            this.Controls.Add(this._btnOK);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._txtCustomerName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Checkout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thanh toán";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnOK;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtFeePaid;
        private System.Windows.Forms.TextBox _txtCustomerPaid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtRemainingFee;
        private System.Windows.Forms.Label label4;
    }
}