using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace GUI
{
    public partial class PhanCum : Form
    {
        public PhanCum()
        {
            InitializeComponent();
            kmean k = new kmean();

            List<kmean.conn> lst = k.xuLy(3);
            List<kmean.conn> ls1 = new List<kmean.conn>();
            List<kmean.conn> ls2 = new List<kmean.conn>();
            List<kmean.conn> ls3 = new List<kmean.conn>();
            foreach (kmean.conn m in lst)
            {
                if (m.Cum == 1)
                    ls1.Add(m);
                else if (m.Cum == 2)
                    ls2.Add(m);
                else
                    ls3.Add(m);
            }
            dataGridView1.DataSource = ls1;
            dataGridView2.DataSource = ls2;
            dataGridView3.DataSource = ls3;


            //dataGridView1.DataSource = k.xuLy1();
            //dataGridView2.DataSource = k.xuLy3();
            //dataGridView3.DataSource = k.xuLy2();
            
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //int cum = int.Parse(textEdit1.Text);

            
            //dataGridView1.DataSource = k.BeforeProcess();
        }
    }
}
