using System;
using System.Collections.Generic;
using System.Text;

namespace QLHS_THPT.Bussiness
{
    public class HocSinhInfo
    {
        public HocSinhInfo()
        {

        }

        private String m_MaHocSinh;
        public String MaHocSinh
        {
            get { return m_MaHocSinh; }
            set { m_MaHocSinh = value; }
        }

        private String m_HoTen;
        public String HoTen
        {
            get { return m_HoTen; }
            set { m_HoTen = value; }
        }

        private bool m_GioiTinh;
        public bool GioiTinh
        {
            get { return m_GioiTinh; }
            set { m_GioiTinh = value; }
        }

        private DateTime m_NgaySinh;
        public DateTime NgaySinh
        {
            get { return m_NgaySinh; }
            set { m_NgaySinh = value; }
        }

        private String m_Email;
        public String Email
        {
            get { return m_Email; }
            set { m_Email = value; }
        }

        private String m_Diachi;
        public String DiaChi
        {
            get { return m_Diachi; }
            set { m_Diachi = value; }
        }
    }
}