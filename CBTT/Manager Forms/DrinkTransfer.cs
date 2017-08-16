using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using DBLibrary;

namespace TTCM
{
    public partial class DrinkTransfer : Form
    {
        private MainForm mainForm;

        public DrinkTransfer(MainForm root)
        {
            mainForm = root;
            InitializeComponent();
        }

        private void DrinkTransfer_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = DB.csb.ConnectionString;

            // bind data to combobox
            DataTable dt = new DataTable();
            dt = DB.getDrinkList();

            _cbxDrink.DataSource = dt;
            _cbxDrink.DisplayMember = "Name";
            _cbxDrink.ValueMember = "IdDrink";

            DataTable dt2 = new DataTable();
            dt2 = DB.getUnPaidCustomers();

            _cbxFrom.DataSource = dt2;
            _cbxFrom.DisplayMember = "Name";
            _cbxFrom.ValueMember = "IdCustomer";

            DataTable dt3 = new DataTable();
            dt3 = DB.getUnPaidCustomers();

            _cbxTo.DataSource = dt3;
            _cbxTo.DisplayMember = "Name";
            _cbxTo.ValueMember = "IdCustomer";

            //auto complete transfer comboboxes
            OleDbConnectionStringBuilder csb = new OleDbConnectionStringBuilder();
            csb.ConnectionString = DB.csb.ConnectionString;

            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

            OleDbConnection conn2 = new OleDbConnection();
            conn2.ConnectionString = csb.ConnectionString;
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "SELECT DISTINCT Name FROM tblCustomer WHERE HasPaid = False ORDER BY Name ASC";
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

            _cbxFrom.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            _cbxFrom.AutoCompleteSource = AutoCompleteSource.CustomSource;
            _cbxFrom.AutoCompleteCustomSource = auto;

            _cbxTo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            _cbxTo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            _cbxTo.AutoCompleteCustomSource = auto;

            try
            {
                _cbxTo.SelectedIndex = 1;
            }
            catch (Exception) { }
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void _btnTransfer_Click(object sender, EventArgs e)
        {
            string info = "";
            int from = Convert.ToInt32(_cbxFrom.SelectedValue);
            int to = Convert.ToInt32(_cbxTo.SelectedValue);
            int IdDrink = Convert.ToInt32(_cbxDrink.SelectedValue);
            int quantity = Convert.ToInt32(_numQuantity.Value);

            if (MessageBox.Show("Chuyển " + quantity + " " + DB.getDrinkNameByID(IdDrink) + " từ " + DB.getCustomerNameByID(from) + " sang " + DB.getCustomerNameByID(to) + " ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                info = DB.drinkTransfer(from, to, IdDrink, quantity);
                MessageBox.Show(info);
                this.Dispose();
                mainForm.refreshDataGridView();
            }
            else { }
        }
    }
}