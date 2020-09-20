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
using Modul_XuLy;
using System.Globalization;
using System.IO;

namespace GUI
{
    public partial class Form_ThemDoUongMoi : DevExpress.XtraEditors.XtraForm
    {
        BLL_TblLoaiMon loai = new BLL_TblLoaiMon();
        BLL_TblThucDon td = new BLL_TblThucDon();
        BLL_TblNguyenLieu nl = new BLL_TblNguyenLieu();
        BLL_TblCongThuc ct = new BLL_TblCongThuc();
        List<NguyenLieu_Item> lst;
        tblThucDon doUong;
        public Form_ThemDoUongMoi()
        {
            InitializeComponent();
            loadCombobox();
        }

        public Form_ThemDoUongMoi(int maMon)
        {
            InitializeComponent();
            doUong = td.getDoUongByID(maMon);
            loadCombobox();
            loadFormChinhSua();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            US_QuanLy_ThucDon.current.loadGridSanPham();
            this.Hide();

        }

        //Load form chỉnh sửa đồ uống -- Trang thông tin chung
        public void loadFormChinhSua()
        {
            ModuleConvert module = new ModuleConvert();
            lbl_TieuDe.Text = "Chỉnh sửa món";
            txt_TenDoUong.Text = doUong.TenMon.Trim();
            txt_GiaBan.Text = doUong.DonGia;
            txt_TuyChonThem.Text = doUong.TuyChonThem;
            cbo_LoaiMon.SelectedValue = doUong.MaLoai;
            //cbo_DVT.SelectedText = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(doUong.DonViTinh.Trim());     
            cbo_DVT.SelectedItem = doUong.DonViTinh.Trim();
            checkEdit_PhoBien.Checked = Convert.ToBoolean(doUong.PhoBien);
            try
            {
                string filePath2 = "..\\..\\HinhAnh\\" + doUong.HinhAnh.Trim();
                pictureEdit_HinhAnhSP.Image = Image.FromFile(filePath2);
                pictureEdit_HinhAnhSP.Name = doUong.HinhAnh.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy hình ảnh");
                string filePath2 = "..\\..\\HinhAnh\\default_coffee_icon.jpg";
                pictureEdit_HinhAnhSP.Image = Image.FromFile(filePath2);
                pictureEdit_HinhAnhSP.Name = doUong.HinhAnh.Trim();
            }
        }

        public void loadCombobox()
        {
            loadCboLoaiDoUong();
            loadCboDonViTinh();
        }

        public void loadCboLoaiDoUong()
        {
            cbo_LoaiMon.ValueMember = "MaLoai";
            cbo_LoaiMon.DisplayMember = "TenLoai";
            cbo_LoaiMon.DataSource = loai.getDSLoaiMon();
        }

        public void loadCboDonViTinh()
        {
            List<String> lst = new List<String>();
            //String[] arr = new String[] { "Ly", "Tách", "Lon", "Chai" ,"Hộp", "Cốc", "Khác" };
            String[] arr = new String[] { "ly", "tách", "lon", "chai", "hộp", "cốc", "khác" };
            lst.AddRange(arr);
            cbo_DVT.DataSource = lst;
            cbo_DVT.SelectedIndex = 0;
        }

        public void formatFormWhileNew()
        {
            txt_TenDoUong.Focus();
        }

        private void Form_ThemDoUongMoi_Load(object sender, EventArgs e)
        {
            //loadCboLoaiDoUong();
            //loadCboDonViTinh();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            // C:\\Users\\USER\\Documents\\Ứng dụng thông minh\\Đồ án Phát triển phần mềm\\DoAnPhatTrienPhanMem\\GUI\\HinhAnh
            string filePath2 = "..\\..\\HinhAnh\\default_coffee_icon.jpg";
            pictureEdit_HinhAnhSP.Image = Image.FromFile(filePath2);
            string imageName = getImageName(filePath2);
            pictureEdit_HinhAnhSP.Name = imageName;
        }


