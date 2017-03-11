using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using System.Collections.Generic;
using DevComponents.Editors;
using QLHS_THPT.Bussiness;
using QLHS_THPT.DataLayer;

namespace QLHS_THPT.Controller
{
    public class BaoCaoTongKetHocKyCtrl
    {
        #region Fields
        DiemCtrl m_DiemCtrl = new DiemCtrl();
        BaoCaoTongKetHocKyData m_BaoCaoTongKetHocKyData = new BaoCaoTongKetHocKyData();
        #endregion

        #region Luu ket qua
        public void LuuKetQua(String maQuaTrinhHoc)
        {
            float diemTBChungCacMonHK = (float)Math.Round(m_DiemCtrl.DiemTrungBinhChungCacMonHocKy(maQuaTrinhHoc), 2);
            m_BaoCaoTongKetHocKyData.XoaKetQua(maQuaTrinhHoc);
            m_BaoCaoTongKetHocKyData.LuuKetQua(maQuaTrinhHoc, diemTBChungCacMonHK);
        }

        public int SoLuongDat(String hocKy, String lop)
        {
            return m_BaoCaoTongKetHocKyData.LaySoLuongDat(hocKy, lop);
        }

        public void LuuKetQua1(String hocKy, String lop)
        {
            int soluongdat = m_BaoCaoTongKetHocKyData.LaySoLuongDat(hocKy, lop);
            m_BaoCaoTongKetHocKyData.XoaKetQua1(hocKy, lop);
            m_BaoCaoTongKetHocKyData.LuuKetQua1(hocKy, lop,  soluongdat);
        }
        #endregion
    }
}
