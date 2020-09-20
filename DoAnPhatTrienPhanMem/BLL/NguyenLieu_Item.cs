using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NguyenLieu_Item
    {
        int maNL;

        public int MaNL
        {
            get { return maNL; }
            set { maNL = value; }
        }
        string tenNL;

        public string TenNL
        {
            get { return tenNL; }
            set { tenNL = value; }
        }
        string dvt;

        public string Dvt
        {
            get { return dvt; }
            set { dvt = value; }
        }
        double hamLuong;

        public double HamLuong
        {
            get { return hamLuong; }
            set { hamLuong = value; }
        }

        public NguyenLieu_Item(){}

        public NguyenLieu_Item(int MaNL, string TenNL, string DVT, double HamLuong) 
        {
            this.MaNL = MaNL;
            this.tenNL = TenNL;
            this.hamLuong = HamLuong;
            this.dvt = DVT;
        }
    }
}
