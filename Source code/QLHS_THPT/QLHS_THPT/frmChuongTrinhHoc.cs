﻿using System;
using System.Data;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using QLHS_THPT.Controller;
using QLHS_THPT.Component;
using DevComponents.DotNetBar;
using DevExpress.XtraEditors;

namespace QLHS_THPT
{
    public partial class frmChuongTrinhHoc : XtraForm
    {
        #region Fields
        ChuongTrinhHocCtrl m_ChuongTrinhHocCtrl = new ChuongTrinhHocCtrl();
        LopCtrl m_LopCtrl = new LopCtrl();
        MonHocCtrl m_MonHocCtrl = new MonHocCtrl();
        QuyDinh     quyDinh         = new QuyDinh();
        KhoiLopCtrl m_KhoiLopCtrl = new KhoiLopCtrl();
        NamHocCtrl m_NamHocCtrl = new NamHocCtrl();
        #endregion

        #region Constructor
        public frmChuongTrinhHoc()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void frmChuongTrinhHoc_Load(object sender, EventArgs e)
        {
            m_NamHocCtrl.HienThiComboBox(cmbNamHoc);    
        }
        #endregion

        #region BindingNavigatorItems
       public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dGVMonHoc.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "" || str == "0")
                    {
                        MessageBoxEx.Show("Giá trị của ô không được rỗng, số tiết và hệ số phải lớn hơn 0!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (
                KiemTraTruocKhiLuu("colMaMonHoc")  == true &&
                KiemTraTruocKhiLuu("colSoTiet")     == true &&
                KiemTraTruocKhiLuu("colHeSo")       == true)
            {
                
                bindingNavigatorPositionItem.Focus();
                //m_ChuongTrinhHocCtrl.LuuMonHoc();
                //m_ChuongTrinhHocCtrl.CapNhatChuongTrinhHoc(cmbLop.SelectedValue.ToString, cmbMonHoc.SelectedValue.ToString, "colHeSo", "colSoTiet");
                //m_ChuongTrinhHocCtrl.LuuChuongTrinhHoc(cmbLop.SelectedValue.ToString(), cmbMonHoc.SelectedValue.ToString(), colHeSo.ToString(), colSoTiet.ToString());
            }
        }
        #endregion

        #region DataError event
        private void dGVMonHoc_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        private void cmbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null)
                m_KhoiLopCtrl.HienThiComboBox_new(cmbNamHoc.SelectedValue.ToString(), cmbKhoiLop);
            cmbKhoiLop.DataBindings.Clear();
        }

        private void cmbKhoiLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null && cmbKhoiLop.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cmbKhoiLop.SelectedValue.ToString(), cmbNamHoc.SelectedValue.ToString(), cmbLop);
            cmbLop.DataBindings.Clear();
        }

        private void btnHienThiDanhSach_Click(object sender, EventArgs e)
        {
            if (cmbKhoiLop.SelectedValue == null)
            {
                MessageBoxEx.Show("Bạn chưa chọn khối lớp!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbLop.SelectedValue == null)
            {
                MessageBoxEx.Show("Bạn chưa chọn lớp!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            m_MonHocCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(), cmbMonHoc);
            m_MonHocCtrl.HienThiDataGridViewComboBoxColumn(colMaMonHoc, cmbNamHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString());
            m_ChuongTrinhHocCtrl.HienThi(dGVMonHoc, bindingNavigatorMonHoc, cmbNamHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString());     
        }

        private void btnThemVaoDanhSach_Click(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue == null)
            {
                MessageBoxEx.Show("Bạn chưa chọn năm học!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbKhoiLop.SelectedValue == null)
            {
                MessageBoxEx.Show("Bạn chưa chọn khối lớp!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (textBoxHeSo.Text == "")
            {
                MessageBoxEx.Show("Giá trị của ô không được rỗng, hệ số phải lớn hơn 0!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;   
            }
            if (iniSoTiet.Value == null)
            {
                MessageBoxEx.Show("Giá trị của ô không được rỗng, số tiết phải lớn hơn 0!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MsgboxUtil.YesNo("Bạn có muốn thêm môn " + cmbMonHoc.Text 
                                       + " vào lớp " +
                                       cmbLop.Text + " hay không?")
                      == DialogResult.No)
            {
                return;
            }
                m_ChuongTrinhHocCtrl.LuuChuongTrinhHoc(cmbLop.SelectedValue.ToString(), cmbMonHoc.SelectedValue.ToString(), Convert.ToInt32(textBoxHeSo.Text), iniSoTiet.Value);
                m_MonHocCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(), cmbMonHoc);
                m_MonHocCtrl.HienThiDataGridViewComboBoxColumn(colMaMonHoc, cmbNamHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString());   
                m_ChuongTrinhHocCtrl.HienThi(dGVMonHoc, bindingNavigatorMonHoc, cmbNamHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString());
                MsgboxUtil.Success("Đã thêm môn " + cmbMonHoc.Text + " vào lớp " + cmbLop.Text + " thành công!");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemNamHoc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormKBNamHoc();
            m_NamHocCtrl.HienThiComboBox(cmbNamHoc);
        }

        private void btnThemHocKy_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormKhoiLop();           
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormPhanLopHoc();
        }
        private void textBoxHeSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keycode = e.KeyChar;
            int c = (int)keycode;
            // Kiểm tra ký tự vừa nhập vào có phải là các số nằm trong khoảng
            // 0..9
            if ((c >= 48) && (c <= 57))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (c == 8)
            {
                e.Handled = false;
            }
            if(c == 32)
            {
                e.Handled = false;
            }
            if(c == 46)
            {
                e.Handled = false;
            }
        }
    }
}