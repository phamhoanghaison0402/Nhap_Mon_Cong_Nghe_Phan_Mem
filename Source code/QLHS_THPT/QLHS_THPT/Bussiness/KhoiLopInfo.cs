using System;
using System.Collections.Generic;
using System.Text;

namespace QLHS_THPT.Bussiness
{
    public class KhoiLopInfo
    {
        public KhoiLopInfo()
        {

        }

        private String m_MaKhoiLop;
        public String MaKhoiLop
        {
            get { return m_MaKhoiLop; }
            set { m_MaKhoiLop = value; }
        }

        private String m_TenKhoiLop;
        public String TenKhoiLop
        {
            get { return m_TenKhoiLop; }
            set { m_TenKhoiLop = value; }
        }

        private String m_KyHieu;
        public String KyHieu
        {
            get { return m_KyHieu; }
            set { m_KyHieu = value; }
        }

        private int m_SoLop;
        public int SoLop
        {
            get { return m_SoLop; }
            set { m_SoLop = value; }
        }
    }
}
