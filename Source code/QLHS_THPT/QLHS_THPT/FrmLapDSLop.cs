using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using QLHS_THPT.Controller;
using QLHS_THPT.Bussiness;
using Util;
using QLHS_THPT.Component;
using System.Data;
using System.Text;
using System.Drawing;
using System.Collections;
using QLHS_THPT.DataLayer;

namespace QLHS_THPT
{
    public partial class FrmLapDsLop : XtraForm
    {
        private readonly GiaoVienBUS _giaoVienBUS;
        private readonly KhoiBUS _khoiBUS;
        private readonly LopBUS _lopBUS;
        private readonly NamHocBUS _namHocBUS;
        private bool _isAddButton;
        private bool _isDeleteButton;
        KhoiLopCtrl m_KhoiLopCtrl = new KhoiLopCtrl();
        NamHocCtrl m_NamHocCtrl = new NamHocCtrl();
        LopCtrl m_LopCtrl = new LopCtrl();
        QuyDinh quyDinh = new QuyDinh();
        LopData m_LopData = new LopData();
      

        public FrmLapDsLop()
        {
            InitializeComponent();
            _giaoVienBUS = new GiaoVienBUS();
            _namHocBUS = new NamHocBUS();
            _khoiBUS = new KhoiBUS();
            _lopBUS = new LopBUS();
            _isAddButton = true;
            _isDeleteButton = true;
        }

        private void HienThi_DSLop()
        {
            gridControlDSLop.DataSource = _lopBUS.LayDTLop_MaNam_MaKhoi(cmbNamHoc.SelectedValue.ToString(),
                                                                        cmbKhoi.SelectedValue.ToString());
            DisableControls(editing: false);
        }

        private void frmLapDSLop_Load(object sender, EventArgs e)
        {
            m_NamHocCtrl.HienThiComboBox(cmbNamHoc);
            
            CboUtil.SetDataSource(comboBoxEditGVCN,
                                  _giaoVienBUS.LayDT_DanhSachGiaoVien(),
                                  "MaGiaoVien", "TenGiaoVien", 0);
            simpleButtonThemMoi.Enabled = false;
            simpleButtonGhiDuLieu.Enabled = false;
            simpleButtonXoa.Enabled = false;
            txtkyhieu.Enabled = false;
            textEditTenLop.Enabled = false;
        }

        private void comboBoxEditNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //m_KhoiLopCtrl.HienThiComboBox_new(cmbNamHoc1.SelectedText.ToString().ToString(), cmbKhoi1);
            //HienThi_DSLop();
        }

        public Boolean KiemTraSiSoTruocKhiLuu(String siSoColumn)
        {
            var lopDTO = new LopDTO();
            lopDTO.SiSo = iniSiSo.Value;
            if (quyDinh.KiemTraSiSo(lopDTO.SiSo) == false)
            {
                MsgboxUtil.Error("Sĩ số không đúng quy định!");

                return false;
            }
            return true;
        }

        private void DisableControls(bool editing)
        {
            simpleButtonDong.Enabled = !editing;
            gridControlDSLop.Enabled = !editing;
            //comboBoxEditGVCN.Enabled = is_adding;
            //textEditTenLop.Enabled = is_adding;
           
            _isAddButton = !editing;
            _isDeleteButton = !editing;

            simpleButtonThemMoi.Text = editing ? "Không nhập (Alt+&N)" : "Thêm (Alt+&A)";
            simpleButtonXoa.Text = editing ? "Nhập lại (Alt+&R)" : "Xóa (Alt+&D)";
            simpleButtonGhiDuLieu.Text = editing ? "Lưu (Alt+&S)" : "Cập nhật (Alt+&U)";

            if (!editing)
            {
                if (gridViewLop.RowCount > 0)
                    gridViewLop_FocusedRowChanged(this,
                                                  new FocusedRowChangedEventArgs(0, 0));
                else
                {
                    textEditMaLop.Text = "";
                    textEditTenLop.Text = "";
                }
            }
        }


        private void ResetControl()
        {
            comboBoxEditGVCN.SelectedIndex = 0;
            textEditTenLop.Text = "";
            textEditMaLop.Text = "";
        }

        private void simpleButtonThemMoi_Click(object sender, EventArgs e)
        {
           
            if (_isAddButton) // button them moi
            {
                DisableControls(true);
                ResetControl();
            }
            else // button khong nhap
            {
                // Bỏ ẩn control
                DisableControls(false);
            }
        }

