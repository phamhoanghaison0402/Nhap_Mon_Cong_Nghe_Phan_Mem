namespace QLHS_THPT.Bussiness
{
    public class LopDTO
    {
        private GiaoVienDTO _GiaoVienDTO = new GiaoVienDTO();
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public string MaKhoiLop { get; set; }
        public string MaNamHoc { get; set; }
        public int SiSo { get; set; }

        public GiaoVienDTO GiaoVien
        {
            get { return _GiaoVienDTO; }
            set { _GiaoVienDTO = value; }
        }
    }
}