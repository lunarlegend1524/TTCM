using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using DBLibrary;

namespace TTCM
{
    public partial class ReportByDate : Form
    {
        private MainForm mainForm;

        public ReportByDate(MainForm root)
        {
            mainForm = root;
            InitializeComponent();
        }

        private static DateTime fromDate = new DateTime();
        private static DateTime toDate = new DateTime();

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void refreshDataGridView()
        {
            fromDate = _fromDate.Value;
            toDate = _toDate.Value;
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            dt = DB.getCustomerInfoByDateTime(fromDate, toDate);
            dt2 = DB.getImportInfoByDateTime(fromDate, toDate);

            _dgvExport.DataSource = dt;

            _dgvExport.Columns["IdCustomer"].Visible = false;
            _dgvExport.Columns["Name"].Width = 105;
            _dgvExport.Columns["Name"].HeaderText = "Tên khách hàng";
            _dgvExport.Columns["OnDate"].Width = 80;
            _dgvExport.Columns["OnDate"].HeaderText = "Ngày";

            _dgvImport.DataSource = dt2;

            _dgvImport.Columns["IdImport"].Visible = false;
            _dgvImport.Columns["Name"].Width = 100;
            _dgvImport.Columns["Name"].HeaderText = "Tên mặt hàng";
            _dgvImport.Columns["Price"].Width = 100;
            _dgvImport.Columns["Price"].HeaderText = "Giá nhập/đơn vị";
            _dgvImport.Columns["Quantity"].Width = 60;
            _dgvImport.Columns["Quantity"].HeaderText = "Số lượng";
            _dgvImport.Columns["OnDate"].Width = 80;
            _dgvImport.Columns["OnDate"].HeaderText = "Ngày";

            updateInterestByExport();
            updateCostByImport();
        }

        private void _dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            refreshDataGridView();
        }

        private void _dgvReport_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            showCustomerInfo();
        }

        private void showCustomerInfo()
        {
            int total;
            int IdCustomer = 0;
            try
            {
                IdCustomer = Convert.ToInt32(_dgvExport.CurrentRow.Cells["IdCustomer"].Value);
                _txtCustomerInfo.Text = DB.getDrinkByCustomer(IdCustomer, out total);
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
            dt = DB.searchCustomerByName(customerName, true);

            _dgvExport.DataSource = dt;
            _dgvExport.Columns["IdCustomer"].Visible = false;
            _dgvExport.Columns["TableRent"].Visible = false;
            _dgvExport.Columns["Name"].Width = 105;
            _dgvExport.Columns["Name"].HeaderText = "Tên khách hàng";
            _dgvExport.Columns["OnDate"].Width = 80;
            _dgvExport.Columns["OnDate"].HeaderText = "Ngày";

            updateInterestByExport();
        }

        private void ReportByDate_Load(object sender, EventArgs e)
        {
            //auto complete search customer
            OleDbConnectionStringBuilder csb = new OleDbConnectionStringBuilder();
            csb.ConnectionString = DB.csb.ConnectionString;

            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "SELECT DISTINCT Name FROM tblCustomer WHERE HasPaid = True ORDER BY Name ASC";
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

            _dateTimePicker_ValueChanged(sender, e);
            updateFinalInterest();
        }

        private void _dgvReport_SelectionChanged(object sender, EventArgs e)
        {
            updateInterestByExport();
        }

        private void updateCostByImport()
        {
            int rowIndex;
            int exportTotal = 0;
            foreach (DataGridViewRow row in _dgvImport.Rows)
            {
                rowIndex = Convert.ToInt32(row.Cells["IdImport"].Value);
                exportTotal += DB.getTotalImportCost(rowIndex);
            }
            _lblImportTotal.Text = exportTotal.ToString();
        }

        private void updateInterestByExport()
        {
            int rowIndex;
            int exportTotal = 0;
            foreach (DataGridViewRow row in _dgvExport.Rows)
            {
                rowIndex = Convert.ToInt32(row.Cells["IdCustomer"].Value);
                exportTotal += DB.getTotalInterestByCustomer(rowIndex);
            }
            _lblExportTotal.Text = exportTotal.ToString();
        }

        private void updateFinalInterest()
        {
            string import = _lblImportTotal.Text;
            string export = _lblExportTotal.Text;

            _lblFinalInterest.Text = (Convert.ToInt32(export) - Convert.ToInt32(import)).ToString();
        }

        private void _lblImportTotal_TextChanged(object sender, EventArgs e)
        {
            updateFinalInterest();
        }

        private void _lblExportTotal_TextChanged(object sender, EventArgs e)
        {
            updateFinalInterest();
        }

        private void _btnContinuePlaying_Click(object sender, EventArgs e)
        {
            int customerID = 0;
            string info = string.Empty;
            try
            {
                customerID = Convert.ToInt32(_dgvExport.CurrentRow.Cells["IdCustomer"].Value);
                if (MessageBox.Show("Tính thêm tiền cho khách hàng " + DB.getCustomerNameByID(customerID) + " ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    info = DB.moveToUnpaidList(customerID);
                    MessageBox.Show(info);
                    refreshDataGridView();
                    showCustomerInfo();
                    mainForm.refreshDataGridView();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa có khách thanh toán");
            }
        }
    }
}