        string urlImg;
        private void btn_ImportIMG_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Image Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "jpg",
                Filter = "JPEG Image (*.jpg)|*.jpg|All Files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                MessageBox.Show(openFileDialog1.FileName);
                urlImg = openFileDialog1.FileName;
                pictureEdit_HinhAnhSP.Image = Image.FromFile(openFileDialog1.FileName);
                string imageName = getImageName(urlImg);
                pictureEdit_HinhAnhSP.Name = imageName;
                //string filePath2 = "..\\..\\HinhAnh\\" + imageName;
                //File.Copy(urlImg, filePath2);
            }
        }

        public void saveImageToLocalFile()
        {
            if (urlImg != null)
            {
                string imageName = getImageName(urlImg);
                if (imageName == pictureEdit_HinhAnhSP.Name)
                {
                    try
                    {
                        string filePath2 = "..\\..\\HinhAnh\\" + imageName;
                        File.Copy(urlImg, filePath2);
                    }
                    catch (Exception ex)
                    {

                    }

                }
            }
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {
            lbl_TenDoUong.Text = "Tên đồ uống " + txt_TenDoUong.Text;
            loaddataGrid_NguyenLieu();
            loadCboNguyenLieu();
        }

        private void xtraTabPage2_Click(object sender, EventArgs e)
        {
            //lbl_TenDoUong.Text = "Tên đồ uống " + txt_TenDoUong.Text;          
            //loaddataGrid_NguyenLieu();
        }

        public void loaddataGrid_NguyenLieu()
        {
            if (doUong == null)
            {
                dtGrid_NguyenLieu.DataSource = ct.getCongThucByMaMon();
                lst = ct.getCongThucByMaMon();
            }
            else
            {
                dtGrid_NguyenLieu.DataSource = ct.getCongThucByMaMon(doUong.MaMon);
                lst = ct.getCongThucByMaMon(doUong.MaMon);
            }
        }

        public void loadCboNguyenLieu()
        {
            cbo_nguyenlieu.ValueMember = "MaNL";
            cbo_nguyenlieu.DisplayMember = "TenNL";
            cbo_nguyenlieu.DataSource = nl.getNguyenLieu();
        }

        private void btn_ThemCongThuc_Click(object sender, EventArgs e)
        {
            if (txt_HamLuong == null || txt_HamLuong.Text == "0")
            {
                MessageBox.Show("Vui lòng nhập hàm lượng nguyên liệu");
            }
            else
            {
                tblNguyenLieu nlieu = new tblNguyenLieu();
                try
                {
                    int maNL = Convert.ToInt32(cbo_nguyenlieu.SelectedValue.ToString());

                    nlieu = nl.getNguyenLieuByID(maNL);

                    double hamLuong = Convert.ToDouble(txt_HamLuong.Text.Trim());
                    int maNguyenLieu = nlieu.MaNL;
                    string tenNL = nlieu.TenNL;
                    String dvt = nlieu.DonViTinh;

                    if (kiemTraNguyenLieuTonTai(maNguyenLieu) == -1)
                    {
                        NguyenLieu_Item nlItem = new NguyenLieu_Item(maNguyenLieu, tenNL, dvt, hamLuong);
                        lst.Add(nlItem);
                    }
                    reloadGird_NguyenLieu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mã nguyên liệu không hợp lệ");
                }

            }
        }

        public int kiemTraNguyenLieuTonTai(int maNL)
        {
            var item = dtGrid_NguyenLieu.Rows.Cast<DataGridViewRow>().Where(t => Convert.ToInt32(t.Cells[0].Value) == maNL).FirstOrDefault();
            if (item != null)
            {
                DialogResult rs = MessageBox.Show("Nguyên liệu này đã tồn tại trong công thức\nCập nhật lại hàm lượng hay không?", "Nguyên liệu trùng", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (rs == DialogResult.Yes)
                {
                    NguyenLieu_Item itemTemp = (NguyenLieu_Item)lst.Where(t => t.MaNL == Convert.ToInt32(item.Cells[0].Value)).FirstOrDefault();
                    itemTemp.HamLuong = Convert.ToDouble(txt_HamLuong.Text);
                    return 1;
                }
                return -1;
            }
            return -1;
        }

        public void reloadGird_NguyenLieu()
        {
            dtGrid_NguyenLieu.DataSource = lst;
        }

        private void btn_XoaDong_Click(object sender, EventArgs e)
        {
            if (dtGrid_NguyenLieu.CurrentRow == null)
            {
                MessageBox.Show("Mã đồ uống và mã nguyên liệu không hợp lệ");
            }
            else
            {
                if (doUong == null)
                {
                    int ma_NL = Convert.ToInt32(dtGrid_NguyenLieu.CurrentRow.Cells[0].Value.ToString());
                    int indexOfItem = Convert.ToInt32(dtGrid_NguyenLieu.CurrentRow.Index);
                    var item = lst.Where(t => t.MaNL == ma_NL).FirstOrDefault();
                    if (item != null)
                    {
                        lst.Remove(item);
                        dtGrid_NguyenLieu.DataSource = lst;
                        if (dtGrid_NguyenLieu.Rows.Count > 0)
                            dtGrid_NguyenLieu.Rows[0].Selected = true;
                    }

                }
                else
                {
                    try
                    {
                        int ma_NL = Convert.ToInt32(dtGrid_NguyenLieu.CurrentRow.Cells[0].Value.ToString());
                        var item = lst.Where(t => t.MaNL == ma_NL).FirstOrDefault();
                        if (item != null)
                        {
                            lst.Remove(item);
                            dtGrid_NguyenLieu.DataSource = lst;
                            if (dtGrid_NguyenLieu.Rows.Count > 0)
                                dtGrid_NguyenLieu.Rows[0].Selected = true;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Mã đồ uống hoặc mã nguyên liệu không đúng định dạng");
                    }

                }

            }

        }

        public void removeItemInList(int maNL)
        {

        }

        private void btn_CatThem_Click(object sender, EventArgs e)
        {
            if (checkControlInPage_IsValidate())
            {
                if (doUong != null)
                {
                    //Cập nhật đồ uống
                    string tenMon = txt_TenDoUong.Text.Trim();
                    int loai = Convert.ToInt32(cbo_LoaiMon.SelectedValue.ToString());
                    string dvt = cbo_DVT.SelectedItem.ToString();
                    double dongia = Convert.ToDouble(txt_GiaBan.Text.Trim());
                    string tuyChon = txt_TuyChonThem.Text.Trim();
                    bool phoBien = checkEdit_PhoBien.Checked;
                    string hinhAnh;
                    if (pictureEdit_HinhAnhSP.Name != null)
                    {
                        hinhAnh = pictureEdit_HinhAnhSP.Name;
                    }
                    else
                    {
                        hinhAnh = "default_coffee_icon.jpg";
                    }
                    bool rs = td.updateDoUong(doUong.MaMon, tenMon, loai, dvt, dongia, hinhAnh, tuyChon, phoBien);
                    if (rs)
                    {
                        MessageBox.Show("Cập nhật đồ uống thành công");
                        saveImageToLocalFile();
                        insertDataOfCongThuc();
                    }

                    else
                        MessageBox.Show("Cập nhật đồ uống thất bại");

                }
                else
                {
                    //Thêm đồ uống mới
                    string tenMon = txt_TenDoUong.Text.Trim();
                    int loai = Convert.ToInt32(cbo_LoaiMon.SelectedValue.ToString());
                    string dvt = cbo_DVT.SelectedItem.ToString();
                    double dongia = Convert.ToDouble(txt_GiaBan.Text.Trim());
                    string tuyChon = txt_TuyChonThem.Text.Trim();
                    bool phoBien = checkEdit_PhoBien.Checked;
                    string hinhAnh;
                    if (urlImg != null)
                    {
                        hinhAnh = getImageName(urlImg);
                    }
                    else
                    {
                        hinhAnh = getImageName("7up.jpg");
                    }

                    bool rs = td.insertDoUongMoi(tenMon, loai, dvt, dongia, hinhAnh, tuyChon, phoBien);
                    if (rs)
                    {
                        MessageBox.Show("Thêm đồ uống thành công");
                        saveImageToLocalFile();
                        if (doUong == null)
                        {
                            doUong = td.getNewestDoUong();
                        }
                        insertDataOfCongThuc();
                    }


                    else
                        MessageBox.Show("Thêm đồ uống thất bại");
                }
            }
            else
            {

            }
        }

        public bool checkControlInPage_IsValidate()
        {
            if (txt_TenDoUong.Text.Trim() == string.Empty || txt_GiaBan.Text.Trim() == String.Empty)
            {
                return false;
            }
            return true;
        }

        public string getImageName(string strInput)
        {
            string fileName = Path.GetFileName(strInput);
            return fileName;
        }

        public void insertDataOfCongThuc()
        {
            if (lst != null && lst.Count > 0)
            {
                int errorRow = 0;
                foreach (var item in lst)
                {
                    if (ct.insertCongThuc(doUong.MaMon, item.MaNL, item.HamLuong) == false)
                    {
                        errorRow++;
                    }
                }
                if (errorRow > 0)
                    MessageBox.Show("Có " + errorRow + " bản ghi thất bại.");
            }
        }




    }
}