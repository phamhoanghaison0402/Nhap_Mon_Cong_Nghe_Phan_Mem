namespace QLHS_THPT
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            System.Windows.Forms.DialogResult rs;
            rs = DevComponents.DotNetBar.MessageBoxEx.Show("Bạn có muốn thoát khỏi chương trình Quản lý học sinh không?", "THOÁT KHỎI CHƯƠNG TRÌNH?", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question);
            if (rs == System.Windows.Forms.DialogResult.Yes)
                base.Dispose(disposing);
            if (disposing && (components != null))
                components.Dispose();
        }

        #region Windows Form Designer generated code
        
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanelQuanLy = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarGiaoVien = new DevComponents.DotNetBar.RibbonBar();
            this.btnGiaoVien = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarHocSinh = new DevComponents.DotNetBar.RibbonBar();
            this.btnHocSinh = new DevComponents.DotNetBar.ButtonItem();
            this.btnPhanLop = new DevComponents.DotNetBar.ButtonItem();
            this.btnTimKiemHocSinh = new DevComponents.DotNetBar.ButtonItem();
            this.btnChuyenLop = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarDiem = new DevComponents.DotNetBar.RibbonBar();
            this.btnBangDiem = new DevComponents.DotNetBar.ButtonItem();
            this.btnXemBangDiem = new DevComponents.DotNetBar.ButtonItem();
            this.btnCapNhatDiem = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarChuongTrinhDaoTao = new DevComponents.DotNetBar.RibbonBar();
            this.btnChuongTrinhHoc = new DevComponents.DotNetBar.ButtonItem();
            this.btnCapNhatChuongTrinh = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarMonHoc = new DevComponents.DotNetBar.RibbonBar();
            this.btnMonHoc = new DevComponents.DotNetBar.ButtonItem();
            this.btnLoaiHinhKiemTra = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarLop = new DevComponents.DotNetBar.RibbonBar();
            this.btnKhoiLop = new DevComponents.DotNetBar.ButtonItem();
            this.btnLopHoc = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarNamHoc = new DevComponents.DotNetBar.RibbonBar();
            this.btnNamHoc = new DevComponents.DotNetBar.ButtonItem();
            this.btnHocKy = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanelThongKe = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarXuatDanhSach = new DevComponents.DotNetBar.RibbonBar();
            this.btnDanhSachLopHoc = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarKQHocKy = new DevComponents.DotNetBar.RibbonBar();
            this.btnKQHKTheoLop = new DevComponents.DotNetBar.ButtonItem();
            this.btnKQHKTheoMon = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanelQuyDinh = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarQuyDinh = new DevComponents.DotNetBar.RibbonBar();
            this.btnQuyDinh = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonTabQuanLy = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabThongKe = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabQuyDinh = new DevComponents.DotNetBar.RibbonTabItem();
            this.buttonFile = new DevComponents.DotNetBar.Office2007StartButton();
            this.menuFileContainer = new DevComponents.DotNetBar.ItemContainer();
            this.menuFileItems = new DevComponents.DotNetBar.ItemContainer();
            this.btnDangNhap = new DevComponents.DotNetBar.ButtonItem();
            this.btnDangXuat = new DevComponents.DotNetBar.ButtonItem();
            this.btnDoiMatKhau = new DevComponents.DotNetBar.ButtonItem();
            this.btnQLNguoiDung = new DevComponents.DotNetBar.ButtonItem();
            this.btnSaoLuu = new DevComponents.DotNetBar.ButtonItem();
            this.btnPhucHoi = new DevComponents.DotNetBar.ButtonItem();
            this.btnThoat = new DevComponents.DotNetBar.ButtonItem();
            this.qatCustomizeItem = new DevComponents.DotNetBar.QatCustomizeItem();
            this.ribbonTabItemGroup = new DevComponents.DotNetBar.RibbonTabItemGroup();
            this.bottomBar = new DevComponents.DotNetBar.Bar();
            this.lblTenNguoiDung = new DevComponents.DotNetBar.LabelX();
            this.lblNguoiDung = new DevComponents.DotNetBar.LabelX();
            this.tabStrip = new DevComponents.DotNetBar.TabStrip();
            this.mdiClient = new System.Windows.Forms.MdiClient();
            this.ctxMenuMain = new DevComponents.DotNetBar.ContextMenuBar();
            this.btnMenuMain = new DevComponents.DotNetBar.ButtonItem();
            this.btnDangNhapContext = new DevComponents.DotNetBar.ButtonItem();
            this.btnDangXuatContext = new DevComponents.DotNetBar.ButtonItem();
            this.btnDoiMatKhauContext = new DevComponents.DotNetBar.ButtonItem();
            this.btnThoatContext = new DevComponents.DotNetBar.ButtonItem();
            this.backupDialog = new System.Windows.Forms.SaveFileDialog();
            this.restoreDialog = new System.Windows.Forms.OpenFileDialog();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.superTooltip = new DevComponents.DotNetBar.SuperTooltip();
            this.ribbonControl.SuspendLayout();
            this.ribbonPanelQuanLy.SuspendLayout();
            this.ribbonPanelThongKe.SuspendLayout();
            this.ribbonPanelQuyDinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomBar)).BeginInit();
            this.bottomBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctxMenuMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.ribbonControl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl.CaptionVisible = true;
            this.ribbonControl.Controls.Add(this.ribbonPanelQuanLy);
            this.ribbonControl.Controls.Add(this.ribbonPanelQuyDinh);
            this.ribbonControl.Controls.Add(this.ribbonPanelThongKe);
            this.ribbonControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ribbonControl.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabQuanLy,
            this.ribbonTabThongKe,
            this.ribbonTabQuyDinh});
            this.ribbonControl.KeyTipsFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControl.Location = new System.Drawing.Point(5, 1);
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonFile,
            this.qatCustomizeItem});
            this.ribbonControl.Size = new System.Drawing.Size(890, 150);
            this.ribbonControl.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonControl.SystemText.MaximizeRibbonText = "Cực &đại menu Ribbon";
            this.ribbonControl.SystemText.MinimizeRibbonText = "Cực &tiểu menu Ribbon";
            this.ribbonControl.SystemText.QatAddItemText = "&Thêm vào thanh công cụ truy xuất nhanh";
            this.ribbonControl.SystemText.QatCustomizeMenuLabel = "Thanh công cụ truy xuất nhanh";
            this.ribbonControl.SystemText.QatCustomizeText = "&Tùy chọn đối tượng hiển thị...";
            this.ribbonControl.SystemText.QatDialogAddButton = "&Thêm >>";
            this.ribbonControl.SystemText.QatDialogCancelButton = "Hủy bỏ";
            this.ribbonControl.SystemText.QatDialogCaption = "TÙY CHỌN ĐỐI TƯỢNG HIỂN THỊ";
            this.ribbonControl.SystemText.QatDialogCategoriesLabel = "&Chọn đối tượng từ danh sách:";
            this.ribbonControl.SystemText.QatDialogOkButton = "Đồng ý";
            this.ribbonControl.SystemText.QatDialogPlacementCheckbox = "&Dời thanh công cụ xuống dưới menu Ribbon";
            this.ribbonControl.SystemText.QatDialogRemoveButton = "&Loại bỏ";
            this.ribbonControl.SystemText.QatPlaceAboveRibbonText = "&Dời thanh công cụ lên trên menu Ribbon";
            this.ribbonControl.SystemText.QatPlaceBelowRibbonText = "&Dời thanh công cụ xuống dưới menu Ribbon";
            this.ribbonControl.SystemText.QatRemoveItemText = "&Loại bỏ khỏi thanh công cụ truy xuất nhanh";
            this.ribbonControl.TabGroupHeight = 14;
            this.ribbonControl.TabGroups.AddRange(new DevComponents.DotNetBar.RibbonTabItemGroup[] {
            this.ribbonTabItemGroup});
            this.ribbonControl.TabGroupsVisible = true;
            this.ribbonControl.TabIndex = 0;
            // 
            // ribbonPanelQuanLy
            // 
            this.ribbonPanelQuanLy.AutoSize = true;
            this.ribbonPanelQuanLy.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ctxMenuMain.SetContextMenuEx(this.ribbonPanelQuanLy, this.btnMenuMain);
            this.ribbonPanelQuanLy.Controls.Add(this.ribbonBarGiaoVien);
            this.ribbonPanelQuanLy.Controls.Add(this.ribbonBarHocSinh);
            this.ribbonPanelQuanLy.Controls.Add(this.ribbonBarDiem);
            this.ribbonPanelQuanLy.Controls.Add(this.ribbonBarChuongTrinhDaoTao);
            this.ribbonPanelQuanLy.Controls.Add(this.ribbonBarMonHoc);
            this.ribbonPanelQuanLy.Controls.Add(this.ribbonBarLop);
            this.ribbonPanelQuanLy.Controls.Add(this.ribbonBarNamHoc);
            this.ribbonPanelQuanLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelQuanLy.Location = new System.Drawing.Point(0, 57);
            this.ribbonPanelQuanLy.Name = "ribbonPanelQuanLy";
            this.ribbonPanelQuanLy.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelQuanLy.Size = new System.Drawing.Size(890, 91);
            // 
            // 
            // 
            this.ribbonPanelQuanLy.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanelQuanLy.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanelQuanLy.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanelQuanLy.TabIndex = 1;
            // 
            // ribbonBarGiaoVien
            // 
            this.ribbonBarGiaoVien.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarGiaoVien.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarGiaoVien.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBarGiaoVien.ContainerControlProcessDialogKey = true;
            this.ribbonBarGiaoVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarGiaoVien.DragDropSupport = true;
            this.ribbonBarGiaoVien.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnGiaoVien});
            this.ribbonBarGiaoVien.Location = new System.Drawing.Point(815, 0);
            this.ribbonBarGiaoVien.Name = "ribbonBarGiaoVien";
            this.ribbonBarGiaoVien.Size = new System.Drawing.Size(100, 88);
            this.ribbonBarGiaoVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBarGiaoVien.TabIndex = 10;
            this.ribbonBarGiaoVien.Text = "Giáo Viên";
            // 
            // 
            // 
            this.ribbonBarGiaoVien.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarGiaoVien.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.Image = global::QLHS_THPT.Properties.Resources.giaovien;
            this.btnGiaoVien.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.SplitButton = true;
            this.btnGiaoVien.SubItemsExpandWidth = 50;
            this.btnGiaoVien.Text = "Hồ Sơ Giáo Viên";
            this.btnGiaoVien.Tooltip = "Giáo viên";
            this.btnGiaoVien.Click += new System.EventHandler(this.btnGiaoVien_Click);
            // 
            // ribbonBarHocSinh
            // 
            this.ribbonBarHocSinh.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarHocSinh.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarHocSinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBarHocSinh.ContainerControlProcessDialogKey = true;
            this.ribbonBarHocSinh.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarHocSinh.DragDropSupport = true;
            this.ribbonBarHocSinh.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnHocSinh,
            this.btnPhanLop,
            this.btnTimKiemHocSinh,
            this.btnChuyenLop});
            this.ribbonBarHocSinh.Location = new System.Drawing.Point(622, 0);
            this.ribbonBarHocSinh.Name = "ribbonBarHocSinh";
            this.ribbonBarHocSinh.Size = new System.Drawing.Size(193, 88);
            this.ribbonBarHocSinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBarHocSinh.TabIndex = 9;
            this.ribbonBarHocSinh.Text = "Học Sinh";
            // 
            // 
            // 
            this.ribbonBarHocSinh.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarHocSinh.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnHocSinh
            // 
            this.btnHocSinh.Image = global::QLHS_THPT.Properties.Resources.pupils;
            this.btnHocSinh.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnHocSinh.Name = "btnHocSinh";
            this.btnHocSinh.SplitButton = true;
            this.btnHocSinh.Text = "Học sinh";
            this.btnHocSinh.Tooltip = "Học sinh";
            this.btnHocSinh.Click += new System.EventHandler(this.btnHocSinh_Click);
            // 
            // btnPhanLop
            // 
            this.btnPhanLop.Image = global::QLHS_THPT.Properties.Resources.phanlop;
            this.btnPhanLop.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPhanLop.Name = "btnPhanLop";
            this.btnPhanLop.SplitButton = true;
            this.btnPhanLop.Text = "<div align=\"center\">Xếp<br />lớp</div>";
            this.btnPhanLop.Tooltip = "Phân lớp";
            this.btnPhanLop.Click += new System.EventHandler(this.btnPhanLop_Click);
            // 
            // btnTimKiemHocSinh
            // 
            this.btnTimKiemHocSinh.Image = global::QLHS_THPT.Properties.Resources.tracuuhocsinh;
            this.btnTimKiemHocSinh.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnTimKiemHocSinh.Name = "btnTimKiemHocSinh";
            this.btnTimKiemHocSinh.SplitButton = true;
            this.btnTimKiemHocSinh.Text = "Tìm Kiếm Học sinh";
            this.btnTimKiemHocSinh.Tooltip = "Học sinh";
            this.btnTimKiemHocSinh.Click += new System.EventHandler(this.btnTimKiemHocSinh_Click);
            // 
            // btnChuyenLop
            // 
            this.btnChuyenLop.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenLop.Image")));
            this.btnChuyenLop.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnChuyenLop.Name = "btnChuyenLop";
            this.btnChuyenLop.SplitButton = true;
            this.btnChuyenLop.Text = "<div align=\"center\">Chuyển<br />lớp</div>";
            this.btnChuyenLop.Tooltip = "Phân lớp";
            this.btnChuyenLop.Click += new System.EventHandler(this.btnChuyenLop_Click);
            // 
            // ribbonBarDiem
            // 
            this.ribbonBarDiem.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarDiem.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarDiem.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBarDiem.ContainerControlProcessDialogKey = true;
            this.ribbonBarDiem.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarDiem.DragDropSupport = true;
            this.ribbonBarDiem.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnBangDiem,
            this.btnXemBangDiem,
            this.btnCapNhatDiem});
            this.ribbonBarDiem.Location = new System.Drawing.Point(472, 0);
            this.ribbonBarDiem.Name = "ribbonBarDiem";
            this.ribbonBarDiem.Size = new System.Drawing.Size(150, 88);
            this.ribbonBarDiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBarDiem.TabIndex = 8;
            this.ribbonBarDiem.Text = "Điểm";
            // 
            // 
            // 
            this.ribbonBarDiem.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarDiem.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnBangDiem
            // 
            this.btnBangDiem.Image = global::QLHS_THPT.Properties.Resources.diem;
            this.btnBangDiem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBangDiem.Name = "btnBangDiem";
            this.btnBangDiem.SplitButton = true;
            this.btnBangDiem.Text = "Nhập điểm";
            this.btnBangDiem.Tooltip = "Nhập điểm ";
            this.btnBangDiem.Click += new System.EventHandler(this.btnBangDiem_Click);
            // 
            // btnXemBangDiem
            // 
            this.btnXemBangDiem.Image = global::QLHS_THPT.Properties.Resources.xemdiem1;
            this.btnXemBangDiem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnXemBangDiem.Name = "btnXemBangDiem";
            this.btnXemBangDiem.SplitButton = true;
            this.btnXemBangDiem.Text = "Xem điểm";
            this.btnXemBangDiem.Tooltip = "Xem bảng điểm lớp";
            this.btnXemBangDiem.Click += new System.EventHandler(this.btnXemBangDiem_Click);
            // 
            // btnCapNhatDiem
            // 
            this.btnCapNhatDiem.Image = global::QLHS_THPT.Properties.Resources.capnhatdiem;
            this.btnCapNhatDiem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCapNhatDiem.Name = "btnCapNhatDiem";
            this.btnCapNhatDiem.SplitButton = true;
            this.btnCapNhatDiem.Text = "<div align=\"center\">Cập nhật<br/>điểm</div>";
            this.btnCapNhatDiem.Click += new System.EventHandler(this.btnCapNhatDiem_Click);
            // 
            // ribbonBarChuongTrinhDaoTao
            // 
            this.ribbonBarChuongTrinhDaoTao.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarChuongTrinhDaoTao.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarChuongTrinhDaoTao.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBarChuongTrinhDaoTao.ContainerControlProcessDialogKey = true;
            this.ribbonBarChuongTrinhDaoTao.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarChuongTrinhDaoTao.DragDropSupport = true;
            this.ribbonBarChuongTrinhDaoTao.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnChuongTrinhHoc,
            this.btnCapNhatChuongTrinh});
            this.ribbonBarChuongTrinhDaoTao.Location = new System.Drawing.Point(295, 0);
            this.ribbonBarChuongTrinhDaoTao.Name = "ribbonBarChuongTrinhDaoTao";
            this.ribbonBarChuongTrinhDaoTao.Size = new System.Drawing.Size(177, 88);
            this.ribbonBarChuongTrinhDaoTao.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBarChuongTrinhDaoTao.TabIndex = 5;
            this.ribbonBarChuongTrinhDaoTao.Text = "Chương Trình Đào Tạo";
            // 
            // 
            // 
            this.ribbonBarChuongTrinhDaoTao.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarChuongTrinhDaoTao.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnChuongTrinhHoc
            // 
            this.btnChuongTrinhHoc.Image = global::QLHS_THPT.Properties.Resources.ketqua;
            this.btnChuongTrinhHoc.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnChuongTrinhHoc.Name = "btnChuongTrinhHoc";
            this.btnChuongTrinhHoc.SplitButton = true;
            this.btnChuongTrinhHoc.Text = "<div align=\"center\">Chương trình học<br/></div>";
            this.btnChuongTrinhHoc.Tooltip = "Chương Trình Học";
            this.btnChuongTrinhHoc.Click += new System.EventHandler(this.btnChuongTrinhHoc_Click);
            // 
            // btnCapNhatChuongTrinh
            // 
            this.btnCapNhatChuongTrinh.Image = global::QLHS_THPT.Properties.Resources.capnhatchuongtrinh;
            this.btnCapNhatChuongTrinh.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCapNhatChuongTrinh.Name = "btnCapNhatChuongTrinh";
            this.btnCapNhatChuongTrinh.SplitButton = true;
            this.btnCapNhatChuongTrinh.Text = "<div align=\"center\">Cập nhật<br/>chương trình học</div>";
            this.btnCapNhatChuongTrinh.Tooltip = "Lớp học";
            this.btnCapNhatChuongTrinh.Click += new System.EventHandler(this.btnCapNhatChuongTrinh_Click);
            // 
            // ribbonBarMonHoc
            // 
            this.ribbonBarMonHoc.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarMonHoc.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarMonHoc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBarMonHoc.ContainerControlProcessDialogKey = true;
            this.ribbonBarMonHoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarMonHoc.DragDropSupport = true;
            this.ribbonBarMonHoc.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnMonHoc,
            this.btnLoaiHinhKiemTra});
            this.ribbonBarMonHoc.Location = new System.Drawing.Point(190, 0);
            this.ribbonBarMonHoc.Name = "ribbonBarMonHoc";
            this.ribbonBarMonHoc.Size = new System.Drawing.Size(105, 88);
            this.ribbonBarMonHoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBarMonHoc.TabIndex = 4;
            this.ribbonBarMonHoc.Text = "Môn Học";
            // 
            // 
            // 
            this.ribbonBarMonHoc.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarMonHoc.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Image = global::QLHS_THPT.Properties.Resources.monhoc1;
            this.btnMonHoc.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.SplitButton = true;
            this.btnMonHoc.Text = "<div align=\"center\">Môn<br/>học</div>";
            this.btnMonHoc.Tooltip = "Năm học";
            this.btnMonHoc.Click += new System.EventHandler(this.btnMonHoc_Click);
            // 
            // btnLoaiHinhKiemTra
            // 
            this.btnLoaiHinhKiemTra.Image = global::QLHS_THPT.Properties.Resources.loaihinhkiemtra;
            this.btnLoaiHinhKiemTra.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnLoaiHinhKiemTra.Name = "btnLoaiHinhKiemTra";
            this.btnLoaiHinhKiemTra.SplitButton = true;
            this.btnLoaiHinhKiemTra.Text = "<div align=\"center\">Loại hình<br/>kiểm tra</div>";
            this.btnLoaiHinhKiemTra.Tooltip = "Học kỳ";
            this.btnLoaiHinhKiemTra.Click += new System.EventHandler(this.btnLoaiHinhKiemTra_Click);
            // 
            // ribbonBarLop
            // 
            this.ribbonBarLop.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarLop.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarLop.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBarLop.ContainerControlProcessDialogKey = true;
            this.ribbonBarLop.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarLop.DragDropSupport = true;
            this.ribbonBarLop.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnKhoiLop,
            this.btnLopHoc});
            this.ribbonBarLop.Location = new System.Drawing.Point(103, 0);
            this.ribbonBarLop.Name = "ribbonBarLop";
            this.ribbonBarLop.Size = new System.Drawing.Size(87, 88);
            this.ribbonBarLop.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBarLop.TabIndex = 3;
            this.ribbonBarLop.Text = "Khối Lớp - Lớp";
            // 
            // 
            // 
            this.ribbonBarLop.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarLop.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnKhoiLop
            // 
            this.btnKhoiLop.Image = global::QLHS_THPT.Properties.Resources.khoilop;
            this.btnKhoiLop.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnKhoiLop.Name = "btnKhoiLop";
            this.btnKhoiLop.SplitButton = true;
            this.btnKhoiLop.Text = "<div align=\"center\">Khối<br/>lớp</div>";
            this.btnKhoiLop.Tooltip = "Năm học";
            this.btnKhoiLop.Click += new System.EventHandler(this.btnKhoiLop_Click);
            // 
            // btnLopHoc
            // 
            this.btnLopHoc.Image = global::QLHS_THPT.Properties.Resources.lophoc1;
            this.btnLopHoc.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnLopHoc.Name = "btnLopHoc";
            this.btnLopHoc.SplitButton = true;
            this.btnLopHoc.Text = "<div align=\"center\">Lớp<br/>học</div>";
            this.btnLopHoc.Tooltip = "Năm học";
            this.btnLopHoc.Click += new System.EventHandler(this.btnLopHoc_Click);
            // 
            // ribbonBarNamHoc
            // 
            this.ribbonBarNamHoc.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarNamHoc.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarNamHoc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBarNamHoc.ContainerControlProcessDialogKey = true;
            this.ribbonBarNamHoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarNamHoc.DragDropSupport = true;
            this.ribbonBarNamHoc.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnNamHoc,
            this.btnHocKy});
            this.ribbonBarNamHoc.Location = new System.Drawing.Point(3, 0);
            this.ribbonBarNamHoc.Name = "ribbonBarNamHoc";
            this.ribbonBarNamHoc.Size = new System.Drawing.Size(100, 88);
            this.ribbonBarNamHoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBarNamHoc.TabIndex = 2;
            this.ribbonBarNamHoc.Text = "Năm Học ";
            // 
            // 
            // 
            this.ribbonBarNamHoc.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarNamHoc.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnNamHoc
            // 
            this.btnNamHoc.Image = global::QLHS_THPT.Properties.Resources.namhoc;
            this.btnNamHoc.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnNamHoc.Name = "btnNamHoc";
            this.btnNamHoc.SplitButton = true;
            this.btnNamHoc.Text = "<div align=\"center\">Năm<br/>học</div>";
            this.btnNamHoc.Tooltip = "Năm học";
            this.btnNamHoc.Click += new System.EventHandler(this.btnNamHoc_Click);
            // 
            // btnHocKy
            // 
            this.btnHocKy.Image = global::QLHS_THPT.Properties.Resources.hocky;
            this.btnHocKy.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnHocKy.Name = "btnHocKy";
            this.btnHocKy.SplitButton = true;
            this.btnHocKy.Text = "<div align=\"center\">Học<br/>kỳ</div>";
            this.btnHocKy.Tooltip = "Học kỳ";
            this.btnHocKy.Click += new System.EventHandler(this.btnHocKy_Click);
            // 
            // ribbonPanelThongKe
            // 
            this.ribbonPanelThongKe.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ctxMenuMain.SetContextMenuEx(this.ribbonPanelThongKe, this.btnMenuMain);
            this.ribbonPanelThongKe.Controls.Add(this.ribbonBarXuatDanhSach);
            this.ribbonPanelThongKe.Controls.Add(this.ribbonBarKQHocKy);
            this.ribbonPanelThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelThongKe.Location = new System.Drawing.Point(0, 57);
            this.ribbonPanelThongKe.Name = "ribbonPanelThongKe";
            this.ribbonPanelThongKe.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelThongKe.Size = new System.Drawing.Size(890, 91);
            // 
            // 
            // 
            this.ribbonPanelThongKe.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanelThongKe.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanelThongKe.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanelThongKe.TabIndex = 3;
            this.ribbonPanelThongKe.Visible = false;
            // 
            // ribbonBarXuatDanhSach
            // 
            this.ribbonBarXuatDanhSach.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarXuatDanhSach.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarXuatDanhSach.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBarXuatDanhSach.ContainerControlProcessDialogKey = true;
            this.ribbonBarXuatDanhSach.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarXuatDanhSach.DragDropSupport = true;
            this.ribbonBarXuatDanhSach.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDanhSachLopHoc});
            this.ribbonBarXuatDanhSach.Location = new System.Drawing.Point(214, 0);
            this.ribbonBarXuatDanhSach.Name = "ribbonBarXuatDanhSach";
            this.ribbonBarXuatDanhSach.Size = new System.Drawing.Size(94, 88);
            this.ribbonBarXuatDanhSach.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBarXuatDanhSach.TabIndex = 3;
            this.ribbonBarXuatDanhSach.Text = "Xuất Danh Sách";
            // 
            // 
            // 
            this.ribbonBarXuatDanhSach.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarXuatDanhSach.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnDanhSachLopHoc
            // 
            this.btnDanhSachLopHoc.Image = global::QLHS_THPT.Properties.Resources.dslophoc;
            this.btnDanhSachLopHoc.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDanhSachLopHoc.Name = "btnDanhSachLopHoc";
            this.btnDanhSachLopHoc.SplitButton = true;
            this.btnDanhSachLopHoc.Text = "Danh sách học sinh";
            this.btnDanhSachLopHoc.Tooltip = "Danh sách học sinh";
            this.btnDanhSachLopHoc.Click += new System.EventHandler(this.btnDanhSachLopHoc_Click);
            // 
            // ribbonBarKQHocKy
            // 
            this.ribbonBarKQHocKy.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarKQHocKy.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarKQHocKy.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBarKQHocKy.ContainerControlProcessDialogKey = true;
            this.ribbonBarKQHocKy.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarKQHocKy.DragDropSupport = true;
            this.ribbonBarKQHocKy.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnKQHKTheoLop,
            this.btnKQHKTheoMon});
            this.ribbonBarKQHocKy.Location = new System.Drawing.Point(3, 0);
            this.ribbonBarKQHocKy.Name = "ribbonBarKQHocKy";
            this.ribbonBarKQHocKy.Size = new System.Drawing.Size(211, 88);
            this.ribbonBarKQHocKy.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBarKQHocKy.TabIndex = 1;
            this.ribbonBarKQHocKy.Text = "Xuất Báo Cáo";
            // 
            // 
            // 
            this.ribbonBarKQHocKy.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarKQHocKy.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnKQHKTheoLop
            // 
            this.btnKQHKTheoLop.Image = global::QLHS_THPT.Properties.Resources.kqhockytheolop;
            this.btnKQHKTheoLop.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnKQHKTheoLop.Name = "btnKQHKTheoLop";
            this.btnKQHKTheoLop.SplitButton = true;
            this.btnKQHKTheoLop.Text = "<div align=\"center\">Báo Cáo Tổng Kết<br/>Theo Học Kỳ</div>";
            this.btnKQHKTheoLop.Tooltip = "Báo Cáo Tổng Kết Học Kỳ";
            this.btnKQHKTheoLop.Click += new System.EventHandler(this.btnKQHKTheoLop_Click);
            // 
            // btnKQHKTheoMon
            // 
            this.btnKQHKTheoMon.Image = global::QLHS_THPT.Properties.Resources.kqhockytheomon;
            this.btnKQHKTheoMon.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnKQHKTheoMon.Name = "btnKQHKTheoMon";
            this.btnKQHKTheoMon.SplitButton = true;
            this.btnKQHKTheoMon.Text = "<div align=\"center\">Báo Cáo Tổng Kết<br/>Theo Môn Học</div>";
            this.btnKQHKTheoMon.Tooltip = "Báo Cáo Tổng Kết Môn Học";
            this.btnKQHKTheoMon.Click += new System.EventHandler(this.btnKQHKTheoMon_Click);
            // 
            // ribbonPanelQuyDinh
            // 
            this.ribbonPanelQuyDinh.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ctxMenuMain.SetContextMenuEx(this.ribbonPanelQuyDinh, this.btnMenuMain);
            this.ribbonPanelQuyDinh.Controls.Add(this.ribbonBarQuyDinh);
            this.ribbonPanelQuyDinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelQuyDinh.Location = new System.Drawing.Point(0, 57);
            this.ribbonPanelQuyDinh.Name = "ribbonPanelQuyDinh";
            this.ribbonPanelQuyDinh.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelQuyDinh.Size = new System.Drawing.Size(890, 91);
            // 
            // 
            // 
            this.ribbonPanelQuyDinh.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanelQuyDinh.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanelQuyDinh.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanelQuyDinh.TabIndex = 3;
            this.ribbonPanelQuyDinh.Visible = false;
            // 
            // ribbonBarQuyDinh
            // 
            this.ribbonBarQuyDinh.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarQuyDinh.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarQuyDinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBarQuyDinh.ContainerControlProcessDialogKey = true;
            this.ribbonBarQuyDinh.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarQuyDinh.DragDropSupport = true;
            this.ribbonBarQuyDinh.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnQuyDinh});
            this.ribbonBarQuyDinh.Location = new System.Drawing.Point(3, 0);
            this.ribbonBarQuyDinh.Name = "ribbonBarQuyDinh";
            this.ribbonBarQuyDinh.Size = new System.Drawing.Size(68, 88);
            this.ribbonBarQuyDinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBarQuyDinh.TabIndex = 1;
            this.ribbonBarQuyDinh.Text = "Quy Định";
            // 
            // 
            // 
            this.ribbonBarQuyDinh.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarQuyDinh.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnQuyDinh
            // 
            this.btnQuyDinh.Image = global::QLHS_THPT.Properties.Resources.tttruonghoc;
            this.btnQuyDinh.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnQuyDinh.Name = "btnQuyDinh";
            this.btnQuyDinh.SplitButton = true;
            this.btnQuyDinh.Text = "<div align=\"center\">Quy định<br/>của trường</div>";
            this.btnQuyDinh.Tooltip = "Quy định chung của trường";
            this.btnQuyDinh.Click += new System.EventHandler(this.buttonItem1_Click);
            // 
            // ribbonTabQuanLy
            // 
            this.ribbonTabQuanLy.Checked = true;
            this.ribbonTabQuanLy.Name = "ribbonTabQuanLy";
            this.ribbonTabQuanLy.Panel = this.ribbonPanelQuanLy;
            this.ribbonTabQuanLy.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2);
            this.ribbonTabQuanLy.Text = "&Quản Lý";
            this.ribbonTabQuanLy.Tooltip = "Quản lý (F2)";
            // 
            // ribbonTabThongKe
            // 
            this.ribbonTabThongKe.Name = "ribbonTabThongKe";
            this.ribbonTabThongKe.Panel = this.ribbonPanelThongKe;
            this.ribbonTabThongKe.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F3);
            this.ribbonTabThongKe.Text = "&Báo Cáo";
            this.ribbonTabThongKe.Tooltip = "Báo Cáo (F3)";
            // 
            // ribbonTabQuyDinh
            // 
            this.ribbonTabQuyDinh.Name = "ribbonTabQuyDinh";
            this.ribbonTabQuyDinh.Panel = this.ribbonPanelQuyDinh;
            this.ribbonTabQuyDinh.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.ribbonTabQuyDinh.Text = "&Quy Định";
            this.ribbonTabQuyDinh.Tooltip = "Quy định (F5)";
            // 
            // buttonFile
            // 
            this.buttonFile.AutoExpandOnClick = true;
            this.buttonFile.CanCustomize = false;
            this.buttonFile.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.buttonFile.Image = global::QLHS_THPT.Properties.Resources.start;
            this.buttonFile.ImagePaddingHorizontal = 2;
            this.buttonFile.ImagePaddingVertical = 2;
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.ShowSubItems = false;
            this.buttonFile.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.menuFileContainer});
            this.buttonFile.Text = "F&ile";
            this.buttonFile.Tooltip = "Nút điều khiển chương trình";
            // 
            // menuFileContainer
            // 
            // 
            // 
            // 
            this.menuFileContainer.BackgroundStyle.Class = "RibbonFileMenuContainer";
            this.menuFileContainer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.menuFileContainer.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.menuFileContainer.Name = "menuFileContainer";
            this.menuFileContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.menuFileItems});
            // 
            // 
            // 
            this.menuFileContainer.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // menuFileItems
            // 
            // 
            // 
            // 
            this.menuFileItems.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer";
            this.menuFileItems.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.menuFileItems.ItemSpacing = 5;
            this.menuFileItems.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.menuFileItems.MinimumSize = new System.Drawing.Size(120, 0);
            this.menuFileItems.Name = "menuFileItems";
            this.menuFileItems.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDangNhap,
            this.btnDangXuat,
            this.btnDoiMatKhau,
            this.btnQLNguoiDung,
            this.btnSaoLuu,
            this.btnPhucHoi,
            this.btnThoat});
            // 
            // 
            // 
            this.menuFileItems.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDangNhap.Image = global::QLHS_THPT.Properties.Resources.dangnhap;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.SubItemsExpandWidth = 24;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDangXuat.Image = global::QLHS_THPT.Properties.Resources.dangxuat;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.SubItemsExpandWidth = 24;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BeginGroup = true;
            this.btnDoiMatKhau.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDoiMatKhau.Image = global::QLHS_THPT.Properties.Resources.doimatkhau;
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.SubItemsExpandWidth = 24;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnQLNguoiDung
            // 
            this.btnQLNguoiDung.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnQLNguoiDung.Image = global::QLHS_THPT.Properties.Resources.quanlynguoidung;
            this.btnQLNguoiDung.Name = "btnQLNguoiDung";
            this.btnQLNguoiDung.SubItemsExpandWidth = 24;
            this.btnQLNguoiDung.Text = "Quản lý người dùng";
            this.btnQLNguoiDung.Click += new System.EventHandler(this.btnQLNguoiDung_Click);
            // 
            // btnSaoLuu
            // 
            this.btnSaoLuu.BeginGroup = true;
            this.btnSaoLuu.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSaoLuu.Image = global::QLHS_THPT.Properties.Resources.saoluudulieu;
            this.btnSaoLuu.Name = "btnSaoLuu";
            this.btnSaoLuu.SubItemsExpandWidth = 24;
            this.btnSaoLuu.Text = "Sao lưu dữ liệu";
            this.btnSaoLuu.Click += new System.EventHandler(this.btnSaoLuu_Click);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnPhucHoi.Image = global::QLHS_THPT.Properties.Resources.phuchoidulieu;
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.SubItemsExpandWidth = 24;
            this.btnPhucHoi.Text = "Phục hồi dữ liệu";
            this.btnPhucHoi.Click += new System.EventHandler(this.btnPhucHoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BeginGroup = true;
            this.btnThoat.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnThoat.Image = global::QLHS_THPT.Properties.Resources.thoat;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.SubItemsExpandWidth = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // qatCustomizeItem
            // 
            this.qatCustomizeItem.Name = "qatCustomizeItem";
            this.qatCustomizeItem.Tooltip = "Thanh công cụ truy xuất nhanh";
            // 
            // ribbonTabItemGroup
            // 
            this.ribbonTabItemGroup.Color = DevComponents.DotNetBar.eRibbonTabGroupColor.Orange;
            this.ribbonTabItemGroup.GroupTitle = "Tab Group";
            this.ribbonTabItemGroup.Name = "ribbonTabItemGroup";
            // 
            // 
            // 
            this.ribbonTabItemGroup.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.ribbonTabItemGroup.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.ribbonTabItemGroup.Style.BackColorGradientAngle = 90;
            this.ribbonTabItemGroup.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonTabItemGroup.Style.BorderBottomWidth = 1;
            this.ribbonTabItemGroup.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(58)))), ((int)(((byte)(59)))));
            this.ribbonTabItemGroup.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonTabItemGroup.Style.BorderLeftWidth = 1;
            this.ribbonTabItemGroup.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonTabItemGroup.Style.BorderRightWidth = 1;
            this.ribbonTabItemGroup.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonTabItemGroup.Style.BorderTopWidth = 1;
            this.ribbonTabItemGroup.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonTabItemGroup.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.ribbonTabItemGroup.Style.TextColor = System.Drawing.Color.Black;
            this.ribbonTabItemGroup.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // bottomBar
            // 
            this.bottomBar.AccessibleDescription = "DotNetBar Bar (bottomBar)";
            this.bottomBar.AccessibleName = "DotNetBar Bar";
            this.bottomBar.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.bottomBar.AlwaysDisplayDockTab = true;
            this.bottomBar.AntiAlias = true;
            this.bottomBar.BarType = DevComponents.DotNetBar.eBarType.StatusBar;
            this.ctxMenuMain.SetContextMenuEx(this.bottomBar, this.btnMenuMain);
            this.bottomBar.Controls.Add(this.lblTenNguoiDung);
            this.bottomBar.Controls.Add(this.lblNguoiDung);
            this.bottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bottomBar.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.ResizeHandle;
            this.bottomBar.ItemSpacing = 2;
            this.bottomBar.Location = new System.Drawing.Point(5, 366);
            this.bottomBar.Name = "bottomBar";
            this.bottomBar.Size = new System.Drawing.Size(890, 26);
            this.bottomBar.Stretch = true;
            this.bottomBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.bottomBar.TabIndex = 7;
            this.bottomBar.TabStop = false;
            this.bottomBar.Text = "barStatus";
            // 
            // lblTenNguoiDung
            // 
            this.lblTenNguoiDung.AutoSize = true;
            this.lblTenNguoiDung.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblTenNguoiDung.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTenNguoiDung.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNguoiDung.ForeColor = System.Drawing.Color.Red;
            this.lblTenNguoiDung.Location = new System.Drawing.Point(145, 5);
            this.lblTenNguoiDung.Name = "lblTenNguoiDung";
            this.lblTenNguoiDung.Size = new System.Drawing.Size(0, 0);
            this.lblTenNguoiDung.TabIndex = 0;
            // 
            // lblNguoiDung
            // 
            this.lblNguoiDung.AutoSize = true;
            this.lblNguoiDung.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblNguoiDung.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguoiDung.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblNguoiDung.Location = new System.Drawing.Point(0, 5);
            this.lblNguoiDung.Name = "lblNguoiDung";
            this.lblNguoiDung.Size = new System.Drawing.Size(144, 15);
            this.lblNguoiDung.TabIndex = 0;
            this.lblNguoiDung.Text = "Người dùng đang đăng nhập:";
            // 
            // tabStrip
            // 
            this.tabStrip.AutoSelectAttachedControl = true;
            this.tabStrip.CanReorderTabs = true;
            this.tabStrip.CloseButtonOnTabsVisible = true;
            this.tabStrip.CloseButtonPosition = DevComponents.DotNetBar.eTabCloseButtonPosition.Right;
            this.tabStrip.CloseButtonVisible = false;
            this.ctxMenuMain.SetContextMenuEx(this.tabStrip, this.btnMenuMain);
            this.tabStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabStrip.Location = new System.Drawing.Point(5, 151);
            this.tabStrip.MdiForm = this;
            this.tabStrip.MdiTabbedDocuments = true;
            this.tabStrip.Name = "tabStrip";
            this.tabStrip.SelectedTab = null;
            this.tabStrip.SelectedTabFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabStrip.Size = new System.Drawing.Size(890, 26);
            this.tabStrip.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document;
            this.tabStrip.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top;
            this.tabStrip.TabIndex = 1;
            this.tabStrip.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabStrip.Text = "tabStrip";
            // 
            // mdiClient
            // 
            this.mdiClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.mdiClient.BackgroundImage = global::QLHS_THPT.Properties.Resources.TruongMoi;
            this.mdiClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mdiClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mdiClient.Location = new System.Drawing.Point(5, 177);
            this.mdiClient.Name = "mdiClient";
            this.mdiClient.Size = new System.Drawing.Size(890, 189);
            this.mdiClient.TabIndex = 2;
            // 
            // ctxMenuMain
            // 
            this.ctxMenuMain.AntiAlias = true;
            this.ctxMenuMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxMenuMain.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnMenuMain});
            this.ctxMenuMain.Location = new System.Drawing.Point(363, 267);
            this.ctxMenuMain.Name = "ctxMenuMain";
            this.ctxMenuMain.Size = new System.Drawing.Size(75, 25);
            this.ctxMenuMain.Stretch = true;
            this.ctxMenuMain.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ctxMenuMain.TabIndex = 8;
            this.ctxMenuMain.TabStop = false;
            this.ctxMenuMain.Text = "ctxMenu";
            // 
            // btnMenuMain
            // 
            this.btnMenuMain.AutoExpandOnClick = true;
            this.btnMenuMain.Name = "btnMenuMain";
            this.btnMenuMain.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnMenuMain.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDangNhapContext,
            this.btnDangXuatContext,
            this.btnDoiMatKhauContext,
            this.btnThoatContext});
            this.btnMenuMain.Text = "Menu";
            // 
            // btnDangNhapContext
            // 
            this.btnDangNhapContext.Image = global::QLHS_THPT.Properties.Resources.dangnhapcontext;
            this.btnDangNhapContext.Name = "btnDangNhapContext";
            this.btnDangNhapContext.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlL);
            this.btnDangNhapContext.Text = "Đăng nhập";
            this.btnDangNhapContext.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnDangXuatContext
            // 
            this.btnDangXuatContext.Image = global::QLHS_THPT.Properties.Resources.dangxuatcontext;
            this.btnDangXuatContext.Name = "btnDangXuatContext";
            this.btnDangXuatContext.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlO);
            this.btnDangXuatContext.Text = "Đăng xuất hệ thống";
            this.btnDangXuatContext.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnDoiMatKhauContext
            // 
            this.btnDoiMatKhauContext.Image = global::QLHS_THPT.Properties.Resources.doimatkhaucontext;
            this.btnDoiMatKhauContext.Name = "btnDoiMatKhauContext";
            this.btnDoiMatKhauContext.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlP);
            this.btnDoiMatKhauContext.Text = "Đổi mật khẩu";
            this.btnDoiMatKhauContext.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnThoatContext
            // 
            this.btnThoatContext.Image = global::QLHS_THPT.Properties.Resources.exit;
            this.btnThoatContext.Name = "btnThoatContext";
            this.btnThoatContext.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.AltF4);
            this.btnThoatContext.Text = "Thoát chương trình";
            this.btnThoatContext.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // backupDialog
            // 
            this.backupDialog.DefaultExt = "*.BAK";
            this.backupDialog.FileName = "QLHocSinhTHPT";
            this.backupDialog.Filter = "Backup files (*.BAK)|*.BAK";
            this.backupDialog.FilterIndex = 2;
            this.backupDialog.Title = "SAO LƯU DỮ LIỆU";
            // 
            // restoreDialog
            // 
            this.restoreDialog.DefaultExt = "*.BAK";
            this.restoreDialog.FileName = "QLHocSinhTHPT.BAK";
            this.restoreDialog.Filter = "Backup files (*.BAK)|*.BAK";
            this.restoreDialog.FilterIndex = 2;
            this.restoreDialog.Title = "PHỤC HỒI DỮ LIỆU";
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "QLHocSinhTHPT.chm";
            // 
            // superTooltip
            // 
            this.superTooltip.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTooltip.DefaultTooltipSettings = new DevComponents.DotNetBar.SuperTooltipInfo("", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray);
            // 
            // frmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.BackgroundImage = global::QLHS_THPT.Properties.Resources.TruongMoi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 394);
            this.Controls.Add(this.ctxMenuMain);
            this.Controls.Add(this.tabStrip);
            this.Controls.Add(this.ribbonControl);
            this.Controls.Add(this.bottomBar);
            this.Controls.Add(this.mdiClient);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmMain_Closing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ribbonControl.ResumeLayout(false);
            this.ribbonControl.PerformLayout();
            this.ribbonPanelQuanLy.ResumeLayout(false);
            this.ribbonPanelThongKe.ResumeLayout(false);
            this.ribbonPanelQuyDinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bottomBar)).EndInit();
            this.bottomBar.ResumeLayout(false);
            this.bottomBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctxMenuMain)).EndInit();
            this.ResumeLayout(false);

        }
        
        #endregion

        #region Components
        private System.Windows.Forms.MdiClient mdiClient;
        private System.Windows.Forms.SaveFileDialog backupDialog;
        private System.Windows.Forms.OpenFileDialog restoreDialog;
        private System.Windows.Forms.HelpProvider helpProvider;
        private DevComponents.DotNetBar.SuperTooltip superTooltip;
        private DevComponents.DotNetBar.RibbonControl ribbonControl;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabQuanLy;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabThongKe;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabQuyDinh;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanelThongKe;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanelQuyDinh;
        private DevComponents.DotNetBar.ItemContainer menuFileContainer;
        private DevComponents.DotNetBar.Office2007StartButton buttonFile;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem;
        private DevComponents.DotNetBar.RibbonBar ribbonBarKQHocKy;
        private DevComponents.DotNetBar.ButtonItem btnKQHKTheoLop;
        private DevComponents.DotNetBar.RibbonBar ribbonBarQuyDinh;
        private DevComponents.DotNetBar.RibbonTabItemGroup ribbonTabItemGroup;
        private DevComponents.DotNetBar.Bar bottomBar;
        private DevComponents.DotNetBar.RibbonBar ribbonBarNamHoc;
        private DevComponents.DotNetBar.ButtonItem btnNamHoc;
        private DevComponents.DotNetBar.ButtonItem btnKQHKTheoMon;
        private DevComponents.DotNetBar.TabStrip tabStrip;
        private DevComponents.DotNetBar.ItemContainer menuFileItems;
        private DevComponents.DotNetBar.ButtonItem btnDangNhap;
        private DevComponents.DotNetBar.ButtonItem btnDangXuat;
        private DevComponents.DotNetBar.ButtonItem btnDoiMatKhau;
        private DevComponents.DotNetBar.ButtonItem btnQLNguoiDung;
        private DevComponents.DotNetBar.ButtonItem btnSaoLuu;
        private DevComponents.DotNetBar.ButtonItem btnPhucHoi;
        private DevComponents.DotNetBar.ButtonItem btnThoat;
        private DevComponents.DotNetBar.LabelX lblNguoiDung;
        private DevComponents.DotNetBar.RibbonBar ribbonBarXuatDanhSach;
        private DevComponents.DotNetBar.ButtonItem btnDanhSachLopHoc;
        private DevComponents.DotNetBar.ContextMenuBar ctxMenuMain;
        private DevComponents.DotNetBar.ButtonItem btnMenuMain;
        private DevComponents.DotNetBar.ButtonItem btnDangNhapContext;
        private DevComponents.DotNetBar.ButtonItem btnDangXuatContext;
        private DevComponents.DotNetBar.ButtonItem btnDoiMatKhauContext;
        private DevComponents.DotNetBar.LabelX lblTenNguoiDung;
        private DevComponents.DotNetBar.ButtonItem btnThoatContext;
        #endregion

        private DevComponents.DotNetBar.ButtonItem btnQuyDinh;
        private DevComponents.DotNetBar.ButtonItem btnHocKy;
        private DevComponents.DotNetBar.RibbonBar ribbonBarMonHoc;
        private DevComponents.DotNetBar.ButtonItem btnMonHoc;
        private DevComponents.DotNetBar.ButtonItem btnLoaiHinhKiemTra;
        private DevComponents.DotNetBar.RibbonBar ribbonBarLop;
        private DevComponents.DotNetBar.ButtonItem btnKhoiLop;
        private DevComponents.DotNetBar.ButtonItem btnLopHoc;
        private DevComponents.DotNetBar.RibbonBar ribbonBarChuongTrinhDaoTao;
        private DevComponents.DotNetBar.ButtonItem btnChuongTrinhHoc;
        private DevComponents.DotNetBar.ButtonItem btnCapNhatChuongTrinh;
        private DevComponents.DotNetBar.RibbonBar ribbonBarDiem;
        private DevComponents.DotNetBar.ButtonItem btnBangDiem;
        private DevComponents.DotNetBar.ButtonItem btnXemBangDiem;
        private DevComponents.DotNetBar.RibbonBar ribbonBarGiaoVien;
        private DevComponents.DotNetBar.ButtonItem btnGiaoVien;
        private DevComponents.DotNetBar.RibbonBar ribbonBarHocSinh;
        private DevComponents.DotNetBar.ButtonItem btnHocSinh;
        private DevComponents.DotNetBar.ButtonItem btnPhanLop;
        private DevComponents.DotNetBar.ButtonItem btnTimKiemHocSinh;
        private DevComponents.DotNetBar.ButtonItem btnChuyenLop;
        public DevComponents.DotNetBar.RibbonPanel ribbonPanelQuanLy;
        private DevComponents.DotNetBar.ButtonItem btnCapNhatDiem;
    }
}