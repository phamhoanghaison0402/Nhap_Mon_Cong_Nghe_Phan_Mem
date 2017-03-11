using System;
using QLHS_THPT.DataLayer;
using QLHS_THPT.Bussiness;

namespace QLHS_THPT.Controller
{
    public class QuyDinhBUS
    {
        private readonly QuyDinhDAL _quyDinhDAL;

        public QuyDinhBUS()
        {
            _quyDinhDAL = new QuyDinhDAL();
        }

        /// <summary>
        /// Lấy danh sách quy định
        /// </summary>
        /// <returns></returns>
        public QuyDinhDTO LayDS_QuyDinh()
        {
            return _quyDinhDAL.LayDS_QuyDinh();
        }

        /// <summary>
        /// Cập nhật quy định
        /// </summary>
        /// <param name="quyDinhDTO">QuyDinhDTO</param>
        /// <returns></returns>
        public bool CapNhat_QuyDinh(QuyDinhDTO quyDinhDTO)
        {
            return _quyDinhDAL.SuaQuyDinh(quyDinhDTO);
        }

        /// <summary>
        /// Lấy tuổi cận dưới
        /// </summary>
        /// <returns>Int</returns>
        public int LayTuoi_CanDuoi()
        {
            return Convert.ToInt32(_quyDinhDAL.LayGiaTri("TuoiToiThieu"));
        }

        /// <summary>
        /// Lấy tuổi cận trên
        /// </summary>
        /// <returns>Int</returns>
        public int LayTuoi_CanTren()
        {
            return Convert.ToInt32(_quyDinhDAL.LayGiaTri("TuoiToiDa"));
        }

        /// <summary>
        /// Lấy năm tuổi cận dưới
        /// </summary>
        /// <returns>Int: Năm</returns>
        public int LayNamTuoi_CanDuoi()
        {
            return DateTime.Now.Year - LayTuoi_CanTren();
        }

        /// <summary>
        /// Lấy năm tuổi cận trên
        /// </summary>
        /// <returns>Int: Năm</returns>
        public int LayNamTuoi_CanTren()
        {
            return DateTime.Now.Year - LayTuoi_CanDuoi();
        }

        /// <summary>
        /// Lấy mã năm học hiện tại
        /// </summary>
        /// <returns>String: mã năm</returns>
        public string LayMaNamHoc_HienTai()
        {
            return Convert.ToString(_quyDinhDAL.LayGiaTri("MaNamHocHT"));
        }

        /// <summary>
        /// Lấy sỉ số cận trên
        /// </summary>
        /// <returns>Int</returns>
        public int LaySiSo_CanTren()
        {
            return Convert.ToInt32(_quyDinhDAL.LayGiaTri("SiSoToiDa"));
        }

        public int Dem_SiSo_Lop(string maLop, string maHocKy)
        {
            return _quyDinhDAL.Dem_SiSo_Lop(maLop, maHocKy);
        }
        /// <summary>
        /// Lấy điểm chuẩn
        /// </summary>
        /// <returns>Double</returns>
        public double LayDiemChuan_DatMon()
        {
            return Convert.ToDouble(_quyDinhDAL.LayGiaTri("DiemDatMon"));
        }

        public double LayDiemChuan_Dat()
        {
            return Convert.ToDouble(_quyDinhDAL.LayGiaTri("DiemDat"));
        }
        /// <summary>
        /// Lấy ngày áp dụng
        /// </summary>
        /// <returns></returns>
        public DateTime LayNgayApDung_QuyDinh()
        {
            string ngayQD = _quyDinhDAL.LayGiaTri("NgayApDung").ToString();
            return DateTime.ParseExact(ngayQD, "dd-MM-yyyy", null);
        }
    }
}