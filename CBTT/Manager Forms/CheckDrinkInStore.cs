using System;
using System.Data;
using System.Windows.Forms;
using DBLibrary;

namespace TTCM
{
    public partial class CheckDrinkInStore : Form
    {
        public CheckDrinkInStore()
        {
            InitializeComponent();
        }

        private void _btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CheckDrinkInStore_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = DB.checkDrinksQuantityInStore();
            }
            catch { }

            _dgvListDrinkInStore.DataSource = dt;
            _dgvListDrinkInStore.Columns["Name"].Width = 150;
            _dgvListDrinkInStore.Columns["Name"].HeaderText = "Tên mặt hàng";
            _dgvListDrinkInStore.Columns["Quantity"].Width = 110;
            _dgvListDrinkInStore.Columns["Quantity"].HeaderText = "Số lượng";
        }
    }
}