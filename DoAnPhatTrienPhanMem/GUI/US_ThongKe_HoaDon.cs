using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLL;

namespace GUI
{
    public partial class US_ThongKe_HoaDon : DevExpress.XtraEditors.XtraUserControl
    {
        BLL_TblHoaDon hd = new BLL_TblHoaDon();
        public US_ThongKe_HoaDon()
        {
            InitializeComponent();
            loadGrid();
        }

        public void loadGrid()
        {
            dtGrid.DataSource = hd.getDooanhThuCacNgayTrongThang();
        }

        public void loadGridDoanhThuTheoMocTG(DateTime dateStart, DateTime dateEnd)
        {
            dtGrid.DataSource = hd.getDooanhThuTheoMocThoiGian(dateStart, dateEnd);
        }

        private void btn_LayDL_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dateStart = dateEdit_Start.DateTime.Date;
                DateTime dateEnd = dateEdit_End.DateTime.Date;
                if (dateStart > dateEnd)
                {
                    MessageBox.Show("Thời gian đầu không được lớn hơn thời gian cuối");
                }
                else
                {
                    loadGridDoanhThuTheoMocTG(dateStart, dateEnd);
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thời gian không hợp lệ");
            }
        }

        private void xemChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dtGrid.CurrentRow.Cells[0].Value != null){
                try{
                   String ngay = dtGrid.CurrentRow.Cells[0].Value.ToString();
                    String thang = dtGrid.CurrentRow.Cells[1].Value.ToString();
                    String nam = dtGrid.CurrentRow.Cells[2].Value.ToString();
                    String dateString = ngay + "/" + thang + "/" + nam;
                    DateTime dateInput = new DateTime();
                    try{
                        dateInput = DateTime.Parse(dateString);
                        Form_BangKeHoaDon frm_BK = new Form_BangKeHoaDon(dateInput);
                        frm_BK.Show();
                    }catch(Exception ex){
                        MessageBox.Show("Ngày không hợp lệ");

                    }
                }
                catch(Exception ex){
                    MessageBox.Show("Vui lòng chọn dòng cần xem chi tiết hóa đơn");
                }
            }
            
        }

        private void btn_XuatKhau_Click(object sender, EventArgs e)
        {
            List<Class1> x = hd.getDooanhThuCacNgayTrongThang2();
            string path = string.Empty;
            ExcelExport1 ex = new ExcelExport1();
            ex.ExportHD(x, ref path, false);
            if (!string.IsNullOrEmpty(path) && MessageBox.Show("Bạn muốn mở file", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(path);
            }
        }
    }
}
