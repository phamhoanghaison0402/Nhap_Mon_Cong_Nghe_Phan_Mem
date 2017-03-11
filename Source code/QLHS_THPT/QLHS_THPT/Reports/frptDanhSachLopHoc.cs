using System;
using System.Text;
using System.Drawing;
using QLHS_THPT.Bussiness;
using QLHS_THPT.Component;
using QLHS_THPT.Controller;
using DevComponents.DotNetBar;
using System.Collections.Generic;
using Microsoft.Reporting.WinForms;

namespace QLHS_THPT.Reports
{
    public partial class frptDanhSachLopHoc : Office2007Form
    {
        #region Field
        NamHocCtrl m_NamHocCtrl = new NamHocCtrl();
        LopCtrl m_LopCtrl = new LopCtrl();
        KhoiLopCtrl m_KhoiLopCtrl = new KhoiLopCtrl();
        HocSinhCtrl m_HocSinhCtrl = new HocSinhCtrl();
        #endregion

        #region Constructor
        public frptDanhSachLopHoc()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void frptDanhSachLopHoc_Load(object sender, EventArgs e)
        { 
            m_NamHocCtrl.HienThiComboBox(cmbNamHoc);
        }
        #endregion

        #region Click event
        private void btnXem_Click(object sender, EventArgs e)
        {           
            IList<ReportParameter> param = new List<ReportParameter>();    
            param.Add(new ReportParameter("NgayLap", DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year));
            param.Add(new ReportParameter("NamHoc", cmbNamHoc.Text));
            param.Add(new ReportParameter("Lop", cmbLop.Text));
            
            this.reportViewerDSLop.LocalReport.SetParameters(param);
            this.HOCSINHTableAdapter.Fill(this.QLHS_THPTDataSet.HOCSINH, cmbNamHoc.Text, cmbLop.Text);
            this.reportViewerDSLop.RefreshReport();       
        }

        #endregion

        private void cmbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null)
                m_KhoiLopCtrl.HienThiComboBox_new(cmbNamHoc.SelectedValue.ToString(), cmbKhoiLop);
            cmbLop.DataBindings.Clear();
        }

        private void cmbKhoiLop_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (cmbNamHoc.SelectedValue != null && cmbKhoiLop.SelectedValue != null)
                 m_LopCtrl.HienThiComboBox(cmbKhoiLop.SelectedValue.ToString(), cmbNamHoc.SelectedValue.ToString(), cmbLop);
        }
    }
}