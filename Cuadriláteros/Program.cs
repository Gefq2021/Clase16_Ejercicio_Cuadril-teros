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
Trapecio trapecio1 = new Trapecio();
trapecio1.Vertice_1[0] = 0;
trapecio1.Vertice_1[1] = 0;
trapecio1.Vertice_2[0] = 1;
trapecio1.Vertice_2[1] = 3;
trapecio1.Vertice_3[0] = 3;
trapecio1.Vertice_3[1] = 3;
trapecio1.Vertice_4[0] = 4;
trapecio1.Vertice_4[1] = 0;

Console.WriteLine($"El Area del Trapecio es {trapecio1.CalcularArea()}");
Console.WriteLine();

// Rectangulo
Rectangulo rectangulo1 = new Rectangulo();
rectangulo1.Vertice_1[0] = 0;
rectangulo1.Vertice_1[1] = 0;
rectangulo1.Vertice_2[0] = 0;
rectangulo1.Vertice_2[1] = 3;
rectangulo1.Vertice_3[0] = 4;
rectangulo1.Vertice_3[1] = 3;
Console.WriteLine($"El Area del Rectangulo es {rectangulo1.CalcularArea()}");
Console.WriteLine();

// Cuadrado
Cuadrado cuadrado1 = new Cuadrado();
cuadrado1.Vertice_1[0] = 0;
cuadrado1.Vertice_1[1] = 0;
cuadrado1.Vertice_2[0] = 0;
cuadrado1.Vertice_2[1] = 3;
Console.WriteLine($"El Area del Cuadrado es {cuadrado1.CalcularArea()}");
