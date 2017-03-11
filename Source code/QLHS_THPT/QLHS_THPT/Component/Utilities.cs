using System;
using System.Text;
using System.Data;
using System.Xml;
using System.Data.SqlClient;
using System.Windows.Forms;
using QLHS_THPT.Bussiness;
using QLHS_THPT.Reports;
using QLHS_THPT.Controller;
using DevComponents.DotNetBar;
using System.Collections.Generic;

namespace QLHS_THPT.Component
{
    #region Utilities
    public static class Utilities
    {
        public static NguoiDungInfo NguoiDung;
        public static String DatabaseName;
    }
    #endregion

    #region QuyDinh
    public class QuyDinh
    {
        public String ArrayToString(String[] array, int n)
        {
            String str = "";
            for (int i = 0; i < n; i++)
            {
                if (i != n - 1)
                    str += array[i] + ";";
                else
                    str += array[i];
            }
            return str;
        }

        public Boolean KiemTraDiem(String diemSo)
        {
            IList<String> gioiHanDiem = new List<String>();

            DataService dS = new DataService();
            DataService dS1 = new DataService();
            dS.Load(new SqlCommand("SELECT GiaTri FROM THAMSO where TenThamSo = 'DiemToiThieu' "));
            dS1.Load(new SqlCommand("SELECT GiaTri FROM THAMSO where TenThamSo = 'DiemToiDa' "));

            int diemToiThieu = Convert.ToInt32(dS.Rows[0]["GiaTri"]);
            int diemToiDa = Convert.ToInt32(dS1.Rows[0]["GiaTri"]);
            float nacDiemTrongGioiHan = 0;

              if (diemToiThieu == 0  && diemToiDa == 10)
              {
                  for (int i = 0; i <= 1010; i++)
                  {
                      gioiHanDiem.Add(nacDiemTrongGioiHan.ToString());
                      nacDiemTrongGioiHan += 0.01F;
                      nacDiemTrongGioiHan = (float)Math.Round(nacDiemTrongGioiHan, 2);
                  }

                  if (gioiHanDiem.Contains(diemSo) == true)
                      return true;
                  else
                      return false;
              }
              else
              {
                  for (int i = 0; i <= 100; i++)
                  {
                      gioiHanDiem.Add(nacDiemTrongGioiHan.ToString());
                      nacDiemTrongGioiHan += 1;
                  }

                  if (gioiHanDiem.Contains(diemSo) == true)
                      return true;
                  else
                      return false;
              }
        }

        public Boolean KiemTraSiSo(int siSo)
        {
            DataService dS = new DataService();
            dS.Load(new SqlCommand("SELECT GiaTri FROM THAMSO where TenThamSo = 'SiSoToiDa'"));

            int siSoMax = Convert.ToInt32(dS.Rows[0]["GiaTri"]);
            

            if (siSo <= siSoMax)
                return true;
            else
                return false;
        }

        

        public Boolean KiemTraDoTuoi(DateTime ngaySinh)
        {
            DataService dS = new DataService();
            DataService dS1 = new DataService();
            //dS.Load(new SqlCommand("SELECT TuoiToiThieu, TuoiToiDa FROM THAMSO"));
            dS.Load(new SqlCommand("SELECT GiaTri FROM THAMSO where TenThamSo = 'TuoiToiThieu'"));
            dS1.Load(new SqlCommand("SELECT GiaTri FROM THAMSO where TenThamSo = 'TuoiToiDa'"));

            int doTuoiMin = Convert.ToInt32(dS.Rows[0]["GiaTri"]);
            int doTuoiMax = Convert.ToInt32(dS1.Rows[0]["GiaTri"]);

            int doTuoi    = DateTime.Today.Year - ngaySinh.Year;

            if (doTuoi >= doTuoiMin && doTuoi <= doTuoiMax)
                return true;
            else
                return false;
        }

        public String LaySTT(int autoNum)
        {
            if (autoNum < 10)
                return "00" + autoNum;

            else if (autoNum >= 10 && autoNum < 100)
                return "0" + autoNum;

            else if (autoNum >= 100 && autoNum < 1000)
                return "" + autoNum;

            else
                return "";
        }

