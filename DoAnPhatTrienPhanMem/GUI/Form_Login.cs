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
using BLL;

namespace GUI
{
    public partial class Form_Login : DevExpress.XtraEditors.XtraForm
    {
        BLL_TblTaiKhoan tk = new BLL_TblTaiKhoan();
        Cart ca = new Cart();

        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            String username = txt_TenDN.Text.Trim();
            String password = txt_MatKhau.Text.Trim();

            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không được để trống!");
                return;
            }
            else
            {
                int result = tk.taiKhoan_isExist(username, password);
                switch (result)
                {
                    case 0:
                        {
                            MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác \n Vui lòng thử lại");
                            break;
                        }
                    case 1:
                        {
                            
                            Form_ThongKe frm = new Form_ThongKe();
                            frm.Show();
                            this.Hide();
                            break;
                        }
                    case 2:
                        {
                            //Form_Main frm = new Form_Main();
                            ca.setMaNV(tk.taiKhoan_isExist2(username, password));
                            if ((Program.frmCNC == null || Program.frmCNC.IsDisposed))
                            {
                                Program.frmCNC = new Form_ChucNangChinh();
                            }
                            Program.frmCNC.Show();
                            this.Hide();
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Vui lòng thử lại");
                            break;
                        }
                }
            }
        }
    }
}