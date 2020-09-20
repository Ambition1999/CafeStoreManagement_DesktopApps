using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_TblCongThuc
    {
        DB_qlQuanCafeDataContext db = new DB_qlQuanCafeDataContext();
        public BLL_TblCongThuc() { }

        public List<NguyenLieu_Item> getCongThucByMaMon()
        {
            int maMon = 392387123;
            var lst = (from congThuc in db.tblCongThucs
                    join nl in db.tblNguyenLieus on congThuc.MaNL equals nl.MaNL
                    where congThuc.MaMon == maMon
                    select new
                    {
                        Mã_nguyên_liệu = nl.MaNL,
                        Tên_nguyên_liệu = nl.TenNL,
                        Đơn_vị_tính = nl.DonViTinh,
                        Hàm_lượng = congThuc.HamLuong
                    });

            List<NguyenLieu_Item> lstNL = new List<NguyenLieu_Item>();
            foreach (var item in lst)
            {
                NguyenLieu_Item nlI = new NguyenLieu_Item(item.Mã_nguyên_liệu, item.Tên_nguyên_liệu, item.Đơn_vị_tính, Convert.ToDouble(item.Hàm_lượng));
                lstNL.Add(nlI);
            }
            return lstNL;
        }

        public List<NguyenLieu_Item> getCongThucByMaMon(int maMon)
        {
            var lst = from congThuc in db.tblCongThucs
                    join nl in db.tblNguyenLieus on congThuc.MaNL equals nl.MaNL
                    where congThuc.MaMon == maMon
                    select new {
                        Mã_nguyên_liệu = nl.MaNL,
                        Tên_nguyên_liệu = nl.TenNL,
                        Đơn_vị_tính = nl.DonViTinh,
                        Hàm_lượng = congThuc.HamLuong                       
                    };
            List<NguyenLieu_Item> lstNL = new List<NguyenLieu_Item>();
            foreach (var item in lst)
            {
                NguyenLieu_Item nlI = new NguyenLieu_Item(item.Mã_nguyên_liệu, item.Tên_nguyên_liệu, item.Đơn_vị_tính, Convert.ToDouble(item.Hàm_lượng));
                lstNL.Add(nlI);
            }
            return lstNL;
        }

        public bool congThuc_isUsed(int maMon, int maNL)
        {
            var item = db.tblCongThucs.Where(t => t.MaMon == maMon && t.MaNL == maNL).FirstOrDefault();
            if (item != null)
            {
                var itemInHD = db.tblChiTietHDs.Where(t=>t.MaMon == item.MaMon).FirstOrDefault();
                if(itemInHD != null){
                    return true; // đã được sử dụng
                }
            }
            return false; //chưa được sử dụng
        }

        public bool insertCongThuc(int maMon, int maNL, double hamLuong)
        {
            var item = db.tblCongThucs.Where(t => t.MaMon == maMon && t.MaNL == maNL).FirstOrDefault();
            if (item != null)
            {
                try
                {
                    item.HamLuong = Convert.ToDecimal(hamLuong);
                    item.Tong = Convert.ToDecimal(hamLuong);
                    db.SubmitChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }  
            }
            else
            {
                try
                {
                    tblCongThuc congThuc = new tblCongThuc();
                    congThuc.MaMon = maMon;
                    congThuc.MaNL = maNL;
                    congThuc.HamLuong = Convert.ToDecimal(hamLuong);
                    congThuc.Tong = Convert.ToDecimal(hamLuong);

                    db.tblCongThucs.InsertOnSubmit(congThuc);
                    db.SubmitChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }                
            }
            
        }

        public bool congThuc_isExitst(int maMon, int maNL)
        {
            var item = db.tblCongThucs.Where(t => t.MaMon == maMon && t.MaNL == maNL).FirstOrDefault();
            if (item != null)
            {
                return true; // đã tồn tại
            }
            return false; //chưa tồn tại
        }
    }
}
