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
    public class BaoCaoTongKetMonCtrl
    {
        #region Fields
        DiemCtrl m_DiemCtrl = new DiemCtrl();
        BaoCaoTongKetMonData m_BaoCaoTongKetMonData = new BaoCaoTongKetMonData();
        #endregion

        public void HienThi(DataGridViewX dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_BaoCaoTongKetMonData.LayDsDiemTrungBinhMon();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public int SoLuongDat(String hocKy, String lop, String monHoc)
        {
            return m_BaoCaoTongKetMonData.LaySoLuongDat(hocKy, lop, monHoc);
        }

        public void LuuKetQua1(String hocKy, String lop, String monHoc)
        {
            int soluongdat = m_BaoCaoTongKetMonData.LaySoLuongDat(hocKy, lop, monHoc);

            m_BaoCaoTongKetMonData.XoaKetQua1(hocKy, lop, monHoc);
            m_BaoCaoTongKetMonData.LuuKetQua1(hocKy, lop, monHoc, soluongdat);
        }

        
        #region Luu ket qua
        public void LuuKetQua(String maQuaTrinhHoc, String maMonHoc)
        {      
            float diemTrungBinhMon = (float)Math.Round(m_DiemCtrl.DiemTrungBinhMon(maQuaTrinhHoc, maMonHoc), 2);   
               m_BaoCaoTongKetMonData.XoaKetQua(maQuaTrinhHoc, maMonHoc);
               m_BaoCaoTongKetMonData.LuuKetQua(maQuaTrinhHoc, maMonHoc, diemTrungBinhMon);         
        }

        public void LuuKetQuaSD(String maQuaTrinhHoc, String maMonHoc)
        {
            float diemTrungBinhMon = (float)Math.Round(m_DiemCtrl.DiemTrungBinhMon(maQuaTrinhHoc, maMonHoc), 2);
            //   m_BaoCaoTongKetMonData.XoaKetQua(maHocSinh, maLop, maMonHoc, maHocKy, maNamHoc);
            m_BaoCaoTongKetMonData.LuuKetQuaSD(maQuaTrinhHoc, maMonHoc, diemTrungBinhMon);

        }
        #endregion
    }
}
