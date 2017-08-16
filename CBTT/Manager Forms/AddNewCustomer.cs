using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using DBLibrary;

namespace TTCM
{
    public partial class AddNewCustomer : Form
    {
        private MainForm mainForm;

        public AddNewCustomer(MainForm root)
        {
            mainForm = root;
            InitializeComponent();
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            string customerName = _txtCustomerName.Text;
            int tableRent = 0;
            bool hasPaid = false;
            int customerID = 0;
            DateTime startTime = new DateTime();

            string info;

            if (customerName == "")
            {
                MessageBox.Show("Chưa nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK);
                _txtCustomerName.Focus();
                return;
            }
            else
            {
                //customer play by head
                if (_groupByHead.Visible)
                {
                    if (_radioBtn0.Checked)
                    {
                        tableRent = 0;
                    }
                    if (_radioBtn12.Checked)
                    {
                        tableRent = 12000;
                    }
                    if (_radioBtn15.Checked)
                    {
                        tableRent = 15000;
                    }
                    if (_radioBtnOther.Checked)
                    {
                        tableRent = Convert.ToInt32(_txtTableRentByHead.Text);
                    }
                    if (MessageBox.Show("Lưu khách hàng ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        info = DB.addNewCustomerByHead(customerName, tableRent, hasPaid, DateTime.Today, ref customerID);
                        MessageBox.Show(info);
                        this.Dispose();
                        mainForm.refreshDataGridView();
                    }
                    else { }
                }

                //customer play by hour
                if (_groupByHour.Visible)
                {
                    startTime = _startTime.Value;

                    if (_radioBtn18.Checked)
                    {
                        tableRent = 18000;
                    }
                    if (_radioBtn22.Checked)
                    {
                        tableRent = 22000;
                    }
                    if (_radioBtnOther2.Checked)
                    {
                        tableRent = Convert.ToInt32(_txtTableRentByHour.Text);
                    }
                    if (MessageBox.Show("Lưu khách hàng ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        info = DB.addNewCustomerByHour(customerName, tableRent, hasPaid, DateTime.Today, startTime, ref customerID);
                        MessageBox.Show(info);
                        this.Dispose();
                        mainForm.refreshDataGridView();
                    }
                    else { }
                }
            }
        }

        private void AddNew_Load(object sender, EventArgs e)
        {
            OleDbConnectionStringBuilder csb = new OleDbConnectionStringBuilder();
            csb.ConnectionString = DB.csb.ConnectionString;

            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "SELECT DISTINCT Name FROM tblCustomer ORDER BY Name ASC";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            conn.Open();
            OleDbDataReader odr = cmd.ExecuteReader();
            while (odr.Read())
            {
                auto.Add(odr["Name"].ToString());
            }
            odr.Close();
            conn.Close();

            _txtCustomerName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            _txtCustomerName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            _txtCustomerName.AutoCompleteCustomSource = auto;

            _chkByHead.Checked = true;
        }

        private void _cbxTableRent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void _chkByHead_CheckedChanged(object sender, EventArgs e)
        {
            if (_chkByHead.Checked)
            {
                _chkByHour.Checked = false;
                _groupByHead.Visible = true;
                _groupByHour.Visible = false;
            }
            else
            {
                _chkByHour.Checked = true;
            }
        }

        private void _chkByHour_CheckedChanged(object sender, EventArgs e)
        {
            if (_chkByHour.Checked)
            {
                _chkByHead.Checked = false;
                _groupByHead.Visible = false;
                _groupByHour.Visible = true;
            }
            else
            {
                _chkByHead.Checked = true;
            }
        }

        private void _txtTableRentByHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void _txtTableRentByHead_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void _txtTableRentByHead_TextChanged(object sender, EventArgs e)
        {
            _radioBtnOther.Checked = true;
        }

        private void _txtTableRentByHour_TextChanged(object sender, EventArgs e)
        {
            _radioBtnOther2.Checked = true;
        }
    }
}