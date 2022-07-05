using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadriláteros.Modelo
{
    public class Rectangulo : Cuadrilatero
    {
        public Rectangulo() : base()
        {

        }

        public override double CalcularArea()
        {
            double ladoA = CalcularDistancia(Vertice_1, Vertice_2);
            double ladoB = CalcularDistancia(Vertice_2, Vertice_3);

            return ladoA * ladoB;
        }
    }
}
