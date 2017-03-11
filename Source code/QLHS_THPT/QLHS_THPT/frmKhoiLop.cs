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
    public partial class frmKhoiLop : XtraForm
    {
        #region Field
        KhoiLopCtrl m_KhoiLopCtrl   = new KhoiLopCtrl();
        NamHocCtrl m_NamHocCtrl = new NamHocCtrl();
        QuyDinh quyDinh = new QuyDinh();
        private bool _isAddButton;
        private bool _isDeleteButton;
        #endregion

        #region constructor
        public frmKhoiLop()
        {
            InitializeComponent();
            DataService.OpenConnection();
            _isAddButton = true;
            _isDeleteButton = true;
        }
        #endregion

        #region Load
        private void frmKhoiLop_Load(object sender, EventArgs e)
        {
            m_NamHocCtrl.HienThiDataGridViewComboBoxColumn(colMaNamHoc);
            m_KhoiLopCtrl.HienThi(dGVKhoiLop, bindingNavigatorKhoiLop);        
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
            foreach (DataGridViewRow row in dGVKhoiLop.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
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
        private void dGVKhoiLop_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        private void simpleButtonThem_Click(object sender, EventArgs e)
        {
            if (_isAddButton)
            {
                _Disable_Control(editing: true);
                DataRow m_Row = m_KhoiLopCtrl.ThemDongMoi();
                m_Row["MaKhoiLop"] = "K" + quyDinh.LaySTT1(dGVKhoiLop.Rows.Count + 1);
                m_Row["TenKhoiLop"] = "";
                m_Row["KyHieu"] = "";
                m_Row["SoLop"] = 0;
                m_Row["MaNamHoc"] = "";
                m_KhoiLopCtrl.ThemKhoiLop(m_Row);
                bindingNavigatorKhoiLop.BindingSource.MoveLast();
            }
            else
            {
                _Disable_Control(editing: false);
                m_NamHocCtrl.HienThiDataGridViewComboBoxColumn(colMaNamHoc);
                m_KhoiLopCtrl.HienThi(dGVKhoiLop, bindingNavigatorKhoiLop);
            }        
        }

        private void simpleButtonLuu_Click(object sender, EventArgs e)
        {
            if (simpleButtonLuu.Text == "Cập nhật (Alt+&U)")
            {
                if (KiemTraTruocKhiLuu("colMaKhoiLop") == true &&
                KiemTraTruocKhiLuu("colTenkhoiLop") == true &&
                KiemTraTruocKhiLuu("colKyHieu") == true &&
                KiemTraTruocKhiLuu("colSoLop") == true &&
                KiemTraTruocKhiLuu("colMaNamHoc") == true)
                {
                    if (MsgboxUtil.YesNo("Bạn có chắc chắn muốn cập nhật không?")
                            == DialogResult.Yes)
                    {
                        m_KhoiLopCtrl.LuuKhoiLop();
                        MsgboxUtil.Success("Đã cập nhật thành công!");
                        m_KhoiLopCtrl.HienThi(dGVKhoiLop, bindingNavigatorKhoiLop);
                        return;
                    }
                    else
                    {
                        m_KhoiLopCtrl.HienThi(dGVKhoiLop, bindingNavigatorKhoiLop);
                        return;
                    }
                }
                else
                {
                    return;
                }
            }

            if (KiemTraTruocKhiLuu("colMaKhoiLop") == true &&
                KiemTraTruocKhiLuu("colTenkhoiLop") == true &&
                KiemTraTruocKhiLuu("colKyHieu") == true &&
                KiemTraTruocKhiLuu("colSoLop") == true &&
                KiemTraTruocKhiLuu("colMaNamHoc") == true)
            {
                if (MsgboxUtil.YesNo("Bạn có chắc chắn muốn thêm khối lớp không?")
                       == DialogResult.Yes)
                {
                    bindingNavigatorPositionItem.Focus();
                    m_KhoiLopCtrl.LuuKhoiLop();
                    MsgboxUtil.Success("Bạn đã lưu khối lớp thành công.");
                    _Disable_Control(editing: false);
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