        private void gridViewLop_FocusedRowChanged(object sender,
                                                   FocusedRowChangedEventArgs e)
        {
            // Chac chan chon duoc 1 dong nao do
            if (gridViewLop.FocusedRowHandle < 0 || gridViewLop.FocusedRowHandle >= gridViewLop.RowCount) return;
            textEditMaLop.Text = gridViewLop.GetRowCellValue(gridViewLop.FocusedRowHandle, "MaLop").ToString();
            textEditTenLop.Text = gridViewLop.GetRowCellValue(gridViewLop.FocusedRowHandle, "TenLop").ToString();
            CboUtil.SelectedItem(comboBoxEditGVCN,
                                 gridViewLop.GetRowCellValue(gridViewLop.FocusedRowHandle, "MaGiaoVien").ToString()
                );
            iniSiSo.Text = gridViewLop.GetRowCellValue(gridViewLop.FocusedRowHandle, "SiSo").ToString();
        }

        private void textEditTenLop_InvalidValue(object sender,
                                                 InvalidValueExceptionEventArgs e)
        {
            if (cmbKhoi.SelectedValue == null)
            {
                MsgboxUtil.Error("Bạn chưa chọn khối lớp!");
                return;
            }
            string maKhoi = cmbKhoi.SelectedValue.ToString();
            e.ErrorText = "Tên lớp không hợp lệ. Tên lớp có dạng " + maKhoi + "[A-Z][0-9][0-9]. VD: " + maKhoi + "B02";
        }

        private void simpleButtonGhiDuLieu_Click(object sender, EventArgs e)
        {

            if (cmbKhoi.Text == "")
            {
                MsgboxUtil.Error("Bạn chưa chọn khối lớp!");
                return;
            }
            if (textEditTenLop.Text == "")
            {
                MsgboxUtil.Error("Bạn chưa nhập tên lớp!");
                return;
            }
            if (CboUtil.CheckSelectedNull(comboBoxEditGVCN))
            {
                MsgboxUtil.Error("Bạn chưa chọn GVCN!");
                return;
            }
            if(iniSiSo.Value <=0)
            {
                MsgboxUtil.Error("Bạn chưa nhập sĩ số!");
                return;
            }
           
            var lopDTO = new LopDTO();
            lopDTO.GiaoVien.MaGiaoVien = CboUtil.GetValueItem(comboBoxEditGVCN);


            int soLopToiDa = _lopBUS.Lay_SoLop_KhoiLop(cmbKhoi.SelectedValue.ToString());

            if (gridViewLop.DataRowCount >= soLopToiDa)
            {
                MsgboxUtil.Error("Không thể thực hiện vì " + cmbKhoi.Text + " năm học " + cmbNamHoc.Text + " đã đủ " + soLopToiDa + " lớp");
                return;
            }

            string tenLop = textEditTenLop.Text;
            string tenkyhieu = txtkyhieu.Text;

            string tTenLop = tenLop.Substring(0, 3); // 10A
            if(cmbKhoi.Text == "Khối 10")
            {
                if(tenLop.Substring(0,2) != "10")
                {
                    MsgboxUtil.Error("Năm học " + cmbNamHoc.Text + " , " + cmbKhoi.Text + " có ký hiệu tên lớp học là 10");
                    return;
                }
            }

            if (cmbKhoi.Text == "Khối 11")
            {
                if (tenLop.Substring(0, 2) != "11")
                {
                    MsgboxUtil.Error("Năm học " + cmbNamHoc.Text + " , " + cmbKhoi.Text + " có ký hiệu tên lớp học là 11");
                    return;
                }
            }

            if (cmbKhoi.Text == "Khối 12")
            {
                if (tenLop.Substring(0, 2) != "12")
                {
                    MsgboxUtil.Error("Năm học " + cmbNamHoc.Text + " , " + cmbKhoi.Text + " có ký hiệu tên lớp học là 12");
                    return;
                }
            }
            if(tenkyhieu != tenLop.Substring(2,1))
            {
                MsgboxUtil.Error("Năm học " + cmbNamHoc.Text + " , " + cmbKhoi.Text + " có ký hiệu lớp học là " + txtkyhieu.Text);
                return;
            }

            int hTenLop = Convert.ToInt32(tenLop.Substring(3, tenLop.Length - 3)); // 1

            tenLop = tTenLop + ((hTenLop < 10) ? "0" + hTenLop.ToString() : hTenLop.ToString()); // 10A01   
            
            lopDTO.MaNamHoc = cmbNamHoc.SelectedValue.ToString();
            lopDTO.MaLop = tenLop + lopDTO.MaNamHoc;    
            lopDTO.MaKhoiLop = cmbKhoi.SelectedValue.ToString();
        
            lopDTO.SiSo = iniSiSo.Value;

            if (simpleButtonGhiDuLieu.Text == "Cập nhật (Alt+&U)")
            {
                if (KiemTraSiSoTruocKhiLuu(iniSiSo.Value.ToString()) == false)
                {
                    HienThi_DSLop();
                    return ;
                }
                else
                {
                    if (MsgboxUtil.YesNo("Bạn có chắc chắn muốn cập nhật không?")
                         == DialogResult.Yes)
                    {
                        _lopBUS.CapNhat_GiaoVienCN_Lop(lopDTO);
                        MsgboxUtil.Success("Đã cập nhật lớp " + textEditTenLop.Text + " thành công!");
                        HienThi_DSLop();
                        return;
                    }
                    else
                    {
                        HienThi_DSLop();
                        return;
                    }
                }           
            }

            if (_lopBUS.KiemTraTonTai_MaLop(lopDTO.MaLop))
            {
                if (KiemTraSiSoTruocKhiLuu(iniSiSo.Value.ToString()) == true)
                {
                    MsgboxUtil.Success("Tên lớp " + tenLop + " đã tồn tại!");
                    return;
                }
            }
            else
            {
                if (MsgboxUtil.YesNo("Bạn có chắc chắn muốn thêm lớp " + textEditTenLop.Text + " vào năm học " + cmbNamHoc.Text +  " không?")
                         == DialogResult.Yes)
                {
                    if (KiemTraSiSoTruocKhiLuu(iniSiSo.Value.ToString()) == true)
                    {
                        m_LopCtrl.LuuLop(lopDTO.MaLop, textEditTenLop.Text, lopDTO.MaKhoiLop, lopDTO.MaNamHoc, lopDTO.SiSo, lopDTO.GiaoVien.MaGiaoVien);
                        MsgboxUtil.Success("Đã tạo lớp " + lopDTO.TenLop + " thành công!");
                        HienThi_DSLop();
                    }
                    return;
                }
                else
                {
                    return;
                }        
            }
            HienThi_DSLop();
        }

