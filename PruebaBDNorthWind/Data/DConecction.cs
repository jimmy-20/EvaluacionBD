using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBDNorthWind.Data
{
    class DConecction
    {
        static string host = "Data Source = DESKTOP-ATV4JNH ; Initial Catalog = Northwind;" +
                              "user = AdminNorthWind ; password = Northwind";

        public static SqlConnection Open()
        {
            SqlConnection conecction = new SqlConnection(host);
            conecction.Open();

            return conecction;
        } 
    }
}
