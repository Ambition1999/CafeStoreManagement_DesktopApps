using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_TblBan
    {
        DB_qlQuanCafeDataContext db = new DB_qlQuanCafeDataContext();
        public BLL_TblBan(){}

        public tblBan getBanByID(int id)
        {
            return db.tblBans.Where(t => t.MaBan == id).Select(t => t).FirstOrDefault();
        }

        public int getSoBanDangSuDung()
        {
            return db.tblBans.Where(t => t.TrangThai == "True").Count();
        }

        public int getSoBanDangTrong()
        {
            return db.tblBans.Where(t => t.TrangThai == "False").Count();
        }

        public int getTongSoBan()
        {
            return db.tblBans.Count();
        }
    }
}
