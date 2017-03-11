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
    public partial class frmLoaiHinhKiemTra : XtraForm
    {
        #region Fields
        LoaiDiemCtrl m_LoaiDiemCtrl = new LoaiDiemCtrl();
        QuyDinh      quyDinh        = new QuyDinh();
        private bool _isAddButton;
        private bool _isDeleteButton;
        #endregion

        #region Constructor
        public frmLoaiHinhKiemTra()
        {
            InitializeComponent();
            DataService.OpenConnection();
            _isAddButton = true;
            _isDeleteButton = true;
        }
        #endregion

        #region Load
        private void frmLoaiHinhKiemTra_Load(object sender, EventArgs e)
        {
            m_LoaiDiemCtrl.HienThi(dGVLoaiDiem, bindingNavigatorLoaiDiem);
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
            foreach (DataGridViewRow row in dGVLoaiDiem.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "" || str == "0")
                    {
                        MessageBoxEx.Show("Giá trị của ô không được rỗng và hệ số phải lớn hơn 0!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

       
        #endregion

        #region LoaiDiem event
        private void dGVLoaiDiem_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        private void simpleButtonThem_Click(object sender, EventArgs e)
        {
            if (_isAddButton)
            {
                _Disable_Control(editing: true);

                DataRow m_Row = m_LoaiDiemCtrl.ThemDongMoi();
                m_Row["MaLoaiKT"] = "LD" + quyDinh.LaySTT(dGVLoaiDiem.Rows.Count + 1);
                m_Row["TenLoaiKT"] = "";
                m_Row["HeSo"] = 0;
                m_LoaiDiemCtrl.ThemLoaiDiem(m_Row);
                bindingNavigatorLoaiDiem.BindingSource.MoveLast();
            }
            else
            {
                _Disable_Control(editing: false);
                m_LoaiDiemCtrl.HienThi(dGVLoaiDiem, bindingNavigatorLoaiDiem);
            }       
        }

        private void simpleButtonLuu_Click(object sender, EventArgs e)
        {
            if (simpleButtonLuu.Text == "Cập nhật (Alt+&U)")
            {
                if (KiemTraTruocKhiLuu("colMaLoai") == true &&
                KiemTraTruocKhiLuu("colTenLoai") == true &&
                KiemTraTruocKhiLuu("colHeSo") == true)
                {
                    if (MsgboxUtil.YesNo("Bạn có chắc chắn muốn cập nhật không?")
                            == DialogResult.Yes)
                    {
                        m_LoaiDiemCtrl.LuuLoaiDiem();
                        MsgboxUtil.Success("Đã cập nhật thành công!");
                        m_LoaiDiemCtrl.HienThi(dGVLoaiDiem, bindingNavigatorLoaiDiem);
                        return;
                    }
                    else
                    {
                        m_LoaiDiemCtrl.HienThi(dGVLoaiDiem, bindingNavigatorLoaiDiem);
                        return;
                    }
                }
                else
                {
                    return;
                }
            }

            if (KiemTraTruocKhiLuu("colMaLoai")     == true &&
                KiemTraTruocKhiLuu("colTenLoai")    == true &&
                KiemTraTruocKhiLuu("colHeSo")       == true)
            {
                if (MsgboxUtil.YesNo("Bạn có chắc chắn muốn thêm loại kiểm tra này không?")
                       == DialogResult.Yes)
                {
                    bindingNavigatorPositionItem.Focus();
                    m_LoaiDiemCtrl.LuuLoaiDiem();
                    MsgboxUtil.Success("Bạn đã lưu thành công.");
                    _Disable_Control(editing: false);
                }
            }
        }

        private void simpleButtonDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
