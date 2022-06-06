using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE2GL18EM21018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //boton agregar
        private void button1_Click(object sender, EventArgs e)
        {
            //variable para los out de los TryParce
            double precioProducto;
            //verifica que los campos esten correctos y si es tv
            if (rbTV.Checked&&txbAnio.Text!=string.Empty&&txbModelo.Text!=string.Empty&&txbMarca.Text!=string.Empty)
            {
                //instancio la clase
                Televisor televisor = new Televisor();
                if (double.TryParse(txbPrecioBace.Text, out precioProducto))
                {
                    televisor.Preciobase = double.Parse(txbPrecioBace.Text);
                    televisor.Marca = txbMarca.Text;
                    televisor.Anio = txbAnio.Text;
                    televisor.Modelo = txbModelo.Text;
                    televisor.Pulgadas = nupPulgadas.Value;

                    dgvProductos.Rows.Add("Televisor", televisor.Marca,televisor.Anio,televisor.Descuento(),televisor.Modelo,televisor.Iva(),televisor.Preciobase,televisor.AumntoPulgadas(televisor.PrecioEstimado()));
                }
                else
                {
                    //mensaje de error si el tryparse devolvió false
                    MessageBox.Show("El precio debe ser un número", "Error");
                }
            }//lo mismo que el anteror solo que con lavadora
            else if (rbLavaroda.Checked && txbAnio.Text != string.Empty && txbModelo.Text != string.Empty && txbMarca.Text != string.Empty)
            {
                Lavadora lavadora = new Lavadora();
                if (double.TryParse(txbPrecioBace.Text, out precioProducto))
                {
                    lavadora.Preciobase = double.Parse(txbPrecioBace.Text);
                    lavadora.Marca = txbMarca.Text;
                    lavadora.Anio = txbAnio.Text;
                    lavadora.Modelo = txbModelo.Text;
                    dgvProductos.Rows.Add("Lavadora", lavadora.Marca, lavadora.Anio, lavadora.Descuento(), lavadora.Modelo, lavadora.Iva(), lavadora.Preciobase,lavadora.PrecioEstimado());
                }
                else
                {
                    MessageBox.Show("El precio debe ser un número", "Error");
                }
            }
            else
            {
                //si no cumplio con la condicion del primer if, de un mensaje de error
                MessageBox.Show("NO DEJO NINGUN CAMPO VACÍO", "Error en el ingreso de datos");
            }
        }

        private void rbTV_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTV.Checked)
            {
                //para mostrar la entrada de datos de las pulgadas de la television
                lbpulgadas.Visible = true;
                nupPulgadas.Visible = true;
            }
        }
        private void rbLavaroda_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLavaroda.Checked)
            {
                //para ocultar la entrada de datos de las pulgadas de la television
                lbpulgadas.Visible = false;
                nupPulgadas.Visible = false;
            }
        }
    }
}
