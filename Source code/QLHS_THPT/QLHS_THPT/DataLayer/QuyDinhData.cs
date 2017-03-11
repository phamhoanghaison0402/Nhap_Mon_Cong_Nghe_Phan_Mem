using System;
using System.Data;
using System.Data.SqlClient;
using QLHS_THPT.Controller;
using QLHS_THPT.Bussiness;
using QLHS_THPT.Component;

namespace QLHS_THPT.DataLayer
{
    public class QuyDinhData 
    {
        DataService m_QuyDinhData = new DataService();

        public DataTable LayDsQuyDinh()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM THAMSO");
            m_QuyDinhData.Load(cmd);
            return m_QuyDinhData;
          
        }

     

        public void CapNhatQuyDinhSiSo(int siSoToiDa)
        {
            SqlCommand cmd = new SqlCommand("UPDATE THAMSO SET SiSoToiDa = @siSoToiDa");
            cmd.Parameters.Add("siSoToiDa", SqlDbType.Int).Value  = siSoToiDa;

          //  m_QuyDinhData.Load(cmd);
        }

        public void CapNhatQuyDinhDoTuoi(int tuoiToiThieu, int tuoiToiDa)
        {
            SqlCommand cmd = new SqlCommand("UPDATE THAMSO SET TuoiToiThieu = @tuoiToiThieu, TuoiToiDa = @tuoiToiDa");
            cmd.Parameters.Add("tuoiToiThieu", SqlDbType.Int).Value = tuoiToiThieu;
            cmd.Parameters.Add("tuoiToiDa", SqlDbType.Int).Value = tuoiToiDa;

          //  m_QuyDinhData.Load(cmd);
        }

        public void CapNhatQuyDinhThangDiem(String diemToiThieu, String diemToiDa)
        {
            SqlCommand cmd = new SqlCommand("UPDATE THAMSO SET DiemToiThieu = @diemToiThieu, DiemToiDa = @diemToiDa");
            cmd.Parameters.Add("diemToiThieu", SqlDbType.Float).Value = diemToiThieu;
            cmd.Parameters.Add("diemToiDa", SqlDbType.Float).Value = diemToiDa;

          //  m_QuyDinhData.Load(cmd);
        }

        public void CapNhatQuyDinhDiemChuan(String diemDat, String diemDatMon)
        {
            SqlCommand cmd = new SqlCommand("UPDATE THAMSO SET DiemDat = @diemDat, DiemDatMon = @diemDatMon");
            cmd.Parameters.Add("diemDat", SqlDbType.Float).Value = diemDat;
            cmd.Parameters.Add("diemDatMon", SqlDbType.Float).Value = diemDatMon;

          //  m_QuyDinhData.Load(cmd);
        }
    

     

    }
}
