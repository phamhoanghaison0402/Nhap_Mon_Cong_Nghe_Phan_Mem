using System;
using System.Data;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using QLHS_THPT.Controller;
using QLHS_THPT.Component;
using DevComponents.DotNetBar;
using System.Data.SqlClient;
using System.IO;

namespace QLHS_THPT
{
    public partial class frmMain : Office2007RibbonForm
    {
        #region Fields
        NguoiDungCtrl   m_NguoiDungCtrl = new NguoiDungCtrl();
        frmDoiMatKhau   m_FrmDoiMatKhau = null;
        frmDangNhap     m_FrmLogin      = null;
        frmNguoiDung    m_FrmNguoiDung  = null;
        frmConnection   m_Connection    = null;
        #endregion

        #region frmMain
        #region Constructor
        public frmMain()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmMain_Load(object sender, System.EventArgs e)
        {
            Default();
            if (DataService.OpenConnection())
            {
                Default();
                DangNhap();

                // Create the list of frequently used commands for the QAT Customize menu
                ribbonControl.QatFrequentCommands.Add(btnDangNhap);
                ribbonControl.QatFrequentCommands.Add(btnDangXuat);
                ribbonControl.QatFrequentCommands.Add(btnThoat);

                // Load Quick Access Toolbar layout if one is saved from last session...
            /*    Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\DevComponents\Ribbon");
                if (key != null)
                {
                    try
                    {
                        string layout = key.GetValue("RibbonPadCSLayout", "").ToString();
                        if (layout != "" && layout != null)
                            ribbonControl.QatLayout = layout;
                    }
                    finally
                    {
                        key.Close();
                    }
                }
                */
                // Pulse the Application Button
              //  buttonFile.Pulse(11);
            }
            else
            {
                Default();
                ReConnection();
            }
        }
        #endregion

        #region Kết nối lại CSDL
        public void ReConnection()
        {
            MessageBoxEx.Show("Lỗi kết nối đến cơ sở dữ liệu! Xin vui lòng thiết lập lại kết nối...", "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);

            if (m_Connection == null || m_Connection.IsDisposed)
                m_Connection = new frmConnection();

            if (m_Connection.ShowDialog() == DialogResult.OK)
            {
                MessageBoxEx.Show("Đã thiết lập kết nối cho lần chạy đầu tiên.\nHãy khởi động lại chương trình để thực thi kết nối!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                return;
        }
        #endregion

        #region Lưu lại trạng thái khi thoát chương trình
        private void frmMain_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Save Quick Access Toolbar layout if it has changed...
            if (ribbonControl.QatLayoutChanged)
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\DevComponents\Ribbon");
                try
                {
                    key.SetValue("RibbonPadCSLayout", ribbonControl.QatLayout);
                }
                finally
                {
                    key.Close();
                }
            }
        }
        #endregion
        #endregion

        #region Form show
        #region Menu start
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (m_FrmLogin == null || m_FrmLogin.IsDisposed)
                m_FrmLogin = new frmDangNhap();
            
            m_FrmLogin.txtUsername.Text = "";
            m_FrmLogin.txtPassword.Text = "";
            m_FrmLogin.lblUserError.Text = "";
            m_FrmLogin.lblPassError.Text = "";

            DangNhap();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            lblTenNguoiDung.Text = "Không có";
            Default();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (m_FrmDoiMatKhau == null || m_FrmDoiMatKhau.IsDisposed)
                m_FrmDoiMatKhau = new frmDoiMatKhau();

            m_FrmDoiMatKhau.txtOldPassword.Text = "";
            m_FrmDoiMatKhau.txtNewPassword.Text = "";
            m_FrmDoiMatKhau.txtReNPassword.Text = "";
            m_FrmDoiMatKhau.lblOldPassError.Text = "";
            m_FrmDoiMatKhau.lblNewPassError.Text = "";
            m_FrmDoiMatKhau.lblReNPassError.Text = "";

            DoiMatKhau();
        }

