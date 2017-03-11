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
    public partial class frptBaoCaoTongKetMon : Office2007Form
    {
        #region Fields
        NamHocCtrl  m_NamHocCtrl    = new NamHocCtrl();
        HocKyCtrl   m_HocKyCtrl     = new HocKyCtrl();
        LopCtrl     m_LopCtrl       = new LopCtrl();
        MonHocCtrl  m_MonHocCtrl    = new MonHocCtrl();
        #endregion

        #region Constructor
        public frptBaoCaoTongKetMon()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void frptKetQuaHocKy_MonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLHS_THPTDataSet.CT_BAOCAOTONGKETMON' table. You can move, or remove it, as needed.
           
            m_NamHocCtrl.HienThiComboBox(cmbNamHoc);    
            m_MonHocCtrl.HienThiComboBox(cmbMonHoc);        
        }
        #endregion

        #region SelectedIndexChanged event
        private void cmbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null)
                m_HocKyCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbHocKy);
            cmbHocKy.DataBindings.Clear();
        }

      
        #endregion

        #region Click event
        private void btnXem_Click(object sender, EventArgs e)
        {
          
            IList<ReportParameter> param = new List<ReportParameter>();
        //    QuyDinhInfo m_ThongTinTruong = QuyDinh.LayThongTinTruong();
          //  param.Add(new ReportParameter("TenTruong", m_ThongTinTruong.TenTruong));
           // param.Add(new ReportParameter("DiaChiTruong", m_ThongTinTruong.DiaChiTruong));
            param.Add(new ReportParameter("NgayLap", DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year));
         //   param.Add(new ReportParameter("NamHoc", cmbNamHoc.Text));
            param.Add(new ReportParameter("HocKy", cmbHocKy.Text));
         //   param.Add(new ReportParameter("Lop", cmbLop.Text));
            param.Add(new ReportParameter("MonHoc", cmbMonHoc.Text));

            this.reportViewer1.LocalReport.SetParameters(param);
            this.cT_BAOCAOTONGKETMONTableAdapter.Fill(this.qLHS_THPTDataSet.CT_BAOCAOTONGKETMON, cmbHocKy.Text, cmbNamHoc.Text, cmbMonHoc.Text);
            //this.cT_BAOCAOTONGKETMONTableAdapter.Fill(this.QLHS_THPTDataSet.CT_BAOCAOTONGKETMON, cmbHocKy.Text, cmbNamHoc.Text, cmbMonHoc.Text);
            this.reportViewer1.RefreshReport();
      
        }
        #endregion
    }
}