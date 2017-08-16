using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using DBLibrary;

namespace TTCM
{
    public partial class UpdateDrinkPrice : Form
    {
        public UpdateDrinkPrice()
        {
            InitializeComponent();
        }

        private void UpdateDrinkPrice_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = DB.csb.ConnectionString;

            // bind data to combobox
            DataTable dt = new DataTable();
            dt = DB.getDrinkList();

            _cbxDrink.DataSource = dt;
            _cbxDrink.DisplayMember = "Name";
            _cbxDrink.ValueMember = "IdDrink";

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

            _cbxDrink.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            _cbxDrink.AutoCompleteSource = AutoCompleteSource.CustomSource;
            _cbxDrink.AutoCompleteCustomSource = auto;

            _cbxDrink.Focus();
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            string info = "";
            string name = _cbxDrink.Text;
            string price = _txtSellPrice.Text;
            int priceS = 0;

            if (name == "")
            {
                MessageBox.Show("Nhập tên đồ uống/vật dụng");
                _cbxDrink.Focus();
                return;
            }
            if (price == "")
            {
                MessageBox.Show("Nhập giá bán ra");
                _txtSellPrice.Focus();
                return;
            }
            else
            {
                try
                {
                    if (DB.checkRegisteredDrink(name))
                    {
                        priceS = Convert.ToInt32(price);
                        if (MessageBox.Show("Lưu thông tin?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            info = DB.modifyDrinkPrice(name, priceS);
                            MessageBox.Show(info);
                        }
                        else { }
                    }
                    else
                    {
                        MessageBox.Show("Mặt hàng không có trong kho");
                        _cbxDrink.Focus();
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }

        private void _txtSellPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void _cbxDrink_SelectedValueChanged(object sender, EventArgs e)
        {
            string name = _cbxDrink.Text;
            _txtImportPrice.Text = DB.getLatestImportPriceByName(name).ToString();
            _txtSellPrice.Text = DB.getSellDrinkPriceByName(name);
        }
    }
}