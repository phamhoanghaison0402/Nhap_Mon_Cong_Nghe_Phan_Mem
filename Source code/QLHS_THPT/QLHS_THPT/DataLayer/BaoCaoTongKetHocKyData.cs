using System;
using System.Data;
using System.Data.SqlClient;

namespace QLHS_THPT.DataLayer
{
    public class BaoCaoTongKetHocKyData
    {
        DataService m_BaoCaoTongKetHocKyData = new DataService();
        DataService HK1 = new DataService();
        DataService HK2 = new DataService();

        public void LuuKetQua(String maQuaTrinhHoc, float diemTBChungCacMonHK)
        {
            DataService m_KQHKTHData = new DataService();

            SqlCommand cmd = new SqlCommand("INSERT INTO BAOCAOTONGKETHOCKY VALUES(@maQuaTrinhHoc, @diemTBChungCacMonHK)");
            cmd.Parameters.Add("maQuaTrinhHoc", SqlDbType.VarChar).Value = maQuaTrinhHoc;
            cmd.Parameters.Add("diemTBChungCacMonHK", SqlDbType.Float).Value = Math.Round(diemTBChungCacMonHK, 2);

            m_KQHKTHData.Load(cmd);
        }

        public void XoaKetQua(String maQuaTrinhHoc)
        {
            DataService m_KQHKTHData = new DataService();

            SqlCommand cmd = new SqlCommand("DELETE FROM BAOCAOTONGKETHOCKY WHERE MaQuaTrinhHoc = @maQuaTrinhHoc");
            cmd.Parameters.Add("maQuaTrinhHoc", SqlDbType.VarChar).Value = maQuaTrinhHoc;
           
            m_KQHKTHData.Load(cmd);
        }

        public void LuuKetQua1(String hocKy, String lop,  int soLuongdat)
        {
            DataService m_BCTKMData = new DataService();

            SqlCommand cmd = new SqlCommand("INSERT INTO CT_BAOCAOTONGKETHOCKY VALUES(@hocKy, @lop,  @soLuongdat)");
            cmd.Parameters.Add("hocKy", SqlDbType.VarChar).Value = hocKy;
            cmd.Parameters.Add("lop", SqlDbType.VarChar).Value = lop;
           
            cmd.Parameters.Add("soLuongdat", SqlDbType.Float).Value = soLuongdat;

            m_BCTKMData.Load(cmd);
        }

        public void XoaKetQua1(String hocKy, String lop)
        {
            DataService m_KQHKTHData = new DataService();

            SqlCommand cmd = new SqlCommand("DELETE FROM CT_BAOCAOTONGKETHOCKY WHERE MaHocKy = @hocKy AND MaLop = @lop");
            cmd.Parameters.Add("hocKy", SqlDbType.VarChar).Value = hocKy;
            cmd.Parameters.Add("lop", SqlDbType.VarChar).Value = lop;
            m_KQHKTHData.Load(cmd);
        }

        public int LaySoLuongDat(String hocKy, String lop)
        {
            float diemDat = LayDiemDat();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(DiemTBHocKy) FROM BAOCAOTONGKETHOCKY BCTKHK, QUATRINHHOC QTH WHERE BCTKHK.MaQuaTrinhHoc = QTH.MaQuaTrinhHoc AND QTH.MaHocKy = @hocKy AND QTH.MaLop = @lop AND DiemTBHocKy >= @diemDat");
            cmd.Parameters.Add("hocKy", SqlDbType.NVarChar).Value = hocKy;
            cmd.Parameters.Add("lop", SqlDbType.VarChar).Value = lop;
            cmd.Parameters.Add("diemDat", SqlDbType.Float).Value = diemDat;
            int sl = (int)m_BaoCaoTongKetHocKyData.ExecuteScalar(cmd);
            return sl;
        }

        private float LayDiemDat()
        {
            SqlCommand cmd = new SqlCommand("SELECT GiaTri FROM THAMSO where TenThamSo = 'DiemDat'");
            float sl = float.Parse(m_BaoCaoTongKetHocKyData.ExecuteScalar(cmd).ToString());
            return sl;
        }

        public DataTable LayDTB_HK1(String MaLop)
        {
            HK1.Clear();
            SqlCommand cmd = new SqlCommand("SELECT DiemTBHocKy, MaHocSinh FROM BAOCAOTONGKETHOCKY BCTKHK, QUATRINHHOC QTH WHERE BCTKHK.MaQuaTrinhHoc = QTH.MaQuaTrinhHoc AND  HocKy = 1 and MaLop = @MaLop ");
            cmd.Parameters.Add("MaLop", SqlDbType.VarChar).Value = MaLop;
            HK1.Load(cmd);
            return HK1;
        }
        public DataTable LayDTB_HK2(String TenMon, String MaLop)
        {
            HK2.Clear();
            SqlCommand cmd = new SqlCommand("SELECT TrungBinh, Mahs FROM CTDIEM WHERE TenMon = @TenMon and HocKy = 2 and MaLop = @MaLop");
            cmd.Parameters.Add("TenMon", SqlDbType.NVarChar).Value = TenMon;
            cmd.Parameters.Add("MaLop", SqlDbType.VarChar).Value = MaLop;
            HK2.Load(cmd);
            return HK2;
        }
    }
}
