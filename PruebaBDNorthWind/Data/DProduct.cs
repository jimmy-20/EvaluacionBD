using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaBDNorthWind.Data
{
    class DProduct
    {
        public static DataTable Show_Recaudate(int year)
        {
            DataTable dt = new DataTable("Recaudacion");

            try
            {
                SqlConnection conecction = DConecction.Open();

                SqlCommand command = new SqlCommand()
                {
                    CommandText = "Show_Recaudate",
                    CommandType = CommandType.StoredProcedure,
                    Connection = conecction
                };

                SqlParameter parameter1 = new SqlParameter()
                {
                    ParameterName = "Year",
                    Value = year,
                    SqlDbType = SqlDbType.Int
                };

                command.Parameters.Add(parameter1);

                SqlDataAdapter data = new SqlDataAdapter(command);

                data.Fill(dt);

            }catch (Exception e)
            {
                dt = null;
                MessageBox.Show("Error :"+e.Message,"Dentro del DConnection",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }
    }
}
