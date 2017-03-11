using System;
using System.Data;
using System.Data.SqlClient;

namespace QLHS_THPT.DataLayer
{
    public class KhoiLopData
    {
        DataService m_KhoiLopData = new DataService();

        public DataTable LayDsKhoiLop()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KHOILOP");
            m_KhoiLopData.Load(cmd);
            return m_KhoiLopData;
        }

        public DataTable LayDsKhoiLop1()
        {
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT TenKhoiLop FROM KHOILOP");
            m_KhoiLopData.Load(cmd);
            return m_KhoiLopData;
        }

        //Mới
        public DataTable LayDsKhoi_Lop(String namHoc)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KHOILOP KL, NAMHOC NH WHERE KL.MaNamHoc = NH.MaNamHoc AND KL.MaNamHoc = @namHoc");
            cmd.Parameters.Add("namHoc", SqlDbType.VarChar).Value = namHoc;

            m_KhoiLopData.Load(cmd);
            return m_KhoiLopData;
        }

        public DataTable LayDsKyHieu(String khoiLop)
        {
            SqlCommand cmd = new SqlCommand("SELECT KyHieu, MaKhoiLop, TenKhoiLop FROM KHOILOP WHERE MaKhoiLop = @khoiLop");
           
            cmd.Parameters.Add("khoiLop", SqlDbType.VarChar).Value = khoiLop;

            m_KhoiLopData.Load(cmd);
            return m_KhoiLopData;
        }

        public DataTable LayDsKhoiLop(String khoiLopCu)
        {
            SqlCommand cmd = new SqlCommand();
            String sql = "SELECT * FROM KHOILOP WHERE MaKhoiLop = @khoiLopCu ";
            cmd.Parameters.Add("khoiLopCu", SqlDbType.VarChar).Value = khoiLopCu;
            
            if (khoiLopCu == "KHOI10")
                sql += "OR MaKhoiLop = 'KHOI11'";
            
            else if (khoiLopCu == "KHOI11")
                sql += "OR MaKhoiLop = 'KHOI12'";

            cmd.CommandText = sql;

            m_KhoiLopData.Load(cmd);
            return m_KhoiLopData;
        }

        public DataRow ThemDongMoi()
        {
            return m_KhoiLopData.NewRow();
        }

        public void ThemKhoiLop(DataRow m_Row)
        {
            m_KhoiLopData.Rows.Add(m_Row);
        }

        public bool LuuKhoiLop()
        {
            return m_KhoiLopData.ExecuteNoneQuery() > 0;
        }
    }
}
