using System;
using System.Data;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using QLHS_THPT.Controller;
using QLHS_THPT.Component;
using DevComponents.DotNetBar;
using System.Collections;
using DevExpress.XtraEditors;

namespace QLHS_THPT
{
    public partial class frmChuyenLop : XtraForm
    {
        #region Fields
        NamHocCtrl      m_NamHocCuCtrl      = new NamHocCtrl();
        NamHocCtrl      m_NamHocMoiCtrl     = new NamHocCtrl();
        KhoiLopCtrl     m_KhoiLopCuCtrl     = new KhoiLopCtrl();
        KhoiLopCtrl     m_KhoiLopMoiCtrl    = new KhoiLopCtrl();
        LopCtrl         m_LopCuCtrl         = new LopCtrl();
        LopCtrl         m_LopMoiCtrl        = new LopCtrl();
        HocSinhCtrl     m_HocSinhCtrl       = new HocSinhCtrl();
        HocKyCtrl       m_HocKyCtrl = new HocKyCtrl();
        private readonly QuyDinhBUS _quyDinhBUS;
        private readonly LopBUS _lopBUS;
        #endregion

        #region Constructor
        public frmChuyenLop()
        {
            InitializeComponent();
            DataService.OpenConnection();
            _quyDinhBUS = new QuyDinhBUS();
            _lopBUS = new LopBUS();
        }
        #endregion

        #region Load
        private void frmPhanLop_Load(object sender, EventArgs e)
        {
            m_NamHocCuCtrl.HienThiComboBox(cmbNamHocCu);
            m_NamHocMoiCtrl.HienThiComboBox(cmbNamHocMoi);      
        }
        #endregion

        #region Click event
        #region Chuyển lớp
       

