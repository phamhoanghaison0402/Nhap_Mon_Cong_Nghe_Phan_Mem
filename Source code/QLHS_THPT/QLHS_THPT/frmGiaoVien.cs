using System;
using System.Data;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using QLHS_THPT.Controller;
using QLHS_THPT.Component;
using DevComponents.DotNetBar;
using DevExpress.XtraEditors;

namespace QLHS_THPT
{
    public partial class frmGiaoVien : XtraForm
    {
        #region Fields
        GiaoVienCtrl    m_GiaoVienCtrl  = new GiaoVienCtrl();
        MonHocCtrl      m_MonHocCtrl    = new MonHocCtrl();
        QuyDinh         quyDinh         = new QuyDinh();
        private bool _isAddButton;
        private bool _isDeleteButton;
        #endregion

        #region Constructor
        public frmGiaoVien()
        {
            InitializeComponent();
            DataService.OpenConnection();
            _isAddButton = true;
            _isDeleteButton = true;
        }
        #endregion

        #region Load
        private void frmGiaoVien_Load(object sender, EventArgs e)
        {        
            m_MonHocCtrl.HienThiDataGridViewComboBoxColumnGiaoVien(colMaMonHoc);
            m_GiaoVienCtrl.HienThi(dGVGiaoVien, bindingNavigatorGiaoVien);
        }
        #endregion

        #region BindingNavigatorItems
        private void _Disable_Control(bool editing)
        {
            _isAddButton = !editing;
            _isDeleteButton = !editing;

            simpleButtonThem.Text = editing ? "Không thêm (Alt+&N)" : "Thêm (Alt+&A)";
            simpleButtonLuu.Text = editing ? "Lưu (Alt+&S)" : "Cập nhật (Alt+&U)";
        }

        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dGVGiaoVien.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBoxEx.Show("Thông tin giáo viên " + row.Cells["colTenGiaoVien"].Value.ToString() + " không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

       
        #endregion

        #region DataError event
        private void dGVGiaoVien_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        #region Tìm kiếm giáo viên
        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiemGiaoVien();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiemGiaoVien();
        }

        void TimKiemGiaoVien()
        {
            if (chkTimTheoMa.Checked == true)
            {
                m_GiaoVienCtrl.TimTheoMa(txtTimKiem.Text);
            }
            else
            {
                m_GiaoVienCtrl.TimTheoTen(txtTimKiem.Text);
            }
        }
        #endregion

        #region Click event
        private void btnThemMonHoc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormMonHoc();
            m_MonHocCtrl.HienThiDataGridViewComboBoxColumnGiaoVien(colMaMonHoc);
        }
        #endregion

        private void simpleButtonThem_Click(object sender, EventArgs e)
        {
            if (_isAddButton)
            {
                _Disable_Control(editing: true);

                DataRow m_Row = m_GiaoVienCtrl.ThemDongMoi();
                m_Row["MaGiaoVien"] = "GV" + quyDinh.LaySTT1(dGVGiaoVien.Rows.Count + 1);
                m_Row["TenGiaoVien"] = "";
                m_Row["MaMonHoc"] = "";
                m_GiaoVienCtrl.ThemGiaoVien(m_Row);
                bindingNavigatorGiaoVien.BindingSource.MoveLast();
            }
            else
            {
                _Disable_Control(editing: false);
                m_MonHocCtrl.HienThiDataGridViewComboBoxColumnGiaoVien(colMaMonHoc);
                m_GiaoVienCtrl.HienThi(dGVGiaoVien, bindingNavigatorGiaoVien); 
            }       
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButtonLuu_Click(object sender, EventArgs e)
        {
            if (simpleButtonLuu.Text == "Cập nhật (Alt+&U)")
            {
                if (KiemTraTruocKhiLuu("colMaGiaoVien") == true &&
               KiemTraTruocKhiLuu("colTenGiaoVien") == true &&
               KiemTraTruocKhiLuu("colMaMonHoc") == true)
                {
                    if (MsgboxUtil.YesNo("Bạn có chắc chắn muốn cập nhật không?")
                            == DialogResult.Yes)
                    {
                        m_GiaoVienCtrl.LuuGiaoVien();
                        MsgboxUtil.Success("Đã cập nhật thành công!");
                        m_MonHocCtrl.HienThiDataGridViewComboBoxColumnGiaoVien(colMaMonHoc);
                        m_GiaoVienCtrl.HienThi(dGVGiaoVien, bindingNavigatorGiaoVien);
                        return;
                    }
                    else
                    {
                        m_MonHocCtrl.HienThiDataGridViewComboBoxColumnGiaoVien(colMaMonHoc);
                        m_GiaoVienCtrl.HienThi(dGVGiaoVien, bindingNavigatorGiaoVien);
                        return;
                    }
                }
                else
                {
                    return;
                }
            }

            if (KiemTraTruocKhiLuu("colMaGiaoVien") == true &&
               KiemTraTruocKhiLuu("colTenGiaoVien") == true &&
               KiemTraTruocKhiLuu("colMaMonHoc") == true)
            {
                if (MsgboxUtil.YesNo("Bạn có chắc chắn muốn thêm giáo viên này không?")
                       == DialogResult.Yes)
                {
                    bindingNavigatorPositionItem.Focus();
                    m_GiaoVienCtrl.LuuGiaoVien();
                    MsgboxUtil.Success("Bạn đã lưu thành công");
                    _Disable_Control(editing: false);
                }
                else
                {
                    return;
                }
            }
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            _Disable_Control(editing: false);
            m_MonHocCtrl.HienThiDataGridViewComboBoxColumnGiaoVien(colMaMonHoc);
            m_GiaoVienCtrl.HienThi(dGVGiaoVien, bindingNavigatorGiaoVien);
        }    
    }
}