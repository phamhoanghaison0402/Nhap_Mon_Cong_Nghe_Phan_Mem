using System;
using System.Collections.Generic;
using System.Text;

namespace QLHS_THPT.Bussiness
{
    public class HocKyInfo
    {
        public HocKyInfo()
        {

        }

        private String m_MaHocKy;
        public String MaHocKy
        {
            get { return m_MaHocKy; }
            set { m_MaHocKy = value; }
        }

        private String m_TenHocKy;
        public String TenHocKy
        {
            get { return m_TenHocKy; }
            set { m_TenHocKy = value; }
        }

        private NamHocInfo m_MaNamHoc;
        public NamHocInfo MaNamHoc
        {
            get { return m_MaNamHoc; }
            set { m_MaNamHoc = value; }
        }
    }
}
