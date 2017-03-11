using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QLHS_THPT.Bussiness;
using QLHS_THPT;

namespace QLHS_THPT.DataLayer
{
    public class LopDAL : ConnectData
    {
        DataService m_LopData = new DataService();
        /// <summary>
        /// Lấy DataTable Lớp từ mã năm và khối
        /// </summary>
        /// <param name="maNamHoc">String: Mã năm học</param>
        /// <param name="maKhoi">String: mã khối</param>
        /// <returns></returns>
        public DataTable LayDTLop_MaNam_MaKhoi(string maNamHoc, string maKhoi)
        {
            SqlCommand cmd = new SqlCommand(
                    "SELECT MaLop, TenLop, gv.MaGiaoVien, TenGiaoVien, SiSo, l. MaNamHoc, TenNamHoc, MaKhoiLop  FROM LOP l INNER JOIN GIAOVIEN gv ON l.MaGiaoVien=gv.MaGiaoVien INNER JOIN NAMHOC namhoc  ON l.MaNamHoc=namhoc.MaNamHoc WHERE MaKhoiLop = @maKhoi AND l.MaNamHoc = @maNamHoc ");
           /* string sql =
                string.Format(
                    "SELECT MaLop, TenLop, gv.MaGiaoVien, TenGiaoVien, SiSo, l. MaNamHoc, TenNamHoc, MaKhoiLop "
                    + " FROM LOP l INNER JOIN GIAOVIEN gv ON l.MaGiaoVien=gv.MaGiaoVien INNER JOIN NAMHOC namhoc  ON "
                    + " l.MaNamHoc=namhoc.MaNamHoc WHERE "
                    + " MaKhoiLop = '{0}' AND l.MaNamHoc = '{1}' ", maKhoi, maNamHoc); */
            //return GetTable(sql);
            cmd.Parameters.Add("maKhoi", SqlDbType.VarChar).Value = maKhoi;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
            m_LopData.Load(cmd);
            return m_LopData;
        }


        public int Lay_SiSo_Lop(string maLop, string maNamHoc)
        {
            string sql = "SELECT SiSo FROM Lop WHERE MaLop = '" + maLop + "' AND MaNamHoc = '" + maNamHoc + "'";
            return Convert.ToInt32(ExecuteScalar(sql));
        }

        public int Lay_SL_KhoiLop(string khoiLop)
        {
            string sql = "SELECT SoLop FROM KHOILOP WHERE MaKhoiLop = '" + khoiLop + "'";
            return Convert.ToInt32(ExecuteScalar(sql));
        }

        public string Lay_KyHieu(string khoiLop)
        {
            string sql = "SELECT KyHieu FROM KHOILOP WHERE MaKhoiLop = '" + khoiLop + "'";
            return Convert.ToString(ExecuteScalar(sql));
        }
        /// <summary>
        /// Lấy list Lớp từ mã năm và khối
        /// </summary>
        /// <param name="maNamHoc">String: Mã năm học</param>
        /// <param name="maKhoi">String: mã khối</param>
        /// <returns></returns>
        public IEnumerable<LopDTO> LayListLop_MaNam_MaKhoi(string maNamHoc, string maKhoi)
        {
            string sql = string.Format("SELECT MaLop, TenLop, g.* FROM LOP l LEFT JOIN GIAOVIEN g "
                                       + " ON l.MaGiaoVien = g.MaGiaoVien WHERE MaKhoiLop = '{0}' "
                                       + " AND MaNamHoc = '{1}' ", maKhoi, maNamHoc);
            OpenConnect();
            var listLopDTO = new List<LopDTO>();
            SqlDataReader dr = ExecuteReader(sql);
            while (dr.Read())
            {
                var lopDTO = new LopDTO
                                 {
                                     MaLop = Convert.ToString(dr["MaLop"]),
                                     TenLop = Convert.ToString(dr["TenLop"]),
                                     GiaoVien =
                                         {
                                             MaGiaoVien = Convert.ToString(dr["MaGiaoVien"]),
                                             TenGiaoVien = Convert.ToString(dr["TenGiaoVien"])
                                         }
                                 };
                listLopDTO.Add(lopDTO);
            }
            CloseConnect();
            return listLopDTO;
        }

