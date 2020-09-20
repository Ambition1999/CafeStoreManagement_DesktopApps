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
    public partial class US_QuanLy_ThucDon : DevExpress.XtraEditors.XtraUserControl
    {
        public static US_QuanLy_ThucDon current;
        BLL_TblThucDon td = new BLL_TblThucDon();
        public US_QuanLy_ThucDon()
        {
            InitializeComponent();
            current = this;
            loadGridSanPham();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void loadGridSanPham()
        {
            dtGridThucDon.DataSource = td.getDSThucDon();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Form_ThemDoUongMoi frm = new Form_ThemDoUongMoi();
            frm.Show();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dtGridThucDon.CurrentRow.Cells[1].Value == null || dtGridThucDon.CurrentRow.Cells[1].Value.ToString() == String.Empty)
            {
                MessageBox.Show("Vui lòng chọn đồ uống cần chỉnh sửa");
            }
            else
            {
                try
                {
                    int maMon = Convert.ToInt32(dtGridThucDon.CurrentRow.Cells[1].Value.ToString());
                    Form_ThemDoUongMoi frm = new Form_ThemDoUongMoi(maMon);
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mã món không hợp lệ");
                }

            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dtGridThucDon.CurrentRow.Cells[1].Value == null || dtGridThucDon.CurrentRow.Cells[1].Value.ToString() == String.Empty)
            {
                MessageBox.Show("Vui lòng chọn đồ uống cần xóa");
            }
            else
            {
                try
                {
                    int maMon = Convert.ToInt32(dtGridThucDon.CurrentRow.Cells[1].Value.ToString());
                    int rs = td.deleteDoUong(maMon);
                    if (rs == 0)
                    {
                        MessageBox.Show("Tồn tại ràng buộc với bảng khác, không được xóa");
                    }
                    else
                    {
                        if (rs == 1)
                        {
                            MessageBox.Show("Xóa thành công");
                            loadGridSanPham();
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mã món không hợp lệ");
                }

            }
        }

        private void btn_DongBo_Click(object sender, EventArgs e)
        {
            loadGridSanPham();
        }
    }
}
