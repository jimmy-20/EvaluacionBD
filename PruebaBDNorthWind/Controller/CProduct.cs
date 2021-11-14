using PruebaBDNorthWind.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBDNorthWind.Controller
{
    class CProduct
    {
        public static DataTable Show_Recaudate(int year)
        {
            return DProduct.Show_Recaudate(year);
        }
    }
}
