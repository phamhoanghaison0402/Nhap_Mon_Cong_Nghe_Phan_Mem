using System;
using System.Data;
using System.Data.SqlClient;

namespace QLHS_THPT.DataLayer
{
    public class MonHocData
    {
        DataService m_MonHocData = new DataService();

        public DataTable LayDsMonHoc()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM MONHOC");
            m_MonHocData.Load(cmd);
            return m_MonHocData;
        }

        public DataTable LayDsMonHoc(String namHoc, String lop)
        {
            SqlCommand cmd = new SqlCommand("SELECT MH.MaMonHoc, MH.TenMonHoc FROM CHUONGTRINHHOC CTH, LOP L, MONHOC MH WHERE CTH.MaLop = L.MaLop AND CTH.MaMonHoc = MH.MaMonHoc AND L.MaNamHoc = @namHoc AND L.MaLop = @lop");
            cmd.Parameters.Add("namHoc", SqlDbType.VarChar).Value   = namHoc;
            cmd.Parameters.Add("lop", SqlDbType.VarChar).Value      = lop;
            
            m_MonHocData.Load(cmd);
            return m_MonHocData;
        }

        public DataTable LayDsMonHocChuaHoc(String namHoc, String lop)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM MONHOC where MaMonHoc not in (SELECT MH.MaMonHoc FROM CHUONGTRINHHOC CTH, LOP L, MONHOC MH WHERE CTH.MaLop = L.MaLop AND CTH.MaMonHoc = MH.MaMonHoc AND L.MaNamHoc = @namHoc AND L.MaLop = @lop)");
            cmd.Parameters.Add("namHoc", SqlDbType.VarChar).Value = namHoc;
            cmd.Parameters.Add("lop", SqlDbType.VarChar).Value = lop;

            m_MonHocData.Load(cmd);
            return m_MonHocData;
        }

        //Mới
        public DataTable LayDsMonHoc1(String namHoc, String lop, String hocKy)
        {
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT Mh.MaMonHoc, MH.TenMonHoc, CTH.MaLop, HK.MaNamHoc, QTH.MaHocKy FROM LOP L, QUATRINHHOC QTH, HOCKY HK, CHUONGTRINHHOC CTH, MONHOC MH WHERE L.MaLop = QTH.MaLop AND QTH.MaHocKy = HK.MaHocKy AND HK.MaHocKy = QTH.MaHocKy AND CTH.MaLop = L.MaLop AND CTH.MaMonHoc = MH.MaMonHoc AND HK.MaNamHoc = @namHoc AND QTH.MaHocKy = @hocKy AND CTH.MaLop = @lop");
            cmd.Parameters.Add("lop", SqlDbType.VarChar).Value = lop;
            cmd.Parameters.Add("namHoc", SqlDbType.VarChar).Value = namHoc;
            cmd.Parameters.Add("hocKy", SqlDbType.VarChar).Value = hocKy;

            m_MonHocData.Load(cmd);
            return m_MonHocData;
        }

        public DataRow ThemDongMoi()
        {
            return m_MonHocData.NewRow();
        }

        public void ThemMonHoc(DataRow m_Row)
        {
            m_MonHocData.Rows.Add(m_Row);
        }

        public bool LuuMonHoc()
        {
            return m_MonHocData.ExecuteNoneQuery() > 0;
        }
    }
}
