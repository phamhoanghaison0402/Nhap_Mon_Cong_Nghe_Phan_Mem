using System;
using System.Data;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using QLHS_THPT.Controller;
using QLHS_THPT.Component;
using QLHS_THPT.DataLayer;
using DevComponents.DotNetBar;
using DevExpress.XtraEditors;

namespace QLHS_THPT
{
    public partial class frmXemDiem : XtraForm
    {
        #region Fields
        NamHocCtrl m_NamHocCtrl = new NamHocCtrl();
        LopCtrl m_LopCtrl = new LopCtrl();
        HocKyCtrl m_HocKyCtrl = new HocKyCtrl();
        MonHocCtrl m_MonHocCtrl = new MonHocCtrl();
        DiemCtrl m_DiemCtrl = new DiemCtrl();
        LoaiDiemCtrl m_LoaiDiemCtrl = new LoaiDiemCtrl();
        HocSinhCtrl m_HocSinhCtrl = new HocSinhCtrl();
         BaoCaoTongKetMonCtrl m_BaoCaoTongKetMonCtrl = new BaoCaoTongKetMonCtrl();

        DiemData m_DiemData = new DiemData();
        QuyDinh quyDinh = new QuyDinh();
        LoaiDiemData m_LoaiDiemData = new LoaiDiemData();
        int[,] STT = null;
        #endregion

        #region Constructor
        public frmXemDiem()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void frmXemDiem_Load(object sender, EventArgs e)
        {
            m_NamHocCtrl.HienThiComboBox(cmbNamHocSD);
          
            DataTable m_DT1 = m_LoaiDiemData.LayDsLoaiDiem();
            DataTable m_DT2 = m_DiemData.LayDsDiem1();

            foreach (DataRow rowDiem1 in m_DT2.Rows)
            {
                if (rowDiem1["MaLoaiKT"].ToString() == "LD001")
                {
                    dGVDiem.Columns.Add("colDiem1", rowDiem1["TenLoaiKT"].ToString());
                }
               
                if (rowDiem1["MaLoaiKT"].ToString() == "LD002")
                {
                    dGVDiem.Columns.Add("colDiem2", rowDiem1["TenLoaiKT"].ToString());
                }

                if (rowDiem1["MaLoaiKT"].ToString() == "LD003" )
                {
                    dGVDiem.Columns.Add("colDiem3", rowDiem1["TenLoaiKT"].ToString());
                }

                if (rowDiem1["MaLoaiKT"].ToString() == "LD004")
                {
                    dGVDiem.Columns.Add("colDiem4", rowDiem1["TenLoaiKT"].ToString());
                }

                if (rowDiem1["MaLoaiKT"].ToString() == "LD005")
                {
                    dGVDiem.Columns.Add("colDiem5", rowDiem1["TenLoaiKT"].ToString());
                }

                if (rowDiem1["MaLoaiKT"].ToString() == "LD006")
                {
                    dGVDiem.Columns.Add("colDiem6", rowDiem1["TenLoaiKT"].ToString());
                }
            }         
        }
        #endregion

