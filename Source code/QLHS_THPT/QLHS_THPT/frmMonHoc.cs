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
    public partial class frmMonHoc : XtraForm
    {
        #region Fields
        MonHocCtrl  m_MonHocCtrl    = new MonHocCtrl();
        QuyDinh     quyDinh         = new QuyDinh();
        private bool _isAddButton;
        private bool _isDeleteButton;
        #endregion

        #region Constructor
        public frmMonHoc()
        {
            InitializeComponent();
            DataService.OpenConnection();
            _isAddButton = true;
            _isDeleteButton = true;
        }
        #endregion

        #region Load
        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            m_MonHocCtrl.HienThi(dGVMonHoc, bindingNavigatorMonHoc);
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
            foreach (DataGridViewRow row in dGVMonHoc.Rows)
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
        private void dGVMonHoc_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        private void simpleButtonDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButtonThem_Click(object sender, EventArgs e)
        {
            if (_isAddButton)
            {
                _Disable_Control(editing: true);

                DataRow m_Row = m_MonHocCtrl.ThemDongMoi();
                m_Row["MaMonHoc"] = "MH" + quyDinh.LaySTT(dGVMonHoc.Rows.Count + 1);
                m_Row["TenMonHoc"] = "";
                m_MonHocCtrl.ThemMonHoc(m_Row);
                bindingNavigatorMonHoc.BindingSource.MoveLast();
            }
            else
            {
                _Disable_Control(editing: false);
                m_MonHocCtrl.HienThi(dGVMonHoc, bindingNavigatorMonHoc);
            }       
        }

        private void simpleButtonLuu_Click(object sender, EventArgs e)
        {
            if (simpleButtonLuu.Text == "Cập nhật (Alt+&U)")
            {
                if (KiemTraTruocKhiLuu("colMaMonHoc") == true &&
                 KiemTraTruocKhiLuu("colTenMonHoc") == true)
                {
                    if (MsgboxUtil.YesNo("Bạn có chắc chắn muốn cập nhật không?")
                            == DialogResult.Yes)
                    {
                        m_MonHocCtrl.LuuMonHoc();
                        MsgboxUtil.Success("Đã cập nhật thành công!");
                        m_MonHocCtrl.HienThi(dGVMonHoc, bindingNavigatorMonHoc);
                        return;
                    }
                    else
                    {
                        m_MonHocCtrl.HienThi(dGVMonHoc, bindingNavigatorMonHoc);
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            if (KiemTraTruocKhiLuu("colMaMonHoc") == true &&
                KiemTraTruocKhiLuu("colTenMonHoc") == true)
            {
                if (MsgboxUtil.YesNo("Bạn có chắc chắn muốn thêm môn học này không?")
                       == DialogResult.Yes)
                {
                    bindingNavigatorPositionItem.Focus();
                    m_MonHocCtrl.LuuMonHoc();
                    MsgboxUtil.Success("Bạn đã lưu thành công");
                    _Disable_Control(editing: false);
                }
                else
                {
                    return;
                }
            }
        }
    }
}