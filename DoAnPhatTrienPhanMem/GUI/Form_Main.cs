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
    public partial class Form_Main : DevExpress.XtraEditors.XtraForm
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void tileControl1_Click(object sender, EventArgs e)
        {

        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            //XtraMessageBox.Show("Chuyển đến trang bán hàng");
            Form_ChucNangChinh form = new Form_ChucNangChinh();
            form.Show();
            this.Hide();
        }
    }
}