        private void btnQLNguoiDung_Click(object sender, EventArgs e)
        {
            if (m_FrmNguoiDung == null || m_FrmNguoiDung.IsDisposed)
            {
                m_FrmNguoiDung = new frmNguoiDung();
                m_FrmNguoiDung.MdiParent = this;
                m_FrmNguoiDung.Show();
            }
            else
                m_FrmNguoiDung.Activate();
        }

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
            if (MsgboxUtil.YesNo("Bạn có chắc chắn muốn sao lưu dữ liệu không?")
                       == DialogResult.Yes)
            {
                bool bBackUpStatus = true;

                Cursor.Current = Cursors.WaitCursor;

                if (Directory.Exists(@"c:\SQLBackup"))
                {
                    if (File.Exists(@"c:\SQLBackup\wcBackUp1.bak"))
                    {
                        if (MessageBox.Show(@"Do you want to replace it?", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            File.Delete(@"c:\SQLBackup\wcBackUp1.bak");
                        }
                        else
                            bBackUpStatus = false;
                    }
                }
                else
                    Directory.CreateDirectory(@"c:\SQLBackup");
                Directory.CreateDirectory(@"c:\SQLBackup");
                if (bBackUpStatus)
                {
                    //Connect to DB
                    SqlConnection connect;
                    string con = "Data Source = SONSE\\SQLEXPRESS; Initial Catalog=QLHS_THPT ;Integrated Security = True;";
                    connect = new SqlConnection(con);
                    connect.Open();
                    //----------------------------------------------------------------------------------------------------

                    //Execute SQL---------------
                    SqlCommand command;
                    command = new SqlCommand(@"backup database QLHS_THPT to disk ='c:\SQLBackup\wcBackUp1.bak' with init,stats=10", connect);
                    command.ExecuteNonQuery();
                    //-------------------------------------------------------------------------------------------------------------------------------

                    connect.Close();

                    MessageBox.Show("Sao lưu dữ liệu thành công", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                return;
            }
        }

        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            if (MsgboxUtil.YesNo("Bạn có chắc chắn muốn phục hồi dữ liệu không?")
                      == DialogResult.Yes)
            {
                if (restoreDialog.ShowDialog() == DialogResult.OK)
                {
                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("USE master RESTORE DATABASE " + Utilities.DatabaseName + " FROM DISK = '" + restoreDialog.FileName.ToString() + "'");
                    DataService data = new DataService();
                    data.Load(cmd);
                    MessageBoxEx.Show("Phục hồi dữ liệu thành công!", "RESTORE COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    return;
            }
            else
            {
                return;
            }
        }


      

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Menu quan ly
       
  
        private void btnHocKy_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormHocKy();
        }

        private void btnNamHoc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormKBNamHoc();
        }

    
      
    
       

        
        #endregion

        #region Menu thong ke
        private void btnKQHKTheoLop_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormKQHKTheoLop();
        }

        private void btnKQHKTheoMon_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormKQHKTheoMon();
        }

        private void btnKQCNTheoLop_Click(object sender, EventArgs e)
        {
            //ThamSo.ShowFormKQCNTheoLop();
        }

        private void btnKQCNTheoMon_Click(object sender, EventArgs e)
        {
           // ThamSo.ShowFormKQCNTheoMon();
        }

        private void btnDanhSachHocSinh_Click(object sender, EventArgs e)
        {
           // ThamSo.ShowFormDanhSachHocSinh();
        }

