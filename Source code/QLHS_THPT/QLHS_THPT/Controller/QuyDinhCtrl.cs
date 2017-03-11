using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;
using QLHS_THPT.DataLayer;
using QLHS_THPT.Bussiness;

namespace QLHS_THPT.Controller
{
    public class QuyDinhCtrl
    {
       
        QuyDinhData m_QuyDinhData = new QuyDinhData();

        public QuyDinhCtrl()
        {
           
        }

       

     

        public void HienThi(IntegerInput txtSiSoToiDa,
                            IntegerInput txtTuoiToiThieu,
                            IntegerInput txtTuoiToiDa, 
                            TextBoxX txtDiemToiThieu, 
                            TextBoxX txtDiemToiDa,
                            TextBoxX txtDiemDat,
                            TextBoxX txtDiemDatMon)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_QuyDinhData.LayDsQuyDinh();

            DataTable dT = m_QuyDinhData.LayDsQuyDinh();
            foreach (DataRow row in dT.Rows)
            {
               
                txtSiSoToiDa.DataBindings.Clear();
                txtSiSoToiDa.DataBindings.Add("Value", bS, "GiaTri");

                txtTuoiToiThieu.DataBindings.Clear();
                txtTuoiToiThieu.DataBindings.Add("Value", bS, "GiaTri");

                if (row["TenThamSo"].ToString() == "TuoiToiDa")
                {
                    txtTuoiToiDa.DataBindings.Clear();
                  //  txtTuoiToiDa.DataBindings.Add("Value", bS, "GiaTri");
                
                  
                }

                txtDiemToiThieu.DataBindings.Clear();
                txtDiemToiThieu.DataBindings.Add("Text", bS, "GiaTri");

                txtDiemToiDa.DataBindings.Clear();
                txtDiemToiDa.DataBindings.Add("Text", bS, "GiaTri");

                txtDiemDat.DataBindings.Clear();
                txtDiemDat.DataBindings.Add("Text", bS, "GiaTri");

                txtDiemDatMon.DataBindings.Clear();
                txtDiemDatMon.DataBindings.Add("Text", bS, "GiaTri");
            }
        }

        public void CapNhatQuyDinhSiSo(int siSoToiDa)
        {
            m_QuyDinhData.CapNhatQuyDinhSiSo(siSoToiDa);
        }

        public void CapNhatQuyDinhDoTuoi(int tuoiToiThieu, int tuoiToiDa)
        {
            m_QuyDinhData.CapNhatQuyDinhDoTuoi(tuoiToiThieu, tuoiToiDa);
        }

        public void CapNhatQuyDinhThangDiem(String diemToiThieu, String diemToiDa)
        {
            m_QuyDinhData.CapNhatQuyDinhThangDiem(diemToiThieu, diemToiDa);
        }

        public void CapNhatQuyDinhDiemChuan(String diemDat, String diemDatMon)
        {
            m_QuyDinhData.CapNhatQuyDinhDiemChuan(diemDat, diemDatMon);
        }
    }
}
