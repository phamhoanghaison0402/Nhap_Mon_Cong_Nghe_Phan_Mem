using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using QLHS_THPT.DataLayer;

namespace QLHS_THPT.Controller
{
    public class LoaiDiemCtrl
    {
        LoaiDiemData m_LoaiDiemData = new LoaiDiemData();

        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = m_LoaiDiemData.LayDsLoaiDiem();
            comboBox.DisplayMember = "TenLoaiKT";
            comboBox.ValueMember = "MaLoaiKT";
        }

        public void HienThiComboBox(String lop, String monHoc,  ComboBoxEx comboBox)
        {
            LoaiDiemData m_LoaiDiemData = new LoaiDiemData();

            comboBox.DataSource = m_LoaiDiemData.LayDsLoaiDiem(lop, monHoc);
            comboBox.DisplayMember = "TenLoaiKT";
            comboBox.ValueMember = "MaLoaiKT";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_LoaiDiemData.LayDsLoaiDiem();
            cmbColumn.DisplayMember = "TenLoaiKT";
            cmbColumn.ValueMember = "MaLoaiKT";
            cmbColumn.DataPropertyName = "MaLoaiKT";
            cmbColumn.HeaderText = "Loại điểm";
        }
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridViewX dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_LoaiDiemData.LayDsLoaiDiem();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_LoaiDiemData.ThemDongMoi();
        }

        public void ThemLoaiDiem(DataRow m_Row)
        {
            m_LoaiDiemData.ThemLoaiDiem(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuLoaiDiem()
        {
            return m_LoaiDiemData.LuuLoaiDiem();
        }
        #endregion
    }
}
