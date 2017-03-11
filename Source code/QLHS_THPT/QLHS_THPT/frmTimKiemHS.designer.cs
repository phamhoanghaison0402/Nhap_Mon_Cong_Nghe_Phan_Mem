namespace QLHS_THPT
{
    partial class frmTimKiemHS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiemHS));
            this.groupBoxDanhSach = new System.Windows.Forms.GroupBox();
            this.dGVKetQuaTimKiem = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colMaHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDanToc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNamHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemTBHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorKetQuaTimKiem = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtHoTen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnTimKiem = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.label01 = new System.Windows.Forms.Label();
            this.btnHienThiDanhSach = new DevComponents.DotNetBar.ButtonX();
            this.cmbNamHoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbLop = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label03 = new System.Windows.Forms.Label();
            this.label02 = new System.Windows.Forms.Label();
            this.cmbHocKy = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButtonDong = new DevExpress.XtraEditors.SimpleButton();
            this.panelControlLeft = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVKetQuaTimKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorKetQuaTimKiem)).BeginInit();
            this.bindingNavigatorKetQuaTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlLeft)).BeginInit();
            this.panelControlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDanhSach
            // 
            this.groupBoxDanhSach.Controls.Add(this.dGVKetQuaTimKiem);
            this.groupBoxDanhSach.Controls.Add(this.bindingNavigatorKetQuaTimKiem);
            this.groupBoxDanhSach.Location = new System.Drawing.Point(185, 52);
            this.groupBoxDanhSach.Name = "groupBoxDanhSach";
            this.groupBoxDanhSach.Size = new System.Drawing.Size(1114, 400);
            this.groupBoxDanhSach.TabIndex = 2;
            this.groupBoxDanhSach.TabStop = false;
            this.groupBoxDanhSach.Text = "Kết quả tìm kiếm";
            // 
            // dGVKetQuaTimKiem
            // 
            this.dGVKetQuaTimKiem.AllowUserToAddRows = false;
            this.dGVKetQuaTimKiem.AllowUserToDeleteRows = false;
            this.dGVKetQuaTimKiem.AllowUserToResizeColumns = false;
            this.dGVKetQuaTimKiem.AllowUserToResizeRows = false;
            this.dGVKetQuaTimKiem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dGVKetQuaTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGVKetQuaTimKiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHocSinh,
            this.colHoTen,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colNoiSinh,
            this.colTenDanToc,
            this.colTenLop,
            this.colTenGiaoVien,
            this.colHocKy,
            this.colNamHoc,
            this.colDiemTBHocKy});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVKetQuaTimKiem.DefaultCellStyle = dataGridViewCellStyle1;
            this.dGVKetQuaTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVKetQuaTimKiem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dGVKetQuaTimKiem.Location = new System.Drawing.Point(3, 52);
            this.dGVKetQuaTimKiem.Name = "dGVKetQuaTimKiem";
            this.dGVKetQuaTimKiem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGVKetQuaTimKiem.Size = new System.Drawing.Size(1108, 345);
            this.dGVKetQuaTimKiem.TabIndex = 4;
            // 
            // colMaHocSinh
            // 
            this.colMaHocSinh.DataPropertyName = "MaHocSinh";
            this.colMaHocSinh.HeaderText = "Mã Học Sinh";
            this.colMaHocSinh.Name = "colMaHocSinh";
            this.colMaHocSinh.ReadOnly = true;
            this.colMaHocSinh.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMaHocSinh.Width = 80;
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Họ Và Tên";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            this.colHoTen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colHoTen.Width = 120;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.DataPropertyName = "GioiTinh";
            this.colGioiTinh.HeaderText = "Giới Tính Nữ";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.ReadOnly = true;
            this.colGioiTinh.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colGioiTinh.ToolTipText = "Nam: không check; Nữ: check";
            this.colGioiTinh.Width = 70;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.DataPropertyName = "NgaySinh";
            this.colNgaySinh.HeaderText = "Ngày Sinh";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.ReadOnly = true;
            this.colNgaySinh.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNgaySinh.Width = 80;
            // 
            // colNoiSinh
            // 
            this.colNoiSinh.DataPropertyName = "DiaChi";
            this.colNoiSinh.HeaderText = "Địa Chỉ";
            this.colNoiSinh.Name = "colNoiSinh";
            this.colNoiSinh.ReadOnly = true;
            this.colNoiSinh.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colTenDanToc
            // 
            this.colTenDanToc.DataPropertyName = "Email";
            this.colTenDanToc.HeaderText = "Email";
            this.colTenDanToc.Name = "colTenDanToc";
            this.colTenDanToc.ReadOnly = true;
            this.colTenDanToc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colTenLop
            // 
            this.colTenLop.DataPropertyName = "TenLop";
            this.colTenLop.HeaderText = "Tên Lớp";
            this.colTenLop.Name = "colTenLop";
            this.colTenLop.ReadOnly = true;
            this.colTenLop.Width = 70;
            // 
            // colTenGiaoVien
            // 
            this.colTenGiaoVien.DataPropertyName = "TenGiaoVien";
            this.colTenGiaoVien.HeaderText = "Giáo Viên Chủ Nhiệm";
            this.colTenGiaoVien.Name = "colTenGiaoVien";
            this.colTenGiaoVien.ReadOnly = true;
            this.colTenGiaoVien.Width = 130;
            // 
            // colHocKy
            // 
            this.colHocKy.DataPropertyName = "TenHocKy";
            this.colHocKy.HeaderText = "Học Kỳ";
            this.colHocKy.Name = "colHocKy";
            this.colHocKy.ReadOnly = true;
            this.colHocKy.Width = 70;
            // 
            // colNamHoc
            // 
            this.colNamHoc.DataPropertyName = "TenNamHoc";
            this.colNamHoc.HeaderText = "Năm Học";
            this.colNamHoc.Name = "colNamHoc";
            this.colNamHoc.ReadOnly = true;
            // 
            // colDiemTBHocKy
            // 
            this.colDiemTBHocKy.DataPropertyName = "DiemTBHocKy";
            this.colDiemTBHocKy.HeaderText = "Điểm Trung Bình Học Kỳ";
            this.colDiemTBHocKy.Name = "colDiemTBHocKy";
            this.colDiemTBHocKy.ReadOnly = true;
            this.colDiemTBHocKy.Width = 130;
            // 
            // bindingNavigatorKetQuaTimKiem
            // 
            this.bindingNavigatorKetQuaTimKiem.AddNewItem = null;
            this.bindingNavigatorKetQuaTimKiem.AutoSize = false;
            this.bindingNavigatorKetQuaTimKiem.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorKetQuaTimKiem.CountItemFormat = "của {0}";
            this.bindingNavigatorKetQuaTimKiem.DeleteItem = null;
            this.bindingNavigatorKetQuaTimKiem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigatorKetQuaTimKiem.Location = new System.Drawing.Point(3, 17);
            this.bindingNavigatorKetQuaTimKiem.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorKetQuaTimKiem.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorKetQuaTimKiem.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorKetQuaTimKiem.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorKetQuaTimKiem.Name = "bindingNavigatorKetQuaTimKiem";
            this.bindingNavigatorKetQuaTimKiem.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorKetQuaTimKiem.Size = new System.Drawing.Size(1108, 35);
            this.bindingNavigatorKetQuaTimKiem.TabIndex = 3;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 32);
            this.bindingNavigatorCountItem.Text = "của {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Tổng số dòng trong danh sách";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorMoveFirstItem.Text = "Đến đầu danh sách";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorMovePreviousItem.Text = "Trở lại dòng trước";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Vị trí hiện tại";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorMoveNextItem.Text = "Tới dòng kế tiếp";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorMoveLastItem.Text = "Đến cuối danh sách";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // txtHoTen
            // 
            // 
            // 
            // 
            this.txtHoTen.Border.Class = "TextBoxBorder";
            this.txtHoTen.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHoTen.ButtonCustom.Tooltip = "";
            this.txtHoTen.ButtonCustom2.Tooltip = "";
            this.txtHoTen.Location = new System.Drawing.Point(7, 46);
            this.txtHoTen.MaxLength = 30;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(156, 21);
            this.txtHoTen.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimKiem.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnTimKiem.Location = new System.Drawing.Point(8, 83);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(155, 23);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "Tìm kiếm (Alt+&F)";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên:";
            // 
            // label01
            // 
            this.label01.AutoSize = true;
            this.label01.Location = new System.Drawing.Point(5, 31);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(52, 13);
            this.label01.TabIndex = 9;
            this.label01.Text = "Năm học:";
            // 
            // btnHienThiDanhSach
            // 
            this.btnHienThiDanhSach.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHienThiDanhSach.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnHienThiDanhSach.Location = new System.Drawing.Point(8, 185);
            this.btnHienThiDanhSach.Name = "btnHienThiDanhSach";
            this.btnHienThiDanhSach.Size = new System.Drawing.Size(156, 23);
            this.btnHienThiDanhSach.TabIndex = 15;
            this.btnHienThiDanhSach.Text = "Hiển thị danh sách học sinh";
            this.btnHienThiDanhSach.Click += new System.EventHandler(this.btnHienThiDanhSach_Click);
            // 
            // cmbNamHoc
            // 
            this.cmbNamHoc.DisplayMember = "Text";
            this.cmbNamHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNamHoc.FormattingEnabled = true;
            this.cmbNamHoc.ItemHeight = 15;
            this.cmbNamHoc.Location = new System.Drawing.Point(8, 47);
            this.cmbNamHoc.Name = "cmbNamHoc";
            this.cmbNamHoc.Size = new System.Drawing.Size(156, 21);
            this.cmbNamHoc.TabIndex = 10;
            this.cmbNamHoc.SelectedIndexChanged += new System.EventHandler(this.cmbNamHoc_SelectedIndexChanged);
            // 
            // cmbLop
            // 
            this.cmbLop.DisplayMember = "Text";
            this.cmbLop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.ItemHeight = 15;
            this.cmbLop.Location = new System.Drawing.Point(8, 149);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(156, 21);
            this.cmbLop.TabIndex = 14;
            // 
            // label03
            // 
            this.label03.AutoSize = true;
            this.label03.Location = new System.Drawing.Point(5, 83);
            this.label03.Name = "label03";
            this.label03.Size = new System.Drawing.Size(43, 13);
            this.label03.TabIndex = 11;
            this.label03.Text = "Học kỳ:";
            // 
            // label02
            // 
            this.label02.AutoSize = true;
            this.label02.Location = new System.Drawing.Point(5, 133);
            this.label02.Name = "label02";
            this.label02.Size = new System.Drawing.Size(28, 13);
            this.label02.TabIndex = 13;
            this.label02.Text = "Lớp:";
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.DisplayMember = "Text";
            this.cmbHocKy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.ItemHeight = 15;
            this.cmbHocKy.Location = new System.Drawing.Point(8, 99);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(156, 21);
            this.cmbHocKy.TabIndex = 12;
            this.cmbHocKy.SelectedIndexChanged += new System.EventHandler(this.cmbHocKy_SelectedIndexChanged);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1314, 46);
            this.panelControl2.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(575, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "TÌM KIẾM HỌC SINH";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButtonDong);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 458);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1314, 53);
            this.panelControl1.TabIndex = 18;
            // 
            // simpleButtonDong
            // 
            this.simpleButtonDong.Image = global::QLHS_THPT.Properties.Resources.thoat_small;
            this.simpleButtonDong.Location = new System.Drawing.Point(1190, 10);
            this.simpleButtonDong.Name = "simpleButtonDong";
            this.simpleButtonDong.Size = new System.Drawing.Size(109, 33);
            this.simpleButtonDong.TabIndex = 13;
            this.simpleButtonDong.Text = "Đóng (Alt+&C)";
            this.simpleButtonDong.Click += new System.EventHandler(this.simpleButtonDong_Click);
            // 
            // panelControlLeft
            // 
            this.panelControlLeft.Controls.Add(this.groupControl2);
            this.panelControlLeft.Controls.Add(this.groupControl1);
            this.panelControlLeft.Location = new System.Drawing.Point(5, 55);
            this.panelControlLeft.Name = "panelControlLeft";
            this.panelControlLeft.Size = new System.Drawing.Size(180, 394);
            this.panelControlLeft.TabIndex = 10;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnTimKiem);
            this.groupControl2.Controls.Add(this.txtHoTen);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Location = new System.Drawing.Point(5, 228);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(170, 118);
            this.groupControl2.TabIndex = 8;
            this.groupControl2.Text = "Theo tên học sinh";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnHienThiDanhSach);
            this.groupControl1.Controls.Add(this.label01);
            this.groupControl1.Controls.Add(this.cmbLop);
            this.groupControl1.Controls.Add(this.cmbNamHoc);
            this.groupControl1.Controls.Add(this.label02);
            this.groupControl1.Controls.Add(this.label03);
            this.groupControl1.Controls.Add(this.cmbHocKy);
            this.groupControl1.Location = new System.Drawing.Point(4, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(169, 213);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Theo lớp";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaHocSinh";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã học sinh";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HoTen";
            this.dataGridViewTextBoxColumn2.HeaderText = "Họ và tên";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NgaySinh";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ngày sinh";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NoiSinh";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nơi sinh";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TenDanToc";
            this.dataGridViewTextBoxColumn5.HeaderText = "Dân tộc";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TenTonGiao";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tôn giáo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TenGiaoVien";
            this.dataGridViewTextBoxColumn7.HeaderText = "Giáo viên chủ nhiệm";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 130;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TenHocKy";
            this.dataGridViewTextBoxColumn8.HeaderText = "Học Kỳ";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 70;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "TenNamHoc";
            this.dataGridViewTextBoxColumn9.HeaderText = "Năm Học";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "DiemTBHocKy";
            this.dataGridViewTextBoxColumn10.HeaderText = "Điểm TB Học Kỳ";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 130;
            // 
            // frmTimKiemHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 511);
            this.Controls.Add(this.panelControlLeft);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.groupBoxDanhSach);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTimKiemHS";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÌM KIẾM HỌC SINH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTimKiemHS_Load);
            this.groupBoxDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVKetQuaTimKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorKetQuaTimKiem)).EndInit();
            this.bindingNavigatorKetQuaTimKiem.ResumeLayout(false);
            this.bindingNavigatorKetQuaTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlLeft)).EndInit();
            this.panelControlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        #region Components
        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private DevComponents.DotNetBar.Controls.DataGridViewX dGVKetQuaTimKiem;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHoTen;
        private DevComponents.DotNetBar.ButtonX btnTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator bindingNavigatorKetQuaTimKiem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDong;
        private System.Windows.Forms.Label label01;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbNamHoc;
        private System.Windows.Forms.Label label03;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbHocKy;
        private System.Windows.Forms.Label label02;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbLop;
        private DevComponents.DotNetBar.ButtonX btnHienThiDanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDanToc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemTBHocKy;
        private DevExpress.XtraEditors.PanelControl panelControlLeft;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}