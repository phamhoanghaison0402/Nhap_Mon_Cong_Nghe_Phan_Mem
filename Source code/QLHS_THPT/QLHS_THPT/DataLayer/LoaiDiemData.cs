using System;
using System.Data;
using System.Data.SqlClient;

namespace QLHS_THPT.DataLayer
{
    public class LoaiDiemData
    {
        DataService m_LoaiDiemData = new DataService();

        public DataTable LayDsLoaiDiem()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOAIHINHKIEMTRA");
            m_LoaiDiemData.Load(cmd);
            return m_LoaiDiemData;
        }

        public DataRow ThemDongMoi()
        {
            return m_LoaiDiemData.NewRow();
        }

        public void ThemLoaiDiem(DataRow m_Row)
        {
            m_LoaiDiemData.Rows.Add(m_Row);
        }

        public bool LuuLoaiDiem()
        {
            return m_LoaiDiemData.ExecuteNoneQuery() > 0;
        }

        public DataTable LayDsLoaiDiem(String lop, String monHoc)
        {
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT BD.MaLoaiKT, TenLoaiKT FROM MONHOC MH,BANGDIEM BD, LOAIHINHKIEMTRA LD, LOP L, QUATRINHHOC QTH WHERE MH.MaMonHoc = BD.MaMonHoc AND BD.MaLoaiKT = LD.MaLoaiKT AND QTH.MaQuaTrinhHoc = BD.MaQuaTrinhHoc AND QTH.MaLop = L.MaLop AND L.MaLop = @lop AND BD.MaMonHoc = @monHoc");
            cmd.Parameters.Add("lop", SqlDbType.VarChar).Value = lop;
            cmd.Parameters.Add("monHoc", SqlDbType.VarChar).Value = monHoc;

            m_LoaiDiemData.Load(cmd);
            return m_LoaiDiemData;
        }
    }
}
