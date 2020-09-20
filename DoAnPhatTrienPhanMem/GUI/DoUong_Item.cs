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
    public partial class DoUong_Item : DevExpress.XtraEditors.XtraUserControl
    {
        Cart ca = new Cart();
        BLL_ThucDon td = new BLL_ThucDon();
        public DoUong_Item()
        {
            InitializeComponent();
            edit_lblGiaBan();
        }

        public DoUong_Item(String tenMon, String giaBan, String imgURL, int ma)
        {
            try
            {
                InitializeComponent();
                edit_lblGiaBan();
                lblTenMon.Text = tenMon;
                lblGiaBan.Text = giaBan;
                lblTenMon.Tag = ma;
                try
                {
                    Image img = Image.FromFile("../HinhAnh/" + imgURL);
                    pictureBox_DoUong.Image = img;
                }
                catch (Exception e)
                {
                    Image img = Image.FromFile("../HinhAnh/" + "SuaTuoi.jpg");
                    pictureBox_DoUong.Image = img;
                }
            }
            catch (Exception ee)
            { }
        }

        public void edit_lblGiaBan()
        {
            lblGiaBan.ForeColor = Color.White;
            lblGiaBan.BackColor = Color.FromArgb(50, 77, 166, 255);
            lblGiaBan.BringToFront();

        }

        private void DoUong_Item_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_DoUong_Click(object sender, EventArgs e)
        {
            try
            {
                if (ca.getFlag() == 0)
                {
                    tblThucDon t = td.getThucDonByMa(int.Parse(lblTenMon.Tag + ""));
                    List<Item> lst = ca.getCart();
                    Item i = lst.FirstOrDefault(n => n.maMon == t.MaMon);

                    if (i == null)
                    {
                        if (td.kiemTraHang(int.Parse(lblTenMon.Tag + ""), 1))
                        {
                            i = new Item(t.MaMon, double.Parse(t.DonGia.Trim()), 1, t.TenMon);
                            ca.addCart(i);
                        }
                        else
                            MessageBox.Show("Không đủ sản phẩm");
                    }
                    else
                    {
                        if (td.kiemTraHang(int.Parse(lblTenMon.Tag + ""), (i.sl + 1)))
                        {
                            i.sl++;
                            i.tongTien = (double)((i.sl) * double.Parse(t.DonGia));
                        }
                        else
                            MessageBox.Show("Không đủ sản phẩm");
                    }
                    Program.frmGM.loadListOrder();

                }
                else
                {
                    tblThucDon t = td.getThucDonByMa(int.Parse(lblTenMon.Tag + ""));
                    List<Item> lst = ca.getCart2();
                    Item i = lst.FirstOrDefault(n => n.maMon == t.MaMon);

                    if (i == null)
                    {
                        if (td.kiemTraHang(int.Parse(lblTenMon.Tag + ""), 1))
                        {
                            i = new Item(t.MaMon, double.Parse(t.DonGia.Trim()), 1, t.TenMon);
                            ca.addCart2(i);
                        }
                        else
                            MessageBox.Show("Không đủ sản phẩm");
                    }
                    else
                    {
                        if (td.kiemTraHang(int.Parse(lblTenMon.Tag + ""), (i.sl + 1)))
                        {
                            i.sl++;
                            i.tongTien = (double)((i.sl) * double.Parse(t.DonGia));
                        }
                        else
                            MessageBox.Show("Không đủ sản phẩm");
                    }
                    Program.frmGM.loadListOrder2();

                }
            }
            catch (Exception ee)
            { }
        }
    }
}
