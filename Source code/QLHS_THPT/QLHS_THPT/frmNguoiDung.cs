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
    public partial class frmNguoiDung : XtraForm
    {
        #region Fields
        NguoiDungCtrl       m_NguoiDungCtrl     = new NguoiDungCtrl();
        LoaiNguoiDungCtrl   m_LoaiNguoiDungCtrl = new LoaiNguoiDungCtrl();
        GiaoVienCtrl m_GiaoVienCtrl = new GiaoVienCtrl();
        QuyDinh             quyDinh             = new QuyDinh();
        private bool _isAddButton;
        private bool _isDeleteButton;
        #endregion

        #region Constructor
        public frmNguoiDung()
        {
            InitializeComponent();
            DataService.OpenConnection();
            _isAddButton = true;
            _isDeleteButton = true;
        }
        #endregion

        #region Load
        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            m_LoaiNguoiDungCtrl.HienThiDataGridViewComboBoxColumn(colMaLoai);
            m_GiaoVienCtrl.HienThiDataGridViewComboBoxColumn1(colMaGiaoVien);
            m_NguoiDungCtrl.HienThi(dGVNguoiDung, bindingNavigatorNguoiDung);
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

        public static byte[] encryptData(string data)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider md5Hasher = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] hashedBytes;
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(data));
            return hashedBytes;
        }
        public static string md5(string data)
        {
            return BitConverter.ToString(encryptData(data)).Replace("-", "").ToLower();
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dGVNguoiDung.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBoxEx.Show("Thông tin người dùng không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("colMaND")       == true &&
                KiemTraTruocKhiLuu("colMaLoai")     == true &&
                KiemTraTruocKhiLuu("colMaGiaoVien")      == true &&
                KiemTraTruocKhiLuu("colTenDNhap")   == true &&
                KiemTraTruocKhiLuu("colMatKhau")    == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_NguoiDungCtrl.LuuNguoiDung();
            }
        }
        #endregion

        #region DataError event
        private void dGVNguoiDung_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        #region Click event
        private void btnThemLoaiND_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormLoaiNguoiDung();
            m_LoaiNguoiDungCtrl.HienThiDataGridViewComboBoxColumn(colMaLoai);
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

                DataRow m_Row = m_NguoiDungCtrl.ThemDongMoi();
                m_Row["MaND"] = "ND" + quyDinh.LaySTT1(dGVNguoiDung.Rows.Count + 1);
                m_Row["MaLoai"] = "";
                m_Row["MaGiaoVien"] = "";
                m_Row["TenDNhap"] = "";
                m_Row["MatKhau"] = "";
                m_NguoiDungCtrl.ThemNguoiDung(m_Row);
                bindingNavigatorNguoiDung.BindingSource.MoveLast();
            }
            else
            {
                _Disable_Control(editing: false);
                m_LoaiNguoiDungCtrl.HienThiDataGridViewComboBoxColumn(colMaLoai);
                m_GiaoVienCtrl.HienThiDataGridViewComboBoxColumn(colMaGiaoVien);
                m_NguoiDungCtrl.HienThi(dGVNguoiDung, bindingNavigatorNguoiDung);
            }       
        }

        private void simpleButtonLuu_Click(object sender, EventArgs e)
        {
            if (simpleButtonLuu.Text == "Cập nhật (Alt+&U)")
            {
                if (KiemTraTruocKhiLuu("colMaND") == true &&
                KiemTraTruocKhiLuu("colMaLoai") == true &&
                KiemTraTruocKhiLuu("colMaGiaoVien") == true &&
                KiemTraTruocKhiLuu("colTenDNhap") == true &&
                KiemTraTruocKhiLuu("colMatKhau") == true)
                {
                    if (MsgboxUtil.YesNo("Bạn có chắc chắn muốn cập nhật không?")
                            == DialogResult.Yes)
                    {
                        m_NguoiDungCtrl.LuuNguoiDung();
                        MsgboxUtil.Success("Đã cập nhật thành công!");
                        m_LoaiNguoiDungCtrl.HienThiDataGridViewComboBoxColumn(colMaLoai);
                        m_GiaoVienCtrl.HienThiDataGridViewComboBoxColumn(colMaGiaoVien);
                        m_NguoiDungCtrl.HienThi(dGVNguoiDung, bindingNavigatorNguoiDung);
                        return;
                    }
                    else
                    {
                        m_LoaiNguoiDungCtrl.HienThiDataGridViewComboBoxColumn(colMaLoai);
                        m_GiaoVienCtrl.HienThiDataGridViewComboBoxColumn(colMaGiaoVien);
                        m_NguoiDungCtrl.HienThi(dGVNguoiDung, bindingNavigatorNguoiDung);
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            if (KiemTraTruocKhiLuu("colMaND") == true &&
                KiemTraTruocKhiLuu("colMaLoai") == true &&
                KiemTraTruocKhiLuu("colMaGiaoVien") == true &&
                KiemTraTruocKhiLuu("colTenDNhap") == true &&
                KiemTraTruocKhiLuu("colMatKhau") == true)
            {
                if (MsgboxUtil.YesNo("Bạn có chắc chắn muốn thêm người dùng này không?")
                       == DialogResult.Yes)
                {
                    bindingNavigatorPositionItem.Focus();
                    m_NguoiDungCtrl.LuuNguoiDung();
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