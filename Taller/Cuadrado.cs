using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller
{
    class Cuadrado : Figura
    {
        private double lado;

        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        public override double CalcularArea()
        {
            return Lado * Lado;
        }

    }
}
