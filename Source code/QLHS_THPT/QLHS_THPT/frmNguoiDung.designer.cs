namespace QLHS_THPT
{
    partial class frmNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNguoiDung));
            this.groupBoxDanhSach = new System.Windows.Forms.GroupBox();
            this.dGVNguoiDung = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colMaND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaGiaoVien = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMaLoai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colTenDNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorNguoiDung = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnThemLoaiND = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButtonDong = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonLuu = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonThem = new DevExpress.XtraEditors.SimpleButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBoxDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorNguoiDung)).BeginInit();
            this.bindingNavigatorNguoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDanhSach
            // 
            this.groupBoxDanhSach.Controls.Add(this.dGVNguoiDung);
            this.groupBoxDanhSach.Controls.Add(this.bindingNavigatorNguoiDung);
            this.groupBoxDanhSach.Location = new System.Drawing.Point(0, 52);
            this.groupBoxDanhSach.Name = "groupBoxDanhSach";
            this.groupBoxDanhSach.Size = new System.Drawing.Size(667, 413);
            this.groupBoxDanhSach.TabIndex = 1;
            this.groupBoxDanhSach.TabStop = false;
            this.groupBoxDanhSach.Text = "Danh sách người dùng";
            // 
            // dGVNguoiDung
            // 
            this.dGVNguoiDung.AllowUserToAddRows = false;
            this.dGVNguoiDung.AllowUserToResizeColumns = false;
            this.dGVNguoiDung.AllowUserToResizeRows = false;
            this.dGVNguoiDung.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dGVNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGVNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaND,
            this.colMaGiaoVien,
            this.colMaLoai,
            this.colTenDNhap,
            this.colMatKhau});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVNguoiDung.DefaultCellStyle = dataGridViewCellStyle1;
            this.dGVNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVNguoiDung.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dGVNguoiDung.Location = new System.Drawing.Point(3, 52);
            this.dGVNguoiDung.Name = "dGVNguoiDung";
            this.dGVNguoiDung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGVNguoiDung.Size = new System.Drawing.Size(661, 358);
            this.dGVNguoiDung.TabIndex = 3;
            this.dGVNguoiDung.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dGVNguoiDung_DataError);
            // 
            // colMaND
            // 
            this.colMaND.DataPropertyName = "MaND";
            this.colMaND.HeaderText = "Mã người dùng";
            this.colMaND.MaxInputLength = 6;
            this.colMaND.Name = "colMaND";
            this.colMaND.ReadOnly = true;
            this.colMaND.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMaND.Width = 85;
            // 
            // colMaGiaoVien
            // 
            this.colMaGiaoVien.DataPropertyName = "MaGiaoVien";
            this.colMaGiaoVien.HeaderText = "Tên giáo viên";
            this.colMaGiaoVien.Name = "colMaGiaoVien";
            this.colMaGiaoVien.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMaGiaoVien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colMaGiaoVien.Width = 130;
            // 
            // colMaLoai
            // 
            this.colMaLoai.DataPropertyName = "MaLoai";
            this.colMaLoai.HeaderText = "Loại người dùng";
            this.colMaLoai.Name = "colMaLoai";
            this.colMaLoai.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMaLoai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colMaLoai.Width = 130;
            // 
            // colTenDNhap
            // 
            this.colTenDNhap.DataPropertyName = "TenDNhap";
            this.colTenDNhap.HeaderText = "Tên đăng nhập";
            this.colTenDNhap.MaxInputLength = 30;
            this.colTenDNhap.Name = "colTenDNhap";
            this.colTenDNhap.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTenDNhap.Width = 120;
            // 
            // colMatKhau
            // 
            this.colMatKhau.DataPropertyName = "MatKhau";
            this.colMatKhau.HeaderText = "Mật khẩu";
            this.colMatKhau.MaxInputLength = 30;
            this.colMatKhau.Name = "colMatKhau";
            this.colMatKhau.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMatKhau.Width = 120;
            // 
            // bindingNavigatorNguoiDung
            // 
            this.bindingNavigatorNguoiDung.AddNewItem = null;
            this.bindingNavigatorNguoiDung.AutoSize = false;
            this.bindingNavigatorNguoiDung.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorNguoiDung.CountItemFormat = "của {0}";
            this.bindingNavigatorNguoiDung.DeleteItem = null;
            this.bindingNavigatorNguoiDung.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnThemLoaiND});
            this.bindingNavigatorNguoiDung.Location = new System.Drawing.Point(3, 17);
            this.bindingNavigatorNguoiDung.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorNguoiDung.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorNguoiDung.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorNguoiDung.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorNguoiDung.Name = "bindingNavigatorNguoiDung";
            this.bindingNavigatorNguoiDung.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorNguoiDung.Size = new System.Drawing.Size(661, 35);
            this.bindingNavigatorNguoiDung.TabIndex = 2;
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
            // btnThemLoaiND
            // 
            this.btnThemLoaiND.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnThemLoaiND.Image = global::QLHS_THPT.Properties.Resources.loainguoidung;
            this.btnThemLoaiND.Name = "btnThemLoaiND";
            this.btnThemLoaiND.RightToLeftAutoMirrorImage = true;
            this.btnThemLoaiND.Size = new System.Drawing.Size(23, 32);
            this.btnThemLoaiND.Text = "Thêm loại người dùng";
            this.btnThemLoaiND.Click += new System.EventHandler(this.btnThemLoaiND_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaND";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã người dùng";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenND";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên người dùng";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 30;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TenDNhap";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên đăng nhập";
            this.dataGridViewTextBoxColumn3.MaxInputLength = 30;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MatKhau";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mật khẩu";
            this.dataGridViewTextBoxColumn4.MaxInputLength = 30;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(884, 46);
            this.panelControl2.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(321, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "THÔNG TIN NGƯỜI DÙNG";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButtonDong);
            this.panelControl1.Controls.Add(this.simpleButtonLuu);
            this.panelControl1.Controls.Add(this.simpleButtonThem);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 446);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(884, 55);
            this.panelControl1.TabIndex = 18;
            // 
            // simpleButtonDong
            // 
            this.simpleButtonDong.Image = global::QLHS_THPT.Properties.Resources.thoat_small;
            this.simpleButtonDong.Location = new System.Drawing.Point(738, 10);
            this.simpleButtonDong.Name = "simpleButtonDong";
            this.simpleButtonDong.Size = new System.Drawing.Size(109, 33);
            this.simpleButtonDong.TabIndex = 13;
            this.simpleButtonDong.Text = "Đóng (Alt+&C)";
            this.simpleButtonDong.Click += new System.EventHandler(this.simpleButtonDong_Click);
            // 
            // simpleButtonLuu
            // 
            this.simpleButtonLuu.Image = global::QLHS_THPT.Properties.Resources.them_small;
            this.simpleButtonLuu.Location = new System.Drawing.Point(398, 10);
            this.simpleButtonLuu.Name = "simpleButtonLuu";
            this.simpleButtonLuu.Size = new System.Drawing.Size(129, 33);
            this.simpleButtonLuu.TabIndex = 12;
            this.simpleButtonLuu.Text = "Cập nhật (Alt+&U)";
            this.simpleButtonLuu.Click += new System.EventHandler(this.simpleButtonLuu_Click);
            // 
            // simpleButtonThem
            // 
            this.simpleButtonThem.Image = global::QLHS_THPT.Properties.Resources.them;
            this.simpleButtonThem.Location = new System.Drawing.Point(147, 10);
            this.simpleButtonThem.Name = "simpleButtonThem";
            this.simpleButtonThem.Size = new System.Drawing.Size(130, 33);
            this.simpleButtonThem.TabIndex = 11;
            this.simpleButtonThem.Text = "Thêm (Alt+&A)";
            this.simpleButtonThem.Click += new System.EventHandler(this.simpleButtonThem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.richTextBox1.Location = new System.Drawing.Point(673, 68);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(211, 372);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // frmNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 501);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.groupBoxDanhSach);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmNguoiDung";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NGƯỜI DÙNG";
            this.Load += new System.EventHandler(this.frmNguoiDung_Load);
            this.groupBoxDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorNguoiDung)).EndInit();
            this.bindingNavigatorNguoiDung.ResumeLayout(false);
            this.bindingNavigatorNguoiDung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        #region Components
        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private DevComponents.DotNetBar.Controls.DataGridViewX dGVNguoiDung;
        private System.Windows.Forms.ToolStripButton btnThemLoaiND;
        private System.Windows.Forms.BindingNavigator bindingNavigatorNguoiDung;
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
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDong;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLuu;
        private DevExpress.XtraEditors.SimpleButton simpleButtonThem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaND;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaGiaoVien;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatKhau;
    }
}