using System;
using System.Collections.Generic;
using System.Text;

namespace QLHS_THPT.Bussiness
{
    public class MonHocInfo
    {
        public MonHocInfo()
        {

        }

        private String m_MaMonHoc;
        public String MaMonHoc
        {
            get { return m_MaMonHoc; }
            set { m_MaMonHoc = value; }
        }

        private String m_TenMonHoc;
        public String TenMonHoc
        {
            get { return m_TenMonHoc; }
            set { m_TenMonHoc = value; }
        }
    }
}
