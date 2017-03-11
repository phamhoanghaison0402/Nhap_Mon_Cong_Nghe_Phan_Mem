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
    public partial class frmCapNhatDiemHS : XtraForm
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
        BaoCaoTongKetHocKyCtrl m_BaoCaoTongKetHocKyCtrl = new BaoCaoTongKetHocKyCtrl();
        DiemData m_DiemData = new DiemData();
        QuyDinh quyDinh = new QuyDinh();
        LoaiDiemData m_LoaiDiemData = new LoaiDiemData();

        int[,] STT = null;
        #endregion

        #region Constructor
        public frmCapNhatDiemHS()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void frmNhapDiemHS_Load(object sender, EventArgs e)
        {   
            m_NamHocCtrl.HienThiComboBox(cmbNamHoc);
          
        }
        #endregion

        #region BindingNavigatorItems
        #region Kiểm tra điểm số trước khi lưu
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
        #endregion

   
        #endregion

        #region DataError event
        private void dGVNhapDiemChung_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        #region Click event nhập điểm
        private void btnThemNamHoc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormKBNamHoc();
           
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormPhanLopHoc();
          
        }

        private void btnThemHocKy_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormHocKy();
        }

        private void btnThemMonHoc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormMonHoc();
        }

        private void btnHienThiDanhSach_Click(object sender, EventArgs e)
        {
           
            if (cmbHocKy.SelectedValue == null)
            {
                MessageBoxEx.Show("Bạn chưa chọn học kỳ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbLop.SelectedValue == null)
            {
                MessageBoxEx.Show("Bạn chưa chọn lớp!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbMonHoc.SelectedValue == null)
            {
                MessageBoxEx.Show("Bạn chưa chọn môn học!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbLoaiDiem.SelectedValue == null)
            {
                MessageBoxEx.Show("Môn " + cmbMonHoc.Text + " ở lớp " + cmbLop.Text + " chưa nhập điểm!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            STT = new int[60, 20];
            if (cmbNamHoc.SelectedValue != null && cmbLop.SelectedValue != null && cmbHocKy.SelectedValue != null && cmbMonHoc.SelectedValue != null)
                m_HocSinhCtrl.HienThiDsHocSinhTheoLop(dGVDiem, bindingNavigatorDiem, cmbNamHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(), cmbHocKy.SelectedValue.ToString());

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

                
                DataTable m_DT = m_DiemData.LayDsDiemCN(rowHocSinh.Cells["colMaHocSinh"].Value.ToString(),
                                                      cmbMonHoc.SelectedValue.ToString(),
                                                      cmbHocKy.SelectedValue.ToString(),
                                                      cmbNamHoc.SelectedValue.ToString(),
                                                      cmbLop.SelectedValue.ToString(),
                                                      cmbLoaiDiem.SelectedValue.ToString()
                                                      );


                int countRowDiem = 0;

                foreach (DataRow rowDiem in m_DT.Rows)
                {
                    countRowDiem++;
                    STT[countRowHocSinh, countRowDiem] = int.Parse(rowDiem["STT"].ToString());

                    if (cmbLoaiDiem.SelectedValue.ToString() == "LD001")
                    {
                        diem[sodiem++] = rowDiem["Diem"].ToString();
                        rowHocSinh.Cells["colDiem"].Value = quyDinh.ArrayToString(diem, sodiem);
                    }
                    else if (cmbLoaiDiem.SelectedValue.ToString() == "LD002")
                    {
                        diem15Phut[soDiem15Phut++] = rowDiem["Diem"].ToString();
                        rowHocSinh.Cells["colDiem"].Value = quyDinh.ArrayToString(diem15Phut, soDiem15Phut);
                    }
                    else if (cmbLoaiDiem.SelectedValue.ToString() == "LD003")
                    {

                        diem45Phut[soDiem45Phut++] = rowDiem["Diem"].ToString();
                        rowHocSinh.Cells["colDiem"].Value = quyDinh.ArrayToString(diem45Phut, soDiem45Phut);
                    }
                    else if (cmbLoaiDiem.SelectedValue.ToString() == "LD004")
                    {
                        diem60Phut[soDiem60Phut++] = rowDiem["Diem"].ToString();
                        rowHocSinh.Cells["colDiem"].Value = quyDinh.ArrayToString(diem60Phut, soDiem60Phut);
                    }
                    else if (cmbLoaiDiem.SelectedValue.ToString() == "LD005")
                    {
                        diem70Phut[soDiem70Phut++] = rowDiem["Diem"].ToString();
                        rowHocSinh.Cells["colDiem"].Value = quyDinh.ArrayToString(diem70Phut, soDiem70Phut);

                    }
                    else if (cmbLoaiDiem.SelectedValue.ToString() == "LD006")
                    {
                        diem70Phut[soDiem90Phut++] = rowDiem["Diem"].ToString();
                        rowHocSinh.Cells["colDiem"].Value = quyDinh.ArrayToString(diem90Phut, soDiem90Phut);
                    }
                }
            }
        }
        #endregion

        #region SelectedIndexChanged event nhập điểm
        //Lấy thông tin lớp theo từng năm học
        private void cmbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null)
                m_HocKyCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbHocKy);
            cmbHocKy.DataBindings.Clear();
        }

        //Lấy môn học theo từng lớp
        private void cmbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null && cmbLop.SelectedValue != null && cmbHocKy.SelectedValue != null)
            {
                m_MonHocCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(), cmbHocKy.SelectedValue.ToString(), cmbMonHoc);
            }
            cmbMonHoc.DataBindings.Clear();
        }
        #endregion

        private void cmbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null && cmbHocKy.SelectedValue != null)
            {
                m_LopCtrl.HienThiComboBox_new(cmbNamHoc.SelectedValue.ToString(), cmbHocKy.SelectedValue.ToString(), cmbLop);
            }
        }

        private void btnThemLoaiKT_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormLoaiHinhKiemTra();
        }

        private void cmbLoaiDiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (cmbNamHoc.SelectedValue != null && cmbLop.SelectedValue != null && cmbHocKy.SelectedValue != null && cmbNamHoc.SelectedValue != null)
            {
               
                m_LoaiDiemCtrl.HienThiComboBox(cmbLop.SelectedValue.ToString(), cmbMonHoc.SelectedValue.ToString(), cmbLoaiDiem);
               
            }
            
            cmbLoaiDiem.DataBindings.Clear();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButtonThem_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormXemDiem();
        }

        private void simpleButtonLuu_Click(object sender, EventArgs e)
        {
            if (dGVDiem.RowCount == 0)
            {
                MessageBoxEx.Show("Chưa có học sinh!", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (KiemTraDiemTruocKhiLuu("colDiem") == true)
            {
                if (MsgboxUtil.YesNo("Bạn có chắc chắn muốn cập nhật không ?")
                      == DialogResult.Yes)
                {
                    if (STT != null)
                    {
                        int rowcount = 0;

                        foreach (DataGridViewRow row in dGVDiem.Rows)
                        {
                            rowcount++;

                            #region Kiểm tra miệng
                            if (row.Cells["colDiem"].Value != null)
                            {
                                String chuoiDiemChuaXuLy = row.Cells["colDiem"].Value.ToString();
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

                                        if (diemDaXuLy != null && diemDaXuLy != " " && quyDinh.KiemTraDiem(diemDaXuLy))
                                            m_DiemCtrl.LuuDiem(row.Cells["colMaQuaTrinhHoc"].Value.ToString(),
                                                               cmbMonHoc.SelectedValue.ToString(),

                                                               cmbLoaiDiem.SelectedValue.ToString(),
                                                               float.Parse(diemDaXuLy.ToString()));

                                        diemDaXuLy = null;
                                        count = 0;
                                    }
                                }
                            }
                            #endregion

                            #region Lưu vào bảng kết quả
                            if (rowcount <= dGVDiem.Rows.Count)
                            {

                                m_BaoCaoTongKetMonCtrl.LuuKetQuaSD(row.Cells["colMaQuaTrinhHoc"].Value.ToString(), cmbMonHoc.SelectedValue.ToString());
                                m_BaoCaoTongKetMonCtrl.LuuKetQua1(cmbHocKy.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(), cmbMonHoc.SelectedValue.ToString());
                                m_BaoCaoTongKetHocKyCtrl.LuuKetQua1(cmbHocKy.SelectedValue.ToString(), cmbLop.SelectedValue.ToString());

                            }
                            #endregion

                            #region Xóa các kết quả cũ
                            if (STT != null)
                            {
                                for (int i = 1; i < 60; i++)
                                    for (int j = 1; j < 20; j++)
                                    {
                                        int id = STT[i, j];
                                        if (id > 0)
                                        {

                                            m_DiemCtrl.XoaBangDiem(id);
                                            // m_DiemCtrl.XoaDiem(id);
                                        }
                                        else
                                            break;
                                    }
                            }
                            #endregion
                        }
                        MessageBoxEx.Show("Cập nhật thành công!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
        }
    }
}