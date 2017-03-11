using System;
using System.Data;
using System.Data.SqlClient;
using QLHS_THPT.Bussiness;
using System.Collections.Generic;

namespace QLHS_THPT.DataLayer
{
    public class NamHocData 
    {
        DataService m_NamHocData = new DataService();

        public DataTable LayDsNamHoc()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NAMHOC");
            m_NamHocData.Load(cmd);
            return m_NamHocData;
        }

        public DataRow ThemDongMoi()
        {
            return m_NamHocData.NewRow();
        }

        public void ThemNamHoc(DataRow m_Row)
        {
            m_NamHocData.Rows.Add(m_Row);
        }

        public void LuuNamHocMoi(String maNamHoc, String tenNamHoc)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO NAMHOC VALUES(@maNamHoc, @tenNamHoc)");
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
            cmd.Parameters.Add("tenNamHoc", SqlDbType.NVarChar).Value = tenNamHoc;
           
            m_NamHocData.Load(cmd);
        }

        public bool KiemTraTonTai_MaNamHoc(String maNamHoc)
        {
            //DataService dS = new DataService();
            //string sql = "SELECT * FROM NAMHOC WHERE MaNamHoc = '" + maNamHoc + "'";
            //SqlCommand cmd = new SqlCommand("SELECT MaNamHoc FROM NAMHOC WHERE MaNamHoc = @maNamHoc");

            SqlCommand cmd = new SqlCommand("SELECT TenNamHoc FROM NAMHOC WHERE TenNamHoc = @maNamHoc AND TenNamHoc in (select TenNamHoc from NAMHOC)");
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
            m_NamHocData.Load(cmd);
            return true;
        }

        public bool kiemtratontai(String maNamHoc)
        {
            bool tatkt = false;
            String maso = maNamHoc;
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings[1].ConnectionString);
            SqlCommand cmd = new SqlCommand("Select * from NAMHOC", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (maso == dr.GetString(0))
                {
                    tatkt = true;
                    break;
                }
            }
            con.Close();
            return tatkt;
        }  
        

        public bool LuuNamHoc()
        {
            return m_NamHocData.ExecuteNoneQuery() > 0;
        }
    }
}
