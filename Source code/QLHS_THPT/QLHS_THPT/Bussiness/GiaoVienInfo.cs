using System;
using System.Collections.Generic;
using System.Text;

namespace QLHS_THPT.Bussiness
{
    public class GiaoVienInfo
    {
        public GiaoVienInfo()
        {

        }

        private String m_MaGiaoVien;
        public String MaGiaoVien
        {
            get { return m_MaGiaoVien; }
            set { m_MaGiaoVien = value; }
        }

        private String m_TenGiaoVien;
        public String TenGiaoVien
        {
            get { return m_TenGiaoVien; }
            set { m_TenGiaoVien = value; }
        }

        private MonHocInfo m_MonHoc;
        public MonHocInfo MonHoc
        {
            get { return m_MonHoc; }
            set { m_MonHoc = value; }
        }
    }
}
