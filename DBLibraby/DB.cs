namespace DBLibrary
{
    using System;
    using System.Configuration;
    using System.Data;
    using System.Data.OleDb;

    public class DB
    {
        public static readonly OleDbConnectionStringBuilder csb;

        static DB()
        {
            csb = new OleDbConnectionStringBuilder();

            //get connectionString in app.config
            csb.ConnectionString = ConfigurationManager.ConnectionStrings["TTCMConnectionString"].ConnectionString;

            //csb.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\TTCM.accdb";
        }

        // display a list of unpaid Customers
        public static DataTable getUnPaidCustomers()
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "SELECT IdCustomer, Name, TableRent, OnDate FROM tblCustomer WHERE HasPaid = False";
            cmd.Connection = conn;

            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = cmd;

            DataTable result = new DataTable();
            adapter.Fill(result);

            return result;
        }

        public static DataTable searchCustomerByName(string name, bool hasPaid)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            OleDbCommand cmd = new OleDbCommand();
            if (name == "")
            {
                cmd.CommandText = "SELECT IdCustomer, Name, TableRent, OnDate FROM tblCustomer WHERE HasPaid = " + hasPaid + string.Empty;
            }
            else
            {
                cmd.CommandText = "SELECT IdCustomer, Name, TableRent, OnDate FROM tblCustomer WHERE Name LIKE '%" + name + "%' AND HasPaid = " + hasPaid + string.Empty;
            }
            cmd.Connection = conn;

            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = cmd;

            DataTable result = new DataTable();
            adapter.Fill(result);

            return result;
        }

        // get customer name when UpdateCustomer shows up
        public static string getCustomerNameByID(int IdCustomer)
        {
            string info = string.Empty;
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;
            OleDbCommand cmd = new OleDbCommand();

            cmd.CommandText = "SELECT Name FROM tblCustomer WHERE IdCustomer = " + IdCustomer + string.Empty;
            cmd.Connection = conn;

            conn.Open();
            OleDbDataReader odr = cmd.ExecuteReader();
            if (odr.Read())
            {
                info = odr["Name"].ToString();
            }
            conn.Close();
            return info;
        }

        // display what drink/equipment a customer has taken
        public static string getDrinkByCustomer(int IdCustomer, out int total)
        {
            String info = string.Empty;
            total = 0;
            int playedHour = 0;
            int playedMinute = 0;
            double playedTime = 0;
            int tableRent = 0;

            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "SELECT D.Name, D.Price, T.Quantity FROM (tblDrink AS D LEFT JOIN tblTransaction AS T"
            + " ON D.IdDrink = T.IdDrink) LEFT JOIN tblCustomer AS C"
            + " ON T.IdCustomer = C.IdCustomer WHERE C.IdCustomer = " + IdCustomer + string.Empty;
            cmd.Connection = conn;

            conn.Open();
            OleDbDataReader odr = cmd.ExecuteReader();
            while (odr.Read())
            {
                info += "Tên đồ uống/vật dụng: ";
                info += odr["Name"].ToString();

                info += Environment.NewLine + "Giá tiền: ";
                info += odr["Price"].ToString();

                info += Environment.NewLine + "Số lượng: ";
                info += odr["Quantity"].ToString() + Environment.NewLine + Environment.NewLine;

                total += Convert.ToInt32(odr["Price"]) * Convert.ToInt32(odr["Quantity"]);
            }

            OleDbConnection conn2 = new OleDbConnection();
            conn2.ConnectionString = csb.ConnectionString;
            OleDbCommand cmd2 = new OleDbCommand();
            cmd2.CommandText = "SELECT TableRent FROM tblCustomer WHERE IdCustomer = " + IdCustomer + string.Empty;
            cmd2.Connection = conn2;

            conn2.Open();
            OleDbDataReader odr2 = cmd2.ExecuteReader();
            if (odr2.Read())
            {
                tableRent = Convert.ToInt32(odr2["TableRent"]);
                info += "Tiền bàn: " + odr2["TableRent"].ToString();
            }

            playedTime = checkTimePlayedByCustomer(IdCustomer, out playedHour, out playedMinute);
            if (playedTime == 1.0)
            {
                total += tableRent;
            }
            else
            {
                if (playedTime < 1)
                {
                    info += Environment.NewLine + Environment.NewLine + "Thời gian chơi: " + playedHour + " giờ " + playedMinute + " phút";
                    total += tableRent;
                }
                else
                {
                    info += Environment.NewLine + Environment.NewLine + "Thời gian chơi: " + playedHour + " giờ " + playedMinute + " phút";
                    info += Environment.NewLine + "Hết: " + playedTime * tableRent;
                    total += Convert.ToInt32(playedTime * tableRent);
                }
            }

            info += Environment.NewLine + Environment.NewLine + Environment.NewLine + "Tổng cộng: " + total.ToString();
            conn.Close();
            conn2.Close();
            return info;
        }

        public static int amountYetToBePaid(int IdCustomer)
        {
            int total = 0;
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            OleDbCommand cmd = new OleDbCommand();

            cmd.Connection = conn;
            cmd.CommandText = "SELECT YetToBePaid FROM tblCustomer WHERE IdCustomer = " + IdCustomer;

            try
            {
                conn.Open();
                OleDbDataReader odr = cmd.ExecuteReader();
                if (odr.Read())
                {
                    total = Convert.ToInt32(odr["YetToBePaid"]);
                }
            }
            catch (Exception)
            {
                total = 0;
            }
            finally
            {
                conn.Close();
            }
            return total;
        }

        // fill list of drinks into UpdateCustomer
        public static DataTable getDrinkList()
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "SELECT * FROM tblDrink ORDER BY Name";
            cmd.Connection = conn;

            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = cmd;

            DataTable result = new DataTable();
            adapter.Fill(result);

            return result;
        }

        public static string getSellDrinkPriceByName(string name)
        {
            string info = string.Empty;
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;
            OleDbCommand cmd = new OleDbCommand();

            cmd.CommandText = "SELECT Price FROM tblDrink WHERE Name = '" + name + "'";
            cmd.Connection = conn;

            conn.Open();
            OleDbDataReader odr = cmd.ExecuteReader();
            if (odr.Read())
            {
                info = odr["Price"].ToString();
            }
            conn.Close();
            return info;
        }

        public static string getImportDrinkPriceByName(string name)
        {
            string info = string.Empty;
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;
            OleDbCommand cmd = new OleDbCommand();

            cmd.CommandText = "SELECT Price FROM tblImport WHERE Name = '" + name + "'";
            cmd.Connection = conn;

            conn.Open();
            OleDbDataReader odr = cmd.ExecuteReader();
            if (odr.Read())
            {
                info = odr["Price"].ToString();
            }
            conn.Close();
            return info;
        }

        public static bool checkRegisteredCustomer(string customerName, DateTime onDate)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            OleDbCommand cmd = new OleDbCommand();

            cmd.Connection = conn;
            cmd.CommandText = "SELECT Name FROM tblCustomer WHERE Name = @pName AND OnDate = @pOnDate";

            cmd.Parameters.Add("pName", OleDbType.VarChar);
            cmd.Parameters.Add("pOnDate", OleDbType.Date);

            cmd.Parameters["pName"].Value = customerName;
            cmd.Parameters["pOnDate"].Value = onDate;

            conn.Open();
            OleDbDataReader odr = cmd.ExecuteReader();
            if (odr.Read())
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }

        // add a new customer at the beginning
        public static string addNewCustomerByHead(string customerName, int tableRent, bool hasPaid, DateTime onDate, ref int customerID)
        {
            bool check = checkRegisteredCustomer(customerName, onDate);
            if (check == true)
            {
                return "Khách hàng đã có tên ngày hôm nay";
            }
            else
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = csb.ConnectionString;

                OleDbCommand cmd = new OleDbCommand();
                OleDbCommand cmd2 = new OleDbCommand();

                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO tblCustomer(Name, TableRent, HasPaid, OnDate)" +
                    " VALUES(@pName, @pTableRent, @pHasPaid, @pOnDate)";
                cmd2.CommandText = "SELECT @@Identity";
                cmd.Connection = conn;
                cmd2.Connection = conn;

                cmd.Parameters.Add("pName", OleDbType.VarChar);
                cmd.Parameters.Add("pTableRent", OleDbType.Numeric);
                cmd.Parameters.Add("pHasPaid", OleDbType.Boolean);
                cmd.Parameters.Add("pOnDate", OleDbType.Date);

                cmd.Parameters["pName"].Value = customerName;
                cmd.Parameters["pTableRent"].Value = tableRent;
                cmd.Parameters["pHasPaid"].Value = hasPaid;
                cmd.Parameters["pOnDate"].Value = onDate;

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    customerID = Convert.ToInt32(cmd2.ExecuteScalar());
                    return "Đã thêm 1 khách mới";
                }
                catch (OleDbException e)
                {
                    return e.ToString();
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        // customer who play by hour
        public static string addNewCustomerByHour(string customerName, int tableRent, bool hasPaid, DateTime onDate, DateTime startTime, ref int customerID)
        {
            bool check = checkRegisteredCustomer(customerName, onDate);
            if (check == true)
            {
                return "Khách hàng đã có tên ngày hôm nay";
            }
            else
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = csb.ConnectionString;

                OleDbCommand cmd = new OleDbCommand();
                OleDbCommand cmd2 = new OleDbCommand();

                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO tblCustomer(Name, TableRent, HasPaid, OnDate, StartTime)" +
                    " VALUES(@pName, @pTableRent, @pHasPaid, @pOnDate, @pStartTime)";
                cmd2.CommandText = "SELECT @@Identity";
                cmd.Connection = conn;
                cmd2.Connection = conn;

                cmd.Parameters.Add("pName", OleDbType.VarChar);
                cmd.Parameters.Add("pTableRent", OleDbType.Numeric);
                cmd.Parameters.Add("pHasPaid", OleDbType.Boolean);
                cmd.Parameters.Add("pOnDate", OleDbType.Date);
                cmd.Parameters.Add("pStartTime", OleDbType.Date);

                cmd.Parameters["pName"].Value = customerName;
                cmd.Parameters["pTableRent"].Value = tableRent;
                cmd.Parameters["pHasPaid"].Value = hasPaid;
                cmd.Parameters["pOnDate"].Value = onDate;
                cmd.Parameters["pStartTime"].Value = startTime;

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    customerID = Convert.ToInt32(cmd2.ExecuteScalar());
                    return "Đã thêm 1 khách mới";
                }
                catch (OleDbException e)
                {
                    return e.ToString();
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public static string deleteCustomer(int IdCustomer)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            OleDbCommand cmd = new OleDbCommand();
            OleDbCommand cmd2 = new OleDbCommand();

            cmd.Connection = conn;
            cmd2.Connection = conn;
            cmd.CommandText = "DELETE FROM tblCustomer WHERE IdCustomer = @pID";
            cmd2.CommandText = "DELETE FROM tblTransaction WHERE IdCustomer = @pID";

            cmd.Parameters.Add("pID", OleDbType.Numeric);
            cmd.Parameters["pID"].Value = IdCustomer;

            cmd2.Parameters.Add("pID", OleDbType.Numeric);
            cmd2.Parameters["pID"].Value = IdCustomer;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                return "Đã xóa khách hàng";
            }
            catch (OleDbException e)
            {
                return e.ToString();
            }
            finally
            {
                conn.Close();
            }
        }

        public static string moveToUnpaidList(int IDCustomer)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            OleDbCommand cmd = new OleDbCommand();

            cmd.Connection = conn;
            cmd.CommandText = "UPDATE tblCustomer SET HasPaid = False WHERE IdCustomer = " + IDCustomer;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                return "Đã đưa khách hàng về mục chưa thanh toán";
            }
            catch (OleDbException e)
            {
                return e.ToString();
            }
            finally
            {
                conn.Close();
            }
        }

        public static bool checkFinishedPlaying(int IdCustomer, out DateTime endTime)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader odr;

            cmd.Connection = conn;
            cmd.CommandText = "SELECT EndTime FROM tblCustomer WHERE IdCustomer = " + IdCustomer;

            try
            {
                conn.Open();
                odr = cmd.ExecuteReader();
                if (odr.Read())
                {
                    endTime = Convert.ToDateTime(odr["EndTime"]);
                    return true;
                }
                else
                {
                    endTime = DateTime.Now;
                    return false;
                }
            }
            catch (Exception)
            {
                endTime = DateTime.Now;
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public static string updateTimePlayedByCustomer(int IdCustomer, DateTime startTime, DateTime endTime)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            OleDbCommand cmd = new OleDbCommand();

            cmd.CommandText = "UPDATE tblCustomer SET StartTime = @pStartTime, EndTime = @pEndTime WHERE IdCustomer = " + IdCustomer;

            cmd.Parameters.Add("pStartTime", OleDbType.Date);
            cmd.Parameters.Add("pEndTime", OleDbType.Date);

            cmd.Parameters["pStartTime"].Value = startTime;
            cmd.Parameters["pEndTime"].Value = endTime;

            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                return "Đã thay đổi giờ chơi";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
            finally
            {
                conn.Close();
            }
        }

        public static double checkTimePlayedByCustomer(int IdCustomer, out int hour, out int minute)
        {
            DateTime startTime = new DateTime();
            DateTime endTime = new DateTime();
            double playedTime = 0;
            TimeSpan span = new TimeSpan();

            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "SELECT StartTime FROM tblCustomer WHERE IdCustomer = " + IdCustomer;
            cmd.Connection = conn;

            OleDbDataReader odr;
            try
            {
                conn.Open();
                odr = cmd.ExecuteReader();
                if (odr.Read())
                {
                    startTime = Convert.ToDateTime(odr["StartTime"]);
                }
                checkFinishedPlaying(IdCustomer, out endTime);
                span = endTime.Subtract(startTime);
                hour = span.Hours;
                minute = span.Minutes;
                playedTime = Math.Round(span.TotalHours, 1);
            }
            catch (Exception)
            {
                hour = 0;
                minute = 0;
                playedTime = 1.0;
            }
            return playedTime;
        }

        public static int getPriceByCustomerByHour(int IdCustomer)
        {
            DateTime startTime = new DateTime();
            double playedTime = 0;
            TimeSpan span = new TimeSpan();
            int tableRent = 0;

            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "SELECT StartTime FROM tblCustomer WHERE IdCustomer = " + IdCustomer;
            cmd.Connection = conn;

            conn.Open();
            OleDbDataReader odr = cmd.ExecuteReader();
            if (odr.Read())
            {
                startTime = Convert.ToDateTime(odr["StartTime"]);
            }

            OleDbCommand cmd2 = new OleDbCommand();
            cmd2.CommandText = "SELECT TableRent FROM tblCustomer WHERE IdCustomer = " + IdCustomer;
            cmd2.Connection = conn;

            odr = cmd2.ExecuteReader();
            if (odr.Read())
            {
                tableRent = Convert.ToInt32(odr["TableRent"]);
            }

            span = DateTime.Now.Subtract(startTime);
            playedTime = span.TotalHours;
            conn.Close();

            return Convert.ToInt32(tableRent * playedTime);
        }

        public static bool checkBoughtDrink(int IdCustomer, int IdDrink)
        {
            int drinnkID = 0;
            int customerID = 0;
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            OleDbCommand cmd = new OleDbCommand();

            cmd.Connection = conn;
            cmd.CommandText = "SELECT IdCustomer, IdDrink FROM tblTransaction WHERE IdCustomer = @pIdCustomer AND IdDrink = @pIdDrink";

            cmd.Parameters.Add("pIdCustomer", OleDbType.Numeric);
            cmd.Parameters.Add("pIdDrink", OleDbType.Numeric);

            cmd.Parameters["pIdCustomer"].Value = IdCustomer;
            cmd.Parameters["pIdDrink"].Value = IdDrink;

            try
            {
                conn.Open();
                OleDbDataReader odr = cmd.ExecuteReader();
                if (odr.Read())
                {
                    drinnkID = Convert.ToInt32(odr["IdDrink"]);
                    customerID = Convert.ToInt32(odr["IdCustomer"]);
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception)
            {
                conn.Close();
                return false;
            }
        }

        public static int quantityOfDrink(int IdCustomer, int IdDrink)
        {
            int quantity = 0;
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            OleDbCommand cmd = new OleDbCommand();

            cmd.CommandText = "SELECT T.Quantity FROM (tblDrink AS D LEFT JOIN tblTransaction AS T"
            + " ON D.IdDrink = T.IdDrink) LEFT JOIN tblCustomer AS C"
            + " ON T.IdCustomer = C.IdCustomer WHERE T.IdCustomer = " + IdCustomer + " AND T.IdDrink = " + IdDrink + string.Empty;
            cmd.Connection = conn;

            conn.Open();
            OleDbDataReader odr = cmd.ExecuteReader();
            if (odr.Read())
            {
                quantity = Convert.ToInt32(odr["Quantity"]);
            }
            conn.Close();
            return quantity;
        }

        public static int getQuantityOfDrinkInStore(int IdDrink)
        {
            int quantity = 0;
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "SELECT Quantity FROM tblDrink WHERE IdDrink = @pIdDrink";
            cmd.Connection = conn;

            cmd.Parameters.Add("pIdDrink", OleDbType.Numeric);
            cmd.Parameters["pIdDrink"].Value = IdDrink;
            try
            {
                conn.Open();
                OleDbDataReader odr = cmd.ExecuteReader();
                if (odr.Read())
                {
                    quantity = Convert.ToInt32(odr["Quantity"]);
                }
            }
            catch (Exception)
            {
                quantity = 0;
            }
            finally
            {
                conn.Close();
            }
            return quantity;
        }

        public static DataTable checkDrinksQuantityInStore()
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "SELECT Name, Quantity FROM tblDrink WHERE Quantity > 0";
            cmd.Connection = conn;

            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = cmd;

            DataTable result = new DataTable();
            adapter.Fill(result);

            return result;
        }

        public static void removeDrinkFromStore(int IdDrink, int quantity)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            OleDbCommand cmd = new OleDbCommand();

            cmd.Connection = conn;
            cmd.CommandText = "UPDATE tblDrink SET Quantity = Quantity - " + quantity + " WHERE IdDrink = " + IdDrink + string.Empty;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static string updateCustomer(int IdCustomer, int IdDrink, int quantity)
        {
            int take = quantity;
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            OleDbCommand cmd = new OleDbCommand();
            OleDbCommand cmd2 = new OleDbCommand();

            cmd.Connection = conn;
            cmd2.Connection = conn;

            // check if customer has bought a specific drink
            if ((quantityOfDrink(IdCustomer, IdDrink) + quantity) < 0)
            {
                return "Không bớt được đồ uống";
            }
            if (getQuantityOfDrinkInStore(IdDrink) == 0 && quantity > 0)
            {
                return "Đồ uống trong kho đã hết";
            }
            if (getQuantityOfDrinkInStore(IdDrink) - quantity < 0)
            {
                return "Đồ uống trong kho không đủ";
            }
            else
            {
                bool check = checkBoughtDrink(IdCustomer, IdDrink);
                if (check == true)
                {
                    quantity += quantityOfDrink(IdCustomer, IdDrink);
                    cmd.CommandText = "UPDATE tblTransaction SET Quantity = " + quantity + " WHERE IdCustomer=" + IdCustomer + " AND IdDrink = " + IdDrink + string.Empty;
                }
                else
                {
                    cmd.CommandText = "INSERT INTO tblTransaction(IdCustomer, IdDrink, Quantity)" +
                    " VALUES(@pIdCustomer, @pIdDrink, @pQuanrity)";
                }
                cmd.Connection = conn;

                cmd.Parameters.Add("pIdCustomer", OleDbType.Numeric);
                cmd.Parameters.Add("pIdDrink", OleDbType.Numeric);
                cmd.Parameters.Add("pQuanrity", OleDbType.Numeric);

                cmd.Parameters["pIdCustomer"].Value = IdCustomer;
                cmd.Parameters["pIdDrink"].Value = IdDrink;
                cmd.Parameters["pQuanrity"].Value = quantity;

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    removeDrinkFromStore(IdDrink, take);
                    return "Đã thêm/bớt đồ uống/vật dụng";
                }
                catch (OleDbException e)
                {
                    return e.ToString();
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        // return true if play by hour
        public static bool checkIfPlayByHour(int IdCustomer)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            OleDbCommand cmd = new OleDbCommand();

            cmd.Connection = conn;
            cmd.CommandText = "SELECT StartTime FROM tblCustomer WHERE IdCustomer = " + IdCustomer;

            try
            {
                conn.Open();
                OleDbDataReader odr = cmd.ExecuteReader();
                if (odr.Read())
                {
                    DateTime check = Convert.ToDateTime(odr["StartTime"]);
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception)
            {
                conn.Close();
                return false;
            }
        }

        public static DateTime getStartTimeByCustomerID(int IdCustomer)
        {
            DateTime startTime = new DateTime();
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            OleDbCommand cmd = new OleDbCommand();

            cmd.Connection = conn;
            cmd.CommandText = "SELECT StartTime FROM tblCustomer WHERE IdCustomer = " + IdCustomer;

            try
            {
                conn.Open();
                OleDbDataReader odr = cmd.ExecuteReader();
                if (odr.Read())
                {
                    startTime = Convert.ToDateTime(odr["StartTime"]);
                }
            }
            catch (Exception) { }
            return startTime;
        }

        public static DateTime getEndTimeByCustomerID(int IdCustomer)
        {
            DateTime endTime = new DateTime();
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            OleDbCommand cmd = new OleDbCommand();

            cmd.Connection = conn;
            cmd.CommandText = "SELECT EndTime FROM tblCustomer WHERE IdCustomer = " + IdCustomer;

            try
            {
                conn.Open();
                OleDbDataReader odr = cmd.ExecuteReader();
                if (odr.Read())
                {
                    endTime = Convert.ToDateTime(odr["EndTime"]);
                }
            }
            catch (Exception)
            {
                endTime = DateTime.Now;
            }
            return endTime;
        }

        public static string checkOut(int IdCustomer, DateTime endTime)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            OleDbCommand cmd = new OleDbCommand();

            if (checkIfPlayByHour(IdCustomer))
            {
                if (checkFinishedPlaying(IdCustomer, out endTime))
                {
                    cmd.CommandText = "UPDATE tblCustomer SET HasPaid = True WHERE IdCustomer = " + IdCustomer;
                }
                else
                {
                    cmd.CommandText = "UPDATE tblCustomer SET HasPaid = True, EndTime = @pEndTime WHERE IdCustomer = " + IdCustomer;

                    cmd.Parameters.Add("pEndTime", OleDbType.Date);

                    cmd.Parameters["pEndTime"].Value = endTime;
                }
            }
            else
            {
                cmd.CommandText = "UPDATE tblCustomer SET HasPaid = True WHERE IdCustomer = " + IdCustomer;
            }

            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                return "Đã thanh toán cho khách hàng " + getCustomerNameByID(IdCustomer);
            }
            catch (OleDbException e)
            {
                return e.ToString();
            }
            finally
            {
                conn.Close();
            }
        }

        public static string checkOutPartly(int IdCustomer, int total)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            OleDbCommand cmd = new OleDbCommand();

            cmd.CommandText = "UPDATE tblCustomer SET YetToBePaid = @pYetToBePaid WHERE IdCustomer = " + IdCustomer;

            cmd.Parameters.Add("pYetToBePaid", OleDbType.Numeric);

            cmd.Parameters["pYetToBePaid"].Value = amountYetToBePaid(IdCustomer) + total;

            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                return "Đã thanh toán 1 phần cho khách hàng " + getCustomerNameByID(IdCustomer) + Environment.NewLine + Environment.NewLine +
                    "Số tiền: " + total;
            }
            catch (OleDbException e)
            {
                return e.ToString();
            }
            finally
            {
                conn.Close();
            }
        }

        public static bool checkRegisteredDrink(string drink)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            OleDbCommand cmd = new OleDbCommand();

            cmd.Connection = conn;
            cmd.CommandText = "SELECT Name FROM tblDrink WHERE Name = @pName";

            cmd.Parameters.Add("pName", OleDbType.VarChar);

            cmd.Parameters["pName"].Value = drink;

            conn.Open();
            OleDbDataReader odr = cmd.ExecuteReader();
            if (odr.Read())
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }

        public static string addNewDrink(string name, int price, int quantity, DateTime onDate)
        {
            string returnValue = string.Empty;
            int newDrinkID = 0;
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            OleDbCommand cmd = new OleDbCommand();
            OleDbCommand cmd2 = new OleDbCommand();
            OleDbCommand cmdID = new OleDbCommand();

            try
            {
                cmd2.CommandText = "INSERT INTO tblDrink(Name, Price, Quantity)" +
                    " VALUES(@pName, @pPrice, @pQuantity)";
                cmdID.CommandText = "SELECT @@Identity";
                cmd2.Connection = conn;
                cmdID.Connection = conn;

                cmd2.Parameters.Add("pName", OleDbType.VarChar);
                cmd2.Parameters.Add("pPrice", OleDbType.Numeric);
                cmd2.Parameters.Add("pQuantity", OleDbType.Numeric);

                cmd2.Parameters["pName"].Value = name;
                cmd2.Parameters["pPrice"].Value = price;
                cmd2.Parameters["pQuantity"].Value = quantity;

                conn.Open();
                cmd2.ExecuteNonQuery();
                newDrinkID = Convert.ToInt32(cmdID.ExecuteScalar());

                // insert into tblImport after getting DrinkId
                cmd.CommandText = "INSERT INTO tblImport(IdDrink, Name, Price, Quantity, OnDate)" +
                    " VALUES(@pID, @pName, @pPrice, @pQuantity, @pOnDate)";
                cmd.Connection = conn;

                cmd.Parameters.Add("pID", OleDbType.Numeric);
                cmd.Parameters.Add("pName", OleDbType.VarChar);
                cmd.Parameters.Add("pPrice", OleDbType.Numeric);
                cmd.Parameters.Add("pQuantity", OleDbType.Numeric);
                cmd.Parameters.Add("pOnDate", OleDbType.Date);

                cmd.Parameters["pID"].Value = newDrinkID;
                cmd.Parameters["pName"].Value = name;
                cmd.Parameters["pPrice"].Value = price;
                cmd.Parameters["pQuantity"].Value = quantity;
                cmd.Parameters["pOnDate"].Value = onDate;

                cmd.ExecuteNonQuery();
                return "Đã nhập đồ uống/vật dụng";
            }
            catch (OleDbException e)
            {
                return e.ToString();
            }
            finally
            {
                conn.Close();
            }
        }

        public static string updateQuantityOfDrink(string name, int price, int quantity, DateTime onDate)
        {
            int drinkID = getDrinkIDByName(name);
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            OleDbCommand cmd = new OleDbCommand();
            OleDbCommand cmd2 = new OleDbCommand();

            cmd.CommandText = "INSERT INTO tblImport(IdDrink, Name, Price, Quantity, OnDate)" +
                " VALUES(@pID, @pName, @pPrice, @pQuantity, @pOnDate)";
            cmd2.CommandText = "UPDATE tblDrink SET Quantity = Quantity + " + quantity + " WHERE IdDrink = " + drinkID + string.Empty;
            cmd.Connection = conn;
            cmd2.Connection = conn;

            cmd.Parameters.Add("pID", OleDbType.Numeric);
            cmd.Parameters.Add("pName", OleDbType.VarChar);
            cmd.Parameters.Add("pPrice", OleDbType.Numeric);
            cmd.Parameters.Add("pQuantity", OleDbType.Numeric);
            cmd.Parameters.Add("pOnDate", OleDbType.Date);

            cmd.Parameters["pID"].Value = drinkID;
            cmd.Parameters["pName"].Value = name;
            cmd.Parameters["pPrice"].Value = price;
            cmd.Parameters["pQuantity"].Value = quantity;
            cmd.Parameters["pOnDate"].Value = onDate;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                return "Đã nhập đồ uống/vật dụng";
            }
            catch (OleDbException e)
            {
                return e.ToString();
            }
            finally
            {
                conn.Close();
            }
        }

        public static string updateDrink(string name, int price, int quantity, DateTime onDate)
        {
            string info = string.Empty;
            if (checkRegisteredDrink(name) == true)
            {
                if (getQuantityOfDrinkInStore(getDrinkIDByName(name)) + quantity < 0)
                {
                    info = "Vật dụng trong kho ít hơn số lượng muốn xuất";
                }
                else
                {
                    info = updateQuantityOfDrink(name, price, quantity, onDate);
                }
            }
            else
            {
                if (quantity < 0)
                {
                    info = "Vật dụng này chưa có, không thể xuất ra";
                }
                else
                {
                    info = addNewDrink(name, price, quantity, onDate);
                }
            }
            return info;
        }

        public static string removeDrink(string name)
        {
            string info = string.Empty;
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            OleDbCommand cmd = new OleDbCommand();

            if (checkRegisteredDrink(name) == true)
            {
                cmd.CommandText = "DELETE FROM tblDrink WHERE Name = @pName";
                cmd.Parameters.Add("pName", OleDbType.VarChar);
                cmd.Parameters["pName"].Value = name;
                cmd.Connection = conn;

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    info = "Đã xóa đồ uống/vật dụng";
                }
                catch (OleDbException e)
                {
                    return e.ToString();
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                info = "Đồ uống/vật dụng không có trong kho";
            }
            return info;
        }

        public static int getDrinkIDByName(string name)
        {
            int id = 0;
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            OleDbCommand cmd = new OleDbCommand();

            cmd.Connection = conn;
            cmd.CommandText = "SELECT IdDrink FROM tblDrink WHERE Name = @pName";
            cmd.Parameters.Add("pName", OleDbType.VarChar);
            cmd.Parameters["pName"].Value = name;

            try
            {
                conn.Open();
                OleDbDataReader odr = cmd.ExecuteReader();
                if (odr.Read())
                {
                    id = Convert.ToInt32(odr["IdDrink"]);
                }
            }
            catch (Exception) { }
            finally
            {
                conn.Close();
            }
            return id;
        }

        public static string getDrinkNameByID(int ID)
        {
            string info = string.Empty;
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            OleDbCommand cmd = new OleDbCommand();

            cmd.Connection = conn;
            cmd.CommandText = "SELECT Name FROM tblDrink WHERE IdDrink = @pID";
            cmd.Parameters.Add("pID", OleDbType.Numeric);
            cmd.Parameters["pID"].Value = ID;

            try
            {
                conn.Open();
                OleDbDataReader odr = cmd.ExecuteReader();
                if (odr.Read())
                {
                    info = odr["Name"].ToString();
                }
            }
            catch (Exception) { }
            finally
            {
                conn.Close();
            }
            return info;
        }

        public static string drinkTransfer(int from, int to, int IdDrink, int quantity)
        {
            if (IdDrink == 10) // tiền bàn
            {
                quantity = 1;
                updateCustomer(to, IdDrink, quantity);
                return modifyTableRent(from, 0);
            }
            if (checkBoughtDrink(from, IdDrink) == true && quantityOfDrink(from, IdDrink) >= quantity)
            {
                updateCustomer(from, IdDrink, -quantity);
                updateCustomer(to, IdDrink, +quantity);
                return "Đã chuyển đồ uống/vật dụng từ " + getCustomerNameByID(from) + " đến " + getCustomerNameByID(to) + string.Empty;
            }
            else
            {
                return "Không đủ để chuyển";
            }
        }

        public static int getTableRentByID(int ID)
        {
            int tableRent = 0;
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            OleDbCommand cmd = new OleDbCommand();

            cmd.Connection = conn;
            cmd.CommandText = "SELECT TableRent FROM tblCustomer WHERE IdCustomer = @pID";
            cmd.Parameters.Add("pID", OleDbType.Numeric);
            cmd.Parameters["pID"].Value = ID;

            try
            {
                conn.Open();
                OleDbDataReader odr = cmd.ExecuteReader();
                if (odr.Read())
                {
                    tableRent = Convert.ToInt32(odr["TableRent"]);
                }
            }
            catch (Exception) { }
            finally
            {
                conn.Close();
            }
            return tableRent;
        }

        public static string modifyTableRent(int ID, int amount)
        {
            string info = string.Empty;
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            OleDbCommand cmd = new OleDbCommand();

            cmd.Connection = conn;
            cmd.CommandText = "UPDATE tblCustomer SET TableRent = " + amount + " WHERE IdCustomer = " + ID + string.Empty;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                info = "Đã thay đổi tiền bàn";
            }
            catch (OleDbException e)
            {
                return e.ToString();
            }
            finally
            {
                conn.Close();
            }
            return info;
        }

        public static string modifyDrinkPrice(string name, int price)
        {
            string info = string.Empty;
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            OleDbCommand cmd = new OleDbCommand();

            cmd.Connection = conn;
            cmd.CommandText = "UPDATE tblDrink SET Price = " + price + " WHERE Name = '" + name + "'";

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                info = "Đã thay đổi tiền bán ra";
            }
            catch (OleDbException e)
            {
                return e.ToString();
            }
            finally
            {
                conn.Close();
            }
            return info;
        }

        public static int getLatestImportPriceByName(string name)
        {
            int importPrice = 0;
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            OleDbCommand cmd = new OleDbCommand();

            cmd.Connection = conn;
            cmd.CommandText = "SELECT Price FROM tblImport WHERE Name = @pName AND OnDate = (SELECT MAX(OnDate) FROM tblImport)";
            cmd.Parameters.Add("pName", OleDbType.VarChar);
            cmd.Parameters["pName"].Value = name;

            try
            {
                conn.Open();
                OleDbDataReader odr = cmd.ExecuteReader();
                if (odr.Read())
                {
                    importPrice = Convert.ToInt32(odr["Price"]);
                }
            }
            catch (Exception) { }
            finally
            {
                conn.Close();
            }
            return importPrice;
        }

        public static DataTable getCustomerInfoByDateTime(DateTime from, DateTime to)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            string fromDate = from.ToShortDateString();
            string toDate = to.ToShortDateString();

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "SELECT IDCustomer, Name, OnDate FROM tblCustomer"
                    + " WHERE HasPaid = True AND OnDate BETWEEN @pFromDate AND @pToDate";
            cmd.Parameters.Add("pFromDate", OleDbType.Date);
            cmd.Parameters.Add("pToDate", OleDbType.Date);

            cmd.Parameters["pFromDate"].Value = fromDate;
            cmd.Parameters["pToDate"].Value = toDate;

            cmd.Connection = conn;

            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = cmd;

            DataTable result = new DataTable();
            adapter.Fill(result);

            return result;
        }

        public static DataTable getImportInfoByDateTime(DateTime from, DateTime to)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            string fromDate = from.ToShortDateString();
            string toDate = to.ToShortDateString();

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "SELECT IdImport, Name, Price, Quantity, OnDate FROM tblImport"
                    + " WHERE OnDate BETWEEN @pFromDate AND @pToDate";
            cmd.Parameters.Add("pFromDate", OleDbType.Date);
            cmd.Parameters.Add("pToDate", OleDbType.Date);

            cmd.Parameters["pFromDate"].Value = fromDate;
            cmd.Parameters["pToDate"].Value = toDate;

            cmd.Connection = conn;

            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = cmd;

            DataTable result = new DataTable();
            adapter.Fill(result);

            return result;
        }

        // get each import cost
        public static string getImportCost(int IdImport, out int total)
        {
            String info = string.Empty;
            total = 0;

            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = csb.ConnectionString;

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "SELECT Name, Price, Quantity FROM tblImport"
                + " WHERE IdImport = " + IdImport + string.Empty;
            cmd.Connection = conn;

            conn.Open();
            OleDbDataReader odr = cmd.ExecuteReader();
            while (odr.Read())
            {
                info += "Tên đồ uống/vật dụng: ";
                info += odr["Name"].ToString();

                total += Convert.ToInt32(odr["Price"]) * Convert.ToInt32(odr["Quantity"]);
            }

            info += Environment.NewLine + Environment.NewLine + "Tổng cộng: " + total.ToString();
            conn.Close();
            return info;
        }

        public static int getTotalImportCost(int IdImport)
        {
            int total = 0;
            string info = string.Empty;
            info = getImportCost(IdImport, out total);

            return total;
        }

        public static int getTotalInterestByCustomer(int IdCustomer)
        {
            int total = 0;
            string info = string.Empty;
            info = getDrinkByCustomer(IdCustomer, out total);

            return total;
        }
    }
}