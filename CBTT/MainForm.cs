using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using DBLibrary;

namespace TTCM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private static int selectedRowIndex = 0;
        private static int customerID = 0;
        private static int total = 0;

        //format datetime in gridview
        //public event DataGridViewCellFormattingEventHandler CellFormatting;

        private void _btnCreate_Click(object sender, EventArgs e)
        {
            AddNewCustomer AddNewForm = new AddNewCustomer(this);
            AddNewForm.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.OK)
            {
                this.Close();
            }
            else { }
        }

        private void _btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                customerID = Convert.ToInt32(_dgvListCustomers.SelectedCells[0].OwningRow.Cells[0].Value);

                // pass IdCustomer to UpdateCustomer
                UpdateCustomer updateCustomerForm = new UpdateCustomer(ref customerID, this);
                updateCustomerForm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa có khách");
            }
        }

        private void thốngKêTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportByDate reportForm = new ReportByDate(this);
            reportForm.ShowDialog();
        }

        private void CreateTable()
        {
            OleDbConnectionStringBuilder csb = new OleDbConnectionStringBuilder();

            //csb.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\TTCM.accdb";
            csb.ConnectionString = ConfigurationManager.ConnectionStrings["TTCMConnectionString"].ConnectionString;

            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "ALTER TABLE tblCustomer ADD YetToBePaid int";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { }
        }

        private void ALTER()
        {
            OleDbConnectionStringBuilder csb = new OleDbConnectionStringBuilder();

            //csb.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\TTCM.accdb";
            csb.ConnectionString = ConfigurationManager.ConnectionStrings["TTCMConnectionString"].ConnectionString;

            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;
            OleDbCommand cmd = new OleDbCommand();
            OleDbCommand cmd2 = new OleDbCommand();
            cmd.CommandText = "ALTER TABLE tblTransaction ADD Constraint FK_Drink Foreign Key (IdDrink) References tblDrink(IdDrink);";
            cmd2.CommandText = "ALTER TABLE tblTransaction ADD Constraint FK_Customer Foreign Key (IdCustomer) References tblCustomer(IdCustomer);";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd2.CommandType = CommandType.Text;
            cmd2.Connection = conn;

            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { }
            try
            {
                cmd2.ExecuteNonQuery();
            }
            catch (Exception) { }
            finally
            {
                conn.Close();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateTable();
            ALTER();
            this.Enabled = false;
            SplashForm Splash = new SplashForm();
            try
            {
                Splash.Show();
            }
            catch { }

            // bind data to combobox
            DataTable dt = new DataTable();
            try
            {
                dt = DB.getUnPaidCustomers();
            }
            catch { }

            _dgvListCustomers.DataSource = dt;
            _dgvListCustomers.Columns["IdCustomer"].Visible = false;
            _dgvListCustomers.Columns["Name"].Width = 200;
            _dgvListCustomers.Columns["Name"].HeaderText = "Tên khách hàng";
            _dgvListCustomers.Columns["TableRent"].HeaderText = "Tiền bàn";
            _dgvListCustomers.Columns["OnDate"].HeaderText = "Ngày";

            //auto complete search customer
            OleDbConnectionStringBuilder csb = new OleDbConnectionStringBuilder();

            //csb.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\TTCM.accdb";
            csb.ConnectionString = ConfigurationManager.ConnectionStrings["TTCMConnectionString"].ConnectionString;

            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;
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

            _txtSearchCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            _txtSearchCustomer.AutoCompleteSource = AutoCompleteSource.CustomSource;
            _txtSearchCustomer.AutoCompleteCustomSource = auto;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Enabled = true;
        }

        private void _dgvListCustomers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                selectedRowIndex = _dgvListCustomers.CurrentCell.RowIndex;

                //display info in _txtCustomerInfo
                customerID = Convert.ToInt32(_dgvListCustomers.CurrentRow.Cells["IdCustomer"].Value);
            }
            catch (Exception)
            {
                selectedRowIndex = 0;
                customerID = 0;
            }
            updateCustomerInfo(customerID);
        }

        public void updateCustomerInfo(int id)
        {
            try
            {
                customerID = id;
                if (id == 0)
                {
                    customerID = Convert.ToInt32(_dgvListCustomers.CurrentRow.Cells["IdCustomer"].Value);
                }
                else
                {
                    _txtCustomerInfo.Text = DB.getDrinkByCustomer(customerID, out total);
                }
                _dgvListCustomers.CurrentRow.Selected = true;
            }
            catch (Exception) { }
        }

        private void _btnCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                customerID = Convert.ToInt32(_dgvListCustomers.SelectedCells[0].OwningRow.Cells[0].Value);
                Checkout checkOut = new Checkout(ref customerID, total, this);
                checkOut.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa có khách");
            }
        }

        public void refreshDataGridView()
        {
            DataTable dt = new DataTable();
            dt = DB.getUnPaidCustomers();

            _dgvListCustomers.DataSource = dt;
            _dgvListCustomers.Columns["IdCustomer"].Visible = false;
            _dgvListCustomers.Columns["Name"].Width = 200;
            _dgvListCustomers.Columns["Name"].HeaderText = "Tên khách hàng";
            _dgvListCustomers.Columns["TableRent"].HeaderText = "Tiền bàn";
            _dgvListCustomers.Columns["OnDate"].HeaderText = "Ngày";

            try
            {
                customerID = Convert.ToInt32(_dgvListCustomers.SelectedCells[0].OwningRow.Cells[0].Value);
                updateCustomerInfo(customerID);
            }
            catch (Exception)
            {
                _txtCustomerInfo.Clear();
            }
        }

        private void _txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            string customerName = _txtSearchCustomer.Text;
            DataTable dt = new DataTable();
            dt = DB.searchCustomerByName(customerName, false);

            _dgvListCustomers.DataSource = dt;
            _dgvListCustomers.Columns["IdCustomer"].Visible = false;
            _dgvListCustomers.Columns["Name"].Width = 200;
            _dgvListCustomers.Columns["Name"].HeaderText = "Tên khách hàng";
            _dgvListCustomers.Columns["TableRent"].HeaderText = "Tiền bàn";
            _dgvListCustomers.Columns["OnDate"].HeaderText = "Ngày";

            try
            {
                customerID = customerID = Convert.ToInt32(_dgvListCustomers.SelectedCells[0].OwningRow.Cells[0].Value);
                updateCustomerInfo(customerID);
            }
            catch (Exception)
            {
            }
        }

        private void thêmĐồUốngvậtDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDrink addNewDrinkForm = new AddNewDrink();
            addNewDrinkForm.ShowDialog();
        }

        private void chuyểnTiềnBànđồUốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrinkTransfer dtForm = new DrinkTransfer(this);
            dtForm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 2.0" + Environment.NewLine + "Created by LongLH" + Environment.NewLine
                + Environment.NewLine + "Contact: lunarlegend1524@gmail.com"
                + Environment.NewLine + "                longlh00905@fpt.edu.vn", "Author");
        }

        private void _btnChangeTableRent_Click(object sender, EventArgs e)
        {
            try
            {
                customerID = Convert.ToInt32(_dgvListCustomers.SelectedCells[0].OwningRow.Cells[0].Value);
                UpdateTableRent updateTableRentForm = new UpdateTableRent(ref customerID, this);
                updateTableRentForm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa có khách");
            }
        }

        private void chỉnhSửaGiáBánRaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDrinkPrice updateDrinkPrice = new UpdateDrinkPrice();
            updateDrinkPrice.ShowDialog();
        }

        private void _dgvListCustomers_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (_dgvListCustomers.CurrentRow.Index != selectedRowIndex || _dgvListCustomers.CurrentRow.Index == 0)
                {
                    customerID = Convert.ToInt32(_dgvListCustomers.CurrentRow.Cells["IdCustomer"].Value);
                    updateCustomerInfo(customerID);
                }
                else { }
            }
            catch (Exception) { }
        }

        private void kiểmTraHàngTồnTrongKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckDrinkInStore checkStore = new CheckDrinkInStore();
            checkStore.ShowDialog();
        }

        private void _btnDelete_Click(object sender, EventArgs e)
        {
            string info = string.Empty;
            try
            {
                customerID = Convert.ToInt32(_dgvListCustomers.CurrentRow.Cells["IdCustomer"].Value);
                if (MessageBox.Show("Xóa khách hàng " + DB.getCustomerNameByID(customerID) + " ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    info = DB.deleteCustomer(customerID);
                    MessageBox.Show(info);
                }
                refreshDataGridView();
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa có khách");
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            try
            {
                customerID = Convert.ToInt32(_dgvListCustomers.CurrentRow.Cells["IdCustomer"].Value);
                updateCustomerInfo(customerID);
            }
            catch (Exception) { }
        }

        private void _btnUpdateTimePlayed_Click(object sender, EventArgs e)
        {
            try
            {
                customerID = Convert.ToInt32(_dgvListCustomers.SelectedCells[0].OwningRow.Cells[0].Value);
                if (DB.checkIfPlayByHour(customerID))
                {
                    UpdateTimePlayed timePlayed = new UpdateTimePlayed(ref customerID, this);
                    timePlayed.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Khách hàng không đăng ký chơi theo giờ");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa có khách");
            }
        }

        //private void _dgvListCustomers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    if (this._dgvListCustomers.Columns[e.ColumnIndex].Name == "Ngày")
        //    {
        //        ShortFormDateFormat(e);
        //    }
        //}

        ////http://msdn.microsoft.com/en-us/library/system.windows.forms.datagridview.cellformatting.aspx
        //private static void ShortFormDateFormat(DataGridViewCellFormattingEventArgs formatting)
        //{
        //    if (formatting.Value != null)
        //    {
        //        try
        //        {
        //            System.Text.StringBuilder dateString = new System.Text.StringBuilder();
        //            DateTime theDate = DateTime.Parse(formatting.Value.ToString());

        //            dateString.Append(theDate.Day);
        //            dateString.Append("/");
        //            dateString.Append(theDate.Month);
        //            dateString.Append("/");
        //            dateString.Append(theDate.Year.ToString().Substring(2));
        //            formatting.Value = dateString.ToString();
        //            formatting.FormattingApplied = true;
        //        }
        //        catch (FormatException)
        //        {
        //            // Set to false in case there are other handlers interested trying to
        //            // format this DataGridViewCellFormattingEventArgs instance.
        //            formatting.FormattingApplied = false;
        //        }
        //    }
        //}
    }
}