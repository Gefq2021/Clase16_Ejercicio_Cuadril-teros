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
            vertice_1 = new float[2] {0, 0};
            vertice_2 = new float[2] { 0, 0 };
            vertice_3 = new float[2] { 0, 0 };
            vertice_4 = new float[2] { 0, 0 };
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

        // Calculamos la distancia entre dos puntos del plano.
        public double CalcularDistancia(float[] punto1, float[] punto2)
        {
            return Math.Sqrt(Math.Pow(punto2[0] - punto1[0], 2) + Math.Pow(punto2[1] - punto1[1], 2));
        }

        // Comprobamos si los puntos Ingresados forman un Cuadrilatero.
        // En este caso serian Trapecio, Rectangulo y Cuadrado
        public bool EsUnCuadrilatero()
        {
            List<float[]> vertices = new List<float[]>() { Vertice_1, Vertice_2, Vertice_3, Vertice_4 };
            List<float> puntos = new List<float>();

            if (true)
            {

            }

            return true;
        }
        
        // Creamos una lista con los lados generados por las coordenadas
        // de los puntos ingresados 
        private List<double> CalcularLados(List<float[]> puntos)
        {
            List<double> Lados = new List<double>();

            Lados.Add(CalcularDistancia(puntos[0], puntos[1]));
            Lados.Add(CalcularDistancia(puntos[1], puntos[2]));
            Lados.Add(CalcularDistancia(puntos[2], puntos[3]));
            Lados.Add(CalcularDistancia(puntos[3], puntos[0]));

            return Lados;
        }

        // Creamos una lista con las pendientes de las rectas formadas
        // por los puntos ingresados
        private List<float> CalcularPendiente(List<float[]> vertices)
        {
            List<float> puntos = new List<float>();

            puntos.Add(Pendiente(vertices[0], vertices[1]));
            puntos.Add(Pendiente(vertices[1], vertices[2]));
            puntos.Add(Pendiente(vertices[2], vertices[3]));
            puntos.Add(Pendiente(vertices[3], vertices[0]));

            return puntos;
        }

        // Calculamos la pendiente de la recta entre dos puntos.
        private float Pendiente(float[] p1, float[] p2)
        {

            float m = ((p2[1] - p1[1]) / (p2[0] - p1[0]));

            return m;
        }

        // Eliminamos los elementos repetidos de una coleccion
        private void EliminarRepetidos(List<double> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = i + 1; j < lista.Count; j++)
                {
                    if (lista[i] == lista[j])
                    {
                        lista.Remove(lista[j]);
                    }
                }
            }
        }
    }
}