        private void btnChuyen_Click(object sender, EventArgs e)
        {
                if (cmbNamHocCu.Text != cmbNamHocMoi.Text)
                {
                    MsgboxUtil.Error("Bạn phải chọn năm học mới giống năm học cũ");
                    return;
                }
                if (cmbKhoiLopCu.Text != cmbKhoiLopMoi.Text)
                {
                    MsgboxUtil.Error("Bạn phải chọn khối lớp học mới giống khối lớp học cũ");
                    return;
                }
                if (cmbHocKyCu.Text == cmbHocKyMoi.Text)
                {
                    MsgboxUtil.Error("Bạn phải chọn học kỳ mới khác học kỳ cũ");
                    return;
                }

            int siSoToiDa = _lopBUS.Lay_SiSo_Lop(cmbLopMoi.SelectedValue.ToString(), cmbNamHocMoi.SelectedValue.ToString());
            int siSoLopMoi;
            siSoLopMoi = _quyDinhBUS.Dem_SiSo_Lop(cmbLopMoi.SelectedValue.ToString(), cmbHocKyMoi.SelectedValue.ToString());
            if (siSoLopMoi >= siSoToiDa)
            {
                MsgboxUtil.Error("Không thể thực hiện vì lớp " +
                                 cmbLopMoi.Text + " (" + siSoLopMoi + " học sinh) đã đủ sĩ số học sinh quy định (" + siSoToiDa +
                                 " học sinh/Lớp)!");
                return;
            }

            if((siSoLopMoi) >= siSoToiDa)
            {
                MsgboxUtil.Error("Không thể thực hiện vì lớp " +
                                cmbLopMoi.Text + " (" + (siSoLopMoi + lVLopMoi.Items.Count) + " học sinh) đã đủ sĩ số học sinh quy định (" + siSoToiDa +
                                " học sinh/Lớp)!");
                return;
            }

            IEnumerator ie = lVLopCu.SelectedItems.GetEnumerator();
            while (ie.MoveNext())
            {
                ListViewItem olditem = (ListViewItem)ie.Current;
               
                ListViewItem newitem = new ListViewItem();
                
                //Trạng thái học sinh đã được chuyển lớp hay chưa?
                bool state = false; 
                
                foreach (ListViewItem item in lVLopMoi.Items)
                {
                    if (item.SubItems[0].Text == olditem.SubItems[0].Text)
                    {
                        MessageBoxEx.Show("Học sinh " + item.SubItems[1].Text + " hiện đang học trong lớp " + cmbLopMoi.Text, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        state = true;
                        goto Cont;
                    }
                }

                DataTable dT = new DataTable();
                if (cmbNamHocMoi.SelectedValue != null)
                {
                    //dT = m_HocSinhCtrl.HienThiDsHocSinhTheoNamHoc(cmbNamHocMoi.SelectedValue.ToString());
                    dT = m_HocSinhCtrl.HienThiDsHocSinhTheoHocKy_Lop(cmbHocKyMoi.SelectedValue.ToString(), cmbLopMoi.SelectedValue.ToString());
                }

                foreach (DataRow row in dT.Rows)
                {
                    if (olditem.SubItems[1].Text.ToString() == row["MaHocSinh"].ToString())
                    {
                        MessageBoxEx.Show("Học sinh " + row["HoTen"].ToString() + " hiện đang học trong lớp " + row["TenLop"].ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        state = true;
                        goto Cont;
                    }
                }

                newitem.SubItems.Add(olditem.SubItems[1].Text);
                newitem.Tag = olditem.Tag;
                
                if (lVLopMoi.Items.Count >= siSoToiDa)
                {
                    MsgboxUtil.Error("Không thể thực hiện vì lớp " +
                                cmbLopMoi.Text + " (" + lVLopMoi.Items.Count + " hs) đã đủ sỉ số học sinh quy định (" + siSoToiDa +
                                " hs/Lớp)!");
                    return;
                }
                else
                {
                    lVLopMoi.Items.Add(newitem);
                }
               
                lVLopMoi.Items[lVLopMoi.Items.IndexOf(newitem)].Text = olditem.SubItems[0].Text;
                lVLopCu.Items.Remove(olditem);
                
                Cont:
                if (state == true)
                    break;
            }
        }
        #endregion

        #region Xóa học sinh khỏi lớp mới
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lVLopMoi.SelectedItems.Count == 0)
            {
                MsgboxUtil.Error("Danh sách chưa có học sinh");
                return;
            }
            else
            {
                if (MessageBoxEx.Show("Bạn có muốn xóa học sinh này khỏi lớp mới không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    IEnumerator ie = lVLopMoi.SelectedItems.GetEnumerator();
                    while (ie.MoveNext())
                    {
                        ListViewItem item = (ListViewItem)ie.Current;
                        lVLopMoi.Items.Remove(item);
                        lVLopCu.Items.Add(item);
                    }
                }
            }            
        }
        #endregion

   
        #endregion

        #region SelectedIndexChanged event
        private void cmbNamHocCu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHocCu.SelectedValue != null)
            {
                m_HocKyCtrl.HienThiComboBox(cmbNamHocCu.SelectedValue.ToString(), cmbHocKyCu);
                m_HocKyCtrl.HienThiComboBox(cmbNamHocCu.SelectedValue.ToString(), cmbHocKyMoi);
            }
            cmbHocKyCu.DataBindings.Clear();
            cmbHocKyMoi.DataBindings.Clear();
        }

