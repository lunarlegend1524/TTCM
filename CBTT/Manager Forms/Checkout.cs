using System;
using System.Windows.Forms;
using DBLibrary;

namespace TTCM
{
    public partial class Checkout : Form
    {
        private static int customerID = 0;
        private static int totalCost = 0;
        private static int amountYetToBePaid = 0;
        private MainForm mainForm;

        // thanh toán hết hoặc từng phần
        public Checkout(ref int id, int total, MainForm root)
        {
            customerID = id;
            mainForm = root;
            totalCost = total;
            InitializeComponent();
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            amountYetToBePaid = DB.amountYetToBePaid(customerID);
            _txtCustomerName.Text = DB.getCustomerNameByID(customerID);

            // amount of fee paid
            _txtFeePaid.Text = amountYetToBePaid.ToString();
            _txtRemainingFee.Text = (totalCost - amountYetToBePaid).ToString();
            amountYetToBePaid = Convert.ToInt32(_txtRemainingFee.Text);
            _txtCustomerPaid.Clear();
            _txtCustomerPaid.Focus();
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void _btnOK_Click(object sender, EventArgs e)
        {
            string info = string.Empty;
            if (Convert.ToInt32(_txtRemainingFee.Text) <= 0)
            {
                if (MessageBox.Show("Thanh toán cho " + DB.getCustomerNameByID(customerID) + "?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    info = DB.checkOutPartly(customerID, amountYetToBePaid);
                    info = DB.checkOut(customerID, DateTime.Now);
                    MessageBox.Show(info);
                    mainForm.refreshDataGridView();
                    this.Dispose();
                }
                else { }
            }
            else
            {
                if (MessageBox.Show("Thanh toán 1 phần cho " + DB.getCustomerNameByID(customerID) + "?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    info = DB.checkOutPartly(customerID, Convert.ToInt32(_txtCustomerPaid.Text));
                    MessageBox.Show(info);
                    mainForm.refreshDataGridView();
                    Checkout_Load(null, null);
                }
                else { }
            }
        }

        private void _txtCustomerPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void _txtCustomerPaid_TextChanged(object sender, EventArgs e)
        {
            int customerPaid = 0;
            if (_txtCustomerPaid.Text != string.Empty)
            {
                customerPaid = Convert.ToInt32(_txtCustomerPaid.Text);
            }
            else
            {
                customerPaid = 0;
            }
            _txtRemainingFee.Text = (totalCost - amountYetToBePaid - customerPaid).ToString();
        }

        private void _txtRemainingFee_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(_txtRemainingFee.Text) < 0)
            {
                label4.Text = "Trả lại khách";
            }
            else
            {
                label4.Text = "Còn lại";
            }
        }
    }
}