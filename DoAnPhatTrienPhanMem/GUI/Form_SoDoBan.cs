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
    public partial class Form_SoDoBan : DevExpress.XtraEditors.XtraUserControl
    {
        public Form_SoDoBan()
        {
            InitializeComponent();
            loadSoDoBan();
        }
        public Form_SoDoBan(int a)
        {
            InitializeComponent();
            if (a == 1)
                loadSoDoBan2();
            else if (a == 0)
                loadSoDoBan3();
            else if (a == 2)
                loadSoDoBan4();
            else if (a == 3)
                loadSoDoBan5();
        }
        public Form_SoDoBan(String a,int maBan)
        {
            InitializeComponent();
            loadSoDoBan6(maBan);
        }
        BLL_Ban dm = new BLL_Ban();
        public void loadSoDoBan()
        {
            //bool trangThai;
            //for (int i = 0; i < 20; i++)
            //{
            //    if (i % 4 == 0) trangThai = false;
            //    else trangThai = true;
            //    Ban_Item ban;
            //    ban = new Ban_Item("Tầng trệt", "Bàn số " + i, trangThai);
            //    ban.Dock = DockStyle.None;
            //    flowLayoutPanel_SoDoBan.Controls.Add(ban);
            //}
            try
            {
                List<tblBan> lstBan = new List<tblBan>();
                lstBan = dm.goiSoDoBan().ToList<tblBan>();
                try
                {
                    int a = lstBan.Count;
                    int ba = lstBan.Count(t => t.TrangThai.Equals("False"));
                    lbl_Trong.Text = "Trống" + ba + "/" + a + " bàn";
                }
                catch (Exception ee)
                {

                }
                foreach (tblBan b in lstBan)
                {
                    bool tt = false;
                    Ban_Item ban;
                    if (b.TrangThai.Equals("True"))
                        tt = true;
                    ban = new Ban_Item(b.KhuVuc, b.MaBan + "", tt, b.MaBan);
                    flowLayoutPanel_SoDoBan.Controls.Add(ban);
                }
            }
            catch (Exception eee)
            { }
        }
        public void loadSoDoBan2()
        {
            try
            {
                List<tblBan> lstBan = new List<tblBan>();
                lstBan = dm.goiSoDoBan().ToList<tblBan>();
                try
                {
                    int a = lstBan.Count;
                    int ba = lstBan.Count(t => t.TrangThai.Equals("False"));
                    lbl_Trong.Text = "Trống" + ba + "/" + a + " bàn";
                }
                catch (Exception ee)
                {

                }
                foreach (tblBan b in lstBan)
                {
                    bool tt = false;
                    Ban_Item ban;
                    if (b.TrangThai.Equals("True"))
                        tt = true;
                    ban = new Ban_Item(b.KhuVuc, b.MaBan + "", tt, b.MaBan);
                    if(b.TrangThai.Equals("True"))
                        flowLayoutPanel_SoDoBan.Controls.Add(ban);
                }
            }
            catch (Exception eee)
            { }
        }
        public void loadSoDoBan3()
        {
            try
            {
                List<tblBan> lstBan = new List<tblBan>();
                lstBan = dm.goiSoDoBan().ToList<tblBan>();
                try
                {
                    int a = lstBan.Count;
                    int ba = lstBan.Count(t => t.TrangThai.Equals("False"));
                    lbl_Trong.Text = "Trống" + ba + "/" + a + " bàn";
                }
                catch (Exception ee)
                {

                }
                foreach (tblBan b in lstBan)
                {
                    bool tt = false;
                    Ban_Item ban;
                    if (b.TrangThai.Equals("True"))
                        tt = true;
                    ban = new Ban_Item(b.KhuVuc, b.MaBan + "", tt, b.MaBan);
                    if (b.TrangThai.Equals("False"))
                        flowLayoutPanel_SoDoBan.Controls.Add(ban);
                }
            }
            catch (Exception eee)
            { }
        }
        public void loadSoDoBan4()
        {
            try
            {
                List<tblBan> lstBan = new List<tblBan>();
                lstBan = dm.goiSoDoBan().ToList<tblBan>();
                try
                {
                    int a = lstBan.Count;
                    int ba = lstBan.Count(t => t.TrangThai.Equals("False"));
                    lbl_Trong.Text = "Trống" + ba + "/" + a + " bàn";
                }
                catch (Exception ee)
                {

                }
                foreach (tblBan b in lstBan)
                {
                    bool tt = false;
                    Ban_Item ban;
                    if (b.TrangThai.Equals("True"))
                        tt = true;
                    ban = new Ban_Item(b.KhuVuc, b.MaBan + "", tt, b.MaBan);
                    if (b.KhuVuc.Equals("Tầng trệt"))
                        flowLayoutPanel_SoDoBan.Controls.Add(ban);
                }
            }
            catch (Exception eee)
            { }
        }
        public void loadSoDoBan5()
        {
            try
            {
                List<tblBan> lstBan = new List<tblBan>();
                lstBan = dm.goiSoDoBan().ToList<tblBan>();
                try
                {
                    int a = lstBan.Count;
                    int ba = lstBan.Count(t => t.TrangThai.Equals("False"));
                    lbl_Trong.Text = "Trống" + ba + "/" + a + " bàn";
                }
                catch (Exception ee)
                {

                }
                foreach (tblBan b in lstBan)
                {
                    bool tt = false;
                    Ban_Item ban;
                    if (b.TrangThai.Equals("True"))
                        tt = true;
                    ban = new Ban_Item(b.KhuVuc, b.MaBan + "", tt, b.MaBan);
                    if (b.KhuVuc.Equals("Tầng 1"))
                        flowLayoutPanel_SoDoBan.Controls.Add(ban);
                }
            }
            catch (Exception eee)
            { }
        }
        public void loadSoDoBan6(int aa)
        {
            try
            {
                List<tblBan> lstBan = new List<tblBan>();
                lstBan = dm.goiSoDoBan().ToList<tblBan>();
                try
                {
                    int a = lstBan.Count;
                    int ba = lstBan.Count(t => t.TrangThai.Equals("False"));
                    lbl_Trong.Text = "Trống" + ba + "/" + a + " bàn";
                }
                catch (Exception ee)
                {

                }
                foreach (tblBan b in lstBan)
                {
                    bool tt = false;
                    Ban_Item ban;
                    if (b.TrangThai.Equals("True"))
                        tt = true;
                    ban = new Ban_Item(b.KhuVuc, b.MaBan + "", tt, b.MaBan);
                    if (b.MaBan==aa)
                        flowLayoutPanel_SoDoBan.Controls.Add(ban);
                }
            }
            catch (Exception eee)
            { }
        }
    }
}
