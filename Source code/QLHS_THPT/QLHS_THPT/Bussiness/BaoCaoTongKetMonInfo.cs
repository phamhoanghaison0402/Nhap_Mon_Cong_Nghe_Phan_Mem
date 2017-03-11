using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS_THPT.Bussiness
{
    public class BaoCaoTongKetMonInfo
    {
        public BaoCaoTongKetMonInfo()
        {

        }

        private QuaTrinhHocInfo m_MaQuaTrinhHoc;
        public QuaTrinhHocInfo MaQuaTrinhHoc
        {
            get { return m_MaQuaTrinhHoc; }
            set { m_MaQuaTrinhHoc = value; }
        }

        private MonHocInfo m_MonHoc;
        public MonHocInfo MonHoc
        {
            get { return m_MonHoc; }
            set { m_MonHoc = value; }
        }

        private float m_DiemTrungBinhMon;
        public float DiemTrungBinhMon
        {
            get { return m_DiemTrungBinhMon; }
            set { m_DiemTrungBinhMon = value; }
        }
    }
}
