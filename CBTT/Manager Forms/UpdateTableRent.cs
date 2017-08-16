using System;
using System.Windows.Forms;
using DBLibrary;

namespace TTCM
{
    public partial class UpdateTableRent : Form
    {
        private static int customerID = 0;
        private MainForm mainForm;

        public UpdateTableRent(ref int id, MainForm root)
        {
            customerID = id;
            mainForm = root;
            InitializeComponent();
        }

        private void UpdateTableRent_Load(object sender, EventArgs e)
        {
            _txtCustomerName.Text = DB.getCustomerNameByID(customerID);
            _cbxTableRent.Text = DB.getTableRentByID(customerID).ToString();
        }

        private void _cbxTableRent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void _btnOK_Click(object sender, EventArgs e)
        {
            string info = string.Empty;

            int amount = 0;
            try
            {
                amount = Convert.ToInt32(_cbxTableRent.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (MessageBox.Show("Thay đổi tiền bàn ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                info = DB.modifyTableRent(customerID, amount);
                MessageBox.Show(info);
                this.Dispose();
                mainForm.refreshDataGridView();
            }
            else { }
        }
    }
}