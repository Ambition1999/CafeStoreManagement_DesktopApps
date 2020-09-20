using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_TblNguyenLieu
    {
        DB_qlQuanCafeDataContext db = new DB_qlQuanCafeDataContext();
        public BLL_TblNguyenLieu(){}

        public IEnumerable<tblNguyenLieu> getNguyenLieu()
        {
            return db.tblNguyenLieus.Select(t => t);
        }

        public tblNguyenLieu getNguyenLieuByID(int maNL)
        {
            return db.tblNguyenLieus.Where(t => t.MaNL == maNL).FirstOrDefault();
        }
        
    }
}
