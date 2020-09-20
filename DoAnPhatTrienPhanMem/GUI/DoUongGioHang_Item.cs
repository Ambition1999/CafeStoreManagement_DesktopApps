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
using Modul_XuLy;
namespace GUI
{
    public partial class DoUongGioHang_Item : DevExpress.XtraEditors.XtraUserControl
    {
        ModuleConvert mc = new ModuleConvert();
        public DoUongGioHang_Item()
        {
            InitializeComponent();
        }
        bool mau;
        Cart ca = new Cart();
        public DoUongGioHang_Item(String tenDoUong, int sl, double giaBan, bool colorFlag,int maMon)
        {
            try
            {
                InitializeComponent();
                lbl_TenDoUong.Text = tenDoUong;
                lbl_TenDoUong.Tag = maMon;
                mau = colorFlag;
                lbl_SoLuong.Text = sl.ToString();
                //lbl_ThanhTien.Text = (sl*giaBan).ToString();
                lbl_ThanhTien.Text = mc.convertCurrency((sl * giaBan)) + "";
                if (colorFlag)
                    tableLayoutPanel1.BackColor = Color.FromArgb(100, 244, 244, 244);
            }
            catch (Exception ee)
            { }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (ca.getFlag() == 0)
                {
                    List<Item> lstCart = ca.getCart();
                    Item i = lstCart.FirstOrDefault(n => n.maMon == int.Parse(lbl_TenDoUong.Tag + ""));
                    lstCart.Remove(i);
                    Program.frmGM.loadListOrder();
                }
                else
                {
                    if (mau != true)
                    {
                        List<Item> lstCart = ca.getCart2();
                        Item i = lstCart.FirstOrDefault(n => n.maMon == int.Parse(lbl_TenDoUong.Tag + ""));
                        lstCart.Remove(i);
                        Program.frmGM.loadListOrder2();
                    }
                    else
                    {
                        MessageBox.Show("Khong the xoa mon an da order");
                    }
                }
            }
            catch (Exception ee)
            { }
        }

        private void DoUongGioHang_Item_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl_SoLuong_Click(object sender, EventArgs e)
        {
            ca.setBienXoa(int.Parse(lbl_TenDoUong.Tag+""));
            ca.setMau(mau);
        }
       
    }
}
