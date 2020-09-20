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
    public partial class DoUongGioHang_Item_Temp : DevExpress.XtraEditors.XtraUserControl
    {
        ModuleConvert mc = new ModuleConvert();
        public DoUongGioHang_Item_Temp()
        {
            InitializeComponent();
        }
        bool mau;
        Cart ca = new Cart();
        public DoUongGioHang_Item_Temp(String tenDoUong, int sl, double giaBan, bool colorFlag,int maMon)
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
        private void DoUongGioHang_Item_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl_SoLuong_Click(object sender, EventArgs e)
        {
            //ca.setBienXoa(int.Parse(lbl_TenDoUong.Tag+""));
            //ca.setMau(mau);
        }
       
    }
}
