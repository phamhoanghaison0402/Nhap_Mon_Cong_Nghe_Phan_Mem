using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using QLHS_THPT.Controller;
using QLHS_THPT.Bussiness;
using QLHS_THPT.Component;
using QLHS_THPT.DataLayer;
using Util;


namespace QLHS_THPT
{
    public partial class FrmKBNamHoc : XtraForm
    {
        private readonly NamHocBUS _namHocBUS;
        NamHocData m_NamHocData = new NamHocData();
        NamHocCtrl m_NamHocCtrl = new NamHocCtrl();
        private bool _isAddButton;
        private bool _isDeleteButton;
       

        public FrmKBNamHoc()
        {
            InitializeComponent();
            _namHocBUS = new NamHocBUS();
            _isAddButton = true;
            _isDeleteButton = true;
        }

        private void frmKBNamHoc_Load(object sender, EventArgs e)
        {
            CboUtil.SetDataSource(comboBoxEdit1, _namHocBUS.LayDT_NamHoc_ThemMoi(),
                                  "MaNamHoc", "TenNamHoc", 0);
            _Load_Lai_GridView();
        }

        private void gridView1_FocusedRowChanged(object sender,
                                                 FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle < 0)
                return;
            string maNamHoc = gridViewNamHoc.GetRowCellValue(e.FocusedRowHandle, "MaNamHoc").ToString();
            CboUtil.SelectedItem(comboBoxEdit1, maNamHoc);
        }

        private void _Load_Lai_GridView()
        {
            gridControlNamHoc.DataSource = _namHocBUS.LayDTNamHoc();
            _Disable_Control(editing: false);
        }

        private void _Disable_Control(bool editing)
        {
            _isAddButton = !editing;
            _isDeleteButton = !editing;

            simpleButtonThem.Text = editing ? "Không thêm (Alt+&N)" : "Thêm (Alt+&A)";

            comboBoxEdit1.Enabled = editing;
            gridControlNamHoc.Enabled = !editing;
            if (!editing)
            {
                if (gridViewNamHoc.RowCount > 0)
                    gridView1_FocusedRowChanged(this,
                                                new FocusedRowChangedEventArgs(0, 0));
            }
        }



        private void simpleButtonLuu_Click(object sender, EventArgs e)
        {
            if (_isAddButton)
            {
                _Disable_Control(editing: false);
            }
            else
            {
                var namHocDTO = new NamHocDTO
                                    {
                                        MaNamHoc = CboUtil.GetValueItem(comboBoxEdit1),
                                        TenNamHoc = CboUtil.GetDisplayItem(comboBoxEdit1)
                                    };
                // check & save
                if (m_NamHocData.kiemtratontai(namHocDTO.MaNamHoc))
                {
                    MsgboxUtil.Error("Năm học " + namHocDTO.TenNamHoc
                                     + " đã tồn tại. Hãy chọn 1 năm học khác!");
                    return;
                }
                  

                       m_NamHocCtrl.LuuNamHocMoi(namHocDTO.MaNamHoc, namHocDTO.TenNamHoc);

                       MsgboxUtil.Success("Đã tạo năm học mới thành công."
                                          + "\nTiếp theo bạn hãy tạo danh sách lớp cho năm học này!");
                       _Load_Lai_GridView();      
            }
        }

        private void simpleButtonXoa_Click(object sender, EventArgs e)
        {
            string maNamHoc = CboUtil.GetValueItem(comboBoxEdit1);
            string tenNamHoc = CboUtil.GetDisplayItem(comboBoxEdit1);

            if (_isDeleteButton)
            {
                //if (_namHocBUS.KiemTraTonTai_NamHoc(maNamHoc))
                //{
                    // xóa
                    if (MsgboxUtil.YesNo("Bạn có chắc chắn muốn xóa năm học"
                                         + tenNamHoc +
                                         " và tất cả hồ sơ: Lớp học, phân lớp, bảng điểm,... liên quan đến năm học này?")
                        == DialogResult.Yes)
                    {
                        _namHocBUS.Xoa_NamHoc(maNamHoc);
                        MsgboxUtil.Success("Đã xóa năm học " + tenNamHoc + " thành công!");
                        _Load_Lai_GridView();
                    }
               // }
               // else
                //{
              //      MsgboxUtil.Error("Không tồn tại năm học " + tenNamHoc);
               // }
            }
            else // Không thêm
            {
                _Disable_Control(editing: false);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButtonThem_Click(object sender, EventArgs e)
        {
            if (_isAddButton)
            {
                _Disable_Control(editing: true);
            }
            else
            {
                _Disable_Control(editing: false);
            }
        }
    }
}