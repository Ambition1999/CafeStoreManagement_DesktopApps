using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_TblHoaDon
    {
        DB_qlQuanCafeDataContext db = new DB_qlQuanCafeDataContext();
        public BLL_TblHoaDon() { }

        //Lấy danh sách hóa đơn trong CSDL
        public IEnumerable<tblHoaDon> getDSHoaDon()
        {
            return db.tblHoaDons.Select(t => t);
        }

        //Lấy hóa đơn theo mã HD
        public tblHoaDon getHDByMaHD(int maHD)
        {
            return db.tblHoaDons.Where(t => t.MaHD == maHD).FirstOrDefault();
        }

        public List<tblHoaDon> getDSHoaDonChuaThanhToan()
        {
            return db.tblHoaDons.Where(t => t.TrangThai.Equals("Chua")).Select(t => t).ToList();
        }

        public dynamic getDooanhThuTheoThang()
        {
            DateTime date = new DateTime();
            date = DateTime.Now;
            var listTongTien3 = (from hd in db.tblHoaDons
                                 where hd.TrangThai == "Roi"
                                 select new { Ngay = hd.TGRa, TienTT = hd.TongTienTT })
                                 .GroupBy(c => new { c.Ngay.Value.Month, c.Ngay.Value.Year })
                                 .Select(g => new { Thang = "Tháng" + g.Key.Month, Nam = g.Key.Year, TongTien = g.Sum(a => a.TienTT) }).ToList();
            return listTongTien3;
        }

        public dynamic getDooanhThuCacNgayTrongThang()
        {
            DateTime dateInput = new DateTime();
            dateInput = DateTime.Now;
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            var listTongTien3 = (from hd in db.tblHoaDons
                                 where hd.TrangThai == "Roi" && hd.TGRa.Value.Month == dateInput.Month && hd.TGRa.Value.Year == dateInput.Year
                                 select new { Ngay = hd.TGRa, TienTT = hd.TongTienTT })
                                 .GroupBy(c => new { c.Ngay.Value.Day, c.Ngay.Value.Month, c.Ngay.Value.Year })
                                 .OrderByDescending(c=>c.Key.Day)
                                 .Select(g => new
                                 {
                                     Ngày = g.Key.Day,
                                     Tháng = g.Key.Month,
                                     Năm = g.Key.Year,
                                     Tổng_Tiền = g.Sum(b => b.TienTT).ToString("#,###", cul.NumberFormat)
                                 }).ToList();
            return listTongTien3;
        }

        public dynamic getDooanhThuTheoMocThoiGian(DateTime dateStart, DateTime dateEnd)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            var listTongTien3 = (from hd in db.tblHoaDons
                                 where hd.TrangThai == "Roi" && (hd.TGRa >= dateStart.Date && hd.TGRa <= dateEnd.Date)
                                 select new { Ngay = hd.TGRa, TienTT = hd.TongTienTT })
                                 .GroupBy(c => new {c.Ngay.Value.Day , c.Ngay.Value.Month, c.Ngay.Value.Year })
                                 .Select(g => new { Ngày = g.Key.Day, Tháng = g.Key.Month, Năm = g.Key.Year, 
                                     Tổng = g.Sum(b => b.TienTT).ToString("#,###", cul.NumberFormat)}).ToList();
            return listTongTien3;
        }

        public dynamic getDSHD_TheoNgay(DateTime ngayHD)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            var listTongTien3 = (from hd in db.tblHoaDons
                                 where hd.TrangThai == "Roi" && (hd.TGRa.Value.Date == ngayHD.Date)
                                 select new { Ngày = ngayHD,Giờ_Vào = hd.TGVao.TimeOfDay , Giờ_Ra = hd.TGRa.Value.TimeOfDay,  
                                     Mã_HD = hd.MaHD, Tổng_Tiền = hd.TongTienTT.ToString("#,###", cul.NumberFormat)}).ToList();
            return listTongTien3;
        }

        //Thêm mới
        public List<Class1> getDooanhThuCacNgayTrongThang2()
        {
            List<Class1> c1 = new List<Class1>();
            DateTime dateInput = new DateTime();
            dateInput = DateTime.Now;
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            c1 = (from hd in db.tblHoaDons
                  where hd.TrangThai == "Roi" && hd.TGRa.Value.Month == dateInput.Month && hd.TGRa.Value.Year == dateInput.Year
                  select new { Ngay = hd.TGRa, TienTT = hd.TongTienTT })
                                 .GroupBy(c => new { c.Ngay.Value.Day, c.Ngay.Value.Month, c.Ngay.Value.Year })
                                 .OrderByDescending(c => c.Key.Day)
                                 .Select(g => new Class1
                                 {
                                     Ngay = g.Key.Day,
                                     Thang = g.Key.Month,
                                     Nam = g.Key.Year,
                                     Tien = g.Sum(b => b.TienTT).ToString("#,###", cul.NumberFormat)
                                 }).ToList();
            return c1;
        }

        public string getTongTienHD_HomNay()
        {
            DateTime date = new DateTime();
            date = DateTime.Now;
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            var item = (from hd in db.tblHoaDons
                                 where hd.TrangThai == "Roi" && (hd.TGRa.Value.Date == date.Date)
                                 select new
                                 {
                                     Giờ_Vào = hd.TGVao.TimeOfDay,
                                     Giờ_Ra = hd.TGRa.Value.TimeOfDay,
                                     Mã_HD = hd.MaHD,
                                     Tổng_Tiền = hd.TongTienTT.ToString("#,###", cul.NumberFormat)
                                 }).ToList();
            return item.Select(t=>t.Tổng_Tiền).FirstOrDefault();
        }

        public int getDSHoaDonChuaThanhToan_HomNay()
        {
             DateTime date = new DateTime();
            date = DateTime.Now;
            var lst = db.tblHoaDons.Where(t => t.TrangThai.Equals("Chua") && t.TGVao.Date == date.Date).Select(t => t).ToList();
            return lst.Count;
        }

        public int getDSHoaDonDaThanhToan_HomNay()
        {
            DateTime date = new DateTime();
            date = DateTime.Now;
            var lst = db.tblHoaDons.Where(t => t.TrangThai.Equals("Da") && t.TGRa.Value.Date == date.Date).Select(t => t).ToList();
            return lst.Count;
        }

        
        
    }
}
