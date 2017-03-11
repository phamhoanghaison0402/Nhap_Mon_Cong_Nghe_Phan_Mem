using System;
using System.Data;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using QLHS_THPT.Controller;
using DevComponents.DotNetBar;
using DevExpress.XtraEditors;

namespace QLHS_THPT
{
    public partial class frmTimKiemHS : XtraForm
    {
        #region Fields
        HocSinhCtrl     m_HocSinhCtrl   = new HocSinhCtrl();
        NamHocCtrl m_NamHocCtrl = new NamHocCtrl();
        LopCtrl m_LopCtrl = new LopCtrl();
        HocKyCtrl m_HocKyCtrl = new HocKyCtrl();
        #endregion

        #region Constructor
        public frmTimKiemHS()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void frmTimKiemHS_Load(object sender, EventArgs e)
        {
            m_NamHocCtrl.HienThiComboBox(cmbNamHoc);
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Tìm kiếm học sinh
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            m_HocSinhCtrl.TimKiemHocSinh(txtHoTen, dGVKetQuaTimKiem, bindingNavigatorKetQuaTimKiem);
            cmbNamHoc.ResetText();
            cmbHocKy.ResetText();
            cmbLop.ResetText();
            
            if (dGVKetQuaTimKiem.RowCount == 0)
                MessageBoxEx.Show("Không có học sinh cần tìm trong hệ thống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion


        private void simpleButtonDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null)
                m_HocKyCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbHocKy);
            cmbHocKy.DataBindings.Clear();
        }

        private void cmbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null && cmbHocKy.SelectedValue != null)
            {
                m_LopCtrl.HienThiComboBox_new(cmbNamHoc.SelectedValue.ToString(), cmbHocKy.SelectedValue.ToString(), cmbLop);
            }
        }

        private void btnHienThiDanhSach_Click(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null && cmbLop.SelectedValue != null && cmbHocKy.SelectedValue != null)
                m_HocSinhCtrl.TimKiemHocSinh_NamHoc_HocKy_Lop(cmbNamHoc, cmbHocKy, cmbLop, dGVKetQuaTimKiem, bindingNavigatorKetQuaTimKiem);
            txtHoTen.ResetText();
        }
    }
}