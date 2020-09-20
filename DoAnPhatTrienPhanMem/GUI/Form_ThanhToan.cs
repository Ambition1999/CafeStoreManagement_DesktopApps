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
using Modul_XuLy;
namespace GUI
{
    public partial class Form_ThanhToan : DevExpress.XtraEditors.XtraForm
    {
        ModuleConvert mc = new ModuleConvert();
        BLL_ChiTietHD ct = new BLL_ChiTietHD();
        BLL_HoaDon hd = new BLL_HoaDon();
        Cart ca = new Cart();
        public Form_ThanhToan()
        {
            InitializeComponent();
            loadListOrder();
        }

        public void loadListOrder()
        {
            //bool colorFlag;
            //for (int i = 0; i < 5; i++)
            //{
            //    if (i % 2 == 0)
            //        colorFlag = true;
            //    else
            //        colorFlag = false;
            //    DoUongGioHang_Item item;
            //    item = new DoUongGioHang_Item("Đồ uống thứ " + i, i, 30000, colorFlag,1);
            //    item.Dock = DockStyle.Top;
            //    lstOrder.Controls.Add(item);
            //}
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            ca.clearCard2();
            ca.clearCard();
            this.Dispose();
            if (Program.frmCNC.Visible == false)
                Program.frmCNC = new Form_ChucNangChinh();
            Program.frmCNC.Show();
        }

        private void btn_ThuTien_Click(object sender, EventArgs e)
        {
            Form_ThuTien frmThuTien = new Form_ThuTien();
            frmThuTien.Show();
            this.Dispose();
        }

        private void Form_ThanhToan_Load(object sender, EventArgs e)
        {
            try
            {
                if (ca.getCart().Count > 0)
                {
                    load1();
                    //lbl_ThanhTien.Text = ca.tinhTong() + "";
                    //lbl_TongThanhToan.Text = ca.tinhTong() + "";
                    lbl_ThanhTien.Text = mc.convertCurrency(ca.tinhTong()) + "";
                    lbl_TongThanhToan.Text = mc.convertCurrency(ca.tinhTong()) + "";
                    lbl_TenBan.Text = "Bàn số: " + ca.getMaBan();
                    lbl_ThoiGianVao.Text = DateTime.Now + "";
                }
                else if (ca.getCart2().Count == 0)
                {
                    load2();
                    tblHoaDon h = hd.getMaHDTheoBan(ca.getMaBan());
                    List<tblChiTietHD> lstCT = (List<tblChiTietHD>)ct.getCTByMaHD(h.MaHD);
                    //lbl_TongThanhToan.Text = lstCT.Sum(t => t.TongTien) + "";
                    lbl_ThanhTien.Text = mc.convertCurrency((double)lstCT.Sum(t => t.TongTien)) + "";
                    lbl_TongThanhToan.Text = mc.convertCurrency((double)lstCT.Sum(t => t.TongTien)) + "";
                    lbl_TenBan.Text = "Bàn số: " + ca.getMaBan();
                    lbl_ThoiGianVao.Text = h.TGVao + "";
                }
                else if (ca.getCart2().Count > 0)
                {
                    load3();
                    tblHoaDon h = hd.getMaHDTheoBan(ca.getMaBan());
                    List<tblChiTietHD> lstCT = (List<tblChiTietHD>)ct.getCTByMaHD(h.MaHD);
                    double sum = ca.tinhTong2();
                    //lbl_ThanhTien.Text = ((double)lstCT.Sum(t => t.TongTien)+sum) + "";
                    //lbl_TongThanhToan.Text = ((double)lstCT.Sum(t => t.TongTien)+sum) + "";
                    lbl_ThanhTien.Text = mc.convertCurrency((double)lstCT.Sum(t => t.TongTien) + sum) + "";
                    lbl_TongThanhToan.Text = mc.convertCurrency((double)lstCT.Sum(t => t.TongTien) + sum) + "";
                    lbl_TenBan.Text = "Bàn số: " + ca.getMaBan();
                    lbl_ThoiGianVao.Text = h.TGVao + "";
                }
            }
            catch (Exception ee)
            { }
        }
        public void load1()
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                bool colorFlag = false;
                List<Item> lstCart = ca.getCart();
                for (int i = 0; i < lstCart.Count; i++)
                {
                    DoUongGioHang_Item_Temp item;
                    item = new DoUongGioHang_Item_Temp(lstCart[i].tenMon, lstCart[i].sl, lstCart[i].donGia, colorFlag, lstCart[i].maMon);
                    item.Dock = DockStyle.Top;
                    flowLayoutPanel1.Controls.Add(item);
                }
            }
            catch (Exception ee)
            { }
        }
        public void load2()
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                bool colorFlag = false;
                tblHoaDon h = hd.getMaHDTheoBan(ca.getMaBan());
                List<tblChiTietHD> lstCT = (List<tblChiTietHD>)ct.getCTByMaHD(h.MaHD);
                for (int i = 0; i < lstCT.Count; i++)
                {
                    DoUongGioHang_Item_Temp item;
                    item = new DoUongGioHang_Item_Temp(lstCT[i].tblThucDon.TenMon, lstCT[i].SoLuong, double.Parse(lstCT[i].tblThucDon.DonGia), colorFlag, lstCT[i].MaMon);
                    item.Dock = DockStyle.Top;
                    flowLayoutPanel1.Controls.Add(item);
                }
            }
            catch (Exception ee)
            { }
        }
        public void load3()
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                bool colorFlag = false;


                tblHoaDon h = hd.getMaHDTheoBan(ca.getMaBan());
                List<tblChiTietHD> lstCT = (List<tblChiTietHD>)ct.getCTByMaHD(h.MaHD);
                for (int i = 0; i < lstCT.Count; i++)
                {
                    DoUongGioHang_Item_Temp item;
                    item = new DoUongGioHang_Item_Temp(lstCT[i].tblThucDon.TenMon, lstCT[i].SoLuong, double.Parse(lstCT[i].tblThucDon.DonGia), colorFlag, lstCT[i].MaMon);
                    item.Dock = DockStyle.Top;
                    flowLayoutPanel1.Controls.Add(item);
                }

                List<Item> lstCart = ca.getCart2();
                for (int i = 0; i < lstCart.Count; i++)
                {
                    DoUongGioHang_Item_Temp item;
                    item = new DoUongGioHang_Item_Temp(lstCart[i].tenMon, lstCart[i].sl, lstCart[i].donGia, colorFlag, lstCart[i].maMon);
                    item.Dock = DockStyle.Top;
                    flowLayoutPanel1.Controls.Add(item);
                }
            }
            catch (Exception ee)
            { }
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_LuuTamHD_Click(object sender, EventArgs e)
        {
            ca.clearCard2();
            ca.clearCard();
            this.Dispose();
            if (Program.frmCNC.Visible == false)
                Program.frmCNC = new Form_ChucNangChinh();
            Program.frmCNC.Show();
        }
    }
}