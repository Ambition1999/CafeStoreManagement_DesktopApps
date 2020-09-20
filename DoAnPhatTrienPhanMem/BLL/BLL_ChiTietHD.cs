using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_ChiTietHD
    {
        DB_qlQuanCafeDataContext db = new DB_qlQuanCafeDataContext();
        public void LuuChiTietHD(int maHD, int maMon, int sl, double tong)
        {
            try
            {
                tblChiTietHD ct = new tblChiTietHD();
                ct.MaHD = maHD;
                ct.MaMon = maMon;
                ct.SoLuong = sl;
                ct.GiamGia = "0";
                ct.TongTien = (Decimal)tong;
                db.tblChiTietHDs.InsertOnSubmit(ct);
                db.SubmitChanges();
            }
            catch (Exception ee)
            {

            }
        }
        public void suaChiTietHD(int maHD, int maMon, int sl, double tong)
        {
            try
            {
                tblChiTietHD ct = new tblChiTietHD();
                ct = db.tblChiTietHDs.Where(t => t.MaHD == maHD && t.MaMon == maMon).FirstOrDefault();
                ct.MaHD = maHD;
                ct.MaMon = maMon;
                ct.SoLuong = sl;
                ct.GiamGia = "0";
                ct.TongTien = (Decimal)tong;
                db.SubmitChanges();

            }
            catch (Exception ee)
            {

            }
        }
        public void xoaCTHDByMa(int maHD, int maMon)
        {
            try
            {
                tblChiTietHD ct = new tblChiTietHD();
                ct = db.tblChiTietHDs.Where(t=>t.MaHD==maHD&&t.MaMon==maMon).FirstOrDefault();
                db.tblChiTietHDs.DeleteOnSubmit(ct);
                db.SubmitChanges();

            }
            catch (Exception ee)
            {

            }
        }
        public IEnumerable<tblChiTietHD> getCTByMaHD(int maHD)
        {
            return db.tblChiTietHDs.Where(t => t.MaHD == maHD).ToList();
        }
        public IQueryable<tblChiTietHD> getCTByMaHD3(int maHD)
        {
            return db.tblChiTietHDs.Where(t => t.MaHD == maHD);
        }
        public IEnumerable<tblChiTietHD> getCTByMaHD2(int maHD)
        {
            dynamic y= from ct in db.tblChiTietHDs where ct.MaHD == maHD select new { ct.tblThucDon.TenMon,ct.SoLuong,ct.TongTien };
            return y;
        }
        public IQueryable<tblChiTietHD> getData()
        {
            return db.tblChiTietHDs.Select(t=>t);
        }
    }
}
