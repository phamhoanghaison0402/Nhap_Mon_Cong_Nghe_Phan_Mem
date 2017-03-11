using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using QLHS_THPT.DataLayer;

namespace QLHS_THPT.Controller
{
    public class ChuongTrinhHocCtrl
    {
        ChuongTrinhHocData m_ChuongTrinhHocData = new ChuongTrinhHocData();

        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = m_ChuongTrinhHocData.LayDsChuongTrinhHoc();
            comboBox.DisplayMember = "TenMonHoc";
            comboBox.ValueMember = "MaMonHoc";
        }

        public void HienThiComboBox_HeSo_SoTiet(String maLop, String maMonHoc, ComboBoxEx comboBox)
        {
            comboBox.DataSource = m_ChuongTrinhHocData.LayDsChuongTrinhHoc_HeSo_SoTiet(maLop, maMonHoc);
            //comboBox.DisplayMember = "TenMonHoc";
            comboBox.DisplayMember = "HeSo";
            //comboBox.ValueMember = "MaMonHoc";
        }

        public void HienThiComboBox(String hocKy, String lop,  ComboBoxEx comboBox)
        {
            MonHocData m_MHData = new MonHocData();

            comboBox.DataSource = m_MHData.LayDsMonHoc(hocKy, lop);
            comboBox.DisplayMember = "TenMonHoc";
            comboBox.ValueMember = "MaMonHoc";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_ChuongTrinhHocData.LayDsChuongTrinhHoc();
            cmbColumn.DisplayMember = "TenMonHoc";
            cmbColumn.ValueMember = "MaMonHoc";
            cmbColumn.DataPropertyName = "MaMonHoc";
            cmbColumn.HeaderText = "Môn học";
        }

        public void HienThiDataGridViewComboBoxColumnGiaoVien(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_ChuongTrinhHocData.LayDsChuongTrinhHoc();
            cmbColumn.DisplayMember = "TenMonHoc";
            cmbColumn.ValueMember = "MaMonHoc";
            cmbColumn.DataPropertyName = "MaMonHoc";
            cmbColumn.HeaderText = "Chuyên môn";
        }
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridViewX dGV, BindingNavigator bN, String namHoc, String lop)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_ChuongTrinhHocData.LayDsChuongTrinhHoc(namHoc, lop);
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public void HienThi(DataGridViewX dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_ChuongTrinhHocData.LayDsChuongTrinhHoc();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_ChuongTrinhHocData.ThemDongMoi();
        }

        public void ThemMonHoc(DataRow m_Row)
        {
            m_ChuongTrinhHocData.ThemMonHoc(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuMonHoc()
        {
            return m_ChuongTrinhHocData.LuuMonHoc();
        }

        public void LuuChuongTrinhHoc(String maLop, String maMonHoc, int heSo, int soTiet)
        {
            m_ChuongTrinhHocData.LuuChuongTrinhHoc(maLop, maMonHoc, heSo, soTiet);
        }

        public void CapNhatChuongTrinhHoc(String maLop, String maMonHoc, int heSo, int soTiet)
        {
            m_ChuongTrinhHocData.CapNhatChuongTrinhHoc(maLop, maMonHoc, heSo, soTiet);
        }

        public void XoaMonHoc_ChuongTrinhHoc(String maLop, String maMonHoc)
        {
            m_ChuongTrinhHocData.XoaMonHoc_ChuongTrinhHoc(maLop, maMonHoc);
        }
        #endregion
    }
}
