using System;
using System.Xml;
using System.Data;
using System.Data.SqlClient;
using DevComponents.DotNetBar;
using QLHS_THPT.Component;


namespace QLHS_THPT.DataLayer
{
    public class ConnectData
    {
        #region Fields
        private static SqlConnection m_Connection;
        public static String m_ConnectString = "";
        private SqlCommand m_Command;
        private SqlDataAdapter m_DataAdapter;
        private SqlDataAdapter _mDataApdater;
        private DataTable _mTable;
        private string _strConnect = "";
        #endregion

        #region Constructor
        public ConnectData()
        {

        }
        #endregion

        #region Hàm lấy lệnh connection
        public static void ConnectionString()
        {
            XmlDocument xmlDoc = XML.XMLReader("Connection.xml");
            XmlElement xmlEle = xmlDoc.DocumentElement;

            try
            {
                if (xmlEle.SelectSingleNode("costatus").InnerText == "true")
                {
                    m_ConnectString = "Data Source=" + xmlEle.SelectSingleNode("servname").InnerText + ";Initial Catalog=" + xmlEle.SelectSingleNode("database").InnerText + ";Integrated Security=True;";
                }
                else
                {
                    m_ConnectString = "Data Source=" + xmlEle.SelectSingleNode("servname").InnerText + ";Initial Catalog=" + xmlEle.SelectSingleNode("database").InnerText + ";User Id=" + xmlEle.SelectSingleNode("username").InnerText + ";Password=" + xmlEle.SelectSingleNode("password").InnerText + ";";
                }

                Utilities.DatabaseName = xmlEle.SelectSingleNode("database").InnerText;
            }
            catch
            {
                MessageBoxEx.Show("Lỗi kết nối đến cơ sở dữ liệu! Xin vui lòng thiết lập lại kết nối...", "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Load
        public void Load(SqlCommand m_Sql)
        {
            m_Command = m_Sql;
            try
            {
                m_Command.Connection = m_Connection;

                m_DataAdapter = new SqlDataAdapter();
                m_DataAdapter.SelectCommand = m_Command;

                //  this.Clear();
                //m_DataAdapter.Fill(this);
            }
            catch (Exception e)
            {
                MessageBoxEx.Show("Không thể thực thi câu lệnh SQL này!\nLỗi: " + e.Message, "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        #endregion

        #region OpenConnection
        public static bool OpenConnection()
        {
            if (m_ConnectString == "")
                ConnectionString();
            try
            {
                if (m_Connection == null)
                    m_Connection = new SqlConnection(m_ConnectString);
                if (m_Connection.State == ConnectionState.Closed)
                    m_Connection.Open();
                return true;
            }
            catch
            {
                m_Connection.Close();
                return false;
            }
        }
        #endregion

        #region CloseConnection
        public void CloseConnection()
        {
            m_Connection.Close();
        }
        #endregion

        private bool Connect()
        {
            try
            {
                m_Connection = new SqlConnection(_strConnect);
                OpenConnect();
                return true;
            }
            catch (SqlException ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.ErrorCode + ": " + ex.Message);
                return false;
            }
            finally
            {
                CloseConnect();
            }
        }

        /// <summary>
        /// Kiểm tra kết nối với Database
        /// </summary>
        /// <param name="strConnect">String: Chuỗi kết nối</param>
        /// <returns></returns>
        protected bool TestConnect(string strConnect = "")
        {
            if (strConnect != "")
                _strConnect = strConnect;
            return Connect();
        }


        /// <summary>
        /// Mở kết nối
        /// </summary>
        protected void OpenConnect()
        {
            try
            {
                if (m_Connection != null)
                    if (m_Connection.State == ConnectionState.Closed)
                        m_Connection.Open();
            }
            catch
            {
                return;
            }
        }

        /// <summary>
        /// Đóng kết nối
        /// </summary>
        protected void CloseConnect()
        {
            if (m_Connection != null)
                if (m_Connection.State == ConnectionState.Open)
                    m_Connection.Close();
        }

        protected DataTable GetTable(string sql, bool setPropertiesDataTable = false)
        {
            try
            {
                if (setPropertiesDataTable)
                {
                    // Tạo dataApdapter vai trò như 1 ống hút thực hiện query đổ vào Datatable
                    _mDataApdater = new SqlDataAdapter(sql, m_Connection);
                    _mTable = new DataTable();
                    // Đổ vào database
                    _mDataApdater.Fill(_mTable);
                    return _mTable;
                }
                var ap = new SqlDataAdapter(sql, m_Connection);
                var tb = new DataTable();
                ap.Fill(tb);
                return tb;

            }
            catch (SqlException ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.ErrorCode + ": " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Truy vấn lấy dòng đầu tiên
        /// </summary>
        /// <param name="sql">String: Chuỗi truy vấn</param>
        /// <returns>DataRow: Dòng đầu tiên của kết quả</returns>
        protected DataRow GetFirstDataRow(string sql)
        {
            return GetTable(sql).Rows[0];
        }

        /// <summary>
        /// Lấy 1 dòng mới ứng với DataTable (Bắt buột trên Datatable truy vấn lần trước phải set properties = TRUE)
        /// </summary>
        /// <returns>Datarow: Dòng mới với kiểu dữ liệu từ DataTable hiện tại</returns>
        protected DataRow GetNewRow()
        {
            return _mTable.NewRow();
        }

        /// <summary>
        /// Lưu 1 dòng mới vào DataTable (Bắt buột trên Datatable truy vấn lần trước phải set properties = TRUE)
        /// </summary>
        /// <param name="dr">Datarow: Dòng mới với kiểu dữ liệu từ DataTable hiện tại được tạo từ hàm GetNewRow()</param>
        protected void AddNewRow(DataRow dr)
        {
            _mTable.Rows.Add(dr);
        }

        #region Update DataTable
        public int ExecuteNoneQuery()
        {
            int result = 0;
            SqlTransaction m_SqlTran = null;
            try
            {
                m_SqlTran = m_Connection.BeginTransaction();

                m_Command.Connection = m_Connection;
                m_Command.Transaction = m_SqlTran;

                m_DataAdapter = new SqlDataAdapter();
                m_DataAdapter.SelectCommand = m_Command;

                SqlCommandBuilder builder = new SqlCommandBuilder(m_DataAdapter);

                //result = m_DataAdapter.Update(this);
                m_SqlTran.Commit();
            }
            catch
            {
                if (m_SqlTran != null)
                    m_SqlTran.Rollback();
                throw;
            }
            return result;
        }
        #endregion

        #region Thực thi câu lệnh SQL
        public int ExecuteNoneQuery(SqlCommand m_Sql)
        {
            int result = 0;
            SqlTransaction m_SqlTran = null;
            try
            {
                m_SqlTran = m_Connection.BeginTransaction();

                m_Sql.Connection = m_Connection;
                m_Sql.Transaction = m_SqlTran;
                result = m_Sql.ExecuteNonQuery();

                //  this.AcceptChanges();
                m_SqlTran.Commit();
            }
            catch
            {
                if (m_SqlTran != null)
                    m_SqlTran.Rollback();
                throw;
            }
            return result;
        }
        #endregion

        #region ExecuteScalar
        public object ExecuteScalar(SqlCommand m_Sql)
        {
            object result = null;
            SqlTransaction m_SqlTran = null;
            try
            {
                m_SqlTran = m_Connection.BeginTransaction();
                m_Sql.Connection = m_Connection;
                m_Sql.Transaction = m_SqlTran;
                result = m_Sql.ExecuteScalar();

                //  this.AcceptChanges();
                m_SqlTran.Commit();
                if (result == DBNull.Value)
                {
                    result = null;
                }
            }
            catch
            {
                if (m_SqlTran != null)
                    m_SqlTran.Rollback();
                throw;
            }
            return result;
        }

        protected object ExecuteScalar(string sql)
        {
            try
            {
                OpenConnection();
                m_Command = new SqlCommand(sql, m_Connection);
                return m_Command.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.ErrorCode + ": " + ex.Message);
                return null;
            }
            finally
            {
                CloseConnection();
            }
        }
        #endregion

        #region Đổi mật khẩu, thiết lập lại kết nối
        public void ChangePassword(String userName, String newPassword)
        {
            m_DataAdapter = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand("UPDATE NGUOIDUNG SET MatKhau = @matkhau WHERE TenDNhap = @tendangnhap");
            cmd.Parameters.Add("tendangnhap", SqlDbType.VarChar).Value = userName;
            cmd.Parameters.Add("matkhau", SqlDbType.VarChar).Value = newPassword;

            if (m_ConnectString == "")
                ConnectionString();

            if (m_Connection == null || m_Connection.State == ConnectionState.Closed)
            {
                m_Connection = new SqlConnection(m_ConnectString);
                m_Connection.Open();
            }

            m_Command = new SqlCommand();
            m_Command = cmd;

            try
            {
                m_Command.Connection = m_Connection;

                m_DataAdapter = new SqlDataAdapter();
                m_DataAdapter.SelectCommand = m_Command;

                //this.Clear();

                //  m_DataAdapter.Fill(this);

                SqlCommandBuilder buider = new SqlCommandBuilder(m_DataAdapter);
                //m_DataAdapter.Update(this);
            }
            catch (Exception e)
            {
                MessageBoxEx.Show("Không thể thực thi câu lệnh SQL này!\nLỗi: " + e.Message, "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        #endregion
        public static class ExceptionUtil
        {
            public static void Throw(string msg)
            {
                throw new Exception(msg);
            }

            public static void ThrowMsgBox(string msg)
            {

            }
        }

        protected SqlDataReader ExecuteReader(string sql)
        {
            try
            {
                var command = new SqlCommand(sql, m_Connection);
                return command.ExecuteReader();
            }
            catch (SqlException ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.ErrorCode + ": " + ex.Message);
                return null;
            }
        }

        protected int ExecuteQuery(string sql)
        {
            int numRecords = 0;
            SqlTransaction sqlTran = null;
            try
            {
                // Mở kết nối
                OpenConnection();
                // Mở Transaction
                sqlTran = m_Connection.BeginTransaction();
                var sqlComm = new SqlCommand(sql, m_Connection) { Transaction = sqlTran };
                numRecords = sqlComm.ExecuteNonQuery();
                // Thực thi
                sqlTran.Commit();
            }
            catch (SqlException ex)
            {
                // Roolback data
                if (sqlTran != null)
                    sqlTran.Rollback();
                ExceptionUtil.ThrowMsgBox(ex.ErrorCode + ": " + ex.Message);
            }
            finally
            {
                // Đóng kn
                CloseConnection();
            }
            // Trả về số record thực thi
            return numRecords;
        }

        /*   protected int ExecuteQuery(string sql)
           {
               int numRecords = 0;
               SqlTransaction sqlTran = null;
               try
               {
                   // Mở kết nối
                   OpenConnect();
                   // Mở Transaction
                   sqlTran = m_Connection.BeginTransaction();
                   var sqlComm = new SqlCommand(sql, m_Connection) { Transaction = sqlTran };
                   numRecords = sqlComm.ExecuteNonQuery();
                   // Thực thi
                   sqlTran.Commit();
               }
               catch (SqlException ex)
               {
                   // Roolback data
                   if (sqlTran != null)
                       sqlTran.Rollback();
                   ExceptionUtil.ThrowMsgBox(ex.ErrorCode + ": " + ex.Message);
               }
               finally
               {
                   // Đóng kn
                   CloseConnect();
               }
               // Trả về số record thực thi
               return numRecords;
           } */

        protected string GetLastID(string nameTable, string nameSelectColumn)
        {
            string sql = "SELECT TOP 1 * FROM " + nameTable + " ORDER BY " + nameSelectColumn + " DESC";
            return (string)ExecuteScalar(sql);
        }
    }
}