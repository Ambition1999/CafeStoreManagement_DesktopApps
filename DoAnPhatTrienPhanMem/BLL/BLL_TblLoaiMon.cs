using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_TblLoaiMon
    {
        DB_qlQuanCafeDataContext db = new DB_qlQuanCafeDataContext();
        public BLL_TblLoaiMon(){}

        public IEnumerable<tblLoaiMon> getDSLoaiMon()
        {
            return db.tblLoaiMons.Select(t => t);
        }
    }
}