        private void simpleButtonXoa_Click(object sender, EventArgs e)
        {
            if (!_isDeleteButton) // button nhap lai 
            {
                ResetControl();
                return;
            }
            if (_lopBUS.KiemTraTonTai_MaLop(textEditMaLop.Text))
            {
                if (MsgboxUtil.YesNo("Bạn có muốn xóa toàn bộ danh sách học sinh, "
                                     + "bảng điểm học sinh và toàn bộ thông tin liên quan đến lớp " +
                                     textEditTenLop.Text + " hay không?")
                    == DialogResult.No)
                {
                    return;
                }

                _lopBUS.Xoa_Lop(textEditMaLop.Text);
                MsgboxUtil.Success("Đã xóa lớp " + textEditTenLop.Text + " thành công!");
                HienThi_DSLop();
            }
        }

        private void simpleButtonDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormKBNamHoc();       
        }

        private void cmbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
              if (cmbNamHoc.SelectedValue != null )
            m_KhoiLopCtrl.HienThiComboBox_new(cmbNamHoc.SelectedValue.ToString(), cmbKhoi); 
        }

        private void cmbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null && cmbKhoi.SelectedValue != null)
            {
                String kyhieu = _lopBUS.Lay_KyHieu(cmbKhoi.SelectedValue.ToString());
                txtkyhieu.Text = kyhieu;
            }
        }

        private void btnHienThiDanhSach_Click(object sender, EventArgs e)
        {
            
            if(cmbKhoi.SelectedValue == null)
            {
                MsgboxUtil.Error("Bạn chưa chọn khối lớp!");
                return;
            }
            if (cmbNamHoc.SelectedValue != null && cmbKhoi.SelectedValue != null)
            {
                HienThi_DSLop();
                simpleButtonThemMoi.Enabled = true;
                simpleButtonGhiDuLieu.Enabled = true;
                simpleButtonXoa.Enabled = true;
                textEditTenLop.Enabled = true;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormKhoiLop();
        }
    }
}