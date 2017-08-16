namespace TTCM
{
    partial class DrinkTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrinkTransfer));
            this.label1 = new System.Windows.Forms.Label();
            this._cbxFrom = new System.Windows.Forms.ComboBox();
            this._cbxTo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this._cbxDrink = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this._btnTransfer = new System.Windows.Forms.Button();
            this._numQuantity = new System.Windows.Forms.NumericUpDown();
            this._btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuyển ";
            // 
            // _txtFrom
            // 
            this._cbxFrom.Location = new System.Drawing.Point(65, 120);
            this._cbxFrom.Name = "_cbxFrom";
            this._cbxFrom.Size = new System.Drawing.Size(121, 20);
            this._cbxFrom.TabIndex = 1;
            // 
            // _txtTo
            // 
            this._cbxTo.Location = new System.Drawing.Point(266, 120);
            this._cbxTo.Name = "_txtTo";
            this._cbxTo.Size = new System.Drawing.Size(121, 20);
            this._cbxTo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sang";
            // 
            // _cbxDrink
            // 
            this._cbxDrink.FormattingEnabled = true;
            this._cbxDrink.Location = new System.Drawing.Point(193, 46);
            this._cbxDrink.Name = "_cbxDrink";
            this._cbxDrink.Size = new System.Drawing.Size(121, 21);
            this._cbxDrink.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Từ";
            // 
            // _btnTransfer
            // 
            this._btnTransfer.Location = new System.Drawing.Point(111, 173);
            this._btnTransfer.Name = "_btnTransfer";
            this._btnTransfer.Size = new System.Drawing.Size(75, 39);
            this._btnTransfer.TabIndex = 6;
            this._btnTransfer.Text = "Chuyển";
            this._btnTransfer.UseVisualStyleBackColor = true;
            this._btnTransfer.Click += new System.EventHandler(this._btnTransfer_Click);
            // 
            // _numQuantity
            // 
            this._numQuantity.Location = new System.Drawing.Point(193, 73);
            this._numQuantity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this._numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._numQuantity.Name = "_numQuantity";
            this._numQuantity.Size = new System.Drawing.Size(39, 20);
            this._numQuantity.TabIndex = 7;
            this._numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(222, 173);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 39);
            this._btnCancel.TabIndex = 8;
            this._btnCancel.Text = "Bỏ qua";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số lượng";
            // 
            // DrinkTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 239);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._numQuantity);
            this.Controls.Add(this._btnTransfer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._cbxDrink);
            this.Controls.Add(this._cbxFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._cbxTo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DrinkTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển đồ uống/vật dụng";
            this.Load += new System.EventHandler(this.DrinkTransfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this._numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _cbxFrom;
        private System.Windows.Forms.ComboBox _cbxTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox _cbxDrink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _btnTransfer;
        private System.Windows.Forms.NumericUpDown _numQuantity;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Label label4;
    }
}