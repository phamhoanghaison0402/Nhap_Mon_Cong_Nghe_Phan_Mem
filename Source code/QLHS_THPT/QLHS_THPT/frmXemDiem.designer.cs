namespace QLHS_THPT
{
    partial class frmXemDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXemDiem));
            this.groupBoxDanhSach = new System.Windows.Forms.GroupBox();
            this.dGVDiem = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.bindingNavigatorDiem = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmbMonHocSD = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbNamHocSD = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbHocKySD = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbLopSD = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.superTooltip = new DevComponents.DotNetBar.SuperTooltip();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButtonDong = new DevExpress.XtraEditors.SimpleButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panelControlLeft = new DevExpress.XtraEditors.PanelControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHienThiDanhSachSD = new DevComponents.DotNetBar.ButtonX();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label03 = new System.Windows.Forms.Label();
            this.label04 = new System.Windows.Forms.Label();
            this.buttonItemCapNhatDuLieu = new DevComponents.DotNetBar.ButtonItem();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaQuaTrinhHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemTrungBinhMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDiem)).BeginInit();
            this.bindingNavigatorDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlLeft)).BeginInit();
            this.panelControlLeft.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDanhSach
            // 
            this.groupBoxDanhSach.Controls.Add(this.dGVDiem);
            this.groupBoxDanhSach.Controls.Add(this.bindingNavigatorDiem);
            this.groupBoxDanhSach.Location = new System.Drawing.Point(174, 45);
            this.groupBoxDanhSach.Name = "groupBoxDanhSach";
            this.groupBoxDanhSach.Size = new System.Drawing.Size(716, 395);
            this.groupBoxDanhSach.TabIndex = 3;
            this.groupBoxDanhSach.TabStop = false;
            this.groupBoxDanhSach.Text = "Danh sách điểm của học sinh";
            // 
            // dGVDiem
            // 
            this.dGVDiem.AllowUserToAddRows = false;
            this.dGVDiem.AllowUserToDeleteRows = false;
            this.dGVDiem.AllowUserToResizeRows = false;
            this.dGVDiem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dGVDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGVDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaQuaTrinhHoc,
            this.colMaHocSinh,
            this.colHoTen,
            this.colDiemTrungBinhMon});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVDiem.DefaultCellStyle = dataGridViewCellStyle1;
            this.dGVDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVDiem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dGVDiem.Location = new System.Drawing.Point(3, 52);
            this.dGVDiem.Name = "dGVDiem";
            this.dGVDiem.ReadOnly = true;
            this.dGVDiem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGVDiem.Size = new System.Drawing.Size(710, 340);
            this.dGVDiem.TabIndex = 5;
            // 
            // bindingNavigatorDiem
            // 
            this.bindingNavigatorDiem.AddNewItem = null;
            this.bindingNavigatorDiem.AutoSize = false;
            this.bindingNavigatorDiem.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorDiem.CountItemFormat = "của {0}";
            this.bindingNavigatorDiem.DeleteItem = null;
            this.bindingNavigatorDiem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorSeparator3});
            this.bindingNavigatorDiem.Location = new System.Drawing.Point(3, 17);
            this.bindingNavigatorDiem.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorDiem.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorDiem.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorDiem.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorDiem.Name = "bindingNavigatorDiem";
            this.bindingNavigatorDiem.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorDiem.Size = new System.Drawing.Size(710, 35);
            this.bindingNavigatorDiem.TabIndex = 4;
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
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 35);
            // 
            // cmbMonHocSD
            // 
            this.cmbMonHocSD.DisplayMember = "Text";
            this.cmbMonHocSD.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMonHocSD.FormattingEnabled = true;
            this.cmbMonHocSD.ItemHeight = 15;
            this.cmbMonHocSD.Location = new System.Drawing.Point(6, 205);
            this.cmbMonHocSD.Name = "cmbMonHocSD";
            this.cmbMonHocSD.Size = new System.Drawing.Size(160, 21);
            this.cmbMonHocSD.TabIndex = 4;
            // 
            // cmbNamHocSD
            // 
            this.cmbNamHocSD.DisplayMember = "Text";
            this.cmbNamHocSD.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNamHocSD.FormattingEnabled = true;
            this.cmbNamHocSD.ItemHeight = 15;
            this.cmbNamHocSD.Location = new System.Drawing.Point(5, 38);
            this.cmbNamHocSD.Name = "cmbNamHocSD";
            this.cmbNamHocSD.Size = new System.Drawing.Size(161, 21);
            this.cmbNamHocSD.TabIndex = 1;
            this.cmbNamHocSD.SelectedIndexChanged += new System.EventHandler(this.cmbNamHocSD_SelectedIndexChanged);
            // 
            // cmbHocKySD
            // 
            this.cmbHocKySD.DisplayMember = "Text";
            this.cmbHocKySD.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHocKySD.FormattingEnabled = true;
            this.cmbHocKySD.ItemHeight = 15;
            this.cmbHocKySD.Location = new System.Drawing.Point(6, 95);
            this.cmbHocKySD.Name = "cmbHocKySD";
            this.cmbHocKySD.Size = new System.Drawing.Size(160, 21);
            this.cmbHocKySD.TabIndex = 3;
            this.cmbHocKySD.SelectedIndexChanged += new System.EventHandler(this.cmbHocKySD_SelectedIndexChanged);
            // 
            // cmbLopSD
            // 
            this.cmbLopSD.DisplayMember = "Text";
            this.cmbLopSD.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLopSD.FormattingEnabled = true;
            this.cmbLopSD.ItemHeight = 15;
            this.cmbLopSD.Location = new System.Drawing.Point(6, 148);
            this.cmbLopSD.Name = "cmbLopSD";
            this.cmbLopSD.Size = new System.Drawing.Size(160, 21);
            this.cmbLopSD.TabIndex = 2;
            this.cmbLopSD.SelectedIndexChanged += new System.EventHandler(this.cmbLopSD_SelectedIndexChanged);
            // 
            // superTooltip
            // 
            this.superTooltip.DefaultFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTooltip.DefaultTooltipSettings = new DevComponents.DotNetBar.SuperTooltipInfo("", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1084, 46);
            this.panelControl2.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(367, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "XEM ĐIỂM CỦA HỌC SINH";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButtonDong);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 446);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1084, 55);
            this.panelControl1.TabIndex = 20;
            // 
            // simpleButtonDong
            // 
            this.simpleButtonDong.Image = global::QLHS_THPT.Properties.Resources.thoat_small;
            this.simpleButtonDong.Location = new System.Drawing.Point(949, 10);
            this.simpleButtonDong.Name = "simpleButtonDong";
            this.simpleButtonDong.Size = new System.Drawing.Size(109, 33);
            this.simpleButtonDong.TabIndex = 13;
            this.simpleButtonDong.Text = "Đóng (Alt+&C)";
            this.simpleButtonDong.Click += new System.EventHandler(this.simpleButtonDong_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.richTextBox1.Location = new System.Drawing.Point(896, 62);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(188, 375);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // panelControlLeft
            // 
            this.panelControlLeft.Controls.Add(this.groupBox3);
            this.panelControlLeft.Location = new System.Drawing.Point(0, 52);
            this.panelControlLeft.Name = "panelControlLeft";
            this.panelControlLeft.Size = new System.Drawing.Size(174, 385);
            this.panelControlLeft.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHienThiDanhSachSD);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label03);
            this.groupBox3.Controls.Add(this.label04);
            this.groupBox3.Controls.Add(this.cmbMonHocSD);
            this.groupBox3.Controls.Add(this.cmbNamHocSD);
            this.groupBox3.Controls.Add(this.cmbLopSD);
            this.groupBox3.Controls.Add(this.cmbHocKySD);
            this.groupBox3.Location = new System.Drawing.Point(0, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(168, 276);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin lớp học";
            // 
            // btnHienThiDanhSachSD
            // 
            this.btnHienThiDanhSachSD.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHienThiDanhSachSD.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHienThiDanhSachSD.Location = new System.Drawing.Point(10, 242);
            this.btnHienThiDanhSachSD.Name = "btnHienThiDanhSachSD";
            this.btnHienThiDanhSachSD.Size = new System.Drawing.Size(152, 23);
            this.btnHienThiDanhSachSD.TabIndex = 5;
            this.btnHienThiDanhSachSD.Text = "Hiển thị danh sách học sinh";
            this.btnHienThiDanhSachSD.Click += new System.EventHandler(this.btnHienThiDanhSachSD_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Năm học:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Lớp:";
            // 
            // label03
            // 
            this.label03.AutoSize = true;
            this.label03.Location = new System.Drawing.Point(6, 79);
            this.label03.Name = "label03";
            this.label03.Size = new System.Drawing.Size(43, 13);
            this.label03.TabIndex = 0;
            this.label03.Text = "Học kỳ:";
            // 
            // label04
            // 
            this.label04.AutoSize = true;
            this.label04.Location = new System.Drawing.Point(7, 189);
            this.label04.Name = "label04";
            this.label04.Size = new System.Drawing.Size(51, 13);
            this.label04.TabIndex = 0;
            this.label04.Text = "Môn học:";
            // 
            // buttonItemCapNhatDuLieu
            // 
            this.buttonItemCapNhatDuLieu.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemCapNhatDuLieu.Checked = true;
            this.buttonItemCapNhatDuLieu.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemCapNhatDuLieu.Image")));
            this.buttonItemCapNhatDuLieu.Name = "buttonItemCapNhatDuLieu";
            this.buttonItemCapNhatDuLieu.OptionGroup = "navBar";
            this.buttonItemCapNhatDuLieu.Text = "Thông tin học sinh";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaQuaTrinhHoc";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Quá Trình Học";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaHocSinh";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã Học Sinh";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HoTen";
            this.dataGridViewTextBoxColumn3.HeaderText = "Họ và tên";
            this.dataGridViewTextBoxColumn3.MaxInputLength = 30;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 155;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DiemTrungBinhMon";
            this.dataGridViewTextBoxColumn4.HeaderText = "Điểm TB Môn";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // colMaQuaTrinhHoc
            // 
            this.colMaQuaTrinhHoc.DataPropertyName = "MaQuaTrinhHoc";
            this.colMaQuaTrinhHoc.HeaderText = "Mã Quá Trình Học";
            this.colMaQuaTrinhHoc.MaxInputLength = 6;
            this.colMaQuaTrinhHoc.Name = "colMaQuaTrinhHoc";
            this.colMaQuaTrinhHoc.ReadOnly = true;
            this.colMaQuaTrinhHoc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMaQuaTrinhHoc.Visible = false;
            // 
            // colMaHocSinh
            // 
            this.colMaHocSinh.DataPropertyName = "MaHocSinh";
            this.colMaHocSinh.HeaderText = "Mã Học Sinh";
            this.colMaHocSinh.Name = "colMaHocSinh";
            this.colMaHocSinh.ReadOnly = true;
            this.colMaHocSinh.Width = 75;
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Họ và tên";
            this.colHoTen.MaxInputLength = 30;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            this.colHoTen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colHoTen.Width = 110;
            // 
            // colDiemTrungBinhMon
            // 
            this.colDiemTrungBinhMon.DataPropertyName = "DiemTrungBinhMon";
            this.colDiemTrungBinhMon.HeaderText = "Điểm TB Môn";
            this.colDiemTrungBinhMon.Name = "colDiemTrungBinhMon";
            this.colDiemTrungBinhMon.ReadOnly = true;
            this.colDiemTrungBinhMon.Width = 80;
            // 
            // frmXemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 501);
            this.Controls.Add(this.panelControlLeft);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.groupBoxDanhSach);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmXemDiem";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XEM ĐIỂM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmXemDiem_Load);
            this.groupBoxDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDiem)).EndInit();
            this.bindingNavigatorDiem.ResumeLayout(false);
            this.bindingNavigatorDiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlLeft)).EndInit();
            this.panelControlLeft.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        #region Components
        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private DevComponents.DotNetBar.SuperTooltip superTooltip;
        private DevComponents.DotNetBar.Controls.DataGridViewX dGVDiem;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbMonHocSD;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbNamHocSD;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbHocKySD;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbLopSD;
        private System.Windows.Forms.BindingNavigator bindingNavigatorDiem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDong;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaQuaTrinhHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemTrungBinhMon;
        private DevExpress.XtraEditors.PanelControl panelControlLeft;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.ButtonX btnHienThiDanhSachSD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label03;
        private System.Windows.Forms.Label label04;
        private DevComponents.DotNetBar.ButtonItem buttonItemCapNhatDuLieu;



    }
}