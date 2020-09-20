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
using System.Globalization;

namespace GUI
{
    public partial class Grid_Item : DevExpress.XtraEditors.XtraUserControl
    {
        int maHoaDon;
        public Grid_Item()
        {
            InitializeComponent();
        }

        public Grid_Item(String tang, string tenban, string sotien, string thoigian)
        {
            InitializeComponent();
            lblTang.Text = "Tầng: " + tang;
            lblSoBan.Text = "Bàn số: " + tenban;
            lblThoiGian.Text = thoigian;
            lblSoTien.Text = sotien + "VNĐ";
        }
        int maB;
        public Grid_Item(String tang, string tenban, double sotien, string thoigian,int x,int maBan)
        {
            InitializeComponent();
            maB = maBan;
            lblTang.Text = "Tầng: " + tang;
            lblSoBan.Text = "Bàn số: " + maB;
            lblThoiGian.Text = thoigian;
            lblSoTien.Text = sotien + "VNĐ";
        }
        

        public String formatCurrency(double strInput)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            return Convert.ToDouble(strInput).ToString("#,###", cul.NumberFormat);
        }

        public void setTagForButton(int maHD)
        {
            btn_Them.Tag = maHD;
            btn_XemTT.Tag = maHD;
            btnKhac.Tag = maHD;
            btnThanhToan.Tag = maHD;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            //Form_ThanhToan form_ThanhToan = new Form_ThanhToan(maHoaDon);
            //form_ThanhToan.Show();
            //this.Hide();
            ca.setFlag(1);
            ca.setMaBan(maB);
            Form_ThanhToan frm = new Form_ThanhToan();
            this.Dispose();
            frm.Show();
        }
        Cart ca = new Cart();
        private void btn_Them_Click(object sender, EventArgs e)
        {
            //Form_GoiMon frm = new Form_GoiMon();
            //frm.Show();
            //this.Hide();
            ca.setMaBan(maB);
            if ((Program.frmGM == null || Program.frmGM.IsDisposed))
            {
                Program.frmGM = new Form_GoiMon("a");
            }
           
            Program.frmCNC.Visible = false;
            Program.frmGM.Show();
        }

        private void btn_XemTT_Click(object sender, EventArgs e)
        {
            ca.setMaBan(maB);
            if ((Program.frmGM == null || Program.frmGM.IsDisposed))
            {
                Program.frmGM = new Form_GoiMon("a");
            }

            Program.frmCNC.Visible = false;
            Program.frmGM.Show();
        }

    }
}
