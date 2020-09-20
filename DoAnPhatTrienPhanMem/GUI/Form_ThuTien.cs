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
    public partial class Form_ThuTien : DevExpress.XtraEditors.XtraForm
    {
        ModuleConvert mc = new ModuleConvert();
        BLL_ChiTietHD ct = new BLL_ChiTietHD();
        BLL_HoaDon hd = new BLL_HoaDon();
        Cart ca = new Cart();
        public Form_ThuTien()
        {
            InitializeComponent();
        }

        private void btn_HuyBo_Click(object sender, EventArgs e)
        {
            ca.clearCard2();
            ca.clearCard();
            this.Dispose();
            if (Program.frmCNC.Visible == false)
                Program.frmCNC = new Form_ChucNangChinh();
            Program.frmCNC.Show();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            ca.clearCard2();
            ca.clearCard();
            this.Dispose();
            if (Program.frmCNC.Visible == false)
                Program.frmCNC = new Form_ChucNangChinh();
            Program.frmCNC.Show();
        }
        private void btn_500_Click(object sender, EventArgs e)
        {
            lbl_TienNhap.Text = (int.Parse(txt_TienKhachDua.Text) + 500000) + "";
            txt_TienKhachDua.Text = (int.Parse(txt_TienKhachDua.Text) + 500000) + "";
            txt_TienTraLai.Text = (int.Parse(txt_TienKhachDua.Text) - double.Parse(lbl_TongTien.Text)) + "";

            //lbl_TienNhap.Text = (mc.convertCurrency(int.Parse(txt_TienKhachDua.Text) + 500000)) + "";
            //txt_TienKhachDua.Text = (mc.convertCurrency(int.Parse(txt_TienKhachDua.Text) + 500000)) + "";
            //txt_TienTraLai.Text = (mc.convertCurrency(int.Parse(txt_TienKhachDua.Text) - double.Parse(lbl_TongTien.Text))) + "";
        }

        private void btn_200_Click(object sender, EventArgs e)
        {
            lbl_TienNhap.Text = (int.Parse(txt_TienKhachDua.Text) + 200000) + "";
            txt_TienKhachDua.Text = (int.Parse(txt_TienKhachDua.Text) + 200000) + "";
            txt_TienTraLai.Text = (int.Parse(txt_TienKhachDua.Text) - double.Parse(lbl_TongTien.Text)) + "";

            //lbl_TienNhap.Text = (mc.convertCurrency(int.Parse(txt_TienKhachDua.Text) + 200000)) + "";
            //txt_TienKhachDua.Text = (mc.convertCurrency(int.Parse(txt_TienKhachDua.Text) + 200000)) + "";
            //txt_TienTraLai.Text = (mc.convertCurrency(int.Parse(txt_TienKhachDua.Text) - double.Parse(lbl_TongTien.Text))) + "";

        }

        private void btn_100_Click(object sender, EventArgs e)
        {
            lbl_TienNhap.Text = (int.Parse(txt_TienKhachDua.Text) + 100000) + "";
            txt_TienKhachDua.Text = (int.Parse(txt_TienKhachDua.Text) + 100000) + "";
            txt_TienTraLai.Text = (int.Parse(txt_TienKhachDua.Text) - double.Parse(lbl_TongTien.Text)) + "";

            //lbl_TienNhap.Text = (mc.convertCurrency(int.Parse(txt_TienKhachDua.Text) + 100000)) + "";
            //txt_TienKhachDua.Text = (mc.convertCurrency(int.Parse(txt_TienKhachDua.Text) + 100000)) + "";
            //txt_TienTraLai.Text = (mc.convertCurrency(int.Parse(txt_TienKhachDua.Text) - double.Parse(lbl_TongTien.Text))) + "";

        }

        private void btn_50_Click(object sender, EventArgs e)
        {
            lbl_TienNhap.Text = (int.Parse(txt_TienKhachDua.Text) + 50000) + "";
            txt_TienKhachDua.Text = (int.Parse(txt_TienKhachDua.Text) + 50000) + "";
            txt_TienTraLai.Text = (int.Parse(txt_TienKhachDua.Text) - double.Parse(lbl_TongTien.Text)) + "";

            //lbl_TienNhap.Text = (mc.convertCurrency(int.Parse(txt_TienKhachDua.Text) + 50000)) + "";
            //txt_TienKhachDua.Text = (mc.convertCurrency(int.Parse(txt_TienKhachDua.Text) + 50000)) + "";
            //txt_TienTraLai.Text = (mc.convertCurrency(int.Parse(txt_TienKhachDua.Text) - double.Parse(lbl_TongTien.Text))) + "";

        }

        private void btn_20_Click(object sender, EventArgs e)
        {
            lbl_TienNhap.Text = (int.Parse(txt_TienKhachDua.Text) + 20000) + "";
            txt_TienKhachDua.Text = (int.Parse(txt_TienKhachDua.Text) + 20000) + "";
            txt_TienTraLai.Text = (int.Parse(txt_TienKhachDua.Text) - double.Parse(lbl_TongTien.Text)) + "";

            //lbl_TienNhap.Text = (mc.convertCurrency(int.Parse(txt_TienKhachDua.Text) + 20000)) + "";
            //txt_TienKhachDua.Text = (mc.convertCurrency(int.Parse(txt_TienKhachDua.Text) + 20000)) + "";
            //txt_TienTraLai.Text = (mc.convertCurrency(int.Parse(txt_TienKhachDua.Text) - double.Parse(lbl_TongTien.Text))) + "";

        }

        private void btn_10_Click(object sender, EventArgs e)
        {
            lbl_TienNhap.Text = (int.Parse(txt_TienKhachDua.Text) + 10000) + "";
            txt_TienKhachDua.Text = (int.Parse(txt_TienKhachDua.Text) + 10000) + "";
            txt_TienTraLai.Text = (int.Parse(txt_TienKhachDua.Text) - double.Parse(lbl_TongTien.Text)) + "";

            //lbl_TienNhap.Text = (mc.convertCurrency(int.Parse(txt_TienKhachDua.Text) + 10000)) + "";
            //txt_TienKhachDua.Text = (mc.convertCurrency(int.Parse(txt_TienKhachDua.Text) + 10000)) + "";
            //txt_TienTraLai.Text = (mc.convertCurrency(int.Parse(txt_TienKhachDua.Text) - double.Parse(lbl_TongTien.Text))) + "";

        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            lbl_TienNhap.Text = (int.Parse(txt_TienKhachDua.Text) + 5000) + "";
            txt_TienKhachDua.Text = (int.Parse(txt_TienKhachDua.Text) + 5000) + "";
            txt_TienTraLai.Text = (int.Parse(txt_TienKhachDua.Text) - double.Parse(lbl_TongTien.Text)) + "";

            //lbl_TienNhap.Text = (mc.convertCurrency(int.Parse(txt_TienKhachDua.Text) + 5000)) + "";
            //txt_TienKhachDua.Text = (mc.convertCurrency(int.Parse(txt_TienKhachDua.Text) + 5000)) + "";
            //txt_TienTraLai.Text = (mc.convertCurrency(int.Parse(txt_TienKhachDua.Text) - double.Parse(lbl_TongTien.Text))) + "";

        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            lbl_TienNhap.Text = (int.Parse(txt_TienKhachDua.Text) + 2000) + "";
            txt_TienKhachDua.Text = (int.Parse(txt_TienKhachDua.Text) + 2000) + "";
            txt_TienTraLai.Text = (int.Parse(txt_TienKhachDua.Text) - double.Parse(lbl_TongTien.Text)) + "";

            //lbl_TienNhap.Text = (mc.convertCurrency(int.Parse(txt_TienKhachDua.Text) + 2000)) + "";
            //txt_TienKhachDua.Text = (mc.convertCurrency(int.Parse(txt_TienKhachDua.Text) + 2000)) + "";
            //txt_TienTraLai.Text = (mc.convertCurrency(int.Parse(txt_TienKhachDua.Text) - double.Parse(lbl_TongTien.Text))) + "";

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            lbl_TienNhap.Text = (int.Parse(txt_TienKhachDua.Text) + 1000) + "";
            txt_TienKhachDua.Text = (int.Parse(txt_TienKhachDua.Text) + 1000) + "";
            txt_TienTraLai.Text = (int.Parse(txt_TienKhachDua.Text) - double.Parse(lbl_TongTien.Text)) + "";

            //lbl_TienNhap.Text = (mc.convertCurrency(int.Parse(txt_TienKhachDua.Text) + 1000)) + "";
            //txt_TienKhachDua.Text = (mc.convertCurrency(int.Parse(txt_TienKhachDua.Text) + 1000)) + "";
            //txt_TienTraLai.Text = (mc.convertCurrency(int.Parse(txt_TienKhachDua.Text) - double.Parse(lbl_TongTien.Text))) + "";

        }

        private void Form_ThuTien_Load(object sender, EventArgs e)
        {
            try
            {
                if (ca.getCart().Count > 0)
                {
                    double sum = ca.tinhTong();
                    lbl_TongTien.Text = sum + "";
                    //lbl_TongTien.Text = mc.convertCurrency(sum);
                }
                else if (ca.getCart2().Count == 0)
                {
                    tblHoaDon h = hd.getMaHDTheoBan(ca.getMaBan());
                    List<tblChiTietHD> lstCT = (List<tblChiTietHD>)ct.getCTByMaHD(h.MaHD);
                    lbl_TongTien.Text = lstCT.Sum(t => t.TongTien) + "";
                    //lbl_TongTien.Text = mc.convertCurrency((double)lstCT.Sum(t => t.TongTien));
                }
                else if (ca.getCart2().Count > 0)
                {
                    tblHoaDon h = hd.getMaHDTheoBan(ca.getMaBan());
                    List<tblChiTietHD> lstCT = (List<tblChiTietHD>)ct.getCTByMaHD(h.MaHD);
                    double sum = ca.tinhTong2();
                    lbl_TongTien.Text = ((double)lstCT.Sum(t => t.TongTien) + sum) + "";
                    //lbl_TongTien.Text = mc.convertCurrency((double)lstCT.Sum(t => t.TongTien) + sum);
                }
            }
            catch (Exception ee)
            { }
        }

        private void btn_In_Dong_Click(object sender, EventArgs e)
        {
            try
            {
                double d = double.Parse(txt_TienTraLai.Text);
                if (d < 0)
                {
                    MessageBox.Show("Mời nhập tiền");
                    return;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Mời nhập tiền");
                return;
            }
            try
            {
                //th1: khach mua mang di
                if (ca.getFlag() == 0)
                {
                    DateTime dt = DateTime.Now;
                    int maB = ca.getMaBan();
                    int maNV = ca.getMaNV();
                    String PT = "Cash";
                    double tong = ca.tinhTong();
                    String TT = "Roi";
                    int x = hd.LuuHoaDon2(dt, maB, maNV, PT, tong, TT);
                    List<Item> lstCart = ca.getCart();

                    foreach (Item i in lstCart)
                    {
                        int maHD = x;
                        int maMon = i.maMon;
                        int sl = i.sl;
                        double tong2 = i.tongTien;
                        ct.LuuChiTietHD(maHD, maMon, sl, tong2);
                    }
                    //thong bao xong
                    ca.clearCard2();
                    ca.clearCard();
                    this.Dispose();
                    if (Program.frmCNC.Visible == false)
                        Program.frmCNC = new Form_ChucNangChinh();
                    Program.frmCNC.Show();
                    MessageBox.Show("Thanh Toán Thành Công");
                    //goi hd ra
                    tblHoaDon hoaDon = hd.getMaHDTheoMaHD(x);
                    //xuat file excel
                    ExcelExport ex = new ExcelExport();
                    List<tblChiTietHD> lstCTExcel = ct.getCTByMaHD(x).ToList();
                    string path = string.Empty;
                    DateTime? dtVao = hoaDon.TGVao;
                    DateTime? dtRa = hoaDon.TGRa;
                    double tien1 = 0;
                    double tien2 = 0;
                    try
                    {
                        tien1 = double.Parse(txt_TienKhachDua.Text);
                        tien2 = double.Parse(txt_TienTraLai.Text);
                    }
                    catch (Exception ee)
                    {
                        tien1 = 0;
                        tien2 = 0;
                    }
                    ex.ExportKhoa(lstCTExcel, ref path, false, dtVao.Value, dtRa.Value, (double)hoaDon.TongTienTT, lstCTExcel.Count, tien1, tien2, x, hoaDon.MaBan, hoaDon.MaNV);
                    if (!string.IsNullOrEmpty(path) && MessageBox.Show("Bạn muốn mở file", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(path);
                    }
                }
                if (ca.getFlag() == 1)
                {
                    //khach tinh tien sau khi ngoi tai quan
                    int maHDExcel = 0;
                    if (ca.getCart2().Count == 0)
                    {
                        tblHoaDon h = hd.getMaHDTheoBan(ca.getMaBan());
                        maHDExcel = h.MaHD;
                        //DateTime dt = DateTime.Today;
                        DateTime dt = DateTime.Now;
                        hd.suaHoaDon(h.MaHD, dt, "Roi");

                        ca.clearCard2();
                        ca.clearCard();
                        this.Dispose();
                        if (Program.frmCNC.Visible == false)
                            Program.frmCNC = new Form_ChucNangChinh();
                        Program.frmCNC.Show();
                    }
                    //khach ngoi tai quan nhung order them roi tinh tien luon
                    else if (ca.getCart2().Count > 0)
                    {
                        tblHoaDon h = hd.getMaHDTheoBan(ca.getMaBan());
                        maHDExcel = h.MaHD;
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
                        //update lai trang thai
                        DateTime dt = DateTime.Now;
                        hd.suaHoaDon(h.MaHD, dt, "Roi");
                        //thong bao xong
                        ca.clearCard2();
                        ca.clearCard();
                        this.Dispose();
                        if (Program.frmCNC.Visible == false)
                            Program.frmCNC = new Form_ChucNangChinh();
                        Program.frmCNC.Show();
                    }
                    MessageBox.Show("Thanh Toán Thành Công");
                    //goi hoa don ra
                    tblHoaDon hoaDon = hd.getMaHDTheoMaHD(maHDExcel);
                    //xuat file excel
                    ExcelExport ex = new ExcelExport();
                    List<tblChiTietHD> lstCTExcel = ct.getCTByMaHD(maHDExcel).ToList();
                    string path = string.Empty;
                    DateTime? dtVao = hoaDon.TGVao;
                    DateTime? dtRa = hoaDon.TGRa;
                    double tien1 = 0;
                    double tien2 = 0;
                    try
                    {
                        tien1 = double.Parse(txt_TienKhachDua.Text);
                        tien2 = double.Parse(txt_TienTraLai.Text);
                    }
                    catch (Exception ee)
                    {
                        tien1 = 0;
                        tien2 = 0;
                    }
                    ex.ExportKhoa(lstCTExcel, ref path, false, dtVao.Value, dtRa.Value, (double)hoaDon.TongTienTT, lstCTExcel.Count, tien1, tien2, maHDExcel, hoaDon.MaBan, hoaDon.MaNV);
                    if (!string.IsNullOrEmpty(path) && MessageBox.Show("Bạn muốn mở file", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(path);
                    }
                }
            }
            catch (Exception ee)
            { }
        }

        private void btn_Khac_Click(object sender, EventArgs e)
        {
            lbl_TienNhap.Text = "0";
            txt_TienKhachDua.Text ="0";
            txt_TienTraLai.Text = "0";
        }

        private void check_TienTip_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                txt_TienThua.Text = txt_TienTraLai.Text;
            }
            catch (Exception ee)
            {
                txt_TienThua.Text = "";
            }
        }
    }
}