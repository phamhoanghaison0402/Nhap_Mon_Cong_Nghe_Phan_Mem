using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using QLHS_THPT.DataLayer;


namespace QLHS_THPT.Controller
{
    public class QuaTrinhHocCtrl
    {
        QuaTrinhHocData m_QuaTrinhHocData = new QuaTrinhHocData();

        #region Hien thi ComboBox
        public void HienThiComboBox(String hocSinh, String hocKy, ComboBox comboBox)
        {
            comboBox.DataSource = m_QuaTrinhHocData.LayDsQTH(hocSinh, hocKy);
            comboBox.DisplayMember = "MaQuaTrinhHoc";
            comboBox.ValueMember = "MaQuaTrinhHoc";
        }

       
        #endregion       
    }
}
