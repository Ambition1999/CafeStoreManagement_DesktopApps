using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_HoaDon
    {
        DB_qlQuanCafeDataContext db = new DB_qlQuanCafeDataContext();
        public int LuuHoaDon(DateTime dt,int maB, int MaNV, String pt,double tong, String tt)
        {
            tblHoaDon h = new tblHoaDon();
            try
            {
                h.TGVao = dt;
                h.MaBan = maB;
                h.MaNV = 2;
                h.PhuongThucTT = "Cash";
                h.TongTienTT = (Decimal)tong;
                h.TrangThai = "Chua";

                db.tblHoaDons.InsertOnSubmit(h);
                db.SubmitChanges();

            }
            catch (Exception ee)
            {

            }
            return h.MaHD;
        }
        public int LuuHoaDon2(DateTime dt, int maB, int MaNV, String pt, double tong, String tt)
        {
            tblHoaDon h = new tblHoaDon();
            try
            {
                h.TGVao = dt;
                h.TGRa = dt;
                h.MaBan = maB;
                h.MaNV = 2;
                h.PhuongThucTT = "Cash";
                h.TongTienTT = (Decimal)tong;
                h.TrangThai = "Roi";
                db.tblHoaDons.InsertOnSubmit(h);
                db.SubmitChanges();

            }
            catch (Exception ee)
            {

            }
            return h.MaHD;
        }
        public int suaHoaDon(int maHD,double tong)
        {
            tblHoaDon h = new tblHoaDon();
            try
            {
                h = db.tblHoaDons.Where(t => t.MaHD == maHD).FirstOrDefault();
                h.TongTienTT = (Decimal)tong;
            
                db.SubmitChanges();

            }
            catch (Exception ee)
            {

            }
            return h.MaHD;
        }
        public int suaHoaDonMaBan(int maHD, int maBan)
        {
            tblHoaDon h = new tblHoaDon();
            try
            {
                h = db.tblHoaDons.Where(t => t.MaHD == maHD).FirstOrDefault();
                h.MaBan = maBan;

                db.SubmitChanges();

            }
            catch (Exception ee)
            {

            }
            return h.MaHD;
        }
        public int suaHoaDon(int maHD, DateTime tgRa,String tt)
        {

            tblHoaDon h = new tblHoaDon();
            try
            {
                h = db.tblHoaDons.Where(t => t.MaHD == maHD).FirstOrDefault();
                h.TGRa = tgRa;
                h.TrangThai = tt;

                db.SubmitChanges();

            }
            catch (Exception ee)
            {

            }
            return h.MaHD;
        }
        public tblHoaDon getMaHDTheoBan(int maB)
        {
            return db.tblHoaDons.Where(t => t.MaBan == maB && t.TrangThai.Equals("Chua")).FirstOrDefault();
        }
        public tblHoaDon getMaHDTheoMaHD(int maHD)
        {
            return db.tblHoaDons.Where(t => t.MaHD == maHD).FirstOrDefault();
        }
    }
}
