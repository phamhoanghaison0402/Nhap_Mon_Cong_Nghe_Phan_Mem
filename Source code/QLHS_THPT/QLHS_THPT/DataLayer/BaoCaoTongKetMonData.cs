using System;
using System.Data;
using System.Data.SqlClient;

namespace QLHS_THPT.DataLayer
{
    public class BaoCaoTongKetMonData
    {
        DataService m_BaoCaoTongKetMonData = new DataService();

        public void LuuKetQua(String maQuaTrinhHoc, String maMonHoc, float diemTrungBinhMon)
        {
            DataService m_BCTKMData = new DataService();

            SqlCommand cmd = new SqlCommand("INSERT INTO BAOCAOTONGKETMON VALUES(@maQuaTrinhHoc, @maMonHoc, @diemTrungBinhMon)");
            cmd.Parameters.Add("maQuaTrinhHoc", SqlDbType.VarChar).Value = maQuaTrinhHoc;           
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
            cmd.Parameters.Add("diemTrungBinhMon", SqlDbType.Float).Value = Math.Round(diemTrungBinhMon, 2) ;

            m_BCTKMData.Load(cmd);
        }

        public void LuuKetQua1(String hocKy, String lop, String monHoc, int soLuongdat)
        {
            DataService m_BCTKMData = new DataService();

            SqlCommand cmd = new SqlCommand("INSERT INTO CT_BAOCAOTONGKETMON VALUES(@hocKy, @lop,  @monHoc, @soLuongdat)");
            cmd.Parameters.Add("hocKy", SqlDbType.VarChar).Value = hocKy;
            cmd.Parameters.Add("lop", SqlDbType.VarChar).Value = lop;
            cmd.Parameters.Add("monHoc", SqlDbType.VarChar).Value = monHoc;
            cmd.Parameters.Add("soLuongdat", SqlDbType.Float).Value = soLuongdat;

            m_BCTKMData.Load(cmd);
        }

        public void LuuKetQuaSD(String maQuaTrinhHoc, String maMonHoc, float diemTrungBinhMon)
        {
            DataService m_BCTKMData = new DataService();

            SqlCommand cmd = new SqlCommand("UPDATE BAOCAOTONGKETMON SET DiemTrungBinhMon = @diemTrungBinhMon WHERE MaQuaTrinhHoc = @maQuaTrinhHoc AND MaMonHoc = @maMonHoc");
            cmd.Parameters.Add("maQuaTrinhHoc", SqlDbType.VarChar).Value = maQuaTrinhHoc;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
            cmd.Parameters.Add("diemTrungBinhMon", SqlDbType.Float).Value = Math.Round(diemTrungBinhMon, 2);

            m_BCTKMData.Load(cmd);
        }

        public void XoaKetQua(String maQuaTrinhHoc, String maMonHoc)
        {
            DataService m_KQHKMHData = new DataService();

            SqlCommand cmd = new SqlCommand("DELETE FROM BAOCAOTONGKETMON WHERE MaQuaTrinhHoc = @maQuaTrinhHoc AND MaMonHoc = @maMonHoc");
            cmd.Parameters.Add("maQuaTrinhHoc", SqlDbType.VarChar).Value = maQuaTrinhHoc;
          
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
        

            m_KQHKMHData.Load(cmd);
        }


        public void XoaKetQua1(String hocKy, String lop, String monHoc)
        {
            DataService m_KQHKTHData = new DataService();

            SqlCommand cmd = new SqlCommand("DELETE FROM CT_BAOCAOTONGKETMON WHERE MaHocKy = @hocKy AND MaLop = @lop AND MaMonHoc = @monHoc");
            cmd.Parameters.Add("hocKy", SqlDbType.VarChar).Value = hocKy;
            cmd.Parameters.Add("lop", SqlDbType.VarChar).Value = lop;
            cmd.Parameters.Add("monHoc", SqlDbType.VarChar).Value = monHoc;

            m_KQHKTHData.Load(cmd);
        }

        public DataTable LayDsDiemTrungBinhMon()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM BAOCAOTONGKETMON");
            m_BaoCaoTongKetMonData.Load(cmd);
            return m_BaoCaoTongKetMonData;
        }
        public int LaySoLuongDat(String hocKy, String lop, String monHoc)
        {
            float diemDatMon = LayDiemDat();
        
            SqlCommand cmd = new SqlCommand("SELECT COUNT(DiemTrungBinhMon) FROM BAOCAOTONGKETMON BCTKM, QUATRINHHOC QTH WHERE BCTKM.MaQuaTrinhHoc = QTH.MaQuaTrinhHoc AND QTH.MaHocKy = @hocKy AND QTH.MaLop = @lop AND BCTKM.MaMonHoc = @monHoc AND DiemTrungBinhMon >= @diemDatMon");
            cmd.Parameters.Add("hocKy", SqlDbType.NVarChar).Value = hocKy;
            cmd.Parameters.Add("lop", SqlDbType.VarChar).Value = lop;
            cmd.Parameters.Add("monHoc", SqlDbType.VarChar).Value = monHoc;
            cmd.Parameters.Add("diemDatMon", SqlDbType.Float).Value = diemDatMon;
            int sl = (int)m_BaoCaoTongKetMonData.ExecuteScalar(cmd);
            return sl;
        }

        private float LayDiemDat()
        {
          
            SqlCommand cmd = new SqlCommand("SELECT GiaTri FROM THAMSO where TenThamSo = 'DiemDatMon'");
            float sl = float.Parse(m_BaoCaoTongKetMonData.ExecuteScalar(cmd).ToString());
            
            return sl;
        }

    }
}
