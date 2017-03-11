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
    public partial class frmHocKy : XtraForm
    {
        #region Field
        HocKyCtrl   m_HocKyCtrl   = new HocKyCtrl();
        NamHocCtrl m_NamHocCtrl = new NamHocCtrl();
        QuyDinh quyDinh = new QuyDinh();
        private bool _isAddButton;
        private bool _isDeleteButton;
        #endregion

        #region Constructor
        public frmHocKy()
        {
            InitializeComponent();
            DataService.OpenConnection();
            _isAddButton = true;
            _isDeleteButton = true;
        }
        #endregion

        #region Load
        private void frmHocKy_Load(object sender, EventArgs e)
        {
            m_NamHocCtrl.HienThiDataGridViewComboBoxColumn(colMaNamHoc);
            m_HocKyCtrl.HienThi(dGVHocKy, bindingNavigatorHocKy);
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
       
        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dGVHocKy.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "" || str == "0")
                    {
                        MessageBoxEx.Show("Giá trị của ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }
        #endregion

        #region DataError event
        private void dGVHocKy_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        private void simpleButtonLuu_Click(object sender, EventArgs e)
        {
            if (simpleButtonLuu.Text == "Cập nhật (Alt+&U)")
            {
                if (KiemTraTruocKhiLuu("colMaHocKy") == true &&
                     KiemTraTruocKhiLuu("colTenHocKy") == true &&
                     KiemTraTruocKhiLuu("colMaNamHoc") == true)
                {
                    if (MsgboxUtil.YesNo("Bạn có chắc chắn muốn cập nhật không?")
                            == DialogResult.Yes)
                    {
                        m_HocKyCtrl.LuuHocKy();
                        MsgboxUtil.Success("Đã cập nhật thành công!");
                        m_HocKyCtrl.HienThi(dGVHocKy, bindingNavigatorHocKy);
                        return;
                    }
                    else
                    {
                        m_HocKyCtrl.HienThi(dGVHocKy, bindingNavigatorHocKy);
                        return;
                    }
                }
                else
                {
                    return;
                }
                
            }

            if (KiemTraTruocKhiLuu("colMaHocKy") == true &&
                KiemTraTruocKhiLuu("colTenHocKy") == true &&
                KiemTraTruocKhiLuu("colMaNamHoc") == true)
            {
                if (MsgboxUtil.YesNo("Bạn có chắc chắn muốn thêm học kỳ không?")
                       == DialogResult.Yes)
                {
                    bindingNavigatorPositionItem.Focus();
                    m_HocKyCtrl.LuuHocKy();
                    MsgboxUtil.Success("Bạn đã lưu học kỳ thành công.");
                    _Disable_Control(editing: false);
                }        
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButtonThem_Click(object sender, EventArgs e)
        {
            if (_isAddButton)
            {
                _Disable_Control(editing: true);
                DataRow m_Row = m_HocKyCtrl.ThemDongMoi();
                m_Row["MaHocKy"] = "HK" + quyDinh.LaySTT1(dGVHocKy.Rows.Count + 1);
                m_Row["TenHocKy"] = "";
                m_Row["MaNamHoc"] = "";
                m_HocKyCtrl.ThemHocKy(m_Row);
                bindingNavigatorHocKy.BindingSource.MoveLast();
            }
            else
            {
                _Disable_Control(editing: false);
                m_NamHocCtrl.HienThiDataGridViewComboBoxColumn(colMaNamHoc);
                m_HocKyCtrl.HienThi(dGVHocKy, bindingNavigatorHocKy);
            }        
        }
    }
}