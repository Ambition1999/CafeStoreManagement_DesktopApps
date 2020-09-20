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

namespace GUI
{
    public partial class Form_ThongKe : DevExpress.XtraEditors.XtraForm
    {
        public Form_ThongKe()
        {
            InitializeComponent();
        }
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }

        private void employeesLabelControl_Click(object sender, EventArgs e)
        {

        }

        private void tileBar_Click(object sender, EventArgs e)
        {

        }

        private void eployeesTileBarItem_ItemClick(object sender, TileItemEventArgs e)
        {
            US_ThongKe_HoaDon us_tk = new US_ThongKe_HoaDon();
            us_tk.Dock = DockStyle.Fill;
            employeesLabelControl.Controls.Add(us_tk);
        }

        private void Form_ThongKe_Load(object sender, EventArgs e)
        {
            //loadTrangThongKe_Ngay();
            loadTrangThongKe();
        }

        public void loadTrangThongKe()
        {
            US_ThongKe_HoaDon us_tk = new US_ThongKe_HoaDon();
            us_tk.Dock = DockStyle.Fill;
            //customersLabelControl.Controls.Add(us_tk);
            employeesLabelControl.Controls.Add(us_tk);
            //navigationPage2.Controls.Add(us_tk);
        }

        public void loadTrangThongKe_Ngay()
        {
            US_ThongKe_Ngay us = new US_ThongKe_Ngay();
            us.Dock = DockStyle.Fill;
            customersLabelControl.Controls.Add(us);
            
        }

        private void tileBarItem_DMDoUong_ItemClick(object sender, TileItemEventArgs e)
        {
            //tileBarItem_DMDoUong
            loadTrangDanhMucDoUong();
        }

        public void loadTrangDanhMucDoUong()
        {
            US_QuanLy_ThucDon us_td = new US_QuanLy_ThucDon();
            us_td.Dock = DockStyle.Fill;
            navigationPage1.Controls.Add(us_td);
        }

        private void tileBarItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            loadTrangThongKe_Ngay();
        }

        private void tileBarItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            Form_Login frm = new Form_Login();
            frm.Show();
            this.Dispose();
        }
    }
}