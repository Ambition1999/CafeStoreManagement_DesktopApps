using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class kmean
    {
        DB_qlQuanCafeDataContext hcl = new DB_qlQuanCafeDataContext();
        List<tblChiTietHD> ds_CTHD_FULL;
        List<conn> ds_CTHD;
        public kmean()
        {
            ds_CTHD_FULL = hcl.tblChiTietHDs.Select(t => t).ToList<tblChiTietHD>();
        }
        public List<conn> BeforeProcess()
        {
            List<conn> lstCon = new List<conn>();
            foreach (tblChiTietHD i in ds_CTHD_FULL)
            {
                int co = 0;
                foreach (conn n in lstCon)
                {
                    if (i.MaMon==n.MaMon)
                    {
                        co = 1;
                        n.SoLuong += i.SoLuong;
                        break;
                    }
                }
                if (co == 0)
                {
                    conn c = new conn();
                    c.MaMon = i.MaMon;
                    c.SoLuong = i.SoLuong;
                    lstCon.Add(c);
                }
            }
            return lstCon;
        }
        public class conn
        {
            int _maMon;

            public int MaMon
            {
                get { return _maMon; }
                set { _maMon = value; }
            }
            int _SoLuong;

            public int SoLuong
            {
                get { return _SoLuong; }
                set { _SoLuong = value; }
            }
            int _Cum;
            public int Cum
            {
                get { return _Cum; }
                set { _Cum = value; }
            }
        } 
        public List<conn> xuLy(int kCum)
        {
            ds_CTHD=new List<conn>();
            ds_CTHD = BeforeProcess();

            List<double> ds_TamCum = new List<double>();

            //ds_CTHD[0].Cum = 1; ds_TamCum.Add(200);
            //ds_CTHD[1].Cum = 2; ds_TamCum.Add(50);
            //ds_CTHD[9].Cum = 3; ds_TamCum.Add(100);
            for (int i = 1; i <= kCum; i++)
            {
                Random rd = new Random();
                int index = rd.Next(0, ds_CTHD.Count - 1);
                if (ds_CTHD[index].Cum != 0)
                {
                    i--;
                    continue;
                }
                ds_CTHD[index].Cum = i;
                ds_TamCum.Add(ds_CTHD[index].SoLuong);
            }
            for (int i = 0; i < ds_CTHD.Count; i++)
            {
                for (int j = 1; j <= ds_TamCum.Count; j++)
                {
                    ds_TamCum[j - 1] = TamCum(j);
                }
                //if (ds_CTHD[i].Cum == 0)
                //{
                    double khoanCachMin = 0;
                    int cum_Min = 0;
                    for (int j = 1; j <= ds_TamCum.Count; j++)
                    {
                        double? giaTriTamCum = ds_TamCum[j - 1];
                        double khoanCach = Math.Sqrt(Math.Pow(giaTriTamCum.Value - ds_CTHD[i].SoLuong,2));
                        if (j == 1)
                        {
                            khoanCachMin = khoanCach;
                            cum_Min = j;
                        }
                        else
                        {
                            if (khoanCach < khoanCachMin)
                            {
                                khoanCachMin = khoanCach;
                                cum_Min = j;
                            }
                        }
                    }
                    ds_CTHD[i].Cum = cum_Min;
                //}
            }
            return ds_CTHD;
        }

        public double TamCum(int cumK)
        {
            try
            {
                return ds_CTHD.Where(t => t.Cum == cumK).Select(t => t.SoLuong).Average();
            }
            catch (Exception ee)
            {
                return 0;
            }
        }

    }
}
