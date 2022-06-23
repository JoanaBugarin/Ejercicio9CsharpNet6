using Ejercicio9CsharpNet6;

Cuadrado cuadrado = new Cuadrado(2, 5, 7, 9, 11, 14, 13, 6);
Console.WriteLine(cuadrado.calcularArea());

Rectangulo rectangulo = new Rectangulo(2, 5, 7, 6, 1, 2, 4, 3);
Console.WriteLine(rectangulo.calcularArea());

Trapecio trapecio = new Trapecio(1, 2, 3, 4, 5, 6, 13, 6);
Console.WriteLine(trapecio.calcularArea());
