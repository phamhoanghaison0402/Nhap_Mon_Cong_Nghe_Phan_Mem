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
    public partial class frmHocSinh : XtraForm
    {
        #region Fields
        HocSinhCtrl     m_HocSinhCtrl       = new HocSinhCtrl();
        QuyDinh         quyDinh             = new QuyDinh();
        private bool _isAddButton;
        private bool _isDeleteButton;
        #endregion

        #region Constructor
        public frmHocSinh()
        {
            InitializeComponent();
            DataService.OpenConnection();
            _isAddButton = true;
            _isDeleteButton = true;
        }
        #endregion

        #region Load
        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            m_HocSinhCtrl.HienThi(dGVHocSinh, bindingNavigatorHocSinh);
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

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            if (simpleButtonThem.Enabled == false)
            {
                //simpleButtonThem.Enabled = true;
                
            }
            _Disable_Control(editing: false);
            m_HocSinhCtrl.HienThi(dGVHocSinh, bindingNavigatorHocSinh);
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dGVHocSinh.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBoxEx.Show("Thông tin học sinh " + row.Cells["colHoTen"].Value.ToString() + " không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        public Boolean KiemTraDoTuoiTruocKhiLuu(String doTuoiColumn)
        {
            foreach (DataGridViewRow row in dGVHocSinh.Rows)
            {
                if (row.Cells[doTuoiColumn].Value != null)
                {
                    DateTime ngaySinh = Convert.ToDateTime(row.Cells[doTuoiColumn].Value.ToString());
                    
                    if (quyDinh.KiemTraDoTuoi(ngaySinh) == false)
                    {
                        MessageBoxEx.Show("Tuổi học sinh " + row.Cells["colHoTen"].Value.ToString() + " không đúng quy định!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

      
        #endregion

        #region DataError event
        private void dGVHocSinh_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        #region Tìm kiếm học sinh
        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiemHocSinh();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                MsgboxUtil.Error("Bạn chưa nhập thông tin vào ô tìm kiếm.");
                return;
            }
            else
            {
                simpleButtonThem.Enabled = false;
                TimKiemHocSinh();
            }
           
        }

        void TimKiemHocSinh()
        {
            if (chkTimTheoMa.Checked == true)
            {
                m_HocSinhCtrl.TimTheoMa(txtTimKiem.Text);
            }
            else
            {
                m_HocSinhCtrl.TimTheoTen(txtTimKiem.Text);
            }
        }
        #endregion

        #region Click event
        private void dGVHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          /*  if (txtGioiTinh.Text == "True")
                ckbGTinhNu.Checked = true;
            else
                ckbGTinhNam.Checked = true; */
        }

        private void btnLuuVaoDS_Click(object sender, EventArgs e)
        {
          /*  bool gioiTinh = false;
            if (ckbGTinhNu.Checked == true)
                gioiTinh = true;

            if (txtMaHocSinh.Text               != "" &&
                txtTenHocSinh.Text              != "" &&
                txtEmail.Text                 != "" &&
                txtDiaChi.Text                != "" &&
                dtpNgaySinh.Value               != null)
            {
                if (quyDinh.KiemTraDoTuoi(dtpNgaySinh.Value) == true)
                {
                    m_HocSinhCtrl.LuuHocSinh(txtMaHocSinh.Text, txtTenHocSinh.Text, gioiTinh, dtpNgaySinh.Value, txtEmail.Text, txtDiaChi.Text);
                    m_HocSinhCtrl.HienThi(dGVHocSinh, bindingNavigatorHocSinh, txtMaHocSinh, txtTenHocSinh, txtGioiTinh, ckbGTinhNam, ckbGTinhNu, dtpNgaySinh, txtEmail, txtDiaChi);

                    bindingNavigatorHocSinh.BindingSource.MoveLast();
                    MessageBoxEx.Show("Thêm học sinh " + txtTenHocSinh.Text + " thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBoxEx.Show("Tuổi của học sinh " + txtTenHocSinh.Text + " không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBoxEx.Show("Giá trị của các ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); */
        } 
        #endregion

        private void simpleButtonThem_Click(object sender, EventArgs e)
        {
            if (_isAddButton)
            {
                _Disable_Control(editing: true);
              
                DataRow m_Row = m_HocSinhCtrl.ThemDongMoi();
                m_Row["MaHocSinh"] = "HS" + quyDinh.LaySTT1(dGVHocSinh.Rows.Count + 1);
                m_Row["HoTen"] = "";
                m_Row["GioiTinh"] = false;
                m_Row["NgaySinh"] = DateTime.Today;
                m_Row["Email"] = "";
                m_Row["DiaChi"] = "";

                m_HocSinhCtrl.ThemHocSinh(m_Row);
                bindingNavigatorHocSinh.BindingSource.MoveLast();
            }
            else
            {
                _Disable_Control(editing: false);
                m_HocSinhCtrl.HienThi(dGVHocSinh, bindingNavigatorHocSinh);
            }
        }

        private void simpleButtonLuu_Click(object sender, EventArgs e)
        {
                if (simpleButtonLuu.Text == "Cập nhật (Alt+&U)")
                {

                    if (KiemTraTruocKhiLuu("colMaHocSinh") == true &&
                    KiemTraTruocKhiLuu("colHoTen") == true &&
                    KiemTraTruocKhiLuu("colEmail") == true &&
                    KiemTraTruocKhiLuu("colDiaChi") == true)
                    {
                        if (MsgboxUtil.YesNo("Bạn có chắc chắn muốn cập nhật không?")
                             == DialogResult.Yes)
                         {
                             m_HocSinhCtrl.LuuHocSinh();
                             MsgboxUtil.Success("Đã cập nhật thành công!");
                             m_HocSinhCtrl.HienThi(dGVHocSinh, bindingNavigatorHocSinh);
                                return;
                        }
                        else
                        {
                            m_HocSinhCtrl.HienThi(dGVHocSinh, bindingNavigatorHocSinh);
                                return;
                        }
                    }
                    else
                    {
                        return;
                    }            
                }

                if (KiemTraTruocKhiLuu("colMaHocSinh") == true &&
                    KiemTraTruocKhiLuu("colHoTen") == true &&
                    KiemTraTruocKhiLuu("colEmail") == true &&
                    KiemTraTruocKhiLuu("colDiaChi") == true)
                {
                    if (KiemTraDoTuoiTruocKhiLuu("colNgaySinh") == true)
                    {
                        if (MsgboxUtil.YesNo("Bạn có chắc chắn muốn thêm học sinh này không?")
                          == DialogResult.Yes)
                        {
                            bindingNavigatorPositionItem.Focus();
                            m_HocSinhCtrl.LuuHocSinh();
                            MsgboxUtil.Success("Bạn đã lưu học sinh này thành công.");
                             _Disable_Control(editing: false);
                        }
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void navPaneLeft_Load(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    } 
}