        private void btnDanhSachGiaoVien_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDanhSachLopHoc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormDanhSachLopHoc();
        }
        #endregion

        #region Tra cuu
        private void btnTimKiemHS_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormTimKiemHS();
        }

    
        #endregion

        #region Menu quy dinh
       // frmQuyDinh m_FrmQD = new frmQuyDinh();
       
        #endregion

        #region Menu giup do
        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider.HelpNamespace, HelpNavigator.TableOfContents);
        }

     
        #endregion
        #endregion

        #region Permissions
        #region DangNhap
        public void DangNhap()
        {
            Cont:
            if (m_FrmLogin == null || m_FrmLogin.IsDisposed)
                m_FrmLogin = new frmDangNhap();

            if (m_FrmLogin.ShowDialog() == DialogResult.OK)
            {
                if (m_FrmLogin.txtUsername.Text == "")
                {
                    m_FrmLogin.lblPassError.Text = "";
                    m_FrmLogin.lblUserError.Text = "Bạn chưa nhập tên!";
                    goto Cont;
                }

                if (m_FrmLogin.txtPassword.Text == "")
                {
                    m_FrmLogin.lblUserError.Text = "";
                    m_FrmLogin.lblPassError.Text = "Bạn chưa nhập mật khẩu!";
                    goto Cont;
                }

                int ketQua = m_NguoiDungCtrl.DangNhap(m_FrmLogin.txtUsername.Text, m_FrmLogin.txtPassword.Text);

                switch (ketQua)
                {
                    case 0:
                        m_FrmLogin.lblPassError.Text = "";
                        m_FrmLogin.lblUserError.Text = "Người dùng này không tồn tại!";
                        goto Cont;
                    case 1:
                        m_FrmLogin.lblUserError.Text = "";
                        m_FrmLogin.lblPassError.Text = "Mật khẩu không hợp lệ!";
                        goto Cont;
                    case 2:
                        lblTenNguoiDung.Text = Utilities.NguoiDung.TenND;
                        Permissions(Utilities.NguoiDung.LoaiND.MaLoai);
                        break;
                }
            }
            else
                return;
        }
        #endregion

        #region Phân quyền
        public void Permissions(String m_Per)
        {
            switch (m_Per)
            {
                case "LND001":  IsBGH();        break;
                case "LND002":  IsGiaoVien();   break;
                case "LND003":  IsGiaoVu();     break;
                default:        Default();      break;
            }
        }
        #endregion

        #region DoiMatKhau
        public void DoiMatKhau()
        {
            Cont:
            if (m_FrmDoiMatKhau.ShowDialog() == DialogResult.OK)
            {
                if (m_FrmDoiMatKhau.txtOldPassword.Text == "")
                {
                    m_FrmDoiMatKhau.lblOldPassError.Text = "Chưa nhập mật khẩu hiện tại!";
                    m_FrmDoiMatKhau.lblNewPassError.Text = "";
                    m_FrmDoiMatKhau.lblReNPassError.Text = "";
                    goto Cont;
                }

                if (m_FrmDoiMatKhau.txtNewPassword.Text == "")
                {
                    m_FrmDoiMatKhau.lblOldPassError.Text = "";
                    m_FrmDoiMatKhau.lblNewPassError.Text = "Chưa nhập mật khẩu mới!";
                    m_FrmDoiMatKhau.lblReNPassError.Text = "";
                    goto Cont;
                }

                if (m_FrmDoiMatKhau.txtReNPassword.Text == "")
                {
                    m_FrmDoiMatKhau.lblOldPassError.Text = "";
                    m_FrmDoiMatKhau.lblNewPassError.Text = "";
                    m_FrmDoiMatKhau.lblReNPassError.Text = "Chưa nhập xác nhận mật khẩu!";
                    goto Cont;
                }

                String m_Username = m_FrmLogin.txtUsername.Text;
                String m_Password = m_FrmLogin.txtPassword.Text;

                String m_OldPassword = m_FrmDoiMatKhau.txtOldPassword.Text;
                String m_NewPassword = m_FrmDoiMatKhau.txtNewPassword.Text;
                String m_ReNPassword = m_FrmDoiMatKhau.txtReNPassword.Text;

                if (m_Password != m_OldPassword)
                {
                    m_FrmDoiMatKhau.lblOldPassError.Text = "Nhập sai mật khẩu cũ!";
                    m_FrmDoiMatKhau.lblNewPassError.Text = "";
                    m_FrmDoiMatKhau.lblReNPassError.Text = "";
                    goto Cont;
                }
                else if (m_NewPassword != m_ReNPassword)
                {
                    m_FrmDoiMatKhau.lblOldPassError.Text = "";
                    m_FrmDoiMatKhau.lblNewPassError.Text = "";
                    m_FrmDoiMatKhau.lblReNPassError.Text = "Nhập xác nhận không khớp!";
                    goto Cont;
                }
                else
                {
                    m_NguoiDungCtrl.ChangePassword(m_Username, m_NewPassword);
                    MessageBoxEx.Show("Đổi mật khẩu thành công!", "PASSWORD CHANGED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                return;
        }
        #endregion

        #region Giao diện mặc định
        public void Default()
        {
            //True
            btnDangNhap.Enabled         = true;
            btnDangNhapContext.Enabled  = true;
            btnThoat.Enabled            = true;
            btnThoatContext.Enabled     = true;
        
            //False
            btnDangXuat.Enabled         = false;
            btnDangXuatContext.Enabled  = false;
            btnDoiMatKhau.Enabled       = false;
            btnDoiMatKhauContext.Enabled= false;
            btnQLNguoiDung.Enabled      = false;
            btnSaoLuu.Enabled           = false;
            btnPhucHoi.Enabled          = false;

            btnLopHoc.Enabled           = false;
            btnKhoiLop.Enabled          = false;
            btnHocKy.Enabled            = false;
            btnNamHoc.Enabled           = false;
            ribbonBarMonHoc.Enabled     = false;
            btnMonHoc.Enabled           = false;
            btnLoaiHinhKiemTra.Enabled             = false;
            btnChuongTrinhHoc.Enabled           = false;
            
          
            btnHocSinh.Enabled          = false;
            btnPhanLop.Enabled          = false;
            
            btnGiaoVien.Enabled         = false;
           

            btnKQHKTheoLop.Enabled      = false;
            btnKQHKTheoMon.Enabled      = false;
          
           
            btnDanhSachLopHoc.Enabled   = false;
            btnCapNhatDiem.Enabled = false;
            btnXemBangDiem.Enabled = false;
                btnBangDiem.Enabled = false;
                btnCapNhatChuongTrinh.Enabled = false;
                btnTimKiemHocSinh.Enabled = false;
                btnChuyenLop.Enabled = false;
                btnQuyDinh.Enabled = false;
         
        }
        #endregion

        #region Giao diện khi đăng nhập với quyền BGH
        public void IsBGH()
        {
            //False
            btnDangNhap.Enabled         = false;
            btnDangNhapContext.Enabled  = false;

            //True
            btnDangXuat.Enabled         = true;
            btnDangXuatContext.Enabled  = true;
            btnDoiMatKhau.Enabled       = true;
            btnDoiMatKhauContext.Enabled= true;
            btnQLNguoiDung.Enabled      = true;
            btnSaoLuu.Enabled           = true;
            btnPhucHoi.Enabled          = true;
            btnThoat.Enabled            = true;
            btnThoatContext.Enabled     = true;

            btnLopHoc.Enabled           = true;
            btnKhoiLop.Enabled          = true;
            btnHocKy.Enabled            = true;
            btnNamHoc.Enabled           = true;
            ribbonBarMonHoc.Enabled     = true;
            btnMonHoc.Enabled           = true;
            btnLoaiHinhKiemTra.Enabled             = true;
            btnChuongTrinhHoc.Enabled           = true;
            
           
            btnHocSinh.Enabled          = true;
            btnPhanLop.Enabled          = true;
            
            btnGiaoVien.Enabled         = true;
           

            btnKQHKTheoLop.Enabled      = true;
            btnKQHKTheoMon.Enabled      = true;
            btnQuyDinh.Enabled = true;
           
          
            btnDanhSachLopHoc.Enabled   = true;

            btnCapNhatDiem.Enabled = true;
            btnXemBangDiem.Enabled = true;
            btnBangDiem.Enabled = true;
            btnCapNhatChuongTrinh.Enabled = true;
            btnTimKiemHocSinh.Enabled = true;
            btnChuyenLop.Enabled = true;
         

          
        }
        #endregion

        #region Giao diện khi đăng nhập với quyền Giáo viên
        public void IsGiaoVien()
        {
            //True
            btnDangXuat.Enabled         = true;
            btnDangXuatContext.Enabled  = true;
            btnDoiMatKhau.Enabled       = true;
            btnDoiMatKhauContext.Enabled= true;
            btnThoat.Enabled            = true;
            btnThoatContext.Enabled     = true;

            btnQuyDinh.Enabled = false;
            btnTimKiemHocSinh.Enabled = true;

            ribbonBarMonHoc.Enabled     = true;
            btnMonHoc.Enabled           = false;
            btnLoaiHinhKiemTra.Enabled             = false;

            btnKQHKTheoLop.Enabled      = true;
            btnKQHKTheoMon.Enabled      = true;
          
           
           
            btnDanhSachLopHoc.Enabled   = true;

           

            //False
            btnDangNhap.Enabled         = false;
            btnDangNhapContext.Enabled  = false;
            btnQLNguoiDung.Enabled      = false;
            btnSaoLuu.Enabled           = false;
            btnPhucHoi.Enabled          = false;

            btnLopHoc.Enabled           = false;
            btnKhoiLop.Enabled          = false;
            btnHocKy.Enabled            = false;
            btnNamHoc.Enabled           = false;
            btnChuongTrinhHoc.Enabled           = false;
           
           
            btnHocSinh.Enabled          = false;
            btnPhanLop.Enabled          = false;
            
            btnGiaoVien.Enabled         = false;
            

        
        }
        #endregion

        #region Giao diện khi đăng nhập với quyền Giáo vụ
        public void IsGiaoVu()
        {
            //True
            btnDangXuat.Enabled         = true;
            btnDangXuatContext.Enabled  = true;
            btnDoiMatKhau.Enabled       = true;
            btnDoiMatKhauContext.Enabled= true;
            btnThoat.Enabled            = true;
            btnThoatContext.Enabled     = true;
            
            btnLopHoc.Enabled           = true;
            btnKhoiLop.Enabled          = true;
            btnHocKy.Enabled            = true;
            btnNamHoc.Enabled           = true;
            btnChuongTrinhHoc.Enabled           = true;
            
           
            ribbonBarMonHoc.Enabled     = true;
            btnMonHoc.Enabled           = true;
            btnLoaiHinhKiemTra.Enabled             = true;
            btnHocSinh.Enabled          = true;
            btnPhanLop.Enabled          = true;
           

            btnKQHKTheoLop.Enabled      = true;
            btnKQHKTheoMon.Enabled      = true;

            btnCapNhatDiem.Enabled = true;
            btnXemBangDiem.Enabled = true;
            btnBangDiem.Enabled = true;
            btnCapNhatChuongTrinh.Enabled = true;
            btnTimKiemHocSinh.Enabled = true;
            btnChuyenLop.Enabled = true;
            
            btnDanhSachLopHoc.Enabled   = true;

            btnGiaoVien.Enabled = true;
            //False
            btnDangNhap.Enabled         = false;
            btnDangNhapContext.Enabled  = false;
            btnQLNguoiDung.Enabled      = false;
            btnSaoLuu.Enabled           = false;
            btnPhucHoi.Enabled          = false;


            btnQuyDinh.Enabled = false;
        }
        #endregion

      
        #endregion

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormQuyDinhDauNam();
        }

        private void btnPhanLopHoc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormPhanLopHoc();
        }

        private void btnKBNamHoc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormKBNamHoc();
        }

        private void btnKhoiLop_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormKhoiLop();
        }

        private void btnLopHoc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormPhanLopHoc();
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormMonHoc();
        }

        private void btnLoaiHinhKiemTra_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormLoaiHinhKiemTra();
        }

        private void btnChuongTrinhHoc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormChuongTrinhHoc();
        }

        private void btnCapNhatChuongTrinh_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormCapNhatChuongTrinhHoc();
        }

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormHocSinh();
        }

        private void btnPhanLop_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormPhanLop();
        }

        private void btnBangDiem_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormNhapDiemChung();
        }

        private void btnXemBangDiem_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormXemBangDiem();
        }

        private void btnTimKiemHocSinh_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormTimKiemHocSinh();
        }

        private void btnChuyenLop_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormChuyenLop();
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormGiaoVien();
        }

        private void btnCapNhatDiem_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormCapNhatDiem();
        }  
    }
}