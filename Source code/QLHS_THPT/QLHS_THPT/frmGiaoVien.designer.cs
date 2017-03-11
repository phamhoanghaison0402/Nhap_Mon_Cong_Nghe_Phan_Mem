namespace QLHS_THPT
{
    partial class frmGiaoVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoVien));
            this.groupBoxDanhSach = new System.Windows.Forms.GroupBox();
            this.dGVGiaoVien = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colMaMonHoc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bindingNavigatorGiaoVien = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.label6 = new System.Windows.Forms.Label();
            this.chkTimTheoTen = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkTimTheoMa = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnTimKiem = new DevComponents.DotNetBar.ButtonX();
            this.txtTimKiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonLuu = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonThem = new DevExpress.XtraEditors.SimpleButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panelControlLeft = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorGiaoVien)).BeginInit();
            this.bindingNavigatorGiaoVien.SuspendLayout();
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
            this.groupBoxDanhSach.Controls.Add(this.dGVGiaoVien);
            this.groupBoxDanhSach.Controls.Add(this.bindingNavigatorGiaoVien);
            this.groupBoxDanhSach.Location = new System.Drawing.Point(185, 52);
            this.groupBoxDanhSach.Name = "groupBoxDanhSach";
            this.groupBoxDanhSach.Size = new System.Drawing.Size(409, 413);
            this.groupBoxDanhSach.TabIndex = 3;
            this.groupBoxDanhSach.TabStop = false;
            this.groupBoxDanhSach.Text = "Danh sách giáo viên";
            // 
            // dGVGiaoVien
            // 
            this.dGVGiaoVien.AllowUserToAddRows = false;
            this.dGVGiaoVien.AllowUserToResizeColumns = false;
            this.dGVGiaoVien.AllowUserToResizeRows = false;
            this.dGVGiaoVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dGVGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGVGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaGiaoVien,
            this.colTenGiaoVien,
            this.colMaMonHoc});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVGiaoVien.DefaultCellStyle = dataGridViewCellStyle1;
            this.dGVGiaoVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVGiaoVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dGVGiaoVien.Location = new System.Drawing.Point(3, 52);
            this.dGVGiaoVien.Name = "dGVGiaoVien";
            this.dGVGiaoVien.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGVGiaoVien.Size = new System.Drawing.Size(403, 358);
            this.dGVGiaoVien.TabIndex = 5;
            // 
            // colMaMonHoc
            // 
            this.colMaMonHoc.DataPropertyName = "MaMonHoc";
            this.colMaMonHoc.HeaderText = "Chuyên môn";
            this.colMaMonHoc.Name = "colMaMonHoc";
            this.colMaMonHoc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // bindingNavigatorGiaoVien
            // 
            this.bindingNavigatorGiaoVien.AddNewItem = null;
            this.bindingNavigatorGiaoVien.AutoSize = false;
            this.bindingNavigatorGiaoVien.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorGiaoVien.CountItemFormat = "của {0}";
            this.bindingNavigatorGiaoVien.DeleteItem = null;
            this.bindingNavigatorGiaoVien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorGiaoVien.Location = new System.Drawing.Point(3, 17);
            this.bindingNavigatorGiaoVien.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorGiaoVien.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorGiaoVien.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorGiaoVien.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorGiaoVien.Name = "bindingNavigatorGiaoVien";
            this.bindingNavigatorGiaoVien.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorGiaoVien.Size = new System.Drawing.Size(403, 35);
            this.bindingNavigatorGiaoVien.TabIndex = 4;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nhập thông tin tìm kiếm:";
            // 
            // chkTimTheoTen
            // 
            // 
            // 
            // 
            this.chkTimTheoTen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkTimTheoTen.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.chkTimTheoTen.Location = new System.Drawing.Point(5, 114);
            this.chkTimTheoTen.Name = "chkTimTheoTen";
            this.chkTimTheoTen.Size = new System.Drawing.Size(159, 23);
            this.chkTimTheoTen.TabIndex = 5;
            this.chkTimTheoTen.Text = "Tìm theo tên giáo viên";
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
            this.chkTimTheoMa.Location = new System.Drawing.Point(4, 85);
            this.chkTimTheoMa.Name = "chkTimTheoMa";
            this.chkTimTheoMa.Size = new System.Drawing.Size(158, 23);
            this.chkTimTheoMa.TabIndex = 4;
            this.chkTimTheoMa.Text = "Tìm theo mã giáo viên";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimKiem.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnTimKiem.Location = new System.Drawing.Point(5, 143);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(160, 23);
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
            this.txtTimKiem.Location = new System.Drawing.Point(4, 49);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(160, 21);
            this.txtTimKiem.TabIndex = 3;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(814, 46);
            this.panelControl2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(304, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "THÔNG TIN GIÁO VIÊN";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.simpleButtonLuu);
            this.panelControl1.Controls.Add(this.simpleButtonThem);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 456);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(814, 55);
            this.panelControl1.TabIndex = 15;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::QLHS_THPT.Properties.Resources.thoat_small;
            this.simpleButton1.Location = new System.Drawing.Point(663, 13);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(109, 33);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "Đóng (Alt+&C)";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButtonLuu
            // 
            this.simpleButtonLuu.Image = global::QLHS_THPT.Properties.Resources.them_small;
            this.simpleButtonLuu.Location = new System.Drawing.Point(441, 13);
            this.simpleButtonLuu.Name = "simpleButtonLuu";
            this.simpleButtonLuu.Size = new System.Drawing.Size(129, 33);
            this.simpleButtonLuu.TabIndex = 8;
            this.simpleButtonLuu.Text = "Cập nhật (Alt+&U)";
            this.simpleButtonLuu.Click += new System.EventHandler(this.simpleButtonLuu_Click);
            // 
            // simpleButtonThem
            // 
            this.simpleButtonThem.Image = global::QLHS_THPT.Properties.Resources.them;
            this.simpleButtonThem.Location = new System.Drawing.Point(219, 13);
            this.simpleButtonThem.Name = "simpleButtonThem";
            this.simpleButtonThem.Size = new System.Drawing.Size(130, 33);
            this.simpleButtonThem.TabIndex = 10;
            this.simpleButtonThem.Text = "Thêm (Alt+&A)";
            this.simpleButtonThem.Click += new System.EventHandler(this.simpleButtonThem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.richTextBox1.Location = new System.Drawing.Point(600, 77);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(214, 373);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // panelControlLeft
            // 
            this.panelControlLeft.Controls.Add(this.groupControl1);
            this.panelControlLeft.Location = new System.Drawing.Point(2, 55);
            this.panelControlLeft.Name = "panelControlLeft";
            this.panelControlLeft.Size = new System.Drawing.Size(180, 395);
            this.panelControlLeft.TabIndex = 10;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnTimKiem);
            this.groupControl1.Controls.Add(this.chkTimTheoTen);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.chkTimTheoMa);
            this.groupControl1.Controls.Add(this.txtTimKiem);
            this.groupControl1.Location = new System.Drawing.Point(4, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(169, 187);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Tìm kiếm giáo viên";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaGiaoVien";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã giáo viên";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 85;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenGiaoVien";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên giáo viên";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 30;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 170;
            // 
            // colMaGiaoVien
            // 
            this.colMaGiaoVien.DataPropertyName = "MaGiaoVien";
            this.colMaGiaoVien.HeaderText = "Mã giáo viên";
            this.colMaGiaoVien.MaxInputLength = 6;
            this.colMaGiaoVien.Name = "colMaGiaoVien";
            this.colMaGiaoVien.ReadOnly = true;
            this.colMaGiaoVien.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMaGiaoVien.Width = 85;
            // 
            // colTenGiaoVien
            // 
            this.colTenGiaoVien.DataPropertyName = "TenGiaoVien";
            this.colTenGiaoVien.HeaderText = "Tên giáo viên";
            this.colTenGiaoVien.MaxInputLength = 30;
            this.colTenGiaoVien.Name = "colTenGiaoVien";
            this.colTenGiaoVien.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTenGiaoVien.Width = 150;
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 511);
            this.Controls.Add(this.panelControlLeft);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.groupBoxDanhSach);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGiaoVien";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GIÁO VIÊN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGiaoVien_Load);
            this.groupBoxDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVGiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorGiaoVien)).EndInit();
            this.bindingNavigatorGiaoVien.ResumeLayout(false);
            this.bindingNavigatorGiaoVien.PerformLayout();
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
        private DevComponents.DotNetBar.Controls.DataGridViewX dGVGiaoVien;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTimKiem;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkTimTheoTen;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkTimTheoMa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingNavigator bindingNavigatorGiaoVien;
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
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLuu;
        private DevExpress.XtraEditors.SimpleButton simpleButtonThem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorRefreshItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenGiaoVien;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaMonHoc;
        private DevExpress.XtraEditors.PanelControl panelControlLeft;
        private DevExpress.XtraEditors.GroupControl groupControl1;


    }
}