        /// <summary>
        /// Lấy tên giáo viên chủ nhiệm
        /// </summary>
        /// <param name="maLop">String: Mã lớp</param>
        /// <returns>String: Tên giáo viên</returns>
        public string LayTen_GiaoVien_MaLop(string maLop)
        {
            string sql = "SELECT gv.TenGiaoVien FROM GIAOVIEN gv, LOP l "
                         + "WHERE gv.MaGiaoVien = l.MaGiaoVien AND l.Malop ='" + maLop + "'";
            return Convert.ToString(ExecuteScalar(sql));
        }

        /// <summary>
        /// Kiểm tra tồn tại mã lớp
        /// </summary>
        /// <param name="maLop">String: Mã lớp</param>
        /// <returns>Bool</returns>
        public bool KiemTra_TonTaiMaLop(string maLop)
        {
            string sql = "SELECT count(*) FROM Lop WHERE MaLop = '" + maLop + "'";
            return Convert.ToInt32(ExecuteScalar(sql)) > 0;
        }

        /// <summary>
        /// Thêm lớp mới
        /// </summary>
        /// <param name="lop">LopDTO</param>
        /// <returns></returns>
        public bool Them_HoSo_Lop(LopDTO lop)
        {
            if (KiemTra_TonTaiMaLop(lop.MaLop))
            {
                ExceptionUtil.ThrowMsgBox("Lớp: " + lop.TenLop + " đã tồn tại!");
                return false;
            }
            string sql = string.Format("INSERT INTO LOP (MaLop, TenLop, MaGiaoVien, MaKhoiLop, MaNamHoc, SiSo) VALUES ('{0}','{1}','{2}',{3},'{4}',{5})",
                                       lop.MaLop, lop.TenLop, lop.GiaoVien.MaGiaoVien, lop.MaKhoiLop, lop.MaNamHoc, lop.SiSo);
            return ExecuteQuery(sql) > 0;
        
        }

        /// <summary>
        /// Cập nhật giáo viên chủ nhiệm
        /// </summary>
        /// <param name="lop">LopDTO</param>
        /// <returns></returns>
        public bool CapNhat_GiaoVienCN_Lop(LopDTO lop)
        {
            string sql = string.Format("UPDATE LOP SET MaGiaoVien = '{1}', SiSo = '{2}' WHERE MaLop = '{0}'",
                                       lop.MaLop,lop.GiaoVien.MaGiaoVien, lop.SiSo);
            return ExecuteQuery(sql) > 0;
        }

        /// <summary>
        /// Xóa lớp từ mã lớp
        /// </summary>
        /// <param name="maLop">String: Mã lớp</param>
        /// <returns></returns>
        public bool Xoa_HoSo_Lop(string maLop)
        {
            string sql = "DELETE FROM QUATRINHHOC WHERE MaLop = '" + maLop + "'";
            sql += "\nDELETE FROM CHUONGTRINHHOC WHERE MaLop = '" + maLop + "'";
            sql += "\nDELETE FROM CT_BAOCAOTONGKETMON WHERE MaLop = '" + maLop + "'";
            sql += "\nDELETE FROM CT_BAOCAOTONGKETHOCKY WHERE MaLop = '" + maLop + "'"; 
            sql += "\nDELETE FROM LOP WHERE MaLop = '" + maLop + "'"; 
            return ExecuteQuery(sql) > 0;
        }

        public bool Xoa_HoSo_Lop_Nam(string maNamHoc)
        {
            string sql = "SELECT MaLop FROM LOP WHERE MaNamHoc = '" + maNamHoc + "'";
            DataTable tbLop = GetTable(sql);
            foreach (DataRow dr in tbLop.Rows)
            {
                Xoa_HoSo_Lop(dr["MaLop"].ToString());
            }
            return true;
        }
    }
}