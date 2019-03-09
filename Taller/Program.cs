using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>();
            
            Circulo circulo = new Circulo();
            circulo.Radio = 2;

            Triangulo triangulo = new Triangulo();
            triangulo.Base = 3;
            triangulo.Altura = 5;

            Cuadrado cuadrado = new Cuadrado();
            cuadrado.Lado = 4;

            figuras.Add(circulo);
            figuras.Add(triangulo);
            figuras.Add(cuadrado);

            foreach (var figura in figuras)
            {
                Console.WriteLine(figura.CalcularArea());
            }
        }
    }
}
