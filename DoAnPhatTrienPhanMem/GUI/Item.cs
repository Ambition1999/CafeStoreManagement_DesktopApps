using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class Item
    {
        public int maMon { set; get; }
        public double donGia { set; get; }
        public int sl { set; get; }
        public String tenMon { set; get; }
        public double tongTien { set; get; }
        public Item(int maM,double donGia,int sl,String ten)
        {
            this.maMon = maM;
            this.donGia = donGia;
            this.sl = sl;
            this.tenMon = ten;
            this.tongTien = donGia * sl;
        }
        public Item(int maM, int sl, String ten, double tong)
        {
            this.maMon = maM;
            this.sl = sl;
            this.tenMon = ten;
            this.tongTien = tong;
        }
      
    }
}