        public String LaySTT1(int autoNum)
        {
            if (autoNum < 10)
                return "000" + autoNum;

            else if (autoNum >= 10 && autoNum < 100)
                return "00" + autoNum;

            else if (autoNum >= 100 && autoNum < 1000)
                return "0" + autoNum;

            else if (autoNum >= 1000 && autoNum < 10000)
                return "" + autoNum;

            else
                return "";
        }
    }
    #endregion

    #region ThamSo
    public static class ThamSo
    {
        #region Fields
        public static frmConnection             m_FrmConnection         = null;
        public static frmGiaoVien               m_FrmGiaoVien           = null;
        public static frmChuongTrinhHoc         m_FrmChuongTrinhHoc = null;
        public static frmHocKy                  m_FrmHocKy              = null;
       
        public static frmNhapDiemHS m_FrmNhapDiemChung = null;
        public static frmKhoiLop                m_FrmKhoiLop            = null;
       
        public static frmMain                   m_FrmMain               = null;
        public static frmMonHoc                 m_FrmMonHoc             = null;
       
        public static frmHocSinh                m_FrmHocSinh            = null;
        public static frmLoaiNguoiDung          m_FrmLoaiNguoiDung      = null;
        public static frmXemDiem m_FrmXemDiem = null;
        public static frmXemDiem m_FrmXemBangDiem = null;
        public static frmLoaiHinhKiemTra                m_FrmLoaiDiem = null;
        public static frptDanhSachLopHoc        m_FrmDSLopHoc = null;
        public static frptBaoCaoTongKetMon m_FrmKetQuaHocKy_MonHoc = null;
        public static frptKetQuaBaoCaoHocKy m_FrmKetQuaHocKy_Lop = null;
        public static frmTimKiemHS m_TimKiemHS = null;
        public static frmXepLop m_FrmPhanLop = null;
     
        public static frmQuyDinhToanTruong m_FrmQuyDinhDauNam = null;
        public static FrmLapDsLop m_FrmLapDsLop = null;
        public static FrmKBNamHoc m_FrmKBNamHoc = null;
        public static frmCapNhatChuongTrinhHoc m_frmCapNhatChuongTrinhHoc = null;
       
        public static frmTimKiemHS m_FrmTimHocSinh = null;
        public static frmChuyenLop m_frmChuyenLop = null;
        public static frmCapNhatDiemHS m_frmCapNhatDiemHS = null;
        #endregion

        #region Ham goi hien form
        #region Menu start
        public static void ShowFormLoaiNguoiDung()
        {
            if (m_FrmLoaiNguoiDung == null || m_FrmLoaiNguoiDung.IsDisposed)
            {
                m_FrmLoaiNguoiDung = new frmLoaiNguoiDung();
                m_FrmLoaiNguoiDung.MdiParent = frmMain.ActiveForm;
                m_FrmLoaiNguoiDung.Show();
            }
            else
                m_FrmLoaiNguoiDung.Activate();
        }
        #endregion

        #region Menu quan ly
        public static void ShowFormCapNhatDiem()
        {
            if (m_frmCapNhatDiemHS == null || m_frmCapNhatDiemHS.IsDisposed)
            {
                m_frmCapNhatDiemHS = new frmCapNhatDiemHS();
                m_frmCapNhatDiemHS.MdiParent = frmMain.ActiveForm;
                m_frmCapNhatDiemHS.Show();
            }
            else
                m_frmCapNhatDiemHS.Activate();
        }

        public static void ShowFormChuyenLop()
        {
            if (m_frmChuyenLop == null || m_frmChuyenLop.IsDisposed)
            {
                m_frmChuyenLop = new frmChuyenLop();
                m_frmChuyenLop.MdiParent = frmMain.ActiveForm;
                m_frmChuyenLop.Show();
            }
            else
                m_frmChuyenLop.Activate();
        }


        public static void ShowFormTimKiemHocSinh()
        {
            if (m_FrmTimHocSinh == null || m_FrmTimHocSinh.IsDisposed)
            {
                m_FrmTimHocSinh = new frmTimKiemHS();
                m_FrmTimHocSinh.MdiParent = frmMain.ActiveForm;
                m_FrmTimHocSinh.Show();
            }
            else
                m_FrmTimHocSinh.Activate();
        }

       
        public static void ShowFormCapNhatChuongTrinhHoc()
        {
            if (m_frmCapNhatChuongTrinhHoc == null || m_frmCapNhatChuongTrinhHoc.IsDisposed)
            {
                m_frmCapNhatChuongTrinhHoc = new frmCapNhatChuongTrinhHoc();
                m_frmCapNhatChuongTrinhHoc.MdiParent = frmMain.ActiveForm;
                m_frmCapNhatChuongTrinhHoc.Show();
            }
            else
                m_frmCapNhatChuongTrinhHoc.Activate();
        }

        public static void ShowFormKBNamHoc()
        {
            if (m_FrmKBNamHoc == null || m_FrmKBNamHoc.IsDisposed)
            {
                m_FrmKBNamHoc = new FrmKBNamHoc();
                m_FrmKBNamHoc.MdiParent = frmMain.ActiveForm;
                m_FrmKBNamHoc.Show();
            }
            else
                m_FrmKBNamHoc.Activate();
        }

        public static void ShowFormPhanLopHoc()
        {
            if (m_FrmLapDsLop == null || m_FrmLapDsLop.IsDisposed)
            {
                m_FrmLapDsLop = new FrmLapDsLop();
                m_FrmLapDsLop.MdiParent = frmMain.ActiveForm;
                m_FrmLapDsLop.Show();
            }
            else
                m_FrmLapDsLop.Activate();
        }

       

        public static void ShowFormKhoiLop()
        {
            if (m_FrmKhoiLop == null || m_FrmKhoiLop.IsDisposed)
            {
                m_FrmKhoiLop = new frmKhoiLop();
                m_FrmKhoiLop.MdiParent = frmMain.ActiveForm;
                m_FrmKhoiLop.Show();
            }
            else
                m_FrmKhoiLop.Activate(); 
        }

        public static void ShowFormQuyDinhDauNam()
        {
            if (m_FrmQuyDinhDauNam == null || m_FrmQuyDinhDauNam.IsDisposed)
            {
                m_FrmQuyDinhDauNam = new frmQuyDinhToanTruong();
                m_FrmQuyDinhDauNam.MdiParent = frmMain.ActiveForm;
                m_FrmQuyDinhDauNam.Show();
            }
            else
                m_FrmQuyDinhDauNam.Activate();
        }

        public static void ShowFormHocKy()
        {
            if (m_FrmHocKy == null || m_FrmHocKy.IsDisposed)
            {
                m_FrmHocKy = new frmHocKy();
                m_FrmHocKy.MdiParent = frmMain.ActiveForm;
                m_FrmHocKy.Show();
            }
            else
                m_FrmHocKy.Activate(); 
        }

        

        public static void ShowFormMonHoc()
        {
            if (m_FrmMonHoc == null || m_FrmMonHoc.IsDisposed)
            {
                m_FrmMonHoc = new frmMonHoc();
                m_FrmMonHoc.MdiParent = frmMain.ActiveForm;
                m_FrmMonHoc.Show();
            }
            else
                m_FrmMonHoc.Activate(); 
        }

        public static void ShowFormLoaiHinhKiemTra()
        {
            if (m_FrmLoaiDiem == null || m_FrmLoaiDiem.IsDisposed)
            {
                m_FrmLoaiDiem = new frmLoaiHinhKiemTra();
                m_FrmLoaiDiem.MdiParent = frmMain.ActiveForm;
                m_FrmLoaiDiem.Show();
            }
            else
                m_FrmLoaiDiem.Activate(); 
        }


        public static void ShowFormNhapDiemChung()
        {
            if (m_FrmNhapDiemChung == null || m_FrmNhapDiemChung.IsDisposed)
            {
                m_FrmNhapDiemChung = new frmNhapDiemHS();
                m_FrmNhapDiemChung.MdiParent = frmMain.ActiveForm;
                m_FrmNhapDiemChung.Show();
            }
            else
                m_FrmNhapDiemChung.Activate();
        }

        public static void ShowFormXemDiem()
        {
            if (m_FrmXemDiem == null || m_FrmXemDiem.IsDisposed)
            {
                m_FrmXemDiem = new frmXemDiem();
                m_FrmXemDiem.MdiParent = frmMain.ActiveForm;
                m_FrmXemDiem.Show();
            }
            else
                m_FrmXemDiem.Activate();
        }

        public static void ShowFormXemBangDiem()
        {
            if (m_FrmXemBangDiem == null || m_FrmXemBangDiem.IsDisposed)
            {
                m_FrmXemBangDiem = new frmXemDiem();
                m_FrmXemBangDiem.MdiParent = frmMain.ActiveForm;
                m_FrmXemBangDiem.Show();
            }
            else
                m_FrmXemBangDiem.Activate();
        }

        public static void ShowFormChuongTrinhHoc()
        {
            if (m_FrmChuongTrinhHoc == null || m_FrmChuongTrinhHoc.IsDisposed)
            {
                m_FrmChuongTrinhHoc = new frmChuongTrinhHoc();
                m_FrmChuongTrinhHoc.MdiParent = frmMain.ActiveForm;
                m_FrmChuongTrinhHoc.Show();
            }
            else
                m_FrmChuongTrinhHoc.Activate(); 
        }

        public static void ShowFormHocSinh()
        {
            if (m_FrmHocSinh == null || m_FrmHocSinh.IsDisposed)
            {
                m_FrmHocSinh = new frmHocSinh();
                m_FrmHocSinh.MdiParent = frmMain.ActiveForm;
                m_FrmHocSinh.Show();
            }
            else
                m_FrmHocSinh.Activate(); 
        }

        public static void ShowFormPhanLop()
        {
            if (m_FrmPhanLop == null || m_FrmPhanLop.IsDisposed)
            {
                m_FrmPhanLop = new frmXepLop();
                m_FrmPhanLop.MdiParent = frmMain.ActiveForm;
                m_FrmPhanLop.Show();
            }
            else
                m_FrmPhanLop.Activate();
        }

      
        public static void ShowFormGiaoVien()
        {
            if (m_FrmGiaoVien == null || m_FrmGiaoVien.IsDisposed)
            {
                m_FrmGiaoVien = new frmGiaoVien();
                m_FrmGiaoVien.MdiParent = frmMain.ActiveForm;
                m_FrmGiaoVien.Show();
            }
            else
                m_FrmGiaoVien.Activate(); 
        }

        public static void ShowFormDanhSachLopHoc()
        {
            if (m_FrmDSLopHoc == null || m_FrmDSLopHoc.IsDisposed)
            {
                m_FrmDSLopHoc = new frptDanhSachLopHoc();
                m_FrmDSLopHoc.MdiParent = frmMain.ActiveForm;
                m_FrmDSLopHoc.Show();
            }
            else
                m_FrmDSLopHoc.Activate();
        }
            
        #endregion

        #region Menu thong ke
        public static void ShowFormKQHKTheoLop()
        {
            if (m_FrmKetQuaHocKy_Lop == null || m_FrmKetQuaHocKy_Lop.IsDisposed)
            {
                m_FrmKetQuaHocKy_Lop = new frptKetQuaBaoCaoHocKy();
                m_FrmKetQuaHocKy_Lop.MdiParent = frmMain.ActiveForm;
                m_FrmKetQuaHocKy_Lop.Show();
            }
            else
                m_FrmKetQuaHocKy_Lop.Activate();
        }
        #endregion

        #region Menu tra cuu
        public static void ShowFormTimKiemHS()
        {
            if (m_TimKiemHS == null || m_TimKiemHS.IsDisposed)
            {
                m_TimKiemHS = new frmTimKiemHS();
                m_TimKiemHS.MdiParent = frmMain.ActiveForm;
                m_TimKiemHS.Show();
            }
            else
                m_TimKiemHS.Activate();
        }

