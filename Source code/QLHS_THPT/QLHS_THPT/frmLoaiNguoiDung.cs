﻿using System;
using System.Data;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using QLHS_THPT.Controller;
using QLHS_THPT.Component;
using DevComponents.DotNetBar;

namespace QLHS_THPT
{
    public partial class frmLoaiNguoiDung : Office2007Form
    {
        #region Fields
        LoaiNguoiDungCtrl   m_LoaiNguoiDungCtrl = new LoaiNguoiDungCtrl();
        QuyDinh             quyDinh             = new QuyDinh();
        #endregion

        #region Constructor
        public frmLoaiNguoiDung()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void frmLoaiNguoiDung_Load(object sender, EventArgs e)
        {
            m_LoaiNguoiDungCtrl.HienThi(dGVLoaiNguoiDung, bindingNavigatorLoaiNguoiDung);
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dGVLoaiNguoiDung.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorLoaiNguoiDung.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dGVLoaiNguoiDung.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row       = m_LoaiNguoiDungCtrl.ThemDongMoi();
            m_Row["MaLoai"]     = "LND" + quyDinh.LaySTT(dGVLoaiNguoiDung.Rows.Count + 1);
            m_Row["TenLoaiND"]  = "";
            m_LoaiNguoiDungCtrl.ThemLoaiNguoiDung(m_Row);
            bindingNavigatorLoaiNguoiDung.BindingSource.MoveLast();
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dGVLoaiNguoiDung.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBoxEx.Show("Giá trị của ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("colMaLoai")     == true &&
                KiemTraTruocKhiLuu("colTenLoaiND")  == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_LoaiNguoiDungCtrl.LuuLoaiNguoiDung();
            }
        }
        #endregion

        #region DataError event
        private void dGVLoaiNguoiDung_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion
    }
}
