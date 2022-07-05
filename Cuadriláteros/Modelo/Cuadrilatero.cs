using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadriláteros.Modelo
{
    public abstract class Cuadrilatero
    {
        private float[] vertice_1;
        private float[] vertice_2;
        private float[] vertice_3;
        private float[] vertice_4;

        // Constructor de la clase.
        public Cuadrilatero()
        {
            vertice_1 = new float[2];
            vertice_2 = new float[2];
            vertice_3 = new float[2];
            vertice_4 = new float[2];
        }

        public float[] Vertice_1 
        {
            get
            {
                return vertice_1;
            }
            set
            {
                vertice_1 = value;
            }
        }

        public float[] Vertice_2
        {
            get
            {
                return vertice_2;
            }
            set
            {
                vertice_2 = value;
            }
        }

        public float[] Vertice_3
        {
            get
            {
                return vertice_3;
            }
            set
            {
                vertice_3 = value;
            }
        }

        public float[] Vertice_4
        {
            get
            {
                return vertice_4;
            }
            set
            {
                vertice_4 = value;
            }
        }

        public abstract double CalcularArea();

        public double CalcularDistancia(float[] punto1, float[] punto2)
        {
            return Math.Sqrt(Math.Pow(punto2[0] - punto1[0], 2) + Math.Pow(punto2[1] - punto1[1], 2));
        }
    }
}
