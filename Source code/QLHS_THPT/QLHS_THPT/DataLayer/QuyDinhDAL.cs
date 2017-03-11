using System;
using System.Data.SqlClient;
using QLHS_THPT.Bussiness;
using System.Data;
using QLHS_THPT.Component;

namespace QLHS_THPT.DataLayer
{
    public class QuyDinhDAL : ConnectData
    {

        /// <summary>
        /// Lấy giá trị quy định
        /// </summary>
        /// <param name="khoa">string: khóa</param>
        /// <returns>object: giá trị</returns>
        public object LayGiaTri(string khoa)
        {
            string sql = "SELECT GiaTri FROM ThamSo WHERE TenThamSo = '" + khoa + "'";
            return ExecuteScalar(sql);
        }

       

        public int Dem_SiSo_Lop(string maLop, string maHocKy)
        {
            string sql = "SELECT count(*) FROM QUATRINHHOC WHERE MaLop = '" + maLop + "' AND MaHocKy = '" + maHocKy + "'";
            return Convert.ToInt32(ExecuteScalar(sql));
        }
        /// <summary>
        /// Sửa quy định
        /// </summary>
        /// <param name="quyDinhDTO">QuyDinhDTO</param>
        /// <returns></returns>
        public bool SuaQuyDinh(QuyDinhDTO quyDinhDTO)
        {
            string sql = string.Format("UPDATE THAMSO SET GiaTri= N'{0}' WHERE TenThamSo = 'DiaChiTruong'\n",
                                       quyDinhDTO.DiaChiTruong);
            sql += string.Format("UPDATE THAMSO SET GiaTri= N'{0}' WHERE TenThamSo = 'TenTruong'\n",
                                quyDinhDTO.TenTruong);

            sql += string.Format("UPDATE THAMSO SET GiaTri= N'{0}' WHERE TenThamSo = 'SiSoToiDa'\n",
                              quyDinhDTO.SiSoToiDa);

            sql += string.Format("UPDATE THAMSO SET GiaTri= N'{0}' WHERE TenThamSo = 'TuoiToiThieu'\n",
                             quyDinhDTO.TuoiToiThieu);
            sql += string.Format("UPDATE THAMSO SET GiaTri= N'{0}' WHERE TenThamSo = 'TuoiToiDa'\n",
                                 quyDinhDTO.TuoiToiDa);

            sql += string.Format("UPDATE THAMSO SET GiaTri= N'{0}' WHERE TenThamSo = 'DiemDat'\n",
                                 quyDinhDTO.DiemDat);
            sql += string.Format("UPDATE THAMSO SET GiaTri= N'{0}' WHERE TenThamSo = 'DiemDatMon'\n",
                                 quyDinhDTO.DiemDatMon);

            sql += string.Format("UPDATE THAMSO SET GiaTri= N'{0}' WHERE TenThamSo = 'DiemToiThieu'\n",
                                quyDinhDTO.DiemToiThieu);
            sql += string.Format("UPDATE THAMSO SET GiaTri= N'{0}' WHERE TenThamSo = 'DiemToiDa'\n",
                                 quyDinhDTO.DiemToiDa);

            sql += string.Format("UPDATE THAMSO SET NgayApDung = '{0:dd-MM-yyyy}' WHERE TenThamSo = 'DiemDat'\n",
                                 quyDinhDTO.NgayApDungDiemDat);
            sql += string.Format("UPDATE THAMSO SET NgayApDung = '{0:dd-MM-yyyy}' WHERE TenThamSo = 'DiemDatMon'\n",
                                quyDinhDTO.NgayApDungDiemDatMon);
            sql += string.Format("UPDATE THAMSO SET NgayApDung = '{0:dd-MM-yyyy}' WHERE TenThamSo = 'DiemToiThieu'\n",
                                quyDinhDTO.NgayApDungDiemToiThieu);
            sql += string.Format("UPDATE THAMSO SET NgayApDung = '{0:dd-MM-yyyy}' WHERE TenThamSo = 'DiemToiDa'\n",
                                quyDinhDTO.NgayApDungDiemToiDa);
            sql += string.Format("UPDATE THAMSO SET NgayApDung = '{0:dd-MM-yyyy}' WHERE TenThamSo = 'TuoiToiThieu'\n",
                                quyDinhDTO.NgayApDungTuoiToiThieu);
            sql += string.Format("UPDATE THAMSO SET NgayApDung = '{0:dd-MM-yyyy}' WHERE TenThamSo = 'TuoiToiDa'\n",
                                quyDinhDTO.NgayApDungTuoiToiDa);
            sql += string.Format("UPDATE THAMSO SET NgayApDung = '{0:dd-MM-yyyy}' WHERE TenThamSo = 'SiSoToiDa'\n",
                                quyDinhDTO.NgayApDungSiSoToiDa);




            return ExecuteQuery(sql) > 0;
        }

        /// <summary>
        /// Lấy danh sách quy định
        /// </summary>
        /// <returns></returns>
        public QuyDinhDTO LayDS_QuyDinh()
        {
            string sql = "SELECT * FROM THAMSO";
            OpenConnection();
            SqlDataReader dr = ExecuteReader(sql);
            var quyDinh = new QuyDinhDTO();
            while (dr.Read())
            {
                switch (Convert.ToString(dr["TenThamSo"]))
                {
                    case "TenTruong":
                        quyDinh.TenTruong = Convert.ToString(dr["GiaTri"]);
                        break;
                    case "DiaChiTruong":
                        quyDinh.DiaChiTruong = Convert.ToString(dr["GiaTri"]);
                        break;

                    case "DiemDat":
                        quyDinh.DiemDat = Convert.ToDouble(dr["GiaTri"]);
                        quyDinh.NgayApDungDiemDat = Convert.ToDateTime(dr["NgayApDung"]);
                        break;
                    case "DiemDatMon":
                        quyDinh.DiemDatMon = Convert.ToDouble(dr["GiaTri"]);
                        quyDinh.NgayApDungDiemDatMon = Convert.ToDateTime(dr["NgayApDung"]);
                        break;

                    case "SiSoToiDa":
                        quyDinh.SiSoToiDa = Convert.ToInt32(dr["GiaTri"]);
                        quyDinh.NgayApDungSiSoToiDa = Convert.ToDateTime(dr["NgayApDung"]);
                        break;

                    case "TuoiToiThieu":
                        quyDinh.TuoiToiThieu = Convert.ToInt32(dr["GiaTri"]);
                        quyDinh.NgayApDungTuoiToiThieu = Convert.ToDateTime(dr["NgayApDung"]);
                        break;
                    case "TuoiToiDa":
                        quyDinh.TuoiToiDa = Convert.ToInt32(dr["GiaTri"]);
                        quyDinh.NgayApDungTuoiToiDa = Convert.ToDateTime(dr["NgayApDung"]);
                        break;

                    case "DiemToiThieu":
                        quyDinh.DiemToiThieu = Convert.ToDouble(dr["GiaTri"]);
                        quyDinh.NgayApDungDiemToiThieu = Convert.ToDateTime(dr["NgayApDung"]);
                        break;
                    case "DiemToiDa":
                        quyDinh.DiemToiDa = Convert.ToDouble(dr["GiaTri"]);
                        quyDinh.NgayApDungDiemToiDa = Convert.ToDateTime(dr["NgayApDung"]);
                        break;
                }
            }
            CloseConnection();
            return quyDinh;
        }
    }
}