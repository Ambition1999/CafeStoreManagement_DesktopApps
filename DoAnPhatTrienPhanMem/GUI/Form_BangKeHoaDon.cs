using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLL;

namespace GUI
{
    public partial class Form_BangKeHoaDon : DevExpress.XtraEditors.XtraForm
    {
        BLL_TblHoaDon hd = new BLL_TblHoaDon();
        public static Form_BangKeHoaDon Current;
        DateTime ngayHD;
        public Form_BangKeHoaDon()
        {
            InitializeComponent();
            Current = this;
        }

        public Form_BangKeHoaDon(DateTime ngayHdInput)
        {
            InitializeComponent();
            Current = this;
            this.ngayHD = ngayHdInput;

        }



        private void Form_BangKeHoaDon_Load(object sender, EventArgs e)
        {
            lbl_NgayHD.Text = "Ngày " + ngayHD;
            loadGirdViewNgayHD();
            //Lấy tổng giá trị hóa đơn trên datagirdview
            try
            {
                double total = dtGridHDNgay.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDouble(t.Cells[4].Value));
                ModuleConvert module = new ModuleConvert();
                lbl_TongTien.Text = "Tổng tiền " + module.convertCurrency(total) + " VNĐ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tổng tiền");
            }
        }

        public void loadGirdViewNgayHD()
        {
            dtGridHDNgay.DataSource = hd.getDSHD_TheoNgay(ngayHD);
            
            //Tạo linklabel cho mã hóa đơn
            foreach (DataGridViewRow row in dtGridHDNgay.Rows)
            {
                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                linkCell.Value = row.Cells[3].Value;
                dtGridHDNgay[3, row.Index] = linkCell;
            }
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dtGridHDNgay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtGridHDNgay.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewLinkCell)
            {
                try
                {
                    int maHD = Convert.ToInt32(dtGridHDNgay.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    Form_ChiTietHoaDon frm = new Form_ChiTietHoaDon(maHD);
                    frm.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mã hóa đơn không hợp lệ");
                }
               
            }
        }


    }
}