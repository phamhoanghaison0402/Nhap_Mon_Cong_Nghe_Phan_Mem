using System;
using System.Collections.Generic;
using System.Text;

namespace QLHS_THPT.Bussiness
{
    public class ChuongTrinhHocInfo
    {
        public ChuongTrinhHocInfo()
        {

        }

        private LopInfo m_Lop;
        public LopInfo Lop
        {
            get { return m_Lop; }
            set { m_Lop = value; }
        }

        private MonHocInfo m_MonHoc;
        public MonHocInfo MonHoc
        {
            get { return m_MonHoc; }
            set { m_MonHoc = value; }
        }

        private int m_SoTiet;
        public int SoTiet
        {
            get { return m_SoTiet; }
            set { m_SoTiet = value; }
        }

        private int m_HeSo;
        public int HeSo
        {
            get { return m_HeSo; }
            set { m_HeSo = value; }
        }
    }
}
