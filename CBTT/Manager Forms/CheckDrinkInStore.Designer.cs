namespace TTCM
{
    partial class CheckDrinkInStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckDrinkInStore));
            this._dgvListDrinkInStore = new System.Windows.Forms.DataGridView();
            this._btnQuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dgvListDrinkInStore)).BeginInit();
            this.SuspendLayout();
            // 
            // _dgvListDrinkInStore
            // 
            this._dgvListDrinkInStore.AllowUserToAddRows = false;
            this._dgvListDrinkInStore.AllowUserToDeleteRows = false;
            this._dgvListDrinkInStore.AllowUserToResizeColumns = false;
            this._dgvListDrinkInStore.AllowUserToResizeRows = false;
            this._dgvListDrinkInStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._dgvListDrinkInStore.Location = new System.Drawing.Point(12, 12);
            this._dgvListDrinkInStore.MultiSelect = false;
            this._dgvListDrinkInStore.Name = "_dgvListDrinkInStore";
            this._dgvListDrinkInStore.ReadOnly = true;
            this._dgvListDrinkInStore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this._dgvListDrinkInStore.Size = new System.Drawing.Size(303, 336);
            this._dgvListDrinkInStore.TabIndex = 1;
            // 
            // _btnQuit
            // 
            this._btnQuit.Location = new System.Drawing.Point(114, 361);
            this._btnQuit.Name = "_btnQuit";
            this._btnQuit.Size = new System.Drawing.Size(100, 41);
            this._btnQuit.TabIndex = 5;
            this._btnQuit.Text = "Thoát";
            this._btnQuit.UseVisualStyleBackColor = true;
            this._btnQuit.Click += new System.EventHandler(this._btnQuit_Click);
            // 
            // CheckDrinkInStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 414);
            this.Controls.Add(this._btnQuit);
            this.Controls.Add(this._dgvListDrinkInStore);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckDrinkInStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hàng tồn trong kho";
            this.Load += new System.EventHandler(this.CheckDrinkInStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dgvListDrinkInStore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _dgvListDrinkInStore;
        private System.Windows.Forms.Button _btnQuit;
    }
}