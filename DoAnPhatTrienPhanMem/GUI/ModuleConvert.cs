using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class ModuleConvert
    {
        public ModuleConvert(){}

        public String convertCurrency(double numInput)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            return numInput.ToString("#,###", cul.NumberFormat);

        }
    }
}
