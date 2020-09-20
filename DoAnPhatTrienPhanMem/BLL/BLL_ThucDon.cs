using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_ThucDon
    {
        DB_qlQuanCafeDataContext db = new DB_qlQuanCafeDataContext();
        public IEnumerable<tblThucDon> getThucDon()
        {
            return db.tblThucDons.Select(t=>t);
        }
        public IEnumerable<tblThucDon> getThucDonPhoBien()
        {
            return db.tblThucDons.Where(t => t.PhoBien==true);
        }
        public IEnumerable<tblThucDon> getThucDonTheoDanhMuc(int maLoai)
        {
            return db.tblThucDons.Where(t => t.MaLoai == maLoai);
        }
        public IEnumerable<tblThucDon> getThucDonTheoTen(String ten)
        {
            return db.tblThucDons.Where(t => t.TenMon.ToLower().Contains(ten.ToLower()));
        }
        public tblThucDon getThucDonByMa(int ma)
        {
            return db.tblThucDons.Where(t => t.MaMon == ma).FirstOrDefault();
        }
        public bool kiemTraHang(int maMon,int param1)
        {
            try
            {
                List<tblCongThuc> lstCongThuc = db.tblCongThucs.Select(t=>t).ToList();
                List<tblNguyenLieu> lstNguyenLieu = db.tblNguyenLieus.Select(t=>t).ToList();
                List<tblCongThuc> lstCT = new List<tblCongThuc>();
                foreach (tblCongThuc c in lstCongThuc)
                {
                    if (c.MaMon == maMon)
                    {
                        lstCT.Add(c);
                    }
                }
                for (int i = 0; i < lstCT.Count; i++)
                {
                    foreach (tblNguyenLieu n in lstNguyenLieu)
                    {
                        if (lstCT[i].MaNL == n.MaNL)
                        {
                            double canSL = (double)(lstCT[i].HamLuong * param1);
                            if (canSL > (double)n.SoLuong)
                                return false;
                        }
                    }
                }
                return true;

            }
            catch (Exception ee)
            {
                return false;
            }
        }
    }
}
