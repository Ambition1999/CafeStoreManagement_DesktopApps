using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_TblTaiKhoan
    {
        DB_qlQuanCafeDataContext db = new DB_qlQuanCafeDataContext();
        public BLL_TblTaiKhoan(){}

        //1 là admin, 2 là nhanvien, 3 là null
        public int taiKhoan_isExist(String username, String password)
        {
            var tk = db.tblTaiKhoans.Select(t=>t).ToList().Where(t => String.Compare(t.TenDN,username,false) == 0  && t.MatKhau == password).FirstOrDefault();
            if(tk != null){
                if (tk.Quyen.Equals("admin") || tk.Quyen.Equals("Admin"))
                    return 1;
                return 2;
            }
            return 0;         
        }
        public int taiKhoan_isExist2(String username, String password)
        {
            var tk = db.tblTaiKhoans.Select(t => t).ToList().Where(t => String.Compare(t.TenDN, username, false) == 0 && t.MatKhau == password).FirstOrDefault();
            if (tk != null)
            {
                if (tk.Quyen.Equals("admin") || tk.Quyen.Equals("Admin"))
                    return 1;
                return tk.MaNV;
            }
            return 0;
        }
    }
}
