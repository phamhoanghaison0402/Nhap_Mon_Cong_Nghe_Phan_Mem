using System;
using System.Data;
using System.Data.SqlClient;

namespace QLHS_THPT.DataLayer
{
    public class HocKyData
    {
        DataService m_HocKyData = new DataService();

        public DataTable LayDsHocKy()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOCKY");
            m_HocKyData.Load(cmd);
            return m_HocKyData;
        }
        //Mới
        public DataTable LayDsHocKy(String namHoc)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOCKY HK, NAMHOC NH WHERE HK.MaNamHoc = NH.MaNamHoc AND NH.MaNamHoc = @namHoc");
            cmd.Parameters.Add("namHoc", SqlDbType.VarChar).Value = namHoc;

            m_HocKyData.Load(cmd);
            return m_HocKyData;
        }

        public DataRow ThemDongMoi()
        {
            return m_HocKyData.NewRow();
        }

        public void ThemHocKy(DataRow m_Row)
        {
            m_HocKyData.Rows.Add(m_Row);
        }

        public bool LuuHocKy()
        {
            return m_HocKyData.ExecuteNoneQuery() > 0;
        }
    }
}
