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

            if (trapecio.EsUnCuadrilatero("TRAPECIO"))
                Console.WriteLine($"El Area del TRAPECIO es: {trapecio.CalcularArea()}");
            else
                Console.WriteLine("Los puntos ingresados no corresponden a un TRAPECIO");

            break;

        case 2:
            Console.WriteLine("############### RECTANGULO ###############");
            var rectangulo = new Rectangulo();

            Console.WriteLine("Ingrese los Vertices del RECTANGULO:");
            cargarPuntos(rectangulo);

            if (rectangulo.EsUnCuadrilatero("RECTANGULO"))
                Console.WriteLine($"El Area del RECTANGULO es: {rectangulo.CalcularArea()}");
            else
                Console.WriteLine("Los puntos ingresados no corresponden a un RECTANGULO...");

            break;

        case 3:
            Console.WriteLine("############### CUADRADO ###############");
            var cuadrado = new Cuadrado();

            Console.WriteLine("Ingrese los Vertices del CUADRADO:");
            cargarPuntos(cuadrado);

            if (cuadrado.EsUnCuadrilatero("CUADRADO"))
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
