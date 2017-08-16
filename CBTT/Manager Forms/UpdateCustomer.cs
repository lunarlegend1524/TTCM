using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using DBLibrary;

namespace TTCM
{
    public partial class UpdateCustomer : Form
    {
        private static int customerID;
        private MainForm mainForm;

        public UpdateCustomer(ref int ID, MainForm form1)
        {
            //get IdCustomer from Main Form
            customerID = ID;
            mainForm = form1;
            InitializeComponent();
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            mainForm.updateCustomerInfo(customerID);
        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
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

            _txtCustomerName.Text = DB.getCustomerNameByID(customerID);
        }

        private void _btnOK_Click(object sender, EventArgs e)
        {
            string info = "";

            int IdDrink = Convert.ToInt32(_cbxDrink.SelectedValue);
            int quantity = Convert.ToInt32(_numQuantity.Value);

            if (MessageBox.Show("Thêm đồ uống/vật dụng ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                info = DB.updateCustomer(customerID, IdDrink, quantity);
                MessageBox.Show(info);
            }
            else { }
        }
    }
}