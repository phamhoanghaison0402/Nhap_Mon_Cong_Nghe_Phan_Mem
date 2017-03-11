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
    public partial class frmNhapDiemHS : XtraForm
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
        public frmNhapDiemHS()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void frmNhapDiemHS_Load(object sender, EventArgs e)
        {   
            m_NamHocCtrl.HienThiComboBox(cmbNamHoc);
            m_LoaiDiemCtrl.HienThiComboBox(cmbLoaiDiem);   
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

        #region Thoát khỏi form nhập điểm
       
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
            if (cmbNamHoc.SelectedValue != null && cmbLop.SelectedValue != null && cmbHocKy.SelectedValue != null && cmbMonHoc.SelectedValue != null)
                m_HocSinhCtrl.HienThiDsHocSinhTheoLop(dGVDiem, bindingNavigatorDiem, cmbNamHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(), cmbHocKy.SelectedValue.ToString());          
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

        private void simpleButtonDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButtonLuu_Click(object sender, EventArgs e)
        {
            if (dGVDiem.RowCount == 0)
            {
                MessageBoxEx.Show("Chưa có học sinh!", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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
            if (KiemTraDiemTruocKhiLuu("colDiem") == true)
            {
                if (MsgboxUtil.YesNo("Bạn có chắc chắn muốn lưu không ?")
                      == DialogResult.Yes)
                {
                    if ( STT == null)
                    {
                        int rowcount = 0;

                        foreach (DataGridViewRow row in dGVDiem.Rows)
                        {
                            rowcount++;

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
                                        {
                                            m_DiemCtrl.LuuDiem(row.Cells["colMaQuaTrinhHoc"].Value.ToString(),
                                                               cmbMonHoc.SelectedValue.ToString(),
                                                               cmbLoaiDiem.SelectedValue.ToString(),
                                                               float.Parse(diemDaXuLy.ToString()));

                                        }

                                        diemDaXuLy = null;
                                        count = 0;
                                    }
                                }
                            }

                            if (rowcount <= dGVDiem.Rows.Count)
                            {
                                m_BaoCaoTongKetMonCtrl.LuuKetQua(row.Cells["colMaQuaTrinhHoc"].Value.ToString(), cmbMonHoc.SelectedValue.ToString());
                                m_BaoCaoTongKetHocKyCtrl.LuuKetQua(row.Cells["colMaQuaTrinhHoc"].Value.ToString());
                            }
                        }
                        m_BaoCaoTongKetMonCtrl.LuuKetQua1(cmbHocKy.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(), cmbMonHoc.SelectedValue.ToString());
                        m_BaoCaoTongKetHocKyCtrl.LuuKetQua1(cmbHocKy.SelectedValue.ToString(), cmbLop.SelectedValue.ToString());

                    }
                    MessageBoxEx.Show("Đã lưu thành công!", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
          
            }
        }

        private void simpleButtonThem_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormXemDiem();
        }

        private void cmbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}