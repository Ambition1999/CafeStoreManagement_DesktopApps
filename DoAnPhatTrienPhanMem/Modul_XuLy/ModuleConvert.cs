using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_XuLy
{
    public class ModuleConvert
    {
        public ModuleConvert(){}

        public String convertCurrency(double numInput)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            return numInput.ToString("#,###", cul.NumberFormat);

        }

        public String convertCurrency(string strInput)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            return double.Parse(strInput).ToString("#,###", cul.NumberFormat);

        }
    }
}
