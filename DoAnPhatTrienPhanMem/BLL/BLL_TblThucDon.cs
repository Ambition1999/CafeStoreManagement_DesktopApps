using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul_XuLy;

namespace BLL
{
    public class BLL_TblThucDon
    {
        DB_qlQuanCafeDataContext db = new DB_qlQuanCafeDataContext();
        public BLL_TblThucDon(){}

        public tblThucDon getDoUongByID(int maMon)
        {
            return db.tblThucDons.Where(t => t.MaMon == maMon).FirstOrDefault();
        }

        public dynamic getDSThucDon()
        {
            ModuleConvert module = new ModuleConvert();
            return from td in db.tblThucDons
                   join loai in db.tblLoaiMons
                   on td.MaLoai equals loai.MaLoai
                   select new
                   {
                       Loại_món = loai.TenLoai,
                       Mã_món = td.MaMon,
                       Tên_món = td.TenMon,
                       Đơn_vị_tính = td.DonViTinh,
                       Giá_bán = module.convertCurrency(Convert.ToDouble(td.DonGia)),                
                       Phổ_biến = td.PhoBien
                   };
        }

        public bool insertDoUongMoi(string tenMon, int maLoai, string dvt, double dongia, string hinhanh, string tuychon, bool phoBien)
        {
            try
            {                
                tblThucDon td = new tblThucDon();
                td.MaLoai = maLoai;
                td.TenMon = tenMon;
                td.DonViTinh = dvt;
                td.DonGia = dongia.ToString();
                td.HinhAnh = hinhanh;
                td.PhoBien = phoBien;
                td.TuyChonThem = tuychon;

                db.tblThucDons.InsertOnSubmit(td);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
           
            
        }

        public bool updateDoUong(int maMon,string tenMon, int maLoai, string dvt, double dongia, string hinhanh, string tuychon, bool phoBien)
        {
            try
            {
                var td = db.tblThucDons.Where(t => t.MaMon == maMon).FirstOrDefault();
                if (td != null)
                {
                    td.MaLoai = maLoai;
                    td.TenMon = tenMon;
                    td.DonViTinh = dvt;
                    td.DonGia = dongia.ToString();
                    td.HinhAnh = hinhanh;
                    td.PhoBien = phoBien;
                    td.TuyChonThem = tuychon;
                    db.SubmitChanges();
                    return true;
                }
                return false;
                
            }
            catch (Exception ex)
            {
                return false;
            }


        }

        public int deleteDoUong(int maMon)
        {
            try
            {
                var td = db.tblThucDons.Where(t => t.MaMon == maMon).FirstOrDefault();
                if (td != null)
                {
                    if (doUong_isExitstInCTHoaDon(td.MaMon))
                        return 0; //Có ràng buộc khóa ngoại với bảng khác
                    else
                    {
                        //xóa các công thức của đồ uống đó
                        deleteCongThucCuaMon(td.MaMon);
                        db.tblThucDons.DeleteOnSubmit(td);
                        db.SubmitChanges();
                        return 1; //Thành công
                    }
                    
                }
                return -1; //Không tồn tại hóa đơn

            }
            catch (Exception ex)
            {
                return -1; //Thất bại
            }
        }

        public tblThucDon getNewestDoUong()
        {
            return db.tblThucDons.OrderByDescending(t => t.MaMon).FirstOrDefault();
        }

        public bool doUong_isExitstInCTHoaDon(int maMon)
        {
            var item = db.tblChiTietHDs.Where(t => t.MaMon == maMon).FirstOrDefault();
            if (item != null)
                return true;
            return false;
        }

        public bool deleteCongThucCuaMon(int maMon)
        {
            var lst = db.tblCongThucs.Where(t => t.MaMon == maMon).Select(t => t);
            if (lst.Count() > 0)
            {
                foreach (var item in lst)
                {
                    db.tblCongThucs.DeleteOnSubmit(item);
                }
                db.SubmitChanges();
            }
            return true;
            
        }


    }
}
