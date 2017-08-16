using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using DBLibrary;

namespace TTCM
{
    public partial class AddNewDrink : Form
    {
        public AddNewDrink()
        {
            InitializeComponent();
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            string info = "";
            int price = 0;
            string name = _cbxDrinkName.Text;
            string priceS = _txtPrice.Text;
            int quantity = 0;
            DateTime onDate = new DateTime();

            if (name == "")
            {
                MessageBox.Show("Nhập tên đồ uống/vật dụng");
                return;
            }
            if (priceS == "")
            {
                MessageBox.Show("Nhập giá tiền");
                return;
            }
            if (_numQuantity.Value == 0)
            {
                MessageBox.Show("Nhập số lượng");
                return;
            }
            else
            {
                try
                {
                    quantity = Convert.ToInt32(_numQuantity.Value);
                    price = Convert.ToInt32(priceS);
                    if (_chkToday.Checked)
                    {
                        onDate = DateTime.Today;
                    }
                    else
                    {
                        onDate = _importDate.Value;
                    }
                    if (MessageBox.Show("Lưu thông tin?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        info = DB.updateDrink(name, price, quantity, onDate);
                        MessageBox.Show(info);
                    }
                    else { }
                }

                catch (Exception)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }

        private void AddNewDrink_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = DB.csb.ConnectionString;

            // bind data to combobox
            DataTable dt = new DataTable();
            dt = DB.getDrinkList();

            _cbxDrinkName.DataSource = dt;
            _cbxDrinkName.DisplayMember = "Name";
            _cbxDrinkName.ValueMember = "IdDrink";

            //auto complete drink list
            OleDbConnectionStringBuilder csb = new OleDbConnectionStringBuilder();
            csb.ConnectionString = DB.csb.ConnectionString;

            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

            conn.ConnectionString = csb.ConnectionString;
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "SELECT DISTINCT Name FROM tblDrink ORDER BY Name ASC";
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

            _cbxDrinkName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            _cbxDrinkName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            _cbxDrinkName.AutoCompleteCustomSource = auto;

            _chkToday.Checked = true;
        }

        private void _btnRemove_Click(object sender, EventArgs e)
        {
            string info = "";
            string name = _cbxDrinkName.Text;

            if (name == "")
                MessageBox.Show("Nhập tên đồ uống/vật dụng");
            else
            {
                try
                {
                    if (MessageBox.Show("Xóa mặt hàng " + name + " khỏi kho?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        info = DB.removeDrink(name);
                        MessageBox.Show(info);
                    }
                    else { }
                }

                catch (Exception)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }

        private void _txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void _chkToday_CheckedChanged(object sender, EventArgs e)
        {
            if (!_chkToday.Checked)
            {
                _importDate.Focus();
            }
        }

        private void _importDate_Enter(object sender, EventArgs e)
        {
            _chkToday.Checked = false;
        }

        private void _cbxDrinkName_TextChanged(object sender, EventArgs e)
        {
            string drinkName = _cbxDrinkName.Text;
            _txtPrice.Text = DB.getImportDrinkPriceByName(drinkName);
        }
    }
}