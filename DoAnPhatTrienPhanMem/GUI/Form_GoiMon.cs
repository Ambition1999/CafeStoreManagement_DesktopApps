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
    public partial class Form_GoiMon : DevExpress.XtraEditors.XtraForm
    {
        ModuleConvert mc = new ModuleConvert();
        Cart ca = new Cart();
        BLL_HoaDon hd = new BLL_HoaDon();
        BLL_ChiTietHD ct = new BLL_ChiTietHD();
        List<Item> lstCartTemp = new List<Item>();
        List<tblChiTietHD> lstCT;
        public Form_GoiMon()
        {
            InitializeComponent();
            loadUserControl();
            ca.setFlag(0);
            //loadListOrder();
        }
        public Form_GoiMon(String a)
        {
            InitializeComponent();
            loadUserControl();
            ca.setFlag(1);
            tblHoaDon h = hd.getMaHDTheoBan(ca.getMaBan());
            lstCT = ct.getCTByMaHD(h.MaHD).ToList<tblChiTietHD>();
            loadListOrder2();
        }
        public void loadUserControl()
        {
            Layout_MenuDoUong menu = new Layout_MenuDoUong();
            menu.loadItemToLayout();
            menu.Dock = DockStyle.Fill;
            menu.Show();
            panel_MenuDoUong.Controls.Add(menu);
        }
        public void loadListOrder2()
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                bool colorFlag;
                for (int i = 0; i < lstCT.Count; i++)
                {
                    colorFlag = true;
                    DoUongGioHang_Item item;
                    item = new DoUongGioHang_Item(lstCT[i].tblThucDon.TenMon, lstCT[i].SoLuong, double.Parse(lstCT[i].tblThucDon.DonGia), colorFlag, lstCT[i].MaMon);
                    item.Dock = DockStyle.Top;
                    flowLayoutPanel1.Controls.Add(item);
                }
                double sum1 = (double)lstCT.Sum(t => t.TongTien);

                List<Item> lstCart = ca.getCart2();
                for (int i = 0; i < lstCart.Count; i++)
                {
                    colorFlag = false;
                    DoUongGioHang_Item item;
                    item = new DoUongGioHang_Item(lstCart[i].tenMon, lstCart[i].sl, lstCart[i].donGia, colorFlag, lstCart[i].maMon);
                    item.Dock = DockStyle.Top;
                    flowLayoutPanel1.Controls.Add(item);
                }
                double sum2 = lstCart.Sum(t => t.tongTien);
                lblTongTien.Text = mc.convertCurrency((sum1 + sum2)) + "";
            }
            catch (Exception ee)
            { }
        }
        public void loadListOrder()
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                bool colorFlag = false;
                List<Item> lstCart = ca.getCart();
                for (int i = 0; i < lstCart.Count; i++)
                {
                    DoUongGioHang_Item item;
                    item = new DoUongGioHang_Item(lstCart[i].tenMon, lstCart[i].sl, lstCart[i].donGia, colorFlag, lstCart[i].maMon);
                    item.Dock = DockStyle.Top;
                    flowLayoutPanel1.Controls.Add(item);
                }
                lblTongTien.Text = mc.convertCurrency(ca.tinhTong()) + "";
            }
            catch (Exception ee)
            { }
        }

        private void btn_HuyBo_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Các lựa chọn sẽ không được lưu /nBạn có muốn hủy?", "Hủy bỏ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    ca.clearCard2();
                    ca.clearCard();
                    this.Dispose();
                    if (Program.frmCNC.Visible == false)
                        Program.frmCNC = new Form_ChucNangChinh();
                    Program.frmCNC.Show();
                }

            }
            catch (Exception ee)
            { }
        }

       

        private void btn_TinhTien_Click(object sender, EventArgs e)
        {
            if(ca.getFlag() == 0&&ca.getCart().Count==0)
            {
                MessageBox.Show("Moi Chon San Pham");
                return;
            }
            
            Form_ThanhToan frm = new Form_ThanhToan();
            this.Dispose();
            frm.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                panel_MenuDoUong.Controls.Clear();
                Layout_MenuDoUong menu = new Layout_MenuDoUong();
                menu.loadItemToLayout_PhoBien();
                menu.Dock = DockStyle.Fill;
                menu.Show();
                panel_MenuDoUong.Controls.Add(menu);
            }
            catch (Exception ee)
            { }
        }
        private void simpleButton7_Click(object sender, EventArgs e)
        {
            try
            {
                if (ca.getFlag() == 0)
                {
                    try
                    {
                        int maMon = ca.getBienXoa();
                        List<Item> lstCart = ca.getCart();
                        Item i = lstCart.FirstOrDefault(t => t.maMon == maMon);
                        i.sl++;
                        i.tongTien = (double)((i.sl) * i.donGia);
                        Program.frmGM.loadListOrder();
                    }
                    catch (Exception ee)
                    {

                    }
                }
                else
                {
                    try
                    {
                        if (!ca.getMau())
                        {
                            int maMon = ca.getBienXoa();
                            List<Item> lstCart = ca.getCart2();
                            Item i = lstCart.FirstOrDefault(t => t.maMon == maMon);
                            i.sl++;
                            i.tongTien = (double)((i.sl) * i.donGia);
                            Program.frmGM.loadListOrder2();
                        }
                        else
                        {
                            MessageBox.Show("Chua the thao tac");
                        }
                    }
                    catch (Exception ee)
                    {

                    }
                }
            }
            catch (Exception eee)
            { }
        }
        private void simpleButton8_Click(object sender, EventArgs e)
        {
            try
            {
                if (ca.getFlag() == 0)
                {
                    try
                    {
                        int maMon = ca.getBienXoa();
                        List<Item> lstCart = ca.getCart();
                        Item i = lstCart.FirstOrDefault(t => t.maMon == maMon);
                        i.sl--;
                        i.tongTien = (double)((i.sl) * i.donGia);
                        Program.frmGM.loadListOrder();
                    }
                    catch (Exception ee)
                    {

                    }
                }
                else
                {
                    try
                    {
                        if (!ca.getMau())
                        {
                            int maMon = ca.getBienXoa();
                            List<Item> lstCart = ca.getCart2();
                            Item i = lstCart.FirstOrDefault(t => t.maMon == maMon);
                            if (i.sl == 1)
                                return;
                            i.sl--;
                            i.tongTien = (double)((i.sl) * i.donGia);
                            Program.frmGM.loadListOrder2();
                        }
                        else
                        {
                            MessageBox.Show("Khong the thao tac");
                        }
                    }
                    catch (Exception ee)
                    {

                    }
                }
            }
            catch (Exception eee)
            { }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            try
            {
                if (ca.getFlag() == 0)
                {
                    if (ca.getCart().Count != 0)
                    {
                        DateTime dt = DateTime.Now;
                        int maB = ca.getMaBan();
                        int maNV = ca.getMaNV();
                        String PT = "Cash";
                        double tong = ca.tinhTong();
                        String TT = "Chua";
                        int x = hd.LuuHoaDon(dt, maB, maNV, PT, tong, TT);
                        List<Item> lstCart = ca.getCart();

                        foreach (Item i in lstCart)
                        {
                            int maHD = x;
                            int maMon = i.maMon;
                            int sl = i.sl;
                            double tong2 = i.tongTien;
                            ct.LuuChiTietHD(maHD, maMon, sl, tong2);
                        }

                        ca.clearCard2();
                        ca.clearCard();
                        this.Dispose();
                        if (Program.frmCNC.Visible == false)
                            Program.frmCNC = new Form_ChucNangChinh();
                        Program.frmCNC.Show();
                    }
                    else
                    {
                        MessageBox.Show("Moi Chon San Pham");
                    }
                }
                else
                {
                    ////xoa het ct cu
                    //tblHoaDon h = hd.getMaHDTheoBan(ca.getMaBan());
                    //List<tblChiTietHD> lstCT = ct.getCTByMaHD(h.MaHD).ToList<tblChiTietHD>();
                    //foreach (tblChiTietHD t in lstCT)
                    //{
                    //    ct.xoaCTHDByMa(t.MaHD,t.MaMon);
                    //}
                    ////them chi tiet moi
                    //DateTime dt = DateTime.Today;
                    //int maB = ca.getMaBan();
                    //int maNV = 2;
                    //String PT = "Cash";
                    //double tong = ca.tinhTong();
                    //String TT = "Chua";
                    //int x = hd.LuuHoaDon(dt, maB, maNV, PT, tong, TT);
                    //List<Item> lstCart = ca.getCart2();

                    //foreach (Item i in lstCart)
                    //{
                    //    int maHD = x;
                    //    int maMon = i.maMon;
                    //    int sl = i.sl;
                    //    double tong2 = i.tongTien;
                    //    ct.LuuChiTietHD(maHD, maMon, sl, tong2);
                    //}

                    //update lai cac mon an da co;
                    if (ca.getCart2().Count != 0)
                    {
                        tblHoaDon h = hd.getMaHDTheoBan(ca.getMaBan());

                        List<tblChiTietHD> lstCT = ct.getCTByMaHD(h.MaHD).ToList<tblChiTietHD>();

                        List<Item> lstCart = ca.getCart2();
                        double tong1 = ca.tinhTong2();
                        //update lai chi tiet
                        for (int i = 0; i < lstCT.Count; i++)
                        {
                            for (int j = 0; j < lstCart.Count; j++)
                            {
                                if (lstCT[i].MaMon == lstCart[j].maMon)
                                {
                                    ct.suaChiTietHD(lstCT[i].MaHD, lstCT[i].MaMon, (lstCart[j].sl + lstCT[i].SoLuong), (lstCart[j].tongTien + (double)lstCT[i].TongTien));
                                    lstCart.Remove(lstCart[j]);
                                    j--;
                                }
                            }
                        }
                        //them cac chi tiet moi
                        foreach (Item i in lstCart)
                        {
                            int maHD = h.MaHD;
                            int maMon = i.maMon;
                            int sl = i.sl;
                            double tong = i.tongTien;
                            ct.LuuChiTietHD(maHD, maMon, sl, tong);
                        }
                        //update lai tong tien cho hoa don
                        hd.suaHoaDon(h.MaHD, (tong1 + (double)h.TongTienTT));

                        ca.clearCard2();
                        ca.clearCard();
                        this.Dispose();
                        if (Program.frmCNC.Visible == false)
                            Program.frmCNC = new Form_ChucNangChinh();
                        Program.frmCNC.Show();
                    }
                    else
                    {
                        MessageBox.Show("Moi Chon San Pham");
                    }
                }
            }
            catch (Exception eee)
            { }
        }

        private void Form_GoiMon_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                panel_MenuDoUong.Controls.Clear();
                Layout_MenuDoUong menu = new Layout_MenuDoUong();
                menu.loadItemToLayout_Loai(1);
                menu.Dock = DockStyle.Fill;
                menu.Show();
                panel_MenuDoUong.Controls.Add(menu);
            }
            catch (Exception ee)
            { }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                panel_MenuDoUong.Controls.Clear();
                Layout_MenuDoUong menu = new Layout_MenuDoUong();
                menu.loadItemToLayout_Loai(2);
                menu.Dock = DockStyle.Fill;
                menu.Show();
                panel_MenuDoUong.Controls.Add(menu);
            }
            catch (Exception ee)
            { }
        }

        private void searchControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void searchControl1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void searchControl1_Enter(object sender, EventArgs e)
        {
            
        }

        private void searchControl1_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void searchControl1_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void searchControl1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                panel_MenuDoUong.Controls.Clear();
                Layout_MenuDoUong menu = new Layout_MenuDoUong();
                menu.loadItemToLayout_Ten(searchControl1.Text);
                menu.Dock = DockStyle.Fill;
                menu.Show();
                panel_MenuDoUong.Controls.Add(menu);
            }
            catch (Exception ee)
            {
                panel_MenuDoUong.Controls.Clear();
            }
        }

    }
}