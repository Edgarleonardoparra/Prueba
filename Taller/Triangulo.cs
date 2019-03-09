using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller
{
    class Triangulo : Figura
    {
        private double _base;
        private double altura;

        public double Base
        {
            get { return _base; }
            set { _base = value; }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }


        public override double CalcularArea()
        {
            return _base * altura;
        }
    }
}
