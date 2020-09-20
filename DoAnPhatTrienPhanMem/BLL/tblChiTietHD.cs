using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public partial class tblChiTietHD
    {
        int _STT;
        String _TenMon;
        int _Cum;
        public String TenMon
        {
            get { return _TenMon; }
            set { _TenMon = value; }
        }
        public int STT
        {
            get { return _STT; }
            set { _STT = value; }
        }
        public int Cum
        {
            get { return _Cum; }
            set { _Cum = value; }
        }
    }
}
