using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadriláteros.Modelo
{
    internal class Cuadrado : Cuadrilatero
    {
        public Cuadrado() : base()
        {

        }

        public override double CalcularArea()
        {
            double ladoA = CalcularDistancia(Vertice_1, Vertice_2);

            return ladoA * ladoA;
        }
    }
}
