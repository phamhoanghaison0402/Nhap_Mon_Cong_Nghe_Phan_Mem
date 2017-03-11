using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QLHS_THPT.Bussiness;


namespace QLHS_THPT.DataLayer
{
    public class NamHocDAL : ConnectData
    {
        DataService m_NamHocData = new DataService();
        /// <summary>
        /// Lấy list năm học
        /// </summary>
        /// <returns>List: NamHocDTO</returns>
        public List<NamHocDTO> LayList_NamHoc()
        {
            string sql = "SELECT MaNamHoc, TenNamHoc FROM NAMHOC";
            var listNamHoc = new List<NamHocDTO>();
            NamHocDTO namHoc;

            OpenConnect();
            SqlDataReader dr = ExecuteReader(sql);
            while (dr.Read())
            {
                namHoc = new NamHocDTO(Convert.ToString(dr["MaNamHoc"]),
                                       Convert.ToString(dr["TenNamHoc"]));
                listNamHoc.Add(namHoc);
            }
            CloseConnect();

            return listNamHoc;
        }

        /// <summary>
        /// Lấy DataTable năm học
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable LayDT_NamHoc()
        {
            SqlCommand cmd = new SqlCommand("SELECT MaNamHoc, TenNamHoc FROM NAMHOC");
            m_NamHocData.Load(cmd);
            return m_NamHocData;
        }

        public DataTable LayDsNamHoc()
        {
            string sql = string.Format("SELECT DISTINCT NH.MaNamHoc, NH.TenNamHoc  FROM NAMHOC NH, HOCKY HK WHERE NH.MaNamHoc = HK.MaNamHoc");   
            return GetTable(sql);
        }
        /// <summary>
        /// Lấy DataTable năm học có mã năm học là tham  số truyền vào
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable LayDT_NamHoc(string maNamHoc)
        {
            string sql = string.Format("SELECT MaNamHoc, TenNamHoc FROM NAMHOC WHERE MaNamHoc='{0}'", maNamHoc);
            return GetTable(sql);
        }

        /// <summary>
        /// Lấy DataTable năm học làm năm hiện tại=năm học mới
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable LayDTNamHocHienTai()
        {
            string sql =
                "SELECT MaNamHoc,TenNamHoc FROM NAMHOC WHERE MaNamHoc in (select GiaTri from QUYDINH where Khoa='MaNamHocHT') ";
            return GetTable(sql);
        }

        /// <summary>
        /// Lấy DataTable năm học cần chuyển lên lớp khi kết thúc năm học
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable LayDT_NamHocTruoc()
        {
            string sql =
                "SELECT MaNamHoc,TenNamHoc FROM NAMHOC WHERE substring(TenNamHoc,8,4) = (select substring(TenNamHoc,1,4) as TenNamHoc from NAMHOC WHERE MaNamHoc in (select GiaTri from QUYDINH where Khoa='MaNamHocHT')) ";
            return GetTable(sql);
        }


        public int KiemTra(String maNamHoc)
        {
            string sql = "SELECT * FROM NAMHOC WHERE MaNamHoc = '" + maNamHoc + "'";
            SqlCommand cmd = new SqlCommand();
           
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            SqlDataReader dr = ExecuteReader(sql);
            //SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return 1;
            }
            else
            {
                // chưa có
                return 0;
            }
        }
        /// <summary>
        /// Kiểm tra tồn tại 1 năm học
        /// </summary>
        /// <param name="maNamHoc">string: mã năm học</param>
        /// <returns></returns>
        public bool KiemTraTonTai_MaNamHoc(string maNamHoc)
        {
            string sql = "SELECT * FROM NAMHOC WHERE MaNamHoc = '" + maNamHoc + "'";
            return GetTable(sql).Rows.Count > 0;
        }

       
        /// <summary>
        /// Thêm 1 năm học mới (không kiểm tra trùng mã năm học cũ)
        /// </summary>
        /// <param name="namHoc">NamHocDTO</param>
        /// <returns></returns>
        /// 
        public bool LuuNamHoc()
        {
            return m_NamHocData.ExecuteNoneQuery() > 0;
        } 

        public bool Them_NamHoc(NamHocDTO namHoc)
        {

            string sql = "INSERT INTO NAMHOC (MaNamHoc,TenNamHoc) VALUES ('" + namHoc.MaNamHoc + "','" +
                         namHoc.TenNamHoc + "')";
            return ExecuteQuery(sql) > 0;

           
           
        }

        /// <summary>
        /// Xóa 1 năm học (xóa toàn bộ thông tin liên quan đến năm học đó)
        /// </summary>
        /// <param name="maNamHoc">string: mã năm học</param>
        /// <returns></returns>
        public bool Xoa_NamHoc(string maNamHoc)
        {
            var lopDAL = new LopDAL();
            lopDAL.Xoa_HoSo_Lop_Nam(maNamHoc);
            string sql = "DELETE FROM KHOILOP WHERE MaNamHoc = '" + maNamHoc + "'";
            return ExecuteQuery("DELETE FROM NAMHOC WHERE MaNamHoc = '" + maNamHoc + "'") > 0;
        }

        /// <summary>
        /// Lấy tên năm học
        /// </summary>
        /// <param name="maNamHoc">String: Mã năm học</param>
        /// <returns></returns>
        public string LayTenNamHoc(string maNamHoc)
        {
            return Convert.ToString(ExecuteScalar("SELECT TenNamHoc FROM NAMHOC WHERE MaNamHoc = '" + maNamHoc + "'"));
        }

       
    }
}