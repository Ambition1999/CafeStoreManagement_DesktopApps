using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul_XuLy;

namespace BLL
{
    public class BLL_TblChiTietHD
    {

        DB_qlQuanCafeDataContext db = new DB_qlQuanCafeDataContext();
        public BLL_TblChiTietHD() { }

        public dynamic getChiTietHDByMaHD(int maHD)
        {
            ModuleConvert module = new ModuleConvert();
            return from ct in db.tblChiTietHDs
                   join td in db.tblThucDons on ct.MaMon equals td.MaMon
                   where ct.MaHD == maHD
                   select new
                   {
                       Tên_món = td.TenMon,
                       Số_lượng = ct.SoLuong,
                       Đơn_giá = module.convertCurrency(Convert.ToDouble(td.DonGia)),
                       Giảm_giá = ct.GiamGia,
                       Tổng_tiền = module.convertCurrency(Convert.ToDouble(ct.TongTien))
                   };
        }
    }
}
