namespace TTCM
{
    partial class UpdateTimePlayed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateTimePlayed));
            this._btnOK = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._txtCustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._startTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this._groupByHour = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this._endTime = new System.Windows.Forms.DateTimePicker();
            this._groupByHour.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btnOK
            // 
            this._btnOK.Location = new System.Drawing.Point(72, 191);
            this._btnOK.Name = "_btnOK";
            this._btnOK.Size = new System.Drawing.Size(75, 34);
            this._btnOK.TabIndex = 1;
            this._btnOK.Text = "Lưu";
            this._btnOK.UseVisualStyleBackColor = true;
            this._btnOK.Click += new System.EventHandler(this._btnOK_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(178, 191);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 34);
            this._btnCancel.TabIndex = 2;
            this._btnCancel.Text = "Bỏ qua";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // _txtCustomerName
            // 
            this._txtCustomerName.Location = new System.Drawing.Point(89, 37);
            this._txtCustomerName.Multiline = true;
            this._txtCustomerName.Name = "_txtCustomerName";
            this._txtCustomerName.ReadOnly = true;
            this._txtCustomerName.Size = new System.Drawing.Size(218, 20);
            this._txtCustomerName.TabIndex = 0;
            this._txtCustomerName.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tên KH:";
            // 
            // _startTime
            // 
            this._startTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this._startTime.Location = new System.Drawing.Point(99, 26);
            this._startTime.Name = "_startTime";
            this._startTime.ShowUpDown = true;
            this._startTime.Size = new System.Drawing.Size(111, 20);
            this._startTime.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Bắt đầu từ";
            // 
            // _groupByHour
            // 
            this._groupByHour.Controls.Add(this.label2);
            this._groupByHour.Controls.Add(this._endTime);
            this._groupByHour.Controls.Add(this.label5);
            this._groupByHour.Controls.Add(this._startTime);
            this._groupByHour.Location = new System.Drawing.Point(46, 88);
            this._groupByHour.Name = "_groupByHour";
            this._groupByHour.Size = new System.Drawing.Size(234, 86);
            this._groupByHour.TabIndex = 20;
            this._groupByHour.TabStop = false;
            this._groupByHour.Text = "Thời gian chơi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Đến";
            // 
            // _endTime
            // 
            this._endTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this._endTime.Location = new System.Drawing.Point(99, 54);
            this._endTime.Name = "_endTime";
            this._endTime.ShowUpDown = true;
            this._endTime.Size = new System.Drawing.Size(111, 20);
            this._endTime.TabIndex = 17;
            // 
            // UpdateTimePlayed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 257);
            this.Controls.Add(this._btnOK);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._txtCustomerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._groupByHour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateTimePlayed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thay đổi giờ chơi";
            this.Load += new System.EventHandler(this.UpdateTimePlayed_Load);
            this._groupByHour.ResumeLayout(false);
            this._groupByHour.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnOK;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.TextBox _txtCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker _startTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox _groupByHour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker _endTime;
    }
}