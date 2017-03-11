using System;

namespace QLHS_THPT.Bussiness
{
    public class QuyDinhDTO
    {
        public string TenTruong { get; set; }
        public string DiaChiTruong { get; set; }

        public double DiemDat { get; set; }
        public double DiemDatMon { get; set; }

        public int SiSoToiDa { get; set; }

        public int TuoiToiThieu { get; set; }
        public int TuoiToiDa { get; set; }

        public double DiemToiThieu { get; set; }
        public double DiemToiDa { get; set; }

        public DateTime NgayApDungDiemDat { get; set; }
        public DateTime NgayApDungDiemDatMon { get; set; }

        public DateTime NgayApDungDiemToiThieu { get; set; }
        public DateTime NgayApDungDiemToiDa { get; set; }

        public DateTime NgayApDungTuoiToiThieu { get; set; }
        public DateTime NgayApDungTuoiToiDa { get; set; }

        public DateTime NgayApDungSiSoToiDa { get; set; }
       
    }
}