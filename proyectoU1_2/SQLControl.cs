using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.IO;


namespace proyectoU1_2
{
    class SQLControl
    {
        private SqlConnection connection = new SqlConnection("Data Source = DESKTOP-C4HL5GO\\Pc; Initial Catalog = pubs;" +
            "Integrated security = True;");
        #region login and sign up
        public int Login(string user, string pass)
        {

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("LoginUsers", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usser", user);
                cmd.Parameters.AddWithValue("@pass", pass);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return dr.GetInt32(0);
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return -1;
        }

        public string AddUser(string user, string pass, bool admin)
        {
            try
            {
                int cont = admin == true ? 1 : 0;

                connection.Open();
                SqlCommand cmd = new SqlCommand("AddUser", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usser", user);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.Parameters.AddWithValue("@acceso_id", admin);
                cmd.ExecuteNonQuery();

                connection.Close();

                return null;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        #endregion
        #region Authors manage
        public string AddAuthor(string id, string Name, string LastName, string Phone, string Address, string City, string State, int CP, bool Contract)
        {
            try
            {
                int cont = Contract == true ? 1 : 0;

                connection.Open();
                SqlCommand cmd = new SqlCommand("AddAuthor", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Lastname", LastName);
                cmd.Parameters.AddWithValue("@Phone", Phone);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@City", City);
                cmd.Parameters.AddWithValue("@State", State);
                cmd.Parameters.AddWithValue("@CP", CP);
                cmd.Parameters.AddWithValue("@Contract", cont);

                cmd.ExecuteNonQuery();

                connection.Close();

                return null;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string DeleteAuthor(string id)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("DeleteAuthors", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();

                
                SqlParameter paramError = new SqlParameter("@Error", SqlDbType.VarChar, 100);
                paramError.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(paramError);

                cmd.ExecuteNonQuery();

                connection.Close();

                return paramError.Value.ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string ModifyAuthor(string id, string Name, string LastName, string Phone, string Address, string City, string State, int CP, bool Contract)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("ModifyAuthor", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Lastname", LastName);
                cmd.Parameters.AddWithValue("@Phone", Phone);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@City", City);
                cmd.Parameters.AddWithValue("@State", State);
                cmd.Parameters.AddWithValue("@CP", CP);
                cmd.Parameters.AddWithValue("@Contract", Contract);

                cmd.ExecuteNonQuery();

                connection.Close();

                return null;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public DataTable RefreshAuthor()
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("consultAuthor", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
                connection.Close();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable Filter(string filter)
        {
            DataTable dt = new DataTable();
            try
            {

                connection.Open();

                SqlCommand cmd = new SqlCommand("authorFilter", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", filter);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                }

                connection.Close();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion
        #region SALES MANAGE (OPERATOR)
        public DataTable salesManageFilter(string filter)
        {
            DataTable dt = new DataTable();
            try
            {

                connection.Open();

                SqlCommand cmd = new SqlCommand("salesFilter", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@title", filter);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                }

                connection.Close();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable RefreshSaleManage()
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                string view = "SELECT * FROM salesView";
                SqlCommand cmd = new SqlCommand(view, connection);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
                connection.Close();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public string sales(int qty, string title, string quantity, string store)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("TotalStock", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@qty", qty);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@stor", store);

                cmd.ExecuteNonQuery();

                return null;
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return null;
        }
        #endregion
        #region discount manage
        public DataTable RefreshDiscount()
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                string view = "SELECT * FROM discountsView";
                SqlCommand cmd = new SqlCommand(view, connection);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
                connection.Close();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable discountFilter(string filter)
        {
            DataTable dt = new DataTable();
            try
            {

                connection.Open();

                SqlCommand cmd = new SqlCommand("discountFilter", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DType", filter);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                }

                connection.Close();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public string AddDiscount(string Dtype, string store_id, int lowqty, int highqty, double discount)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("AddDiscount", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DType", Dtype);
                cmd.Parameters.AddWithValue("@Store_id", store_id);
                cmd.Parameters.AddWithValue("@lowqty", lowqty);
                cmd.Parameters.AddWithValue("@highqty", highqty);
                cmd.Parameters.AddWithValue("@discount", discount);

                cmd.ExecuteNonQuery();

                connection.Close();

                return null;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string ModifyDiscount(string Dtype, string store_id, int lowqty, int highqty, double discount)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("ModifyDiscount", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DType", Dtype);
                cmd.Parameters.AddWithValue("@Store_id", store_id);
                cmd.Parameters.AddWithValue("@lowqty", lowqty);
                cmd.Parameters.AddWithValue("@highqty", highqty);
                cmd.Parameters.AddWithValue("@discount", discount);
                cmd.ExecuteNonQuery();

                connection.Close();

                return null;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string DeleteDiscount(string DType)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("DeleteDiscount", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DType", DType);
                cmd.ExecuteNonQuery();

                SqlParameter paramError = new SqlParameter("@Error", SqlDbType.VarChar, 100);
                paramError.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(paramError);

                cmd.ExecuteNonQuery();

                connection.Close();

                return paramError.Value.ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        #endregion
        #region sales manage (ADMINISTRATOR)
        public DataTable RefreshSales_ADMIN()
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                string view = "SELECT * FROM salesView_ADMIN";
                SqlCommand cmd = new SqlCommand(view, connection);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
                connection.Close();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public string DeleteSale(string orderNo)
        {
            try
            {
                string QueryDelete = "delete from sales where ord_num = '" + orderNo + "'";

                connection.Open();
                SqlCommand cmd = new SqlCommand(QueryDelete, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                return null;

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string ModifySale(string Store_id, string orderNo, DateTime orderDate, int qty, string payterm, string titleID)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("ModifySale", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@store_id", Store_id);
                cmd.Parameters.AddWithValue("@OrderNo", orderNo);
                cmd.Parameters.AddWithValue("@orderDate", orderDate);
                cmd.Parameters.AddWithValue("@QTY", qty);
                cmd.Parameters.AddWithValue("@Pay", payterm);
                cmd.Parameters.AddWithValue("@titleID", titleID);
                cmd.ExecuteNonQuery();

                connection.Close();

                return null;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string AddSale(string Store_id, string orderNo, DateTime orderDate, int qty, string payterm, string titleID)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("AddSale", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@store_id", Store_id);
                cmd.Parameters.AddWithValue("@OrderNo", orderNo);
                cmd.Parameters.AddWithValue("@orderDate", orderDate);
                cmd.Parameters.AddWithValue("@QTY", qty);
                cmd.Parameters.AddWithValue("@Pay", payterm);
                cmd.Parameters.AddWithValue("@titleID", titleID);
                cmd.ExecuteNonQuery();

                connection.Close();

                return null;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public DataTable SaleFilter(string filter)
        {
            DataTable dt = new DataTable();
            try
            {

                connection.Open();

                SqlCommand cmd = new SqlCommand("SalesFilter_ADMIN", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OrderNo", filter);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                }

                connection.Close();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion
        #region stores manage
        public DataTable StoreFilter(string filter)
        {
            DataTable dt = new DataTable();
            try
            {

                connection.Open();

                SqlCommand cmd = new SqlCommand("StoresFilter", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@storName", filter);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                }

                connection.Close();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public string AddStore(string Store_id, string storeName, string storeAddress, string city, string state, string cp)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("AddStore", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@storeID", Store_id);
                cmd.Parameters.AddWithValue("@storeName", storeName);
                cmd.Parameters.AddWithValue("@storeAddress", storeAddress);
                cmd.Parameters.AddWithValue("@City", city);
                cmd.Parameters.AddWithValue("@State", state);
                cmd.Parameters.AddWithValue("@Zip", cp);
                cmd.ExecuteNonQuery();

                connection.Close();

                return null;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string ModifyStore(string Store_id, string storeName, string storeAddress, string city, string state, string cp)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("ModifyStore", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@storeID", Store_id);
                cmd.Parameters.AddWithValue("@storeName", storeName);
                cmd.Parameters.AddWithValue("@storeAddress", storeAddress);
                cmd.Parameters.AddWithValue("@City", city);
                cmd.Parameters.AddWithValue("@State", state);
                cmd.Parameters.AddWithValue("@Zip", cp);
                cmd.ExecuteNonQuery();

                connection.Close();

                return null;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public DataTable RefreshStores()
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                string view = "SELECT * FROM storesView_ADMIN";
                SqlCommand cmd = new SqlCommand(view, connection);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
                connection.Close();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public string DeleteStore(string stor_id)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("DeleteStores", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@storeID", stor_id);
                cmd.ExecuteNonQuery();

                SqlParameter paramError = new SqlParameter("@Error", SqlDbType.VarChar, 100);
                paramError.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(paramError);

                cmd.ExecuteNonQuery();

                connection.Close();

                return paramError.Value.ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        #endregion
        #region employee manage
        public DataTable RefreshEmployee()
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                string view = "SELECT * FROM empView";
                SqlCommand cmd = new SqlCommand(view, connection);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
                connection.Close();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public string ModifyEmployee(string emp_id, string empName, string empLName, string minit, int jobID, int jobLVL, string pubID, DateTime hireDate)
        {
            try
            {
                string QueryUpdate = "update employee" +
                        " set emp_id ='" + emp_id + "'," +
                        "fname = '" + empName + "'," +
                        "lname = '" + empLName + "'," +
                        "minit = '" + minit + "'," +
                        "job_id = '" + jobID + "'," +
                        "job_lvl = '" + jobLVL + "'," +
                        "pub_id = '" + pubID + "'," +
                        "hire_date = '" + hireDate.ToString("MM-dd-yyyy") + "'"+
                        "where emp_id = '" + emp_id + "'";
                connection.Open();
                SqlCommand cmd = new SqlCommand(QueryUpdate, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                return null;

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string AddEmployee(string emp_id, string empName, string empLName, string minit, int jobID, int jobLVL, string pubID, DateTime hireDate)
        {
            try
            {
                string QueryAgregar = "insert into employee values (" +
                        "'" + emp_id + "'," +
                        "'" + empName + "'," +
                        "'" + empLName + "'," +
                        "'" + minit + "'," +
                        "'" + jobID + "'," +
                        "'" + jobLVL + "'," +
                        "'" + pubID + "'," +
                        "' " + hireDate.ToString("MM-dd-yyyy") + "')";
                connection.Open();
                SqlCommand cmd = new SqlCommand(QueryAgregar, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                return null;

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public DataTable EmployeeFilter(string filter)
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("empFilt", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", filter);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
                connection.Close();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public string DeleteEmployee(string emp_id)
        {
            try
            {
                string QueryDelete = "delete from employee where emp_id = '" + emp_id + "'";

                connection.Open();
                SqlCommand cmd = new SqlCommand(QueryDelete, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                return null;

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        #endregion
        #region TITLES MANAGE
        public DataTable RefreshTitles()
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                string view = "SELECT * FROM titleView_admin";
                SqlCommand cmd = new SqlCommand(view, connection);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
                connection.Close();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable TitleFilter(string filter)
        {
            DataTable dt = new DataTable();
            try
            {

                connection.Open();

                SqlCommand cmd = new SqlCommand("titleFilter", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Title", filter);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                }

                connection.Close();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public string ModifyTitle(string title_id, string titleName, string type, string pubID, double price, double advance, int royal, int ytdSales, string notes, DateTime pubDate)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("ModifyTitle", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@titleID", title_id);
                cmd.Parameters.AddWithValue("@titleName", titleName);
                cmd.Parameters.AddWithValue("@Type", type);
                cmd.Parameters.AddWithValue("@P_ID", pubID);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Advance", advance);
                cmd.Parameters.AddWithValue("@Royal", royal);
                cmd.Parameters.AddWithValue("@LastYearSales", ytdSales);
                cmd.Parameters.AddWithValue("@Notes", notes);
                cmd.Parameters.AddWithValue("@PubDate", pubDate);
                cmd.ExecuteNonQuery();

                connection.Close();

                return null;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string addTitle(string title_id, string titleName, string type, string pubID, double price, double advance, int royal, int ytdSales, string notes, DateTime pubDate)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("addTitle", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@titleID", title_id);
                cmd.Parameters.AddWithValue("@titleName", titleName);
                cmd.Parameters.AddWithValue("@Type", type);
                cmd.Parameters.AddWithValue("@P_ID", pubID);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Advance", advance);
                cmd.Parameters.AddWithValue("@Royal", royal);
                cmd.Parameters.AddWithValue("@LastYearSales", ytdSales);
                cmd.Parameters.AddWithValue("@Notes", notes);
                cmd.Parameters.AddWithValue("@PubDate", pubDate);
                cmd.ExecuteNonQuery();

                connection.Close();

                return null;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string DeleteTitle(string title_id)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("DeleteTitle", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@titleID", title_id);
                cmd.ExecuteNonQuery();

                SqlParameter paramError = new SqlParameter("@Error", SqlDbType.VarChar, 100);
                paramError.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(paramError);

                cmd.ExecuteNonQuery();

                connection.Close();

                return paramError.Value.ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        #endregion
        #region titleAuthor manage
        public string addTitleAuthor(string auID, string titleID, int auOR, int royalP)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("addTitleAuthor", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@auID", auID);
                cmd.Parameters.AddWithValue("@titleID", titleID);
                cmd.Parameters.AddWithValue("@auOR", auOR);
                cmd.Parameters.AddWithValue("@RoyalP", royalP);
                cmd.ExecuteNonQuery();

                connection.Close();

                return null;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public DataTable RefreshTA()
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                string view = "SELECT * FROM titleAuthorView";
                SqlCommand cmd = new SqlCommand(view, connection);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
                connection.Close();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public string modifyTitleAuthor(string auID, string titleID, int auOR, int royalP)
        {
            try
            {
                string QueryAgregar = "update titleauthor" +
                        " set au_id ='" + auID + "'," +
                        "title_id = '" + titleID + "'," +
                        "au_ord = '" + auOR + "'," +
                        "royaltyper = '" + royalP + "'" +
                        "where au_id = '" + auID + "'";
                connection.Open();
                SqlCommand cmd = new SqlCommand(QueryAgregar, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                return null;

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string DeleteTitleAuthor(string title_id)
        {
            try
            {
                string QueryAgregar = "delete from titleauthor where title_id = '" + title_id + "'";

                connection.Open();
                SqlCommand cmd = new SqlCommand(QueryAgregar, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                return null;

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public DataTable FilterTitleAuthor(string TitleID)
        {
            DataTable dt = new DataTable();
            try
            {

                connection.Open();

                SqlCommand cmd = new SqlCommand("titleAuthorFilter", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@titleID", TitleID);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                }

                connection.Close();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion
        #region client
        public DataTable RefreshClient()
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                string view = "SELECT * FROM dbo.StockStores";
                SqlCommand cmd = new SqlCommand(view, connection);
                
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
                connection.Close();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable SearchStock(string filter)
        {
            DataTable dt = new DataTable();
            try
            {
                
                connection.Open();

                SqlCommand cmd = new SqlCommand("searchStock", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@title", filter);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                }

                connection.Close();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public string author()
        {
            try
            {
                connection.Open();
                string au = "select dbo.fnAuthor()";
                SqlCommand cmd = new SqlCommand(au, connection);
                cmd.ExecuteNonQuery();
                var result = cmd.ExecuteScalar();
                connection.Close();
                return result.ToString();
            }
            catch(Exception e)
            {
                return e.ToString();
            }
        }
        public string store()
        {
            try
            {
                string str = "select dbo.storeInfo()";
                connection.Open();
                SqlCommand cmd = new SqlCommand(str, connection);
                cmd.ExecuteNonQuery();
                var result = cmd.ExecuteScalar();
                connection.Close();
                return result.ToString();
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
        public string title()
        {
            try
            {
                string str = "select dbo.fnTitleAuthor()";
                connection.Open();
                SqlCommand cmd = new SqlCommand(str, connection);
                cmd.ExecuteNonQuery();
                var result = cmd.ExecuteScalar();
                connection.Close();
                return result.ToString();
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
        #endregion
    }
}
