namespace TTCM
{
    partial class UpdateDrinkPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDrinkPrice));
            this.label4 = new System.Windows.Forms.Label();
            this._btnCancel = new System.Windows.Forms.Button();
            this._btnSave = new System.Windows.Forms.Button();
            this._txtImportPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._txtSellPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._cbxDrink = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "/ đơn vị";
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(180, 131);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(79, 39);
            this._btnCancel.TabIndex = 3;
            this._btnCancel.Text = "Bỏ qua";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(55, 131);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(81, 39);
            this._btnSave.TabIndex = 2;
            this._btnSave.Text = "Lưu giá bán";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _txtImportPrice
            // 
            this._txtImportPrice.Location = new System.Drawing.Point(142, 52);
            this._txtImportPrice.Name = "_txtImportPrice";
            this._txtImportPrice.ReadOnly = true;
            this._txtImportPrice.Size = new System.Drawing.Size(95, 20);
            this._txtImportPrice.TabIndex = 15;
            this._txtImportPrice.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Giá nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên Đồ uống/ Vật dụng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "/ đơn vị";
            // 
            // _txtSellPrice
            // 
            this._txtSellPrice.Location = new System.Drawing.Point(142, 88);
            this._txtSellPrice.Name = "_txtSellPrice";
            this._txtSellPrice.Size = new System.Drawing.Size(95, 20);
            this._txtSellPrice.TabIndex = 1;
            this._txtSellPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtSellPrice_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Giá bán:";
            // 
            // _cbxDrink
            // 
            this._cbxDrink.FormattingEnabled = true;
            this._cbxDrink.Location = new System.Drawing.Point(142, 16);
            this._cbxDrink.Name = "_cbxDrink";
            this._cbxDrink.Size = new System.Drawing.Size(171, 21);
            this._cbxDrink.TabIndex = 23;
            this._cbxDrink.SelectedValueChanged += new System.EventHandler(this._cbxDrink_SelectedValueChanged);
            // 
            // UpdateDrinkPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 182);
            this.Controls.Add(this._cbxDrink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._txtSellPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._txtImportPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateDrinkPrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chỉnh sửa giá bán ra";
            this.Load += new System.EventHandler(this.UpdateDrinkPrice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.TextBox _txtImportPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtSellPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox _cbxDrink;
    }
}