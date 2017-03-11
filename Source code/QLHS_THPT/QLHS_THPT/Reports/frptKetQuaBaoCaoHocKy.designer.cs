namespace QLHS_THPT.Reports
{
    partial class frptKetQuaBaoCaoHocKy
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
            this.CT_BAOCAOTONGKETHOCKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLHS_THPTDataSet = new QLHS_THPT.Reports.QLHS_THPTDataSet();
            this.groupPanelDS = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnXem = new DevComponents.DotNetBar.ButtonX();
            this.cmbHocKy = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cmbNamHoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX0 = new DevComponents.DotNetBar.LabelX();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CT_BAOCAOTONGKETHOCKYTableAdapter = new QLHS_THPT.Reports.QLHS_THPTDataSetTableAdapters.CT_BAOCAOTONGKETHOCKYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CT_BAOCAOTONGKETHOCKYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLHS_THPTDataSet)).BeginInit();
            this.groupPanelDS.SuspendLayout();
            this.SuspendLayout();
            // 
            // CT_BAOCAOTONGKETHOCKYBindingSource
            // 
            this.CT_BAOCAOTONGKETHOCKYBindingSource.DataMember = "CT_BAOCAOTONGKETHOCKY";
            this.CT_BAOCAOTONGKETHOCKYBindingSource.DataSource = this.QLHS_THPTDataSet;
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
            this.groupPanelDS.Controls.Add(this.btnXem);
            this.groupPanelDS.Controls.Add(this.cmbHocKy);
            this.groupPanelDS.Controls.Add(this.labelX1);
            this.groupPanelDS.Controls.Add(this.cmbNamHoc);
            this.groupPanelDS.Controls.Add(this.labelX0);
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
            // btnXem
            // 
            this.btnXem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXem.Location = new System.Drawing.Point(396, 16);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 20);
            this.btnXem.TabIndex = 4;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.DisplayMember = "Text";
            this.cmbHocKy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.ItemHeight = 14;
            this.cmbHocKy.Location = new System.Drawing.Point(236, 16);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(110, 20);
            this.cmbHocKy.TabIndex = 2;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(194, 16);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(45, 20);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Học kỳ:";
            // 
            // cmbNamHoc
            // 
            this.cmbNamHoc.DisplayMember = "Text";
            this.cmbNamHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNamHoc.FormattingEnabled = true;
            this.cmbNamHoc.ItemHeight = 14;
            this.cmbNamHoc.Location = new System.Drawing.Point(64, 16);
            this.cmbNamHoc.Name = "cmbNamHoc";
            this.cmbNamHoc.Size = new System.Drawing.Size(110, 20);
            this.cmbNamHoc.TabIndex = 1;
            this.cmbNamHoc.SelectedIndexChanged += new System.EventHandler(this.cmbNamHoc_SelectedIndexChanged);
            // 
            // labelX0
            // 
            this.labelX0.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX0.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX0.Location = new System.Drawing.Point(12, 16);
            this.labelX0.Name = "labelX0";
            this.labelX0.Size = new System.Drawing.Size(55, 20);
            this.labelX0.TabIndex = 0;
            this.labelX0.Text = "Năm học:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CT_BAOCAOTONGKETHOCKYBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLHS_THPT.Reports.BaoCaoTongKetHocKy.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 58);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(792, 408);
            this.reportViewer1.TabIndex = 2;
            // 
            // CT_BAOCAOTONGKETHOCKYTableAdapter
            // 
            this.CT_BAOCAOTONGKETHOCKYTableAdapter.ClearBeforeFill = true;
            // 
            // frptKetQuaBaoCaoHocKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 466);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupPanelDS);
            this.DoubleBuffered = true;
            this.Name = "frptKetQuaBaoCaoHocKy";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KẾT QUẢ HỌC KỲ THEO LỚP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frptKetQuaHocKy_Lop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CT_BAOCAOTONGKETHOCKYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLHS_THPTDataSet)).EndInit();
            this.groupPanelDS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelDS;
        private DevComponents.DotNetBar.ButtonX btnXem;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbHocKy;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbNamHoc;
        private DevComponents.DotNetBar.LabelX labelX0;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CT_BAOCAOTONGKETHOCKYBindingSource;
        private QLHS_THPTDataSet QLHS_THPTDataSet;
        private QLHS_THPTDataSetTableAdapters.CT_BAOCAOTONGKETHOCKYTableAdapter CT_BAOCAOTONGKETHOCKYTableAdapter;
    }
}