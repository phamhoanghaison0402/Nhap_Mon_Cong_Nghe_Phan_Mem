using System;
using System.Data;
using System.Data.SqlClient;

namespace QLHS_THPT.DataLayer
{
    public class ChuongTrinhHocData
    {
        DataService m_ChuongTrinhHocData = new DataService();

        public DataTable LayDsChuongTrinhHoc()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM CHUONGTRINHHOC");
            m_ChuongTrinhHocData.Load(cmd);
            return m_ChuongTrinhHocData;
        }

        public DataTable LayDsChuongTrinhHoc(String namHoc, String lop)
        {
            SqlCommand cmd = new SqlCommand("SELECT CTH.MaMonHoc, CTH.SoTiet , CTH.HeSo FROM CHUONGTRINHHOC CTH, LOP L, MONHOC MH WHERE CTH.MaLop = L.MaLop AND CTH.MaMonHoc = MH.MaMonHoc AND L.MaNamHoc = @namHoc AND CTH.MaLop = @lop");
            cmd.Parameters.Add("namHoc", SqlDbType.VarChar).Value   = namHoc;
            cmd.Parameters.Add("lop", SqlDbType.VarChar).Value      = lop;

            m_ChuongTrinhHocData.Load(cmd);
            return m_ChuongTrinhHocData;
        }

        public DataTable LayDsChuongTrinhHoc_HeSo_SoTiet(String maLop, String maMonHoc)
        {
            SqlCommand cmd = new SqlCommand("SELECT CTH.MaMonHoc, CTH.SoTiet, CTH.HeSo FROM CHUONGTRINHHOC CTH WHERE CTH.MaMonHoc = @maMonHoc AND CTH.MaLop = @maLop");
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;

           

            m_ChuongTrinhHocData.Load(cmd);
            return m_ChuongTrinhHocData;
        }

        public DataRow ThemDongMoi()
        {
            return m_ChuongTrinhHocData.NewRow();
        }

        public void ThemMonHoc(DataRow m_Row)
        {
            m_ChuongTrinhHocData.Rows.Add(m_Row);
        }

        public bool LuuMonHoc()
        {
            return m_ChuongTrinhHocData.ExecuteNoneQuery() > 0;
        }

        public void LuuChuongTrinhHoc(String maLop, String maMonHoc, int heSo, int soTiet)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO CHUONGTRINHHOC VALUES(@maLop, @maMonHoc, @heSo, @soTiet)");
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maMonHoc", SqlDbType.NVarChar).Value = maMonHoc;
            cmd.Parameters.Add("heSo", SqlDbType.Int).Value = heSo;
            cmd.Parameters.Add("soTiet", SqlDbType.Int).Value = soTiet;
          
            m_ChuongTrinhHocData.Load(cmd);
        }

        public void CapNhatChuongTrinhHoc(String maLop, String maMonHoc,  int heSo, int soTiet)
        {
            SqlCommand cmd = new SqlCommand("UPDATE CHUONGTRINHHOC SET SoTiet = @soTiet, HeSo = @heSo where MaLop = @maLop AND MaMonHoc = @maMonHoc");
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maMonHoc", SqlDbType.NVarChar).Value = maMonHoc;
            cmd.Parameters.Add("heSo", SqlDbType.Int).Value = heSo;
            cmd.Parameters.Add("soTiet", SqlDbType.Int).Value = soTiet;

            m_ChuongTrinhHocData.Load(cmd);
        }

        public void XoaMonHoc_ChuongTrinhHoc(String maLop, String maMonHoc)
        {
            SqlCommand cmd1 = new SqlCommand("DELETE FROM CT_BAOCAOTONGKETMON WHERE MaMonHoc = @maMonHoc");
            SqlCommand cmd2 = new SqlCommand("DELETE FROM BAOCAOTONGKETMON WHERE MaMonHoc = @maMonHoc");
            SqlCommand cmd3 = new SqlCommand("DELETE FROM BANGDIEM WHERE MaMonHoc = @maMonHoc");
            SqlCommand cmd = new SqlCommand("DELETE FROM CHUONGTRINHHOC WHERE MaLop = @maLop AND MaMonHoc = @maMonHoc");
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maMonHoc", SqlDbType.NVarChar).Value = maMonHoc;
            cmd1.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
            cmd2.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
            cmd3.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;

            m_ChuongTrinhHocData.Load(cmd1);
            m_ChuongTrinhHocData.Load(cmd2);
            m_ChuongTrinhHocData.Load(cmd3);
            m_ChuongTrinhHocData.Load(cmd);
        }
    }
}
