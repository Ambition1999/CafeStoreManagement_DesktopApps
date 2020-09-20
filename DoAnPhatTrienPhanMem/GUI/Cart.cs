using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class Cart
    {
        static List<Item> lstCart = new List<Item>();
        static List<Item> lstCart2 = new List<Item>();
        static int bienXoa;
        static bool mau;
        static int maBan;
        static double tienGoc;
        static int flag = 0;
        static int manv = 2;
        public Cart()
        {
           
        }
        public void setFlag(int f)
        {
            flag = f;
        }
        public int getFlag()
        {
            return flag;
        }
        public void setMau(bool m)
        {
            mau = m;
        }
        public bool getMau()
        {
            return mau;
        }
        public void setTienGoc(double tg)
        {
            tienGoc = tg;
        }
        public double getTienGoc()
        {
            return tienGoc;
        }
        public int getMaBan()
        {
            return maBan;
        }
        public void setMaBan(int mb)
        {
            maBan = mb;
        }
        public int getMaNV()
        {
            return manv;
        }
        public void setMaNV(int ma)
        {
            manv = ma;
        }
        public int getBienXoa()
        {
            return bienXoa;
        }
        public void setBienXoa(int bx)
        {
            bienXoa = bx;
        }
        public List<Item> getCart()
        {
            return lstCart;
        }
        public void setCart(List<Item> lst)
        {
            lstCart = lst;
        }
        public List<Item> getCart2()
        {
            return lstCart2;
        }
        public void setCart2(List<Item> lst)
        {
            lstCart2 = lst;
        }
        public void clearCard2()
        {
            lstCart2.Clear();
        }
        public void clearCard()
        {
            lstCart.Clear();
        }
        public void addCart(Item i)
        {
            lstCart.Add(i);
        }
        public void addCart2(Item i)
        {
            lstCart2.Add(i);
        }
        public double tinhTong()
        {
            double sum = 0;
            for (int i = 0; i < lstCart.Count; i++)
            {
                sum += lstCart[i].tongTien;
            }
            return sum;
        }
        public double tinhTong2()
        {
            double sum = 0;
            for (int i = 0; i < lstCart2.Count; i++)
            {
                sum += lstCart2[i].tongTien;
            }
            return sum;
        }
    }
}
