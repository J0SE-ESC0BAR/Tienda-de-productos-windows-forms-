using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE2GL18EM21018
{
    class Producto
    {
        private double preciobase=0;
        private string marca;
        private string anio;
        private string modelo;
        private double subtotal=0;
        //set y get de los atributos
        public double Preciobase { get => preciobase; set => preciobase = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Anio { get => anio; set => anio = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        //comprueva si es nuevo y si lo es agrega 175 al precio
        public double Nuevo() 
        {
            if (int.Parse(anio) == 2021)
            {
                subtotal = subtotal+(preciobase + 175);
            }
            else
            {
                subtotal = preciobase;
            }
            return subtotal;
        }
        //comprueba si tiene mas de dos años de antiguedad y si es verdadero lo indica
        public string Descuento()
        {
            string descuento = "NO";
            if (int.Parse(anio)<2019)
            {
                descuento = "SI";
            }
            return descuento;
        }
        //saca el iva del producto
        public double Iva()
        {
            double iva;
            iva = (Nuevo() * 0.13);
            return iva;
        }
        //encuentra el precio estimado
        public double PrecioEstimado()
        {
            double totalEstimado;
            totalEstimado = Nuevo()+Iva();
            return totalEstimado;
        }
    }
}
