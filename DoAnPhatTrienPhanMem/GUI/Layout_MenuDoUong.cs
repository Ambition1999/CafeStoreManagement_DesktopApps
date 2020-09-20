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
    public partial class Layout_MenuDoUong : DevExpress.XtraEditors.XtraUserControl
    {
        public Layout_MenuDoUong()
        {
            InitializeComponent();
            
        }
        BLL_ThucDon td = new BLL_ThucDon();
        public void loadItemToLayout()
        {
            try
            {
                List<tblThucDon> lstTD = new List<tblThucDon>();
                lstTD = td.getThucDon().ToList<tblThucDon>();
                for (int i = 0; i < lstTD.Count; i++)
                {
                    DoUong_Item doUong;
                    double gia = (double)(double.Parse(lstTD[i].DonGia) / 1000);
                    doUong = new DoUong_Item(lstTD[i].TenMon, gia + "K", lstTD[i].HinhAnh, lstTD[i].MaMon);
                    flowLayout_MenuDoUong.Controls.Add(doUong);
                }
            }
            catch (Exception ee)
            { }
        }
        public void loadItemToLayout_PhoBien()
        {
            try
            {
                List<tblThucDon> lstTD = new List<tblThucDon>();
                lstTD = td.getThucDonPhoBien().ToList<tblThucDon>();
                for (int i = 0; i < lstTD.Count; i++)
                {
                    DoUong_Item doUong;
                    double gia = (double)(double.Parse(lstTD[i].DonGia) / 1000);
                    doUong = new DoUong_Item(lstTD[i].TenMon, gia + "K", lstTD[i].HinhAnh, lstTD[i].MaMon);
                    flowLayout_MenuDoUong.Controls.Add(doUong);
                }
            }
            catch (Exception ee)
            { }
        }
        public void loadItemToLayout_Loai(int maLoai)
        {
            try
            {
                List<tblThucDon> lstTD = new List<tblThucDon>();
                lstTD = td.getThucDonTheoDanhMuc(maLoai).ToList<tblThucDon>();
                for (int i = 0; i < lstTD.Count; i++)
                {
                    DoUong_Item doUong;
                    double gia = (double)(double.Parse(lstTD[i].DonGia) / 1000);
                    doUong = new DoUong_Item(lstTD[i].TenMon, gia + "K", lstTD[i].HinhAnh, lstTD[i].MaMon);
                    flowLayout_MenuDoUong.Controls.Add(doUong);
                }
            }
            catch (Exception ee)
            { }
        }
        public void loadItemToLayout_Ten(String ten)
        {
            try
            {
                List<tblThucDon> lstTD = new List<tblThucDon>();
                lstTD = td.getThucDonTheoTen(ten).ToList<tblThucDon>();
                for (int i = 0; i < lstTD.Count; i++)
                {
                    DoUong_Item doUong;
                    double gia = (double)(double.Parse(lstTD[i].DonGia) / 1000);
                    doUong = new DoUong_Item(lstTD[i].TenMon, gia + "K", lstTD[i].HinhAnh, lstTD[i].MaMon);
                    flowLayout_MenuDoUong.Controls.Add(doUong);
                }
            }
            catch (Exception ee)
            { }
        }
    }
}
