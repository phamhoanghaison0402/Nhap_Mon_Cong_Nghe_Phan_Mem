namespace QLHS_THPT
{
    partial class frmHocSinh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHocSinh));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxDanhSach = new System.Windows.Forms.GroupBox();
            this.dGVHocSinh = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colMaHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colNgaySinh = new QLHS_THPT.Component.CalendarColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorHocSinh = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorRefreshItem = new System.Windows.Forms.ToolStripButton();
            this.label01 = new System.Windows.Forms.Label();
            this.chkTimTheoTen = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkTimTheoMa = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnTimKiem = new DevComponents.DotNetBar.ButtonX();
            this.txtTimKiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendarColumn1 = new QLHS_THPT.Component.CalendarColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simpleButtonThem = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonLuu = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panelControlLeft = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupBoxDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHocSinh)).BeginInit();
            this.bindingNavigatorHocSinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlLeft)).BeginInit();
            this.panelControlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDanhSach
            // 
            this.groupBoxDanhSach.Controls.Add(this.dGVHocSinh);
            this.groupBoxDanhSach.Controls.Add(this.bindingNavigatorHocSinh);
            this.groupBoxDanhSach.Location = new System.Drawing.Point(188, 52);
            this.groupBoxDanhSach.Name = "groupBoxDanhSach";
            this.groupBoxDanhSach.Size = new System.Drawing.Size(779, 413);
            this.groupBoxDanhSach.TabIndex = 3;
            this.groupBoxDanhSach.TabStop = false;
            this.groupBoxDanhSach.Text = "Danh sách học sinh";
            // 
            // dGVHocSinh
            // 
            this.dGVHocSinh.AllowUserToAddRows = false;
            this.dGVHocSinh.AllowUserToResizeRows = false;
            this.dGVHocSinh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dGVHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGVHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHocSinh,
            this.colHoTen,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colEmail,
            this.colDiaChi});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVHocSinh.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGVHocSinh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dGVHocSinh.Location = new System.Drawing.Point(3, 52);
            this.dGVHocSinh.Name = "dGVHocSinh";
            this.dGVHocSinh.Size = new System.Drawing.Size(773, 346);
            this.dGVHocSinh.TabIndex = 5;
            this.dGVHocSinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVHocSinh_CellClick);
            this.dGVHocSinh.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dGVHocSinh_DataError);
            // 
            // colMaHocSinh
            // 
            this.colMaHocSinh.DataPropertyName = "MaHocSinh";
            this.colMaHocSinh.HeaderText = "Mã học sinh";
            this.colMaHocSinh.MaxInputLength = 6;
            this.colMaHocSinh.Name = "colMaHocSinh";
            this.colMaHocSinh.ReadOnly = true;
            this.colMaHocSinh.Width = 80;
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Họ và tên";
            this.colHoTen.MaxInputLength = 30;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Width = 150;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.DataPropertyName = "GioiTinh";
            this.colGioiTinh.HeaderText = "Giới tính nữ";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Width = 70;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.colNgaySinh.DefaultCellStyle = dataGridViewCellStyle1;
            this.colNgaySinh.HeaderText = "Ngày sinh";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Width = 85;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Width = 150;
            // 
            // colDiaChi
            // 
            this.colDiaChi.DataPropertyName = "DiaChi";
            this.colDiaChi.HeaderText = "Địa Chỉ";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Width = 245;
            // 
            // bindingNavigatorHocSinh
            // 
            this.bindingNavigatorHocSinh.AddNewItem = null;
            this.bindingNavigatorHocSinh.AutoSize = false;
            this.bindingNavigatorHocSinh.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorHocSinh.CountItemFormat = "của {0}";
            this.bindingNavigatorHocSinh.DeleteItem = null;
            this.bindingNavigatorHocSinh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorRefreshItem});
            this.bindingNavigatorHocSinh.Location = new System.Drawing.Point(3, 17);
            this.bindingNavigatorHocSinh.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorHocSinh.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorHocSinh.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorHocSinh.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorHocSinh.Name = "bindingNavigatorHocSinh";
            this.bindingNavigatorHocSinh.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorHocSinh.Size = new System.Drawing.Size(773, 35);
            this.bindingNavigatorHocSinh.TabIndex = 4;
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
            // bindingNavigatorRefreshItem
            // 
            this.bindingNavigatorRefreshItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorRefreshItem.Image = global::QLHS_THPT.Properties.Resources.refresh;
            this.bindingNavigatorRefreshItem.Name = "bindingNavigatorRefreshItem";
            this.bindingNavigatorRefreshItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorRefreshItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorRefreshItem.Text = "Làm mới danh dách";
            this.bindingNavigatorRefreshItem.Click += new System.EventHandler(this.bindingNavigatorRefreshItem_Click);
            // 
            // label01
            // 
            this.label01.AutoSize = true;
            this.label01.Location = new System.Drawing.Point(5, 31);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(123, 13);
            this.label01.TabIndex = 0;
            this.label01.Text = "Nhập thông tin tìm kiếm:";
            // 
            // chkTimTheoTen
            // 
            // 
            // 
            // 
            this.chkTimTheoTen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkTimTheoTen.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.chkTimTheoTen.Location = new System.Drawing.Point(9, 118);
            this.chkTimTheoTen.Name = "chkTimTheoTen";
            this.chkTimTheoTen.Size = new System.Drawing.Size(152, 23);
            this.chkTimTheoTen.TabIndex = 5;
            this.chkTimTheoTen.Text = "Tìm theo tên học sinh";
            // 
            // chkTimTheoMa
            // 
            // 
            // 
            // 
            this.chkTimTheoMa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkTimTheoMa.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.chkTimTheoMa.Checked = true;
            this.chkTimTheoMa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTimTheoMa.CheckValue = "Y";
            this.chkTimTheoMa.Location = new System.Drawing.Point(8, 89);
            this.chkTimTheoMa.Name = "chkTimTheoMa";
            this.chkTimTheoMa.Size = new System.Drawing.Size(153, 23);
            this.chkTimTheoMa.TabIndex = 4;
            this.chkTimTheoMa.Text = "Tìm theo mã học sinh";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimKiem.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnTimKiem.Location = new System.Drawing.Point(5, 159);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(161, 23);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            // 
            // 
            // 
            this.txtTimKiem.Border.Class = "TextBoxBorder";
            this.txtTimKiem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTimKiem.ButtonCustom.Tooltip = "";
            this.txtTimKiem.ButtonCustom2.Tooltip = "";
            this.txtTimKiem.Location = new System.Drawing.Point(6, 47);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(155, 21);
            this.txtTimKiem.TabIndex = 3;
            this.txtTimKiem.WatermarkText = "Nhập thông tin cần tìm vào đây";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaHocSinh";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã học sinh";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HoTen";
            this.dataGridViewTextBoxColumn2.HeaderText = "Họ và tên";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 30;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // calendarColumn1
            // 
            this.calendarColumn1.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            this.calendarColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.calendarColumn1.HeaderText = "Ngày sinh";
            this.calendarColumn1.Name = "calendarColumn1";
            this.calendarColumn1.Width = 85;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn3.HeaderText = "Email";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DiaChi";
            this.dataGridViewTextBoxColumn4.HeaderText = "Địa Chỉ";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 170;
            // 
            // simpleButtonThem
            // 
            this.simpleButtonThem.Image = global::QLHS_THPT.Properties.Resources.them;
            this.simpleButtonThem.Location = new System.Drawing.Point(412, 10);
            this.simpleButtonThem.Name = "simpleButtonThem";
            this.simpleButtonThem.Size = new System.Drawing.Size(130, 33);
            this.simpleButtonThem.TabIndex = 12;
            this.simpleButtonThem.Text = "Thêm (Alt+&A)";
            this.simpleButtonThem.Click += new System.EventHandler(this.simpleButtonThem_Click);
            // 
            // simpleButtonLuu
            // 
            this.simpleButtonLuu.Image = global::QLHS_THPT.Properties.Resources.them_small;
            this.simpleButtonLuu.Location = new System.Drawing.Point(719, 10);
            this.simpleButtonLuu.Name = "simpleButtonLuu";
            this.simpleButtonLuu.Size = new System.Drawing.Size(129, 33);
            this.simpleButtonLuu.TabIndex = 13;
            this.simpleButtonLuu.Text = "Cập nhật (Alt+&U)";
            this.simpleButtonLuu.Click += new System.EventHandler(this.simpleButtonLuu_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::QLHS_THPT.Properties.Resources.thoat_small;
            this.simpleButton1.Location = new System.Drawing.Point(1071, 10);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(109, 33);
            this.simpleButton1.TabIndex = 14;
            this.simpleButton1.Text = "Đóng (Alt+&C)";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1214, 46);
            this.panelControl2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(490, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "THÔNG TIN HỌC SINH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButtonThem);
            this.panelControl1.Controls.Add(this.simpleButtonLuu);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 456);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1214, 55);
            this.panelControl1.TabIndex = 16;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.richTextBox1.Location = new System.Drawing.Point(973, 72);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(241, 378);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // panelControlLeft
            // 
            this.panelControlLeft.Controls.Add(this.groupControl1);
            this.panelControlLeft.Location = new System.Drawing.Point(8, 52);
            this.panelControlLeft.Name = "panelControlLeft";
            this.panelControlLeft.Size = new System.Drawing.Size(180, 398);
            this.panelControlLeft.TabIndex = 9;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label01);
            this.groupControl1.Controls.Add(this.btnTimKiem);
            this.groupControl1.Controls.Add(this.txtTimKiem);
            this.groupControl1.Controls.Add(this.chkTimTheoTen);
            this.groupControl1.Controls.Add(this.chkTimTheoMa);
            this.groupControl1.Location = new System.Drawing.Point(4, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(169, 187);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Tìm kiếm học sinh";
            // 
            // frmHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 511);
            this.Controls.Add(this.panelControlLeft);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.groupBoxDanhSach);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmHocSinh";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỌC SINH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHocSinh_Load);
            this.groupBoxDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHocSinh)).EndInit();
            this.bindingNavigatorHocSinh.ResumeLayout(false);
            this.bindingNavigatorHocSinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlLeft)).EndInit();
            this.panelControlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        #region Components
        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private DevComponents.DotNetBar.ButtonX btnTimKiem;
        private DevComponents.DotNetBar.Controls.DataGridViewX dGVHocSinh;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTimKiem;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkTimTheoTen;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkTimTheoMa;
        private System.Windows.Forms.Label label01;
        private System.Windows.Forms.BindingNavigator bindingNavigatorHocSinh;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorRefreshItem;
        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Component.CalendarColumn calendarColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGioiTinh;
        private Component.CalendarColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private DevExpress.XtraEditors.SimpleButton simpleButtonThem;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLuu;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.PanelControl panelControlLeft;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}