using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadriláteros.Modelo
{
    public class Trapecio : Cuadrilatero
    {
        public Trapecio() : base()
        {
        }

        public override double CalcularArea()
        {
            double ladoA = CalcularDistancia(Vertice_1, Vertice_2);
            double ladoB = CalcularDistancia(Vertice_2, Vertice_3);
            double ladoC = CalcularDistancia(Vertice_3, Vertice_4);
            double ladoD = CalcularDistancia(Vertice_4, Vertice_1);

            double area = ((ladoD + ladoB) / 2) * Math.Sqrt(Math.Pow(ladoA, 2) - Math.Pow((Math.Pow(ladoA,2) - Math.Pow(ladoC,2) + Math.Pow(ladoD - ladoB,2)) / (2 * (ladoD - ladoB)),2));

            return area;
        }
    }
}
