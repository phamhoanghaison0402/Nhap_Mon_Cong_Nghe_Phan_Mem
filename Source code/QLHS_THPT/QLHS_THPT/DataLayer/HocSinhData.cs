using System;
using System.Data;
using System.Data.SqlClient;

namespace QLHS_THPT.DataLayer
{
    public class HocSinhData
    {
        DataService m_HocSinhData = new DataService();

        public DataTable LayDsHocSinh()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOCSINH");
            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public DataTable LayDsHocSinhChuaPhanLop()
        {
            SqlCommand cmd = new SqlCommand("SELECT hs.MaHocSinh, hs.HoTen FROM HOCSINH hs where hs.MaHocSinh not in (SELECT QTH.MaHocSinh from QUATRINHHOC QTH)");
            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }
        //Cũ
        public DataTable LayDsHocSinhTheoLop(String namHoc, String lop)
        {
            SqlCommand cmd = new SqlCommand("SELECT PL.MaHocSinh, HS.HoTen " +
                                            "FROM HOCSINH HS INNER JOIN QUATRINHHOC QTH ON HS.MaHocSinh = QTH.MaHocSinh " +
                                            "INNER JOIN LOP L ON L.MaLop = QTH.MaLop " +
                                            "WHERE QTH.MaLop = @lop AND L.MaNamHoc = @namHoc");
            cmd.Parameters.Add("lop", SqlDbType.VarChar).Value = lop;
            cmd.Parameters.Add("namHoc", SqlDbType.VarChar).Value = namHoc;

            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public DataTable LayDsHocSinhTheoQTH(String namHoc, String lop, String hocKy)
        {
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT QTH.MaQuaTrinhHoc, QTH.MaHocSinh, HS.HoTen From LOAIHINHKIEMTRA LD, LOP L, QUATRINHHOC QTH, HOCKY HK, HOCSINH HS WHERE L.MaLop = QTH.MaLop AND QTH.MaHocKy = HK.MaHocKy AND QTH.MaHocSinh = HS.MaHocSinh AND HK.MaNamHoc = @namHoc AND QTH.MaHocKy = @hocKy AND L.MaLop = @lop");
            cmd.Parameters.Add("lop", SqlDbType.VarChar).Value = lop;
            cmd.Parameters.Add("namHoc", SqlDbType.VarChar).Value = namHoc;
            cmd.Parameters.Add("hocKy", SqlDbType.VarChar).Value = hocKy;
           

            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public DataTable LayDsHocSinhTheoQTH1(String namHoc, String lop, String hocKy, String maMonHoc)
        {
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT QTH.MaQuaTrinhHoc, QTH.MaHocSinh, HS.HoTen, BCTKM.DiemTrungBinhMon FROM BAOCAOTONGKETMON BCTKM, LOAIHINHKIEMTRA LD, LOP L, QUATRINHHOC QTH, HOCKY HK, HOCSINH HS WHERE BCTKM.MaQuaTrinhHoc = QTH.MaQuaTrinhHoc AND   L.MaLop = QTH.MaLop AND QTH.MaHocKy = HK.MaHocKy AND QTH.MaHocSinh = HS.MaHocSinh AND HK.MaNamHoc = @namHoc AND QTH.MaHocKy = @hocKy AND L.MaLop = @lop AND BCTKM.MaMonHoc = @maMonHoc");
            cmd.Parameters.Add("lop", SqlDbType.VarChar).Value      = lop;
            cmd.Parameters.Add("namHoc", SqlDbType.VarChar).Value   = namHoc;
            cmd.Parameters.Add("hocKy", SqlDbType.VarChar).Value = hocKy;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;

            m_HocSinhData.Load(cmd); 
            return m_HocSinhData;
        }

        public DataTable LayDsHocSinhTheoHocKy_Lop(String hocKy, String lop)
        {
            SqlCommand cmd = new SqlCommand("SELECT QTH.MaQuaTrinhHoc, QTH.MaHocSinh, HS.HoTen  FROM LOP L, HOCKY HK, HOCSINH HS, QUATRINHHOC QTH WHERE L.MaLop = QTH.MaLop AND QTH.MaHocKy = HK.MaHocKy AND QTH.MaHocSinh = HS.MaHocSinh AND L.MaLop = @lop AND QTH.MaHocKy = @hocKy");
            cmd.Parameters.Add("lop", SqlDbType.VarChar).Value = lop;
            cmd.Parameters.Add("hocKy", SqlDbType.VarChar).Value = hocKy;

            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public DataTable LayDsHocSinhTheoLop(String namHoc, String khoiLop, String lop)
        {
            SqlCommand cmd = new SqlCommand("SELECT QTH.MaHocSinh, HS.HoTen, L.TenLop " +
                                            "FROM HOCSINH HS INNER JOIN QUATRINHHOC QTH ON HS.MaHocSinh = QTH.MaHocSinh " +
                                            "INNER JOIN LOP L ON L.MaLop = QTH.MaLop " +
                                            "INNER JOIN KHOILOP KL ON KL.MaKhoiLop = L.MaKhoiLop " +
                                            "WHERE L.MaLop = @lop AND KL.MaNamHoc = @namHoc AND KL.MaKhoiLop = @khoiLop");
            cmd.Parameters.Add("lop", SqlDbType.VarChar).Value      = lop;
            cmd.Parameters.Add("namHoc", SqlDbType.VarChar).Value   = namHoc;
            cmd.Parameters.Add("khoiLop", SqlDbType.VarChar).Value  = khoiLop;

            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public DataTable LayDsHocSinhTheoNamHoc(String namHoc)
        {
            SqlCommand cmd = new SqlCommand("SELECT QTH.MaHocSinh, HS.HoTen, L.TenLop " +
                                            "FROM HOCSINH HS INNER JOIN QUATRINHHOC QTH ON HS.MaHocSinh = QTH.MaHocSinh " +
                                            "INNER JOIN LOP L ON L.MaLop = QTH.MaLop " +
                                            "INNER JOIN KHOILOP KL ON KL.MaKhoiLop = L.MaKhoiLop " +
                                            "WHERE KL.MaNamHoc = @namHoc");
            cmd.Parameters.Add("namHoc", SqlDbType.VarChar).Value = namHoc;

            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

     /*   public void LuuHSVaoBangPhanLop(String maNamHoc, String maKhoiLop, String maLop, String maHS)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO PHANLOP VALUES(@maNamHoc, @maKhoiLop, @maLop, @maHS)");
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
            cmd.Parameters.Add("maKhoiLop", SqlDbType.VarChar).Value = maKhoiLop;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maHS", SqlDbType.VarChar).Value = maHS;

            m_HocSinhData.Load(cmd);
        } */

        public void LuuHSVaoBangPhanLop(String maLop, String maHocKy, String maHocSinh)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO QUATRINHHOC VALUES(@maHocSinh, @maLop, @maHocKy)");
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;       
            cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value = maHocKy;

            m_HocSinhData.Load(cmd);
        }

        public void LuuHSVaoBangQuaTrinhHoc(String maHocKy, String maLop, String maHocSinh)
       {
           SqlCommand cmd = new SqlCommand("UPDATE QUATRINHHOC SET MaLop = @maLop where MaHocKy = @maHocKy AND MaHocSinh = @maHocSinh");

           cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value = maHocKy;
           cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
           cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;

           m_HocSinhData.Load(cmd);
       } 

           public DataTable LayDSHSChuaCoLop()
           {
               SqlCommand cmd = new SqlCommand("SELECT hs.MaHocSinh, hs.HoTen FROM HOCSINH hs where hs.MaHocSinh not in (SELECT QTH.MaHocSinh from QUATRINHHOC QTH)");
               m_HocSinhData.Rows.Clear();
               m_HocSinhData.Load(cmd);
               return m_HocSinhData;
           }

        public void XoaHSKhoiBangPhanLop(String maHocKy, String maLop, String maQuaTrinhHoc)
        {
            SqlCommand cmd = new SqlCommand("UPDATE  QUATRINHHOC SET MaHocKy = @maHocKy , MaLop = @maLop where MaQuaTrinhHoc = @maQuaTrinhHoc");

            cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value    = maHocKy;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value        = maLop;
            cmd.Parameters.Add("maQuaTrinhHoc", SqlDbType.VarChar).Value = maQuaTrinhHoc;

            m_HocSinhData.Load(cmd);
        }
        
        public DataTable LayDsHocSinhForReport()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NGHENGHIEP NNC, NGHENGHIEP NNM, HOCSINH HS, DANTOC DT, TONGIAO TG WHERE HS.MaNNghiepCha = NNC.MaNghe AND HS.MaNNghiepMe = NNM.MaNghe AND HS.MaDanToc = DT.MaDanToc AND HS.MaTonGiao = TG.MaTonGiao");
            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        //Mới
        public DataTable LayDsHocSinhForReport(String namHoc, String khoiLop, String lop)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOCSINH HS, QUATRINHHOC QTH, LOP L, HOCKY HK WHERE HS.MaHocSinh = QTH.MaHocSinh");
            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public DataRow ThemDongMoi()
        {
            return m_HocSinhData.NewRow();
        }

        public void ThemHocSinh(DataRow m_Row)
        {
            m_HocSinhData.Rows.Add(m_Row);
        }

        public bool LuuHocSinh()
        {
            return m_HocSinhData.ExecuteNoneQuery() > 0;
        }

        public void LuuHocSinh(String maHocSinh, String hoTen, bool gioiTinh, DateTime ngaySinh, String email, String diachi)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO HOCSINH VALUES(@maHocSinh, @hoTen, @gioiTinh, @ngaySinh, @email, @diachi)");
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value    = maHocSinh;
            cmd.Parameters.Add("hoTen", SqlDbType.NVarChar).Value       = hoTen;
            cmd.Parameters.Add("gioiTinh", SqlDbType.Bit).Value         = gioiTinh;
            cmd.Parameters.Add("ngaySinh", SqlDbType.DateTime).Value    = ngaySinh;
            cmd.Parameters.Add("email", SqlDbType.NVarChar).Value     =   email;
            cmd.Parameters.Add("diachi", SqlDbType.VarChar).Value     = diachi;
           
            m_HocSinhData.Load(cmd);
        }

        public DataTable TimTheoMa(String id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOCSINH WHERE MaHocSinh LIKE '%' + @id + '%'");
            cmd.Parameters.Add("id", SqlDbType.VarChar).Value = id;

            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public DataTable TimTheoTen(String ten)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOCSINH WHERE HoTen LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;

            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public String TruyVanChung()
        {
            return "SELECT QTH.MaHocSinh, HS.HoTen, HS.GioiTinh, HS.NgaySinh, HS.DiaChi, HS.Email, L.TenLop, GV.TenGiaoVien, HK.TenHocKy, NH.TenNamHoc, BCTKHK.DiemTBHocKy FROM HOCSINH HS, QUATRINHHOC QTH, LOP L, GIAOVIEN GV, HOCKY HK, NAMHOC NH, BAOCAOTONGKETHOCKY BCTKHK";
        }

        public DataTable TimKiemHocSinh(String hoTen)
        {
            SqlCommand cmd = new SqlCommand();

            String sql = TruyVanChung() + " WHERE HS.MaHocSinh = QTH.MaHocSinh AND QTH.MaLop = L.MaLop AND GV.MaGiaoVien = L.MaGiaoVien AND HK.MaHocKy = QTH.MaHocKy AND L.MaNamHoc = NH.MaNamHoc AND BCTKHK.MaQuaTrinhHoc = QTH.MaQuaTrinhHoc AND HoTen LIKE '%' + @hoTen + '%' ";
            cmd.Parameters.Add("hoTen", SqlDbType.NVarChar).Value = hoTen;

            cmd.CommandText = sql;
            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public DataTable TimKiemHocSinh_NamHoc_HocKy_Lop(String maNamHoc, String maHocKy, String maLop)
        {
            SqlCommand cmd = new SqlCommand();

            String sql = TruyVanChung() + " WHERE HS.MaHocSinh = QTH.MaHocSinh AND QTH.MaLop = L.MaLop AND GV.MaGiaoVien = L.MaGiaoVien AND HK.MaHocKy = QTH.MaHocKy AND L.MaNamHoc = NH.MaNamHoc AND BCTKHK.MaQuaTrinhHoc = QTH.MaQuaTrinhHoc AND L.MaLop = @maLop AND L.MaNamHoc = @maNamHoc AND QTH.MaHocKy = @maHocKy";
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
            cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value = maHocKy;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;

            cmd.CommandText = sql;
            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

    }
}