        private void cmbNamHocMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHocCu.SelectedValue != null)
            {
                m_HocKyCtrl.HienThiComboBox(cmbNamHocMoi.SelectedValue.ToString(), cmbHocKyMoi);
            }
            cmbHocKyMoi.DataBindings.Clear();
        }

        private void cmbKhoiLopCu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHocCu.SelectedValue != null && cmbKhoiLopCu.SelectedValue != null && cmbHocKyCu.SelectedValue != null)
            {
                m_LopCuCtrl.HienThiComboBox(cmbKhoiLopCu.SelectedValue.ToString(), cmbNamHocCu.SelectedValue.ToString(), cmbLopCu);
                m_KhoiLopMoiCtrl.HienThiComboBox(cmbKhoiLopCu.SelectedValue.ToString(), cmbKhoiLopMoi);
                
                cmbLopCu.DataBindings.Clear();
                lVLopCu.Items.Clear();
            }
        }

        private void cmbKhoiLopMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHocMoi.SelectedValue != null && cmbKhoiLopMoi.SelectedValue != null)
            {
                m_LopMoiCtrl.HienThiComboBox(cmbKhoiLopMoi.SelectedValue.ToString(), cmbNamHocMoi.SelectedValue.ToString(), cmbLopMoi);
                
                cmbLopMoi.DataBindings.Clear();
                lVLopMoi.Items.Clear();
            }
        }

        private void cmbLopCu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLopCu.SelectedValue != null && cmbNamHocCu.SelectedValue != null && cmbKhoiLopCu.SelectedValue != null)
                m_HocSinhCtrl.HienThiDsHocSinhTheoLop1(cmbNamHocCu.SelectedValue.ToString(), cmbLopCu.SelectedValue.ToString(), cmbHocKyCu.SelectedValue.ToString(), lVLopCu);
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            m_HocSinhCtrl.HienThiDsHocSinhTheoLop(cmbNamHocCu.SelectedValue.ToString(), cmbKhoiLopCu.SelectedValue.ToString(), cmbLopCu.SelectedValue.ToString(), lVLopCu);
        }

        private void cmbHocKyCu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHocCu.SelectedValue != null && cmbHocKyCu.SelectedValue != null)
                m_KhoiLopCuCtrl.HienThiComboBox_new(cmbNamHocCu.SelectedValue.ToString(), cmbKhoiLopCu);
        }

        private void btnHienThiDanhSach_Click(object sender, EventArgs e)
        {
            m_HocSinhCtrl.LayDSHSChuaCoLop(lVLopCu);
        }

        private void cmbHocKyMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHocMoi.SelectedValue != null && cmbHocKyMoi.SelectedValue != null)
                m_KhoiLopCuCtrl.HienThiComboBox_new(cmbNamHocMoi.SelectedValue.ToString(), cmbKhoiLopMoi);
        }

        private void btnHienThiDSHSCu_Click(object sender, EventArgs e)
        {
            if (cmbHocKyCu.SelectedValue == null)
            {
                MsgboxUtil.Error("Bạn chưa chọn học kỳ cũ");
                return;
            }
            if (cmbKhoiLopCu.SelectedValue == null)
            {
                MsgboxUtil.Error("Bạn chưa chọn khối lớp cũ");
                return;
            }
            if (cmbLopCu.SelectedValue == null)
            {
                MsgboxUtil.Error("Bạn chưa chọn lớp cũ");
                return;
            }
            if (cmbLopCu.SelectedValue != null && cmbNamHocCu.SelectedValue != null && cmbKhoiLopCu.SelectedValue != null)
                m_HocSinhCtrl.HienThiDsHocSinhTheoLop1(cmbNamHocCu.SelectedValue.ToString(), cmbLopCu.SelectedValue.ToString(), cmbHocKyCu.SelectedValue.ToString(), lVLopCu);
        }

        private void btnHienThiDSHSMoi_Click(object sender, EventArgs e)
        {
            if (cmbHocKyMoi.SelectedValue == null)
            {
                MsgboxUtil.Error("Bạn chưa chọn học kỳ mới");
                return;
            }
            if (cmbKhoiLopMoi.SelectedValue == null)
            {
                MsgboxUtil.Error("Bạn chưa chọn khối lớp mới");
                return;
            }
            if (cmbLopMoi.SelectedValue == null)
            {
                MsgboxUtil.Error("Bạn chưa chọn lớp mói");
                return;
            }
            if (cmbLopMoi.SelectedValue != null && cmbNamHocMoi.SelectedValue != null && cmbKhoiLopMoi.SelectedValue != null)
                m_HocSinhCtrl.HienThiDsHocSinhTheoLop1(cmbNamHocMoi.SelectedValue.ToString(), cmbLopMoi.SelectedValue.ToString(), cmbHocKyMoi.SelectedValue.ToString(), lVLopMoi);
        }

        private void simpleButtonDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButtonLuu_Click(object sender, EventArgs e)
        {
            if (cmbNamHocCu.SelectedValue != null &&
                cmbKhoiLopCu.SelectedValue != null &&
                cmbLopCu.SelectedValue != null &&
                cmbNamHocMoi.SelectedValue != null &&
                cmbKhoiLopMoi.SelectedValue != null &&
                cmbLopMoi.SelectedValue != null)
            {
                if (MsgboxUtil.YesNo("Bạn có chắc chắn muốn lưu không?")
                          == DialogResult.Yes)
                {
                    m_HocSinhCtrl.LuuHSVaoBangQuaTrinhHoc(
                                                      cmbHocKyMoi.SelectedValue.ToString(),
                                                      cmbLopMoi.SelectedValue.ToString(),
                                                      lVLopMoi);

                    MessageBoxEx.Show("Đã lưu học sinh vào lớp " + cmbLopMoi.Text + " thành công !", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lVLopMoi.Items.Clear();
                    return;
                }
                else
                {
                    return;
                }
            }
            else
                MessageBoxEx.Show("Giá trị của các ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}