        public static void ShowFormKQHKTheoMon()
        {
            if (m_FrmKetQuaHocKy_MonHoc == null || m_FrmKetQuaHocKy_MonHoc.IsDisposed)
            {
                m_FrmKetQuaHocKy_MonHoc = new frptBaoCaoTongKetMon();
                m_FrmKetQuaHocKy_MonHoc.MdiParent = frmMain.ActiveForm;
                m_FrmKetQuaHocKy_MonHoc.Show();
            }
            else
                m_FrmKetQuaHocKy_MonHoc.Activate();
        }
        #endregion

        #region Menu quy dinh
   
        public static void ShowFormKetNoi()
        {
            if (m_FrmConnection == null || m_FrmConnection.IsDisposed)
            {
                m_FrmConnection = new frmConnection();
                m_FrmConnection.Show();
            }
            else
                m_FrmConnection.Activate();
        }
        #endregion

        #region Menu giup do
        public static void ShowFormThongTin()
        {
           
        }
        #endregion
        #endregion
    }
    #endregion

    #region Các hàm xử lý tập tin XML
    public class XML
    {
        public static XmlDocument XMLReader(String filename)
        {
            XmlDocument xmlR = new XmlDocument();
            try
            {
                xmlR.Load(filename);
            }
            catch
            {
                MessageBoxEx.Show("Không đọc được hoặc không tồn tại tập tin cấu hình " + filename, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return xmlR;
        }

        public static void XMLWriter(String filename, String servname, String database, String costatus)
        {
            XmlTextWriter xmlW = new XmlTextWriter(filename, null);
            xmlW.Formatting = Formatting.Indented;

            xmlW.WriteStartDocument();
            xmlW.WriteComment("\nKhong duoc thay doi noi dung file nay!\n" +
                                "Thong so co ban:\n\t" +
                                "costatus = true : quyen Windows\n\t" +
                                "costatus = false: quyen SQL Server\n\t" +
                                "servname: ten server\n\t" +
                                "username: ten dang nhap he thong\n\t" +
                                "password: mat khau dang nhap he thong\n\t" +
                                "database: ten co so du lieu\n");
            xmlW.WriteStartElement("config");

            xmlW.WriteStartElement("costatus");
            xmlW.WriteString(costatus);
            xmlW.WriteEndElement();
            
            xmlW.WriteStartElement("servname");
            xmlW.WriteString(servname);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("username");
            xmlW.WriteString("");
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("password");
            xmlW.WriteString("");
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("database");
            xmlW.WriteString(database);
            xmlW.WriteEndElement();

            xmlW.WriteEndElement();
            xmlW.WriteEndDocument();

            xmlW.Close();
        }

        public static void XMLWriter(String filename, String servname, String username, String password, String database, String costatus)
        {
            XmlTextWriter xmlW = new XmlTextWriter(filename, null);
            xmlW.Formatting = Formatting.Indented;

            xmlW.WriteStartDocument();
            xmlW.WriteComment("\nKhong duoc thay doi noi dung file nay!\n" +
                                "Thong so co ban:\n\t" +
                                "costatus = true : quyen Windows\n\t" +
                                "costatus = false: quyen SQL Server\n\t" +
                                "servname: ten server\n\t" +
                                "username: ten dang nhap he thong\n\t" +
                                "password: mat khau dang nhap he thong\n\t" +
                                "database: ten co so du lieu\n");
            xmlW.WriteStartElement("config");
            
            xmlW.WriteStartElement("costatus");
            xmlW.WriteString(costatus);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("servname");
            xmlW.WriteString(servname);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("username");
            xmlW.WriteString(username);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("password");
            xmlW.WriteString(password);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("database");
            xmlW.WriteString(database);
            xmlW.WriteEndElement();

            xmlW.WriteEndElement();
            xmlW.WriteEndDocument();

            xmlW.Close();
        }
    }
    #endregion
}