        private void cmbHocKySD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHocSD.SelectedValue != null && cmbHocKySD.SelectedValue != null)
            {
                m_LopCtrl.HienThiComboBox_new(cmbNamHocSD.SelectedValue.ToString(), cmbHocKySD.SelectedValue.ToString(), cmbLopSD);
            }
        }

        private void cmbNamHocSD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHocSD.SelectedValue != null)
                m_HocKyCtrl.HienThiComboBox(cmbNamHocSD.SelectedValue.ToString(), cmbHocKySD);
            cmbHocKySD.DataBindings.Clear();
        }

        private void cmbLopSD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHocSD.SelectedValue != null && cmbLopSD.SelectedValue != null && cmbHocKySD.SelectedValue != null)
            {
                m_MonHocCtrl.HienThiComboBox(cmbNamHocSD.SelectedValue.ToString(), cmbLopSD.SelectedValue.ToString(), cmbHocKySD.SelectedValue.ToString(), cmbMonHocSD);
                
            }
            cmbMonHocSD.DataBindings.Clear();
            
        }

        private void btnHienThiDanhSachSD_Click(object sender, EventArgs e)
        {

            STT = new int[60, 20];
            
            if (cmbNamHocSD.SelectedValue != null && cmbLopSD.SelectedValue != null && cmbHocKySD.SelectedValue != null && cmbMonHocSD.SelectedValue != null)
            {
                m_HocSinhCtrl.HienThiDsHocSinhTheoLop1(dGVDiem, bindingNavigatorDiem, cmbNamHocSD.SelectedValue.ToString(), cmbLopSD.SelectedValue.ToString(), cmbHocKySD.SelectedValue.ToString(), cmbMonHocSD.SelectedValue.ToString());
            }
           
            int countRowHocSinh = 0;
            foreach (DataGridViewRow rowHocSinh in dGVDiem.Rows)
            {
                countRowHocSinh++;

                String[] diemMieng = new String[100];
                String[] diem15Phut = new String[100];
                String[] diem45Phut = new String[100];
                String[] diem60Phut = new String[100];
                String[] diem70Phut = new String[100];
                String[] diem90Phut = new String[100];
                String[] diem = new String[100];
                String diemThi = "";

                int soDiemMieng = 0;
                int soDiem15Phut = 0;
                int soDiem45Phut = 0;
                int soDiem60Phut = 0;
                int soDiem70Phut = 0;
                int soDiem90Phut = 0;

                int sodiem = 0;

                DataTable m_DT = m_DiemData.LayDsDiem(rowHocSinh.Cells["colMaHocSinh"].Value.ToString(),
                                                      cmbMonHocSD.SelectedValue.ToString(),
                                                      cmbHocKySD.SelectedValue.ToString(),
                                                      cmbNamHocSD.SelectedValue.ToString(),
                                                      cmbLopSD.SelectedValue.ToString()
                                                      );


                int countRowDiem = 0;
               
                    foreach (DataRow rowDiem in m_DT.Rows)
                    {
                        countRowDiem++;
                        STT[countRowHocSinh, countRowDiem] = int.Parse(rowDiem["STT"].ToString());

                        if (rowDiem["MaLoaiKT"].ToString() == "LD001")
                        {
                            
                            diem[sodiem++] = rowDiem["Diem"].ToString();
                            rowHocSinh.Cells["colDiem1"].Value = quyDinh.ArrayToString(diem, sodiem);
                        }
                        else if (rowDiem["MaLoaiKT"].ToString() == "LD002")
                        {
                            diem15Phut[soDiem15Phut++] = rowDiem["Diem"].ToString();
                            rowHocSinh.Cells["colDiem2"].Value = quyDinh.ArrayToString(diem15Phut, soDiem15Phut);
                        }
                        else if (rowDiem["MaLoaiKT"].ToString() == "LD003")
                        {
                            
                            diem45Phut[soDiem45Phut++] = rowDiem["Diem"].ToString();
                            rowHocSinh.Cells["colDiem3"].Value = quyDinh.ArrayToString(diem45Phut, soDiem45Phut);
                        }
                        else if (rowDiem["MaLoaiKT"].ToString() == "LD004")
                        {
                            diem60Phut[soDiem60Phut++] = rowDiem["Diem"].ToString();
                            rowHocSinh.Cells["colDiem4"].Value = quyDinh.ArrayToString(diem60Phut, soDiem60Phut);
                        }
                        else if (rowDiem["MaLoaiKT"].ToString() == "LD005")
                        {
                            diem70Phut[soDiem70Phut++] = rowDiem["Diem"].ToString();
                            rowHocSinh.Cells["colDiem5"].Value = quyDinh.ArrayToString(diem70Phut, soDiem70Phut);

                        }
                        else if (rowDiem["MaLoaiKT"].ToString() == "LD006")
                        {
                            diem70Phut[soDiem90Phut++] = rowDiem["Diem"].ToString();
                            rowHocSinh.Cells["colDiem6"].Value = quyDinh.ArrayToString(diem90Phut, soDiem90Phut);
                        }
                    }
                    
                   
            }
        }

        private void simpleButtonDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         public Boolean KiemTraDiemTruocKhiLuu(String loaiDiem)
        {
            foreach (DataGridViewRow row in dGVDiem.Rows)
            {
                if (row.Cells[loaiDiem].Value != null)
                {
                    String chuoiDiemChuaXuLy = row.Cells[loaiDiem].Value.ToString();
                    String diemDaXuLy = null;

                    int count = 0;
                    for (int i = 0; i < chuoiDiemChuaXuLy.Length; i++)
                    {
                        if (chuoiDiemChuaXuLy[i] != ';' && i != chuoiDiemChuaXuLy.Length - 1)
                            count++;
                        else
                        {
                            if (i == chuoiDiemChuaXuLy.Length - 1)
                            {
                                i++;
                                count++;
                            }

                            diemDaXuLy = chuoiDiemChuaXuLy.Substring(i - count, count);

                            if (count != 0 && quyDinh.KiemTraDiem(diemDaXuLy) == false)
                            {
                                MessageBoxEx.Show("Điểm của học sinh " + row.Cells["colHoTen"].Value.ToString() + " không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }

                            diemDaXuLy = null;
                            count = 0;
                        }
                    }
                }
                else
                {
                    MessageBoxEx.Show("Điểm không được để trống!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

         private void simpleButtonLuu_Click(object sender, EventArgs e)
         {

         }
    }
}

  