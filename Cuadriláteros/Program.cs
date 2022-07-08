// Clase 16: Ejercicio - Cuadriláteros
// Gerardo Fabián Quispe

/*  Diseñe la siguiente jerarquía para las clases:
        Cuadrilátero.
        Trapecio.
        Rectángulo.
        Cuadrado.

    Use la clase Cuadrilátero como la clase base de la jerarquía, 
    que debe ser abstracta.

    Los datos privados de la clase base deben ser las coordenadas 
    x-y de los cuatro vértices de la figura y debe contener un 
    método abstracto para calcular el área.

    Agregue un constructor a cada clase para inicializar sus datos 
    e invoque el constructor de la clase base desde el constructor 
    de cada clase derivada.

    Escriba un programa que instancie objetos de cada una de las 
    clases y calcule el área correspondiente.

    Investigue las fórmulas para calcular el área de cada figura.
 */

using Cuadriláteros.Modelo;

// Trapecio
//Trapecio trapecio1 = new Trapecio();
//trapecio1.Vertice_1[0] = 0;
//trapecio1.Vertice_1[1] = 0;
//trapecio1.Vertice_2[0] = 1;
//trapecio1.Vertice_2[1] = 3;
//trapecio1.Vertice_3[0] = 3;
//trapecio1.Vertice_3[1] = 3;
//trapecio1.Vertice_4[0] = 4;
//trapecio1.Vertice_4[1] = 0;

//Console.WriteLine($"El Area del Trapecio es {trapecio1.CalcularArea()}");
//Console.WriteLine();

// Rectangulo
//Rectangulo rectangulo1 = new Rectangulo();
//rectangulo1.Vertice_1[0] = 0;
//rectangulo1.Vertice_1[1] = 0;
//rectangulo1.Vertice_2[0] = 0;
//rectangulo1.Vertice_2[1] = 3;
//rectangulo1.Vertice_3[0] = 4;
//rectangulo1.Vertice_3[1] = 3;
//Console.WriteLine($"El Area del Rectangulo es {rectangulo1.CalcularArea()}");
//Console.WriteLine();

// Cuadrado
//Cuadrado cuadrado1 = new Cuadrado();
//cuadrado1.Vertice_1[0] = 0;
//cuadrado1.Vertice_1[1] = 0;
//cuadrado1.Vertice_2[0] = 0;
//cuadrado1.Vertice_2[1] = 3;
//Console.WriteLine($"El Area del Cuadrado es {cuadrado1.CalcularArea()}");

int opc;

do
{
    Console.WriteLine(@"############### CUADRILATEROS ###############
    1. Area del TRAPECIO.
    2. Areea del RECTANGULO.
    3. Area del CUADRADO.
    4. SALIR.");
    Console.Write("Eliga una opcion: ");
    opc = int.Parse(Console.ReadLine());
    Console.Clear();
    switch (opc)
    {
        case 1:
            var trapecio = new Trapecio();

            Console.WriteLine("############### TRAPECIO ###############");
            Console.WriteLine("Ingrese los Vertices del TRAPECIO:");
            cargarPuntos(trapecio);

            if (trapecio.EsUnCuadrilatero())
                Console.WriteLine($"El Area del TRAPECIO es: {trapecio.CalcularArea()}");
            else
                Console.WriteLine("Los puntos ingresados no corresponden a un TRAPECIO");

            break;

        case 2:
            Console.WriteLine("############### RECTANGULO ###############");
            var rectangulo = new Rectangulo();

            Console.WriteLine("Ingrese los Vertices del RECTANGULO:");
            cargarPuntos(rectangulo);

            if (rectangulo.EsUnCuadrilatero())
                Console.WriteLine($"El Area del RECTANGULO es: {rectangulo.CalcularArea()}");
            else
                Console.WriteLine("Los puntos ingresados no corresponden a un RECTANGULO...");

            break;

        case 3:
            Console.WriteLine("############### CUADRADO ###############");
            var cuadrado = new Cuadrado();

            Console.WriteLine("Ingrese los Vertices del CUADRADO:");
            cargarPuntos(cuadrado);

            if (cuadrado.EsUnCuadrilatero())
                Console.WriteLine($"El Area del CUADRADO es: {cuadrado.CalcularArea()}");
            else
                Console.WriteLine("Los puntos ingresados no corresponden a un CUADRADO...");

            break;
        case 4:
            Console.WriteLine("############### SALIENDO ###############");
            break;
        default:
            Console.WriteLine("Opcion no valida...");
            break;
    }
} while (opc != 4);

static void cargarPuntos(Cuadrilatero cuadrilatero)
{
    Console.WriteLine("Vertice 1:");
    Console.Write("Coordenas X: ");
    cuadrilatero.Vertice_1[0] = int.Parse(Console.ReadLine());
    Console.Write("Coordenas Y: ");
    cuadrilatero.Vertice_1[1] = int.Parse(Console.ReadLine());

    Console.WriteLine("Vertice 2:");
    Console.Write("Coordenas X: ");
    cuadrilatero.Vertice_2[0] = int.Parse(Console.ReadLine());
    Console.Write("Coordenas Y: ");
    cuadrilatero.Vertice_2[1] = int.Parse(Console.ReadLine());

    Console.WriteLine("Vertice 3:");
    Console.Write("Coordenas X: ");
    cuadrilatero.Vertice_3[0] = int.Parse(Console.ReadLine());
    Console.Write("Coordenas Y: ");
    cuadrilatero.Vertice_3[1] = int.Parse(Console.ReadLine());

    Console.WriteLine("Vertice 4:");
    Console.Write("Coordenas X: ");
    cuadrilatero.Vertice_4[0] = int.Parse(Console.ReadLine());
    Console.Write("Coordenas Y: ");
    cuadrilatero.Vertice_4[1] = int.Parse(Console.ReadLine());
}
