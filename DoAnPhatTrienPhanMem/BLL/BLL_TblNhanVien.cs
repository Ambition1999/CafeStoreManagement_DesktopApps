using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_TblNhanVien
    {
        DB_qlQuanCafeDataContext db = new DB_qlQuanCafeDataContext();
        public BLL_TblNhanVien(){}

        public tblNhanVien getNhanVienByMaNV(int maNV)
        {
            return db.tblNhanViens.Where(t => t.MaNV == maNV).FirstOrDefault();
        }

        public String getTenNhanVienByMaNV(int maNV)
        {
            return db.tblNhanViens.Where(t => t.MaNV == maNV).Select(t=>t.TenNV).FirstOrDefault();
        }
    }
}
