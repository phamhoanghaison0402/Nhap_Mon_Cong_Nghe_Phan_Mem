namespace QLHS_THPT
{
    partial class frmKhoiLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoiLop));
            this.groupBoxDanhSach = new System.Windows.Forms.GroupBox();
            this.dGVKhoiLop = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colMaNamHoc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bindingNavigatorKhoiLop = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.simpleButtonThem = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonLuu = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKhoiLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKhoiLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKyHieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVKhoiLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorKhoiLop)).BeginInit();
            this.bindingNavigatorKhoiLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDanhSach
            // 
            this.groupBoxDanhSach.Controls.Add(this.dGVKhoiLop);
            this.groupBoxDanhSach.Controls.Add(this.bindingNavigatorKhoiLop);
            this.groupBoxDanhSach.Location = new System.Drawing.Point(0, 51);
            this.groupBoxDanhSach.Name = "groupBoxDanhSach";
            this.groupBoxDanhSach.Size = new System.Drawing.Size(528, 399);
            this.groupBoxDanhSach.TabIndex = 1;
            this.groupBoxDanhSach.TabStop = false;
            this.groupBoxDanhSach.Text = "Danh sách khối lớp";
            // 
            // dGVKhoiLop
            // 
            this.dGVKhoiLop.AllowUserToAddRows = false;
            this.dGVKhoiLop.AllowUserToResizeColumns = false;
            this.dGVKhoiLop.AllowUserToResizeRows = false;
            this.dGVKhoiLop.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dGVKhoiLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGVKhoiLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaKhoiLop,
            this.colTenKhoiLop,
            this.colKyHieu,
            this.colSoLop,
            this.colMaNamHoc});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVKhoiLop.DefaultCellStyle = dataGridViewCellStyle1;
            this.dGVKhoiLop.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dGVKhoiLop.Location = new System.Drawing.Point(3, 52);
            this.dGVKhoiLop.Name = "dGVKhoiLop";
            this.dGVKhoiLop.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGVKhoiLop.Size = new System.Drawing.Size(522, 341);
            this.dGVKhoiLop.TabIndex = 3;
            this.dGVKhoiLop.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dGVKhoiLop_DataError);
            // 
            // colMaNamHoc
            // 
            this.colMaNamHoc.DataPropertyName = "MaNamHoc";
            this.colMaNamHoc.HeaderText = "Năm Học";
            this.colMaNamHoc.Name = "colMaNamHoc";
            // 
            // bindingNavigatorKhoiLop
            // 
            this.bindingNavigatorKhoiLop.AddNewItem = null;
            this.bindingNavigatorKhoiLop.AutoSize = false;
            this.bindingNavigatorKhoiLop.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorKhoiLop.CountItemFormat = "của {0}";
            this.bindingNavigatorKhoiLop.DeleteItem = null;
            this.bindingNavigatorKhoiLop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigatorKhoiLop.Location = new System.Drawing.Point(3, 17);
            this.bindingNavigatorKhoiLop.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorKhoiLop.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorKhoiLop.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorKhoiLop.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorKhoiLop.Name = "bindingNavigatorKhoiLop";
            this.bindingNavigatorKhoiLop.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorKhoiLop.Size = new System.Drawing.Size(522, 35);
            this.bindingNavigatorKhoiLop.TabIndex = 2;
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
            // simpleButtonThem
            // 
            this.simpleButtonThem.Image = global::QLHS_THPT.Properties.Resources.them;
            this.simpleButtonThem.Location = new System.Drawing.Point(76, 12);
            this.simpleButtonThem.Name = "simpleButtonThem";
            this.simpleButtonThem.Size = new System.Drawing.Size(130, 33);
            this.simpleButtonThem.TabIndex = 11;
            this.simpleButtonThem.Text = "Thêm (Alt+&A)";
            this.simpleButtonThem.Click += new System.EventHandler(this.simpleButtonThem_Click);
            // 
            // simpleButtonLuu
            // 
            this.simpleButtonLuu.Image = global::QLHS_THPT.Properties.Resources.them_small;
            this.simpleButtonLuu.Location = new System.Drawing.Point(308, 12);
            this.simpleButtonLuu.Name = "simpleButtonLuu";
            this.simpleButtonLuu.Size = new System.Drawing.Size(129, 33);
            this.simpleButtonLuu.TabIndex = 12;
            this.simpleButtonLuu.Text = "Cập nhật (Alt+&U)";
            this.simpleButtonLuu.Click += new System.EventHandler(this.simpleButtonLuu_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::QLHS_THPT.Properties.Resources.thoat_small;
            this.simpleButton1.Location = new System.Drawing.Point(617, 10);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(109, 33);
            this.simpleButton1.TabIndex = 13;
            this.simpleButton1.Text = "Đóng (Alt+&C)";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.richTextBox1.Location = new System.Drawing.Point(534, 68);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(215, 382);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(749, 46);
            this.panelControl2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(250, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "THÔNG TIN KHỐI LỚP";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.simpleButtonLuu);
            this.panelControl1.Controls.Add(this.simpleButtonThem);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 456);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(749, 55);
            this.panelControl1.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaKhoiLop";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã khối lớp";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenKhoiLop";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên khối lớp";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 30;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Ban";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ban";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SoLop";
            this.dataGridViewTextBoxColumn4.HeaderText = "Số Lớp";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // colMaKhoiLop
            // 
            this.colMaKhoiLop.DataPropertyName = "MaKhoiLop";
            this.colMaKhoiLop.HeaderText = "Mã khối lớp";
            this.colMaKhoiLop.MaxInputLength = 9;
            this.colMaKhoiLop.Name = "colMaKhoiLop";
            this.colMaKhoiLop.ReadOnly = true;
            this.colMaKhoiLop.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colTenKhoiLop
            // 
            this.colTenKhoiLop.DataPropertyName = "TenKhoiLop";
            this.colTenKhoiLop.HeaderText = "Tên khối lớp";
            this.colTenKhoiLop.MaxInputLength = 30;
            this.colTenKhoiLop.Name = "colTenKhoiLop";
            this.colTenKhoiLop.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colKyHieu
            // 
            this.colKyHieu.DataPropertyName = "KyHieu";
            this.colKyHieu.HeaderText = "Ký Hiệu";
            this.colKyHieu.Name = "colKyHieu";
            this.colKyHieu.Width = 80;
            // 
            // colSoLop
            // 
            this.colSoLop.DataPropertyName = "SoLop";
            this.colSoLop.HeaderText = "Số Lớp";
            this.colSoLop.Name = "colSoLop";
            this.colSoLop.Width = 80;
            // 
            // frmKhoiLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 511);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBoxDanhSach);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmKhoiLop";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KHỐI LỚP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKhoiLop_Load);
            this.groupBoxDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVKhoiLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorKhoiLop)).EndInit();
            this.bindingNavigatorKhoiLop.ResumeLayout(false);
            this.bindingNavigatorKhoiLop.PerformLayout();
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
        private DevComponents.DotNetBar.Controls.DataGridViewX dGVKhoiLop;
        private System.Windows.Forms.BindingNavigator bindingNavigatorKhoiLop;
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
        private DevExpress.XtraEditors.SimpleButton simpleButtonThem;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLuu;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKhoiLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKhoiLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKyHieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLop;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaNamHoc;



    }
}