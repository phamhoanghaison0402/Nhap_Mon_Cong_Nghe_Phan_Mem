using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS_THPT.Bussiness
{
    public class QuaTrinhHocInfo
    {
        public QuaTrinhHocInfo()
        {

        }

        private String m_MaQuaTrinhHoc;
        public String MaQuaTrinhHoc
        {
            get { return m_MaQuaTrinhHoc; }
            set { m_MaQuaTrinhHoc = value; }
        }

        private HocSinhInfo m_HocSinh;
        public HocSinhInfo HocSinh
        {
            get { return m_HocSinh; }
            set { m_HocSinh = value; }
        }

        private HocKyInfo m_HocKy;
        public HocKyInfo HocKy
        {
            get { return m_HocKy; }
            set { m_HocKy = value; }
        }

        private NamHocInfo m_MaNamHoc;
        public NamHocInfo MaNamHoc
        {
            get { return m_MaNamHoc; }
            set { m_MaNamHoc = value; }
        }

        private LopInfo m_MaLop;
        public LopInfo MaLop
        {
            get { return m_MaLop; }
            set { m_MaLop = value; }
        }
    }
}
