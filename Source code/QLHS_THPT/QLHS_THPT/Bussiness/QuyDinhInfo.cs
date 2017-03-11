using System;
using System.Collections.Generic;
using System.Text;

namespace QLHS_THPT.Bussiness
{
    public class QuyDinhInfo
    {
        public QuyDinhInfo()
        {
        
        }

       public string TenTruong { get; set; }
        public string DiaChiTruong { get; set; }

        public int SiSoToiDa { get; set; }

        public double DiemToiThieu { get; set; }
        public double DiemToiDa { get; set; }

        public int TuoiToiDa { get; set; }
        public int TuoiToiThieu { get; set; }

        public double DiemDat { get; set; }
        public double DiemDatMon { get; set; } 

        private int m_TenThamso;
        public int TenThamso
        {
            get { return m_TenThamso; }
            set { m_TenThamso = value; }
        }

        private int m_GiaTri;
        public int GiaTri
        {
            get { return m_GiaTri; }
            set { m_GiaTri = value; }
        }

        private int m_NgayApDung;
        public int NgayApDung
        {
            get { return m_NgayApDung; }
            set { m_NgayApDung = value; }
        }
        
    /*   private int m_TuoiToiThieu;
        public int TuoiToiThieu
        {
            get { return m_TuoiToiThieu; }
            set { m_TuoiToiThieu = value; }
        }

        private int m_TuoiToiDa;
        public int TuoiToiDa
        {
            get { return m_TuoiToiDa; }
            set { m_TuoiToiDa = value; }
        }

        private int m_SiSoToiDa;
        public int SiSoToiDa
        {
            get { return m_SiSoToiDa; }
            set { m_SiSoToiDa = value; }
        }

        private double m_DiemToiThieu;
        public double DiemToiThieu
        {
            get { return m_DiemToiThieu; }
            set { m_DiemToiThieu = value; }
        }

        private double m_DiemToiDa;
        public double DiemToiDa
        {
            get { return m_DiemToiDa; }
            set { m_DiemToiDa = value; }
        }

        private double m_DiemDat;
        public double DiemDat
        {
            get { return m_DiemDat; }
            set { m_DiemDat = value; }
        }

        private double m_DiemDatMon;
        public double DiemDatMon
        {
            get { return m_DiemDatMon; }
            set { m_DiemDatMon = value; }
        } */
    }
}
