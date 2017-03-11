using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;
using QLHS_THPT.DataLayer;
using QLHS_THPT.Bussiness;

namespace QLHS_THPT.Controller
{
    public class HocSinhCtrl
    {
        HocSinhData m_HocSinhData = new HocSinhData();

        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = m_HocSinhData.LayDsHocSinh();
            comboBox.DisplayMember = "HoTen";
            comboBox.ValueMember = "MaHocSinh";
        }

        public void HienThiComboBox(String namHoc, String lop, String hocKy, ComboBoxEx comboBox)
        {
            HocSinhData m_HSData = new HocSinhData();

            comboBox.DataSource = m_HSData.LayDsHocSinhTheoQTH(namHoc, lop, hocKy);
            comboBox.DisplayMember = "HoTen";
            comboBox.ValueMember = "MaHocSinh";
        }

        //Cũ
        public void HienThiComboBox(String namHoc, String lop, ComboBoxEx comboBox)
        {
            HocSinhData m_HSData = new HocSinhData();

            comboBox.DataSource = m_HSData.LayDsHocSinhTheoLop(namHoc, lop);
            comboBox.DisplayMember = "HoTen";
            comboBox.ValueMember = "MaHocSinh";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_HocSinhData.LayDsHocSinh();
            cmbColumn.DisplayMember = "HoTen";
            cmbColumn.ValueMember = "MaHocSinh";
            cmbColumn.DataPropertyName = "MaHocSinh";
            cmbColumn.HeaderText = "Học sinh";
        }
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_HocSinhData.LayDsHocSinh();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN,
                            TextBoxX txtMaHocSinh,
                            TextBoxX txtTenHocSinh,
                            TextBoxX txtGioiTinh,
                            CheckBoxX ckbGTinhNam,
                            CheckBoxX ckbGTinhNu,
                            DateTimeInput dtpNgaySinh,
                            TextBoxX txtEmail,
                            TextBoxX txtDiaChi)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_HocSinhData.LayDsHocSinh();

            DataTable dT = m_HocSinhData.LayDsHocSinh();
            bool gioiTinh = Convert.ToBoolean(dT.Rows[0]["GioiTinh"]);

            if (gioiTinh)
                ckbGTinhNu.Checked = true;
            else
                ckbGTinhNam.Checked = true;

            txtMaHocSinh.DataBindings.Clear();
            txtMaHocSinh.DataBindings.Add("Text", bS, "MaHocSinh");

            txtTenHocSinh.DataBindings.Clear();
            txtTenHocSinh.DataBindings.Add("Text", bS, "HoTen");

            txtGioiTinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Add("Text", bS, "GioiTinh");

            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Value", bS, "NgaySinh");

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", bS, "Email");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bS, "DiaChi");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

     /*   public void LayDSHSChuaCoLop(DataGridView DGV)
        {
            BindingSource BS = new BindingSource();
            BS.DataSource = m_HocSinhData.LayDSHSChuaCoLop();
            DGV.DataSource = BS;
        } */

        public void LayDSHSChuaCoLop(ListViewEx lV)
        {
            DataTable m_DT = m_HocSinhData.LayDSHSChuaCoLop();
            lV.Items.Clear();
            foreach (DataRow Row in m_DT.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = Row["MaHocSinh"].ToString();
                item.SubItems.Add(Row["HoTen"].ToString());

                lV.Items.Add(item);
            }
        }
        #endregion

        public void HienThiDsHocSinhTheoLop(DataGridViewX dGV, BindingNavigator bN, String namHoc, String lop, String hocKy)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_HocSinhData.LayDsHocSinhTheoQTH(namHoc, lop, hocKy);
            
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public void HienThiDsHocSinhTheoLop1(DataGridViewX dGV, BindingNavigator bN, String namHoc, String lop, String hocKy, String maMonHoc)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_HocSinhData.LayDsHocSinhTheoQTH1(namHoc, lop, hocKy, maMonHoc);

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        //Mới
        public void HienThiDsHocSinhTheoLop1(String namHoc, String lop, String hocKy, ListViewEx lV)
        {
            DataTable m_DT = m_HocSinhData.LayDsHocSinhTheoQTH(namHoc, lop, hocKy);
            
            lV.Items.Clear();
            

            foreach (DataRow Row in m_DT.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = Row["MaHocSinh"].ToString();
                item.SubItems.Add(Row["HoTen"].ToString());

                lV.Items.Add(item);
            }
        }

        public void HienThiDsHocSinhTheoLop(String namHoc, String lop , String hocKy, ListViewEx lV)
        {
           // DataTable m_DT = m_HocSinhData.LayDsHocSinhTheoLop(namHoc, khoiLop, lop);
            DataTable m_DT = m_HocSinhData.LayDsHocSinhTheoQTH(namHoc, lop, hocKy);
            lV.Items.Clear();
            foreach (DataRow Row in m_DT.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = Row["MaQuaTrinhHoc"].ToString();
                item.SubItems.Add(Row["MaHocSinh"].ToString());
                item.SubItems.Add(Row["HoTen"].ToString());
                
                
                lV.Items.Add(item);
            }
        }

        public DataTable HienThiDsHocSinhTheoNamHoc(String namHoc)
        {
            return m_HocSinhData.LayDsHocSinhTheoNamHoc(namHoc);
        }

        public DataTable HienThiDsHocSinhTheoHocKy_Lop(String hocKy, String lop)
        {
            return m_HocSinhData.LayDsHocSinhTheoHocKy_Lop(hocKy, lop);
        }

        public void XoaHSKhoiBangPhanLop(String hocKyCu, String lopCu, ListViewEx hocSinh)
        {
            foreach (ListViewItem item in hocSinh.Items)
            {
                m_HocSinhData.XoaHSKhoiBangPhanLop(hocKyCu, lopCu, item.SubItems[0].Text.ToString());
            }
        }

        public void LuuHSVaoBangQuaTrinhHoc(String hocKyCu, String lopCu, ListViewEx hocSinh)
        {
            foreach (ListViewItem item in hocSinh.Items)
            {
                m_HocSinhData.LuuHSVaoBangQuaTrinhHoc(hocKyCu, lopCu, item.SubItems[0].Text.ToString());
            }
        }


        public void LuuHSVaoBangPhanLop(String maLop, String maHocKy, ListViewEx hocSinh)
        {
            foreach (ListViewItem item in hocSinh.Items)
            {
                m_HocSinhData.LuuHSVaoBangPhanLop(maLop, maHocKy, item.SubItems[0].Text.ToString());
            }
        } 

        #region Lay danh sach hoc sinh do vao report
        public static IList<HocSinhInfo> LayDsHocSinh()
        {
            HocSinhData m_HSData = new HocSinhData();
            DataTable m_DT = m_HSData.LayDsHocSinhForReport();

            IList<HocSinhInfo> dS = new List<HocSinhInfo>();

            foreach (DataRow Row in m_DT.Rows)
            {
                HocSinhInfo hs = new HocSinhInfo();

                hs.MaHocSinh        = Convert.ToString(Row["MaHocSinh"]);
                hs.HoTen            = Convert.ToString(Row["HoTen"]);
                hs.GioiTinh         = Convert.ToBoolean(Row["GioiTinh"]);
                hs.NgaySinh         = Convert.ToDateTime(Row["NgaySinh"]);
                hs.Email            = Convert.ToString(Row["Email"]);
                hs.DiaChi            = Convert.ToString(Row["DiaChi"]);

                dS.Add(hs);
            }
            return dS;
        }

        //Mới 
        public static IList<HocSinhInfo> LayDsHocSinh(String namHoc, String khoiLop, String lop)
        {
            HocSinhData m_HSData = new HocSinhData();
            DataTable m_DT = m_HSData.LayDsHocSinhForReport(namHoc, khoiLop, lop);

            IList<HocSinhInfo> dS = new List<HocSinhInfo>();

            foreach (DataRow Row in m_DT.Rows)
            {
                HocSinhInfo hs = new HocSinhInfo();

                hs.MaHocSinh = Convert.ToString(Row["MaHocSinh"]);
                hs.HoTen = Convert.ToString(Row["HoTen"]);
                hs.GioiTinh = Convert.ToBoolean(Row["GioiTinh"]);
                hs.NgaySinh = Convert.ToDateTime(Row["NgaySinh"]);
                hs.Email = Convert.ToString(Row["Email"]);
                hs.DiaChi = Convert.ToString(Row["DiaChi"]);

                dS.Add(hs);
            }
            return dS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_HocSinhData.ThemDongMoi();
        }

        public void ThemHocSinh(DataRow m_Row)
        {
            m_HocSinhData.ThemHocSinh(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuHocSinh()
        {
            return m_HocSinhData.LuuHocSinh();
        }

        public void LuuHocSinh(String maHocSinh, String hoTen, bool gioiTinh, DateTime ngaySinh, String email, String diachi)
        {
            m_HocSinhData.LuuHocSinh(maHocSinh, hoTen, gioiTinh, ngaySinh, email, diachi);
        }
        #endregion

        #region Tim kiem
   /*     public void TimKiemHocSinh1(TextBoxX txtHoTen,
                                   ComboBoxEx cmbTheoNSinh,
                                   TextBoxX txtEmail,
                                   TextBoxX txtDiaChi,
                                   DataGridViewX dGV,
                                   BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_HocSinhData.TimKiemHocSinh(txtHoTen.Text, cmbTheoNSinh.Text, txtEmail.Text, txtDiaChi.Text);

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        } */

        public void TimKiemHocSinh(TextBoxX txtHoTen,
                                   DataGridViewX dGV,
                                   BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_HocSinhData.TimKiemHocSinh(txtHoTen.Text);

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public void TimKiemHocSinh_NamHoc_HocKy_Lop(ComboBoxEx maNamHoc,
                                    ComboBoxEx maHocKy,
                                    ComboBoxEx maLop,
                                   DataGridViewX dGV,
                                   BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_HocSinhData.TimKiemHocSinh_NamHoc_HocKy_Lop(maNamHoc.SelectedValue.ToString(), maHocKy.SelectedValue.ToString(), maLop.SelectedValue.ToString());
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public void TimTheoMa(String m_MaHocSinh)
        {
            m_HocSinhData.TimTheoMa(m_MaHocSinh);
        }

        public void TimTheoTen(String m_TenHocSinh)
        {
            m_HocSinhData.TimTheoTen(m_TenHocSinh);
        }
        #endregion
    }
}
