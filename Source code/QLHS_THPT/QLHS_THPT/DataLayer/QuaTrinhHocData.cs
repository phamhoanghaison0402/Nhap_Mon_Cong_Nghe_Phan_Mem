using System;
using System.Data;
using System.Data.SqlClient;

namespace QLHS_THPT.DataLayer
{
    public class QuaTrinhHocData
    {
        DataService m_QuaTrinhHocData = new DataService();

        public DataTable LayDsQTH()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM QUATRINHHOC");
            m_QuaTrinhHocData.Load(cmd);
            return m_QuaTrinhHocData;
        }

        public DataTable LayDsQTH(String hocSinh, String hocKy)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM QUATRINHHOC QTH, HOCSINH HS WHERE QTH.MaHocSinh = HS.MaHocSinh AND HS.MaHocSinh = @hocSinh AND QTH.MaHocKy = @hocKy");
            cmd.Parameters.Add("hocSinh", SqlDbType.VarChar).Value = hocSinh;
            cmd.Parameters.Add("hocKy", SqlDbType.VarChar).Value = hocKy;

            m_QuaTrinhHocData.Load(cmd);
            return m_QuaTrinhHocData;
        }
    }
}
      