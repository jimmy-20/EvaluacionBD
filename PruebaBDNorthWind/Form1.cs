using PruebaBDNorthWind.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaBDNorthWind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(txtAño.Text);

            DataTable dt = CProduct.Show_Recaudate(year);
            DataRow row = dt.Rows[0];
            
            if (dt != null)
            {
                if (row.ItemArray[0].ToString() == "Not Found")
                {
                    MessageBox.Show("No existe el año ingresado","NorthWind",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvProductos.DataSource = null;
                }
                else
                {
                    dgvProductos.DataSource = dt;
                    dgvProductos.Refresh();
                }
            }
            else
            {
                MessageBox.Show("BD vacia", "Error en Base de Datos");
            }
        }

        private void txtAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (Char.IsLetter(c))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public DataTable Show_Product(int year)
        {
            return CProduct.Show_Recaudate(year);
        }
    }
}
