using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE2GL18EM21018
{
    class Televisor:Producto
    {
        private decimal pulgadas;
        public decimal Pulgadas { get => pulgadas; set => pulgadas = value; }

        //suma 250 si el tamaño de la televicion es mayor a 36 pulgadas
        public double AumntoPulgadas(double preciobace)
        {
            if (pulgadas>36)
            {
                preciobace = preciobace + 250;
            }
            return preciobace;
        }
    }
}
