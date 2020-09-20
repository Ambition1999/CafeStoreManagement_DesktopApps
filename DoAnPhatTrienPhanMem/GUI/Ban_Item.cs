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
    public partial class Ban_Item : DevExpress.XtraEditors.XtraUserControl
    {
        public Ban_Item()
        {
            InitializeComponent();
        }
        Cart ca = new Cart();
        BLL_HoaDon hd = new BLL_HoaDon();
        BLL_Ban b = new BLL_Ban();
        public Ban_Item(String tenKhuVuc, String tenBan, bool trangThai,int maBan)
        {
            try
            {
                InitializeComponent();
                lbl_TenKhuVuc.Text = tenKhuVuc;
                lbl_TrangThai.Tag = trangThai;
                lbl_TenBan.Tag = maBan;
                lbl_TenBan.Text = tenBan;
                if (trangThai)
                {
                    lbl_TrangThai.Text = "Trạng thái: đang sử dụng";
                    lbl_TenKhuVuc.BackColor = Color.OrangeRed;
                    lbl_TrangThai.BackColor = Color.OrangeRed;
                }
                else
                {
                    lbl_TrangThai.Text = "Trạng thái: trống";
                    lbl_TenKhuVuc.BackColor = Color.LimeGreen;
                    lbl_TrangThai.BackColor = Color.LimeGreen;
                }
            }
            catch (Exception ee)
            { }
        }

        private void lbl_TenBan_Click(object sender, EventArgs e)
        {
            try
            {
                if (chuyen == 0)
                {
                    ca.setMaBan(int.Parse(lbl_TenBan.Tag + ""));
                    if ((Program.frmGM == null || Program.frmGM.IsDisposed) && lbl_TrangThai.Tag.ToString().Equals("False"))
                    {
                        Program.frmGM = new Form_GoiMon();
                    }
                    else if ((Program.frmGM == null || Program.frmGM.IsDisposed) && lbl_TrangThai.Tag.ToString().Equals("True"))
                    {
                        Program.frmGM = new Form_GoiMon("a");
                    }
                    Program.frmCNC.Visible = false;
                    Program.frmGM.Show();
                }
                else if (chuyen == 1)
                {
                    if (lbl_TrangThai.Tag.ToString().Equals("False"))
                    {
                        int maBanMoi = int.Parse(lbl_TenBan.Tag + "");
                        int maBanCu = maBan;
                        //xu li
                        tblHoaDon h = hd.getMaHDTheoBan(maBanCu);
                        hd.suaHoaDonMaBan(h.MaHD, maBanMoi);
                        b.updateTTBan(maBanCu);
                        Program.frmCNC.load2();
                        chuyen = 0;
                    }
                    else
                    {
                        MessageBox.Show("Mời chọn 1 bàn khác");
                    }
                }
                else if (chuyen == 2)
                {
                    if (lbl_TrangThai.Tag.ToString().Equals("True") && maBan != int.Parse(lbl_TenBan.Tag + ""))
                    {
                        int maBanMoi = int.Parse(lbl_TenBan.Tag + "");
                        int maBanCu = maBan;
                        //xu li
                        b.gopBan(maBanCu, maBanMoi);
                        Program.frmCNC.load2();
                        chuyen = 0;
                    }
                    else
                    {
                        MessageBox.Show("Mời chọn 1 bàn khác");
                    }
                }
            }
            catch (Exception ee)
            { 
            
            }
        }

        private void lbl_TenKhuVuc_Click(object sender, EventArgs e)
        {

        }

        private void lbl_TrangThai_Click(object sender, EventArgs e)
        {

        }
        static int chuyen = 0;
        static int maBan = -1;
        private void chuyểnBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mời chọn bàn cần chuyển");
            maBan = int.Parse(lbl_TenBan.Tag + "");
            chuyen = 1;
        }

        private void hủyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã hủy thao tác");
            chuyen = 0;
        }

        private void gộpBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mời chọn bàn cần gộp");
            maBan = int.Parse(lbl_TenBan.Tag + "");
            chuyen = 2;
        }
    }
}
