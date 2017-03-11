namespace QLHS_THPT.Reports
{
    partial class frptDanhSachLopHoc
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.HOCSINHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLHS_THPTDataSet = new QLHS_THPT.Reports.QLHS_THPTDataSet();
            this.groupPanelDS = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cmbLop = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cmbKhoiLop = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnXem = new DevComponents.DotNetBar.ButtonX();
            this.cmbNamHoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX01 = new DevComponents.DotNetBar.LabelX();
            this.reportViewerDSLop = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HOCSINHTableAdapter = new QLHS_THPT.Reports.QLHS_THPTDataSetTableAdapters.HOCSINHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HOCSINHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLHS_THPTDataSet)).BeginInit();
            this.groupPanelDS.SuspendLayout();
            this.SuspendLayout();
            // 
            // HOCSINHBindingSource
            // 
            this.HOCSINHBindingSource.DataMember = "HOCSINH";
            this.HOCSINHBindingSource.DataSource = this.QLHS_THPTDataSet;
            // 
            // QLHS_THPTDataSet
            // 
            this.QLHS_THPTDataSet.DataSetName = "QLHS_THPTDataSet";
            this.QLHS_THPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupPanelDS
            // 
            this.groupPanelDS.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelDS.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelDS.Controls.Add(this.cmbLop);
            this.groupPanelDS.Controls.Add(this.labelX2);
            this.groupPanelDS.Controls.Add(this.cmbKhoiLop);
            this.groupPanelDS.Controls.Add(this.labelX1);
            this.groupPanelDS.Controls.Add(this.btnXem);
            this.groupPanelDS.Controls.Add(this.cmbNamHoc);
            this.groupPanelDS.Controls.Add(this.labelX01);
            this.groupPanelDS.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanelDS.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelDS.Location = new System.Drawing.Point(0, 0);
            this.groupPanelDS.Name = "groupPanelDS";
            this.groupPanelDS.Size = new System.Drawing.Size(792, 58);
            // 
            // 
            // 
            this.groupPanelDS.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelDS.Style.BackColorGradientAngle = 90;
            this.groupPanelDS.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelDS.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelDS.Style.BorderBottomWidth = 1;
            this.groupPanelDS.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelDS.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelDS.Style.BorderLeftWidth = 1;
            this.groupPanelDS.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelDS.Style.BorderRightWidth = 1;
            this.groupPanelDS.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelDS.Style.BorderTopWidth = 1;
            this.groupPanelDS.Style.CornerDiameter = 4;
            this.groupPanelDS.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelDS.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelDS.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelDS.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanelDS.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanelDS.TabIndex = 1;
            // 
            // cmbLop
            // 
            this.cmbLop.DisplayMember = "Text";
            this.cmbLop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.ItemHeight = 14;
            this.cmbLop.Location = new System.Drawing.Point(452, 16);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(121, 20);
            this.cmbLop.TabIndex = 7;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(423, 16);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(23, 20);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "Lớp:";
            // 
            // cmbKhoiLop
            // 
            this.cmbKhoiLop.DisplayMember = "Text";
            this.cmbKhoiLop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKhoiLop.FormattingEnabled = true;
            this.cmbKhoiLop.ItemHeight = 14;
            this.cmbKhoiLop.Location = new System.Drawing.Point(285, 16);
            this.cmbKhoiLop.Name = "cmbKhoiLop";
            this.cmbKhoiLop.Size = new System.Drawing.Size(121, 20);
            this.cmbKhoiLop.TabIndex = 5;
            this.cmbKhoiLop.SelectedIndexChanged += new System.EventHandler(this.cmbKhoiLop_SelectedIndexChanged);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(234, 16);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(64, 20);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "Khối Lớp:";
            // 
            // btnXem
            // 
            this.btnXem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXem.Location = new System.Drawing.Point(595, 16);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 20);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // cmbNamHoc
            // 
            this.cmbNamHoc.DisplayMember = "Text";
            this.cmbNamHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNamHoc.FormattingEnabled = true;
            this.cmbNamHoc.ItemHeight = 14;
            this.cmbNamHoc.Location = new System.Drawing.Point(93, 16);
            this.cmbNamHoc.Name = "cmbNamHoc";
            this.cmbNamHoc.Size = new System.Drawing.Size(121, 20);
            this.cmbNamHoc.TabIndex = 1;
            this.cmbNamHoc.SelectedIndexChanged += new System.EventHandler(this.cmbNamHoc_SelectedIndexChanged);
            // 
            // labelX01
            // 
            this.labelX01.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX01.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX01.Location = new System.Drawing.Point(12, 16);
            this.labelX01.Name = "labelX01";
            this.labelX01.Size = new System.Drawing.Size(84, 20);
            this.labelX01.TabIndex = 0;
            this.labelX01.Text = "Chọn năm học:";
            // 
            // reportViewerDSLop
            // 
            this.reportViewerDSLop.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.HOCSINHBindingSource;
            this.reportViewerDSLop.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerDSLop.LocalReport.ReportEmbeddedResource = "QLHS_THPT.Reports.LapDanhSachLopHoc.rdlc";
            this.reportViewerDSLop.Location = new System.Drawing.Point(0, 58);
            this.reportViewerDSLop.Name = "reportViewerDSLop";
            this.reportViewerDSLop.Size = new System.Drawing.Size(792, 408);
            this.reportViewerDSLop.TabIndex = 2;
            // 
            // HOCSINHTableAdapter
            // 
            this.HOCSINHTableAdapter.ClearBeforeFill = true;
            // 
            // frptDanhSachLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 466);
            this.Controls.Add(this.reportViewerDSLop);
            this.Controls.Add(this.groupPanelDS);
            this.DoubleBuffered = true;
            this.Name = "frptDanhSachLopHoc";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH LỚP HỌC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frptDanhSachLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HOCSINHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLHS_THPTDataSet)).EndInit();
            this.groupPanelDS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelDS;
        private DevComponents.DotNetBar.ButtonX btnXem;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbNamHoc;
        private DevComponents.DotNetBar.LabelX labelX01;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbLop;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbKhoiLop;
        private DevComponents.DotNetBar.LabelX labelX1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerDSLop;
        private System.Windows.Forms.BindingSource HOCSINHBindingSource;
        private QLHS_THPTDataSet QLHS_THPTDataSet;
        private QLHS_THPTDataSetTableAdapters.HOCSINHTableAdapter HOCSINHTableAdapter;
    }
}