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
    public partial class FormOrder : DevExpress.XtraEditors.XtraUserControl
    {
        tblHoaDon tblHD = new tblHoaDon();
        BLL_TblBan ban = new BLL_TblBan();
        BLL_TblHoaDon hd = new BLL_TblHoaDon();

        public FormOrder()
        {
            InitializeComponent();
            loadItemFormOrder(tblHD);
        }

        public void loadItemFormOrder(tblHoaDon tblHD)
        {
            tblBan tblBan = new tblBan();

            List<tblHoaDon> listHD = hd.getDSHoaDonChuaThanhToan();

            //List<Grid_Item> lst = new List<Grid_Item>();
            foreach (tblHoaDon item in listHD)
            {
                tblBan = ban.getBanByID(item.MaBan);
                Grid_Item user;
                user = new Grid_Item(tblBan.KhuVuc, tblBan.TenBan, Convert.ToDouble(item.TongTienTT.ToString()), item.TGVao.ToString(), item.MaHD,item.MaBan);
                //lst.Add(user);
                flowLayoutPanel_TrangOrder.Controls.Add(user);
            }
        }

    }
}