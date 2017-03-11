using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS_THPT.Bussiness
{
    public class BaoCaoTongKetHocKyInfo
    {
        public BaoCaoTongKetHocKyInfo()
        {

        }

        private QuaTrinhHocInfo m_MaQuaTrinhHoc;
        public QuaTrinhHocInfo MaQuaTrinhHoc
        {
            get { return m_MaQuaTrinhHoc; }
            set { m_MaQuaTrinhHoc = value; }
        }

        private float m_DiemTrungBinhHocKy;
        public float DiemTrungBinhMonHocKy
        {
            get { return m_DiemTrungBinhHocKy; }
            set { m_DiemTrungBinhHocKy = value; }
        }
    }
}
