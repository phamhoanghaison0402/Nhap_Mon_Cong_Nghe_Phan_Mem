namespace QLHS_THPT
{
    partial class frmChuyenLop
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lVLopCu = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.colMaHocSinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListPhanLop = new System.Windows.Forms.ImageList(this.components);
            this.btnHienThiDSHSCu = new DevComponents.DotNetBar.ButtonX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.cmbHocKyCu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbLopCu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbKhoiLopCu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbNamHocCu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnChuyen = new DevComponents.DotNetBar.ButtonX();
            this.lVLopMoi = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.colMaHocSinhMoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTenMoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHienThiDSHSMoi = new DevComponents.DotNetBar.ButtonX();
            this.cmbHocKyMoi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.cmbLopMoi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.cmbKhoiLopMoi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cmbNamHocMoi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButtonDong = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonLuu = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lVLopCu
            // 
            // 
            // 
            // 
            this.lVLopCu.Border.Class = "ListViewBorder";
            this.lVLopCu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lVLopCu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaHocSinh,
            this.colHoTen});
            this.lVLopCu.DisabledBackColor = System.Drawing.Color.Empty;
            this.lVLopCu.FullRowSelect = true;
            this.lVLopCu.Location = new System.Drawing.Point(4, 229);
            this.lVLopCu.Name = "lVLopCu";
            this.lVLopCu.Size = new System.Drawing.Size(304, 221);
            this.lVLopCu.SmallImageList = this.imageListPhanLop;
            this.lVLopCu.TabIndex = 2;
            this.lVLopCu.UseCompatibleStateImageBehavior = false;
            this.lVLopCu.View = System.Windows.Forms.View.Details;
            // 
            // colMaHocSinh
            // 
            this.colMaHocSinh.Text = "Mã học sinh";
            this.colMaHocSinh.Width = 80;
            // 
            // colHoTen
            // 
            this.colHoTen.Text = "Họ tên";
            this.colHoTen.Width = 160;
            // 
            // imageListPhanLop
            // 
            this.imageListPhanLop.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListPhanLop.ImageSize = new System.Drawing.Size(1, 18);
            this.imageListPhanLop.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnHienThiDSHSCu
            // 
            this.btnHienThiDSHSCu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHienThiDSHSCu.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnHienThiDSHSCu.Location = new System.Drawing.Point(47, 139);
            this.btnHienThiDSHSCu.Name = "btnHienThiDSHSCu";
            this.btnHienThiDSHSCu.Size = new System.Drawing.Size(200, 23);
            this.btnHienThiDSHSCu.TabIndex = 11;
            this.btnHienThiDSHSCu.Text = "Hiển thị danh sách (Alt+&V)";
            this.btnHienThiDSHSCu.Click += new System.EventHandler(this.btnHienThiDSHSCu_Click);
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(8, 87);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(57, 20);
            this.labelX7.TabIndex = 5;
            this.labelX7.Text = "Học kỳ :";
            // 
            // cmbHocKyCu
            // 
            this.cmbHocKyCu.DisplayMember = "Text";
            this.cmbHocKyCu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHocKyCu.FormattingEnabled = true;
            this.cmbHocKyCu.ItemHeight = 15;
            this.cmbHocKyCu.Location = new System.Drawing.Point(8, 110);
            this.cmbHocKyCu.Name = "cmbHocKyCu";
            this.cmbHocKyCu.Size = new System.Drawing.Size(121, 21);
            this.cmbHocKyCu.TabIndex = 4;
            this.cmbHocKyCu.SelectedIndexChanged += new System.EventHandler(this.cmbHocKyCu_SelectedIndexChanged);
            // 
            // cmbLopCu
            // 
            this.cmbLopCu.DisplayMember = "Text";
            this.cmbLopCu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLopCu.FormattingEnabled = true;
            this.cmbLopCu.ItemHeight = 15;
            this.cmbLopCu.Location = new System.Drawing.Point(163, 110);
            this.cmbLopCu.Name = "cmbLopCu";
            this.cmbLopCu.Size = new System.Drawing.Size(121, 21);
            this.cmbLopCu.TabIndex = 3;
            this.cmbLopCu.SelectedIndexChanged += new System.EventHandler(this.cmbLopCu_SelectedIndexChanged);
            // 
            // cmbKhoiLopCu
            // 
            this.cmbKhoiLopCu.DisplayMember = "Text";
            this.cmbKhoiLopCu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKhoiLopCu.FormattingEnabled = true;
            this.cmbKhoiLopCu.ItemHeight = 15;
            this.cmbKhoiLopCu.Location = new System.Drawing.Point(163, 60);
            this.cmbKhoiLopCu.Name = "cmbKhoiLopCu";
            this.cmbKhoiLopCu.Size = new System.Drawing.Size(121, 21);
            this.cmbKhoiLopCu.TabIndex = 2;
            this.cmbKhoiLopCu.SelectedIndexChanged += new System.EventHandler(this.cmbKhoiLopCu_SelectedIndexChanged);
            // 
            // cmbNamHocCu
            // 
            this.cmbNamHocCu.DisplayMember = "Text";
            this.cmbNamHocCu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNamHocCu.FormattingEnabled = true;
            this.cmbNamHocCu.ItemHeight = 15;
            this.cmbNamHocCu.Location = new System.Drawing.Point(8, 60);
            this.cmbNamHocCu.Name = "cmbNamHocCu";
            this.cmbNamHocCu.Size = new System.Drawing.Size(121, 21);
            this.cmbNamHocCu.TabIndex = 1;
            this.cmbNamHocCu.SelectedIndexChanged += new System.EventHandler(this.cmbNamHocCu_SelectedIndexChanged);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(163, 88);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(43, 19);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Lớp:";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(163, 34);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(57, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Khối lớp:";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(8, 34);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(57, 20);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Năm học:";
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Image = global::QLHS_THPT.Properties.Resources.chuyenlopve;
            this.btnXoa.Location = new System.Drawing.Point(314, 373);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(55, 43);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Tooltip = "Xóa học sinh khỏi lớp mới";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChuyen
            // 
            this.btnChuyen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChuyen.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChuyen.Image = global::QLHS_THPT.Properties.Resources.chuyenlop;
            this.btnChuyen.Location = new System.Drawing.Point(314, 284);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(55, 43);
            this.btnChuyen.TabIndex = 1;
            this.btnChuyen.Tooltip = "Chuyển lớp";
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            // 
            // lVLopMoi
            // 
            // 
            // 
            // 
            this.lVLopMoi.Border.Class = "ListViewBorder";
            this.lVLopMoi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lVLopMoi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaHocSinhMoi,
            this.colHoTenMoi});
            this.lVLopMoi.DisabledBackColor = System.Drawing.Color.Empty;
            this.lVLopMoi.FullRowSelect = true;
            this.lVLopMoi.Location = new System.Drawing.Point(375, 229);
            this.lVLopMoi.Name = "lVLopMoi";
            this.lVLopMoi.Size = new System.Drawing.Size(297, 221);
            this.lVLopMoi.SmallImageList = this.imageListPhanLop;
            this.lVLopMoi.TabIndex = 5;
            this.lVLopMoi.UseCompatibleStateImageBehavior = false;
            this.lVLopMoi.View = System.Windows.Forms.View.Details;
            // 
            // colMaHocSinhMoi
            // 
            this.colMaHocSinhMoi.Text = "Mã học sinh";
            this.colMaHocSinhMoi.Width = 80;
            // 
            // colHoTenMoi
            // 
            this.colHoTenMoi.Text = "Họ tên";
            this.colHoTenMoi.Width = 170;
            // 
            // btnHienThiDSHSMoi
            // 
            this.btnHienThiDSHSMoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHienThiDSHSMoi.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnHienThiDSHSMoi.Location = new System.Drawing.Point(57, 139);
            this.btnHienThiDSHSMoi.Name = "btnHienThiDSHSMoi";
            this.btnHienThiDSHSMoi.Size = new System.Drawing.Size(191, 23);
            this.btnHienThiDSHSMoi.TabIndex = 11;
            this.btnHienThiDSHSMoi.Text = "Hiển thị danh sách (Alt+&V)";
            this.btnHienThiDSHSMoi.Click += new System.EventHandler(this.btnHienThiDSHSMoi_Click);
            // 
            // cmbHocKyMoi
            // 
            this.cmbHocKyMoi.DisplayMember = "Text";
            this.cmbHocKyMoi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHocKyMoi.FormattingEnabled = true;
            this.cmbHocKyMoi.ItemHeight = 15;
            this.cmbHocKyMoi.Location = new System.Drawing.Point(9, 112);
            this.cmbHocKyMoi.Name = "cmbHocKyMoi";
            this.cmbHocKyMoi.Size = new System.Drawing.Size(121, 21);
            this.cmbHocKyMoi.TabIndex = 5;
            this.cmbHocKyMoi.SelectedIndexChanged += new System.EventHandler(this.cmbHocKyMoi_SelectedIndexChanged);
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(5, 88);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(57, 20);
            this.labelX8.TabIndex = 4;
            this.labelX8.Text = "Học kỳ";
            // 
            // cmbLopMoi
            // 
            this.cmbLopMoi.DisplayMember = "Text";
            this.cmbLopMoi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLopMoi.FormattingEnabled = true;
            this.cmbLopMoi.ItemHeight = 15;
            this.cmbLopMoi.Location = new System.Drawing.Point(154, 112);
            this.cmbLopMoi.Name = "cmbLopMoi";
            this.cmbLopMoi.Size = new System.Drawing.Size(121, 21);
            this.cmbLopMoi.TabIndex = 3;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(154, 31);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(57, 23);
            this.labelX5.TabIndex = 0;
            this.labelX5.Text = "Khối lớp:";
            // 
            // cmbKhoiLopMoi
            // 
            this.cmbKhoiLopMoi.DisplayMember = "Text";
            this.cmbKhoiLopMoi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKhoiLopMoi.FormattingEnabled = true;
            this.cmbKhoiLopMoi.ItemHeight = 15;
            this.cmbKhoiLopMoi.Location = new System.Drawing.Point(154, 60);
            this.cmbKhoiLopMoi.Name = "cmbKhoiLopMoi";
            this.cmbKhoiLopMoi.Size = new System.Drawing.Size(121, 21);
            this.cmbKhoiLopMoi.TabIndex = 2;
            this.cmbKhoiLopMoi.SelectedIndexChanged += new System.EventHandler(this.cmbKhoiLopMoi_SelectedIndexChanged);
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(5, 35);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(57, 20);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "Năm học:";
            // 
            // cmbNamHocMoi
            // 
            this.cmbNamHocMoi.DisplayMember = "Text";
            this.cmbNamHocMoi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNamHocMoi.FormattingEnabled = true;
            this.cmbNamHocMoi.ItemHeight = 15;
            this.cmbNamHocMoi.Location = new System.Drawing.Point(9, 60);
            this.cmbNamHocMoi.Name = "cmbNamHocMoi";
            this.cmbNamHocMoi.Size = new System.Drawing.Size(121, 21);
            this.cmbNamHocMoi.TabIndex = 1;
            this.cmbNamHocMoi.SelectedIndexChanged += new System.EventHandler(this.cmbNamHocMoi_SelectedIndexChanged);
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(166, 87);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(57, 19);
            this.labelX6.TabIndex = 0;
            this.labelX6.Text = "Lớp:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButtonDong);
            this.panelControl1.Controls.Add(this.simpleButtonLuu);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 456);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(684, 55);
            this.panelControl1.TabIndex = 19;
            // 
            // simpleButtonDong
            // 
            this.simpleButtonDong.Image = global::QLHS_THPT.Properties.Resources.thoat_small;
            this.simpleButtonDong.Location = new System.Drawing.Point(541, 10);
            this.simpleButtonDong.Name = "simpleButtonDong";
            this.simpleButtonDong.Size = new System.Drawing.Size(109, 33);
            this.simpleButtonDong.TabIndex = 13;
            this.simpleButtonDong.Text = "Đóng (Alt+&C)";
            this.simpleButtonDong.Click += new System.EventHandler(this.simpleButtonDong_Click);
            // 
            // simpleButtonLuu
            // 
            this.simpleButtonLuu.Image = global::QLHS_THPT.Properties.Resources.them_small;
            this.simpleButtonLuu.Location = new System.Drawing.Point(75, 10);
            this.simpleButtonLuu.Name = "simpleButtonLuu";
            this.simpleButtonLuu.Size = new System.Drawing.Size(129, 33);
            this.simpleButtonLuu.TabIndex = 12;
            this.simpleButtonLuu.Text = "Lưu (Alt+&S)";
            this.simpleButtonLuu.Click += new System.EventHandler(this.simpleButtonLuu_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnHienThiDSHSCu);
            this.groupControl1.Controls.Add(this.labelX1);
            this.groupControl1.Controls.Add(this.cmbLopCu);
            this.groupControl1.Controls.Add(this.cmbHocKyCu);
            this.groupControl1.Controls.Add(this.labelX3);
            this.groupControl1.Controls.Add(this.cmbKhoiLopCu);
            this.groupControl1.Controls.Add(this.labelX7);
            this.groupControl1.Controls.Add(this.cmbNamHocCu);
            this.groupControl1.Controls.Add(this.labelX2);
            this.groupControl1.Location = new System.Drawing.Point(4, 52);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(304, 171);
            this.groupControl1.TabIndex = 20;
            this.groupControl1.Text = "Thông tin lớp cũ";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(684, 46);
            this.panelControl2.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(205, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "CHUYỂN LỚP HỌC SINH";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnHienThiDSHSMoi);
            this.groupControl2.Controls.Add(this.labelX4);
            this.groupControl2.Controls.Add(this.cmbLopMoi);
            this.groupControl2.Controls.Add(this.cmbHocKyMoi);
            this.groupControl2.Controls.Add(this.labelX6);
            this.groupControl2.Controls.Add(this.cmbKhoiLopMoi);
            this.groupControl2.Controls.Add(this.labelX5);
            this.groupControl2.Controls.Add(this.cmbNamHocMoi);
            this.groupControl2.Controls.Add(this.labelX8);
            this.groupControl2.Location = new System.Drawing.Point(375, 52);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(297, 171);
            this.groupControl2.TabIndex = 21;
            this.groupControl2.Text = "Thông tin lớp mới";
            // 
            // frmChuyenLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnChuyen);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lVLopMoi);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.lVLopCu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmChuyenLop";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHUYỂN LỚP CHO HỌC SINH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhanLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        #region Components

        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbKhoiLopMoi;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbNamHocMoi;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbLopMoi;
        private DevComponents.DotNetBar.Controls.ListViewEx lVLopCu;
        private DevComponents.DotNetBar.Controls.ListViewEx lVLopMoi;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnChuyen;
        private System.Windows.Forms.ImageList imageListPhanLop;
        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbHocKyMoi;
        private DevComponents.DotNetBar.LabelX labelX8;
        private System.Windows.Forms.ColumnHeader colMaHocSinh;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colMaHocSinhMoi;
        private System.Windows.Forms.ColumnHeader colHoTenMoi;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbHocKyCu;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbLopCu;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbKhoiLopCu;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbNamHocCu;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnHienThiDSHSCu;
        private DevComponents.DotNetBar.ButtonX btnHienThiDSHSMoi;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDong;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLuu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl2;

    }
}