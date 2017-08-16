using System;
using System.Windows.Forms;
using DBLibrary;

namespace TTCM
{
    public partial class UpdateTimePlayed : Form
    {
        private static int customerID = 0;
        private MainForm mainForm;

        public UpdateTimePlayed(ref int id, MainForm root)
        {
            customerID = id;
            mainForm = root;
            InitializeComponent();
        }

        private void UpdateTimePlayed_Load(object sender, EventArgs e)
        {
            _txtCustomerName.Text = DB.getCustomerNameByID(customerID);
            _startTime.Value = DB.getStartTimeByCustomerID(customerID);
            _endTime.Value = DB.getEndTimeByCustomerID(customerID);
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void _btnOK_Click(object sender, EventArgs e)
        {
            string info = string.Empty;
            DateTime startTime = _startTime.Value;
            DateTime endTime = _endTime.Value;
            if (MessageBox.Show("Thay đổi giờ chơi ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                info = DB.updateTimePlayedByCustomer(customerID, startTime, endTime);
                MessageBox.Show(info);
                this.Dispose();
                mainForm.updateCustomerInfo(customerID);
            }
            else { }
        }
    }
}