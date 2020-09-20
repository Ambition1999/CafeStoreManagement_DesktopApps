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
    public partial class Form_ChiTietHoaDon : DevExpress.XtraEditors.XtraForm
    {
        BLL_TblChiTietHD ct = new BLL_TblChiTietHD();
        BLL_TblHoaDon hd = new BLL_TblHoaDon();
        BLL_TblNhanVien nv = new BLL_TblNhanVien();
        BLL_TblBan ban = new BLL_TblBan();
        public static Form_ChiTietHoaDon Current;
        int maHD;
        tblHoaDon hoaDon;
        public Form_ChiTietHoaDon()
        {
            InitializeComponent();
            Current = this;
        }

        public Form_ChiTietHoaDon(int maHDInput)
        {
            InitializeComponent();
            Current = this;
            this.maHD = maHDInput;
            this.hoaDon = hd.getHDByMaHD(maHDInput);
        }

        private void Form_ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            loadGridView();
            loadDataToLabel();

        }

        public void loadGridView()
        {
            dtGridChiTietHD.DataSource = ct.getChiTietHDByMaHD(maHD);
        }

        public void loadDataToLabel()
        {
            ModuleConvert module = new ModuleConvert();
            lbl_MaHD.Text = "Số HĐ: " + hoaDon.MaHD;
            try
            {
                lbl_SoTien.Text = module.convertCurrency(Convert.ToDouble(hoaDon.TongTienTT)) + " VNĐ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trường tiền không hợp lệ");
            }
            lbl_TGRa.Text = "Thời gian ra: " + hoaDon.TGRa;
            lbl_TGVao.Text = "Thời gian vào: " + hoaDon.TGVao;

            if (nv.getTenNhanVienByMaNV(hoaDon.MaNV) == null || nv.getTenNhanVienByMaNV(hoaDon.MaNV) == String.Empty)
            {
                MessageBox.Show("Tên nhân viên không hợp lệ");
                lbl_ThuNgan.Text = "Thu ngân: " + " unknown";
            }
            else
                lbl_ThuNgan.Text = "Thu ngân: " + nv.getTenNhanVienByMaNV(hoaDon.MaNV);
            tblBan ban_cls = new tblBan();
            if (ban.getBanByID(hoaDon.MaBan) == null)
            {
                MessageBox.Show("Mã bàn không hợp lệ");
                lbl_ban.Text = "Bàn: " + "unknown";
                lbl_KhuVuc.Text = "Khu vực: " + "unknown";
            }
            else
            {
                ban_cls = ban.getBanByID(hoaDon.MaBan);
                lbl_ban.Text = ban_cls.TenBan;
                lbl_KhuVuc.Text = "Khu vực: " + ban_cls.KhuVuc;
            }
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            Form_BangKeHoaDon.Current.Show();
            this.Hide();
        }
    }
}