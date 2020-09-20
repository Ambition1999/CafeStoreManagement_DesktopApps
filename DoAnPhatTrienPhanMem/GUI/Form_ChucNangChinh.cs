using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using BLL;

namespace GUI
{
    public partial class Form_ChucNangChinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        List<TabPage> lstTab = new List<TabPage>();
        BLL_TblHoaDon hd = new BLL_TblHoaDon();
        public Form_ChucNangChinh()
        {
            InitializeComponent();


        }

        public void loadListTabPage()
        {

        }

        public void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel theme = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            theme.LookAndFeel.SkinName = "Metropolis";
        }

        private void Form_ChucNangChinhcs_Load(object sender, EventArgs e)
        {
            skin();
        }

        private void panelControl_SoDo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ribbon_ItemPress(object sender, ItemClickEventArgs e)
        {

        }

        private void ribbon_TabIndexChanged(object sender, EventArgs e)
        {

            FormOrder frmOrder = new FormOrder();
            foreach (Control ctrl in panelControl_Home.Controls)
            {
                ctrl.Dispose();
            }
            panelControl_Home.Controls.Add(frmOrder);

        }

        private void barButton_ThemOrder_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Form_GoiMon frm_GoiMon = new Form_GoiMon();
            //frm_GoiMon.Show();
            //Program.frmGM.Show();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {
            if (Ribbon.SelectedPage.Text.Equals(ribbonOrder.Text))
            {
                FormOrder frmOrder = new FormOrder();
                frmOrder.Dock = DockStyle.Fill;
                frmOrder.Show();
                foreach (Control ctrl in panelControl_Home.Controls)
                {
                    ctrl.Dispose();
                }
                panelControl_Home.Controls.Add(frmOrder);
                return;
            }

            if (Ribbon.SelectedPage.Text.Equals(ribbonSoDo.Text))
            {
                //if ((Program.frmSD == null || Program.frmSD.IsDisposed))
                //{
                //    Program.frmSD = new Form_SoDoBan();
                //}
                //Program.frmSD.Dock = DockStyle.Fill;
                //Program.frmSD.Show();

                //if ((Program.frmSD == null || Program.frmSD.IsDisposed))
                //{
                //    Program.frmSD = new Form_SoDoBan();
                //}
                //Program.frmSD.Dock = DockStyle.Fill;
                //Program.frmSD.Show();
                //foreach (Control ctrl in panelControl_Home.Controls)
                //{
                //    ctrl.Dispose();
                //}
                //panelControl_Home.Controls.Add(Program.frmSD);
                //return;

                Form_SoDoBan frmSoDoBan = new Form_SoDoBan();
                frmSoDoBan.Dock = DockStyle.Fill;
                frmSoDoBan.Show();
                foreach (Control ctrl in panelControl_Home.Controls)
                {
                    ctrl.Dispose();
                }
                panelControl_Home.Controls.Add(frmSoDoBan);
                return;
            }

        }

        public void load2()
        {
            panelControl_Home.Controls.Clear();
            //if ((Program.frmSD == null || Program.frmSD.IsDisposed))
            //{
            //    Program.frmSD = new Form_SoDoBan();
            //}
            //Program.frmSD.Dock = DockStyle.Fill;
            //Program.frmSD.Show();
            //foreach (Control ctrl in panelControl_Home.Controls)
            //{
            //    ctrl.Dispose();
            //}
            //panelControl_Home.Controls.Add(Program.frmSD);
            //return;

            Form_SoDoBan frmSoDoBan = new Form_SoDoBan();
            frmSoDoBan.Dock = DockStyle.Fill;
            frmSoDoBan.Show();
            foreach (Control ctrl in panelControl_Home.Controls)
            {
                ctrl.Dispose();
            }
            panelControl_Home.Controls.Add(frmSoDoBan);
            return;
        }

        private void barEditItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_SoDoBan frmSoDoBan = new Form_SoDoBan(0);
            frmSoDoBan.Dock = DockStyle.Fill;
            frmSoDoBan.Show();
            foreach (Control ctrl in panelControl_Home.Controls)
            {
                ctrl.Dispose();
            }
            panelControl_Home.Controls.Add(frmSoDoBan);
            return;
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_SoDoBan frmSoDoBan = new Form_SoDoBan(1);
            frmSoDoBan.Dock = DockStyle.Fill;
            frmSoDoBan.Show();
            foreach (Control ctrl in panelControl_Home.Controls)
            {
                ctrl.Dispose();
            }
            panelControl_Home.Controls.Add(frmSoDoBan);
            return;
        }

        private void barHeaderItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            //tang tret
            Form_SoDoBan frmSoDoBan = new Form_SoDoBan(2);
            frmSoDoBan.Dock = DockStyle.Fill;
            frmSoDoBan.Show();
            foreach (Control ctrl in panelControl_Home.Controls)
            {
                ctrl.Dispose();
            }
            panelControl_Home.Controls.Add(frmSoDoBan);
            return;
        }

        private void barHeaderItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            //toan bo
            Form_SoDoBan frmSoDoBan = new Form_SoDoBan();
            frmSoDoBan.Dock = DockStyle.Fill;
            frmSoDoBan.Show();
            foreach (Control ctrl in panelControl_Home.Controls)
            {
                ctrl.Dispose();
            }
            panelControl_Home.Controls.Add(frmSoDoBan);
            return;
        }

        private void barHeaderItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            //tang tret
            Form_SoDoBan frmSoDoBan = new Form_SoDoBan(3);
            frmSoDoBan.Dock = DockStyle.Fill;
            frmSoDoBan.Show();
            foreach (Control ctrl in panelControl_Home.Controls)
            {
                ctrl.Dispose();
            }
            panelControl_Home.Controls.Add(frmSoDoBan);
            return;
        }

        private void barEditItem2_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void barEditItem2_HiddenEditor(object sender, ItemClickEventArgs e)
        {

        }

        private void barEditItem2_HyperlinkClick(object sender, DevExpress.Utils.HyperlinkClickEventArgs e)
        {

        }

        private void barEditItem2_ItemPress(object sender, ItemClickEventArgs e)
        {


        }

        private void barEditItem2_ShowingEditor(object sender, ItemCancelEventArgs e)
        {


        }

        private void barEditItem2_ShownEditor(object sender, ItemClickEventArgs e)
        {

        }

        private void barEditItem2_ItemDoubleClick(object sender, ItemClickEventArgs e)
        {
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            PhanCum pc = new PhanCum();
            pc.Show();
        }

        Cart ca = new Cart();
        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            ca.clearCard();
            ca.clearCard2();
            this.Dispose();
            Form_Login lg = new Form_Login();
            lg.Show();
        }

    }
}