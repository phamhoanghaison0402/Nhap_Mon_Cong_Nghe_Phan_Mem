using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using QLHS_THPT.Controller;
using QLHS_THPT.Bussiness;
using DevExpress.XtraEditors;

namespace QLHS_THPT
{
    public partial class frmQuyDinhToanTruong : XtraForm
    {
        private readonly QuyDinhBUS _quyDinhBUS;

        public frmQuyDinhToanTruong()
        {
            InitializeComponent();
            _quyDinhBUS = new QuyDinhBUS();
        }

        private void frmQuyDinhToanTruong_Load(object sender, EventArgs e)
        {
            QuyDinhDTO quyDinh = _quyDinhBUS.LayDS_QuyDinh();
            txtTenTruong.Text = quyDinh.TenTruong;
            txtDiaChiTruong.Text = quyDinh.DiaChiTruong;
            integerInputTuoiToiThieuHienTai.Value = quyDinh.TuoiToiThieu;
            integerInputTuoiToiDaHienTai.Value = quyDinh.TuoiToiDa;
            integerInputSiSoToiDaHienTai.Value = quyDinh.SiSoToiDa;
            spinEditDiemToiThieuHienTai.Value = Convert.ToDecimal(quyDinh.DiemToiThieu);
            spinEditDiemToiDaHienTai.Value = Convert.ToDecimal(quyDinh.DiemToiDa);
            spinEditDiemDatHienTai.Value = Convert.ToDecimal(quyDinh.DiemDat);
            spinEditDiemDatMonHienTai.Value = Convert.ToDecimal(quyDinh.DiemDatMon);
           
            dateTimePickerSiSoToiDa.Value = quyDinh.NgayApDungSiSoToiDa;
            dateTimePickerTuoiToiDa.Value = quyDinh.NgayApDungTuoiToiDa;
            dateTimePickerTuoiToiThieu.Value = quyDinh.NgayApDungTuoiToiThieu;
            dateTimePickerDiemDat.Value = quyDinh.NgayApDungDiemDat;
            dateTimePickerDiemDatMon.Value = quyDinh.NgayApDungDiemDatMon;
            dateTimePickerDiemToiThieu.Value = quyDinh.NgayApDungDiemToiThieu;
            dateTimePickerDiemToiDa.Value = quyDinh.NgayApDungDiemToiDa;

            integerInputTuoiToiThieuMoi.Value = quyDinh.TuoiToiThieu;
            integerInputTuoiToiDaMoi.Value = quyDinh.TuoiToiDa;
            integerInputSiSoToiDaMoi.Value = quyDinh.SiSoToiDa;
            spinEditDiemToiThieuMoi.Value = Convert.ToDecimal(quyDinh.DiemToiThieu);
            spinEditDiemToiDaMoi.Value = Convert.ToDecimal(quyDinh.DiemToiDa);
            spinEditDiemDatMoi.Value = Convert.ToDecimal(quyDinh.DiemDat);
            spinEditDiemDatMonMoi.Value = Convert.ToDecimal(quyDinh.DiemDatMon);
        }

        private void simpleButtonDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButtonLuu_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (txtTenTruong.Text.Length < 3)
            {
                msg = "\nTên trường không hợp lệ! (lớn hơn 3 ký tự)";
            }
            if (txtDiaChiTruong.Text.Length < 3)
            {
                msg = "\nĐịa chỉ không hợp lệ! (lớn hơn 3 ký tự)";
            }

            if (integerInputSiSoToiDaMoi.Value <= 0)
            {
                msg = "\nSỉ số lớp tối đa không hợp lệ! (lớn hơn 0)";
            }

            else if (integerInputTuoiToiThieuMoi.Value >= integerInputTuoiToiDaMoi.Value)
            {
                msg = "\nTuổi tối thiểu phải nhỏ hơn tuổi tối đa!";
            }

            if (msg != "")
            {
                MsgboxUtil.Error(msg);
                return;
            }
            var quyDinh = new QuyDinhDTO

            {
                TenTruong = txtTenTruong.Text.Replace("'", "''"),
                DiaChiTruong = txtDiaChiTruong.Text.Replace("'", "''"),

                SiSoToiDa = Convert.ToInt32(integerInputSiSoToiDaMoi.Value),
                TuoiToiDa = Convert.ToInt32(integerInputTuoiToiDaMoi.Value),
                TuoiToiThieu = Convert.ToInt32(integerInputTuoiToiThieuMoi.Value),

                DiemToiThieu = Convert.ToDouble(spinEditDiemToiThieuMoi.Value),
                DiemToiDa = Convert.ToDouble(spinEditDiemToiDaMoi.Value),
                DiemDat = Convert.ToDouble(spinEditDiemDatMoi.Value),
                DiemDatMon = Convert.ToDouble(spinEditDiemDatMonMoi.Value),

                NgayApDungDiemDat = dateTimePickerDiemDat.Value,
                NgayApDungDiemDatMon = dateTimePickerDiemDatMon.Value,
                NgayApDungDiemToiThieu = dateTimePickerDiemToiThieu.Value,
                NgayApDungDiemToiDa = dateTimePickerDiemToiDa.Value,
                NgayApDungSiSoToiDa = dateTimePickerSiSoToiDa.Value,
                NgayApDungTuoiToiThieu = dateTimePickerTuoiToiThieu.Value,
               NgayApDungTuoiToiDa = dateTimePickerTuoiToiDa.Value,
                

            };
            if (MsgboxUtil.YesNo("Bạn có chắc chắn muốn cập nhật không?")
                            == DialogResult.Yes)
            {
                if (_quyDinhBUS.CapNhat_QuyDinh(quyDinh))
                    MsgboxUtil.Success("Cập nhật quy định năm học thành công!");
                else
                    MsgboxUtil.Error("Có lỗi trong quá trình cập nhật!");
                return;
            }
            else
            {
                return;
            }
        }   
    }
}
