using System;
using System.Collections.Generic;
using System.Text;

namespace QLHS_THPT.Bussiness
{
    public class NamHocInfo
    {
        public NamHocInfo()
        {

        }

        private String m_MaNamHoc;
        public String MaNamHoc
        {
            get { return m_MaNamHoc; }
            set { m_MaNamHoc = value; }
        }
        private String m_TenNamHoc;
        public String TenNamHoc
        {
            get { return m_MaNamHoc; }
            set { m_MaNamHoc = value; }
        }

        private String m_Nam_1;
        public String Nam_1
        {
            get { return m_Nam_1; }
            set { m_Nam_1 = value; }
        }

        private String m_Nam_2;
        public String Nam_2
        {
            get { return m_Nam_2; }
            set { m_Nam_2 = value; }
        }
    }
}
