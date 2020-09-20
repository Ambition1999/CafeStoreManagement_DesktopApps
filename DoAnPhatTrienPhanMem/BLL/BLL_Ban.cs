using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Ban
    {
        DB_qlQuanCafeDataContext db = new DB_qlQuanCafeDataContext();
        BLL_HoaDon hd = new BLL_HoaDon();
        BLL_ChiTietHD ct = new BLL_ChiTietHD();
        public IEnumerable<tblBan> goiSoDoBan()
        {
            return db.tblBans.Select(t=>t);
        }
        public void updateTTBan(int maBan)
        {
            tblBan b = db.tblBans.Where(t=>t.MaBan==maBan).FirstOrDefault();
            b.TrangThai = "False";
            db.SubmitChanges();
        }
        public void gopBan(int maBanCu,int maBanMoi)
        {
            try
            {
                tblBan bCu = db.tblBans.Where(t => t.MaBan == maBanCu).FirstOrDefault();
                tblBan bMoi = db.tblBans.Where(t => t.MaBan == maBanMoi).FirstOrDefault();

                tblHoaDon hCu = hd.getMaHDTheoBan(maBanCu);
                tblHoaDon hMoi = hd.getMaHDTheoBan(maBanMoi);

                List<tblChiTietHD> lstCu = ct.getCTByMaHD(hCu.MaHD).ToList();
                List<tblChiTietHD> lstMoi = ct.getCTByMaHD(hMoi.MaHD).ToList();
                double sum1 = (double)hCu.TongTienTT;
                double sum2 = (double)hCu.TongTienTT;
                //cap nhat cac hoa don trung nhau
                foreach (tblChiTietHD ctCu in lstCu)
                {
                    foreach (tblChiTietHD ctMoi in lstMoi)
                    {
                        if (ctCu.MaMon == ctMoi.MaMon)
                        {
                            //cap nhat sl + tong tien
                            ctCu.SoLuong = ctCu.SoLuong + ctMoi.SoLuong;
                            ctCu.TongTien = ctCu.TongTien + ctMoi.TongTien;
                            //xoa chi tiet moi
                            ct.xoaCTHDByMa(hMoi.MaHD, ctMoi.MaMon);
                        }
                    }
                }
                //them cac hoa don moi
                foreach (tblChiTietHD ctMoi in lstMoi)
                {
                    //them
                    tblChiTietHD c = new tblChiTietHD();
                    c.MaHD = hCu.MaHD;
                    c.MaMon = ctMoi.MaMon;
                    c.SoLuong = ctMoi.SoLuong;
                    c.TongTien = ctMoi.TongTien;
                    c.GiamGia = ctMoi.GiamGia;
                    db.tblChiTietHDs.InsertOnSubmit(c);
                    //xoa
                    ct.xoaCTHDByMa(hMoi.MaHD, ctMoi.MaMon);
                }
                //update tong tien hd
                hd.suaHoaDon(hCu.MaHD, (sum1 + sum2));
                db.SubmitChanges();
            }
            catch (Exception ee)
            { 
            
            }
        }
    }
}
