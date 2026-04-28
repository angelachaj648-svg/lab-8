//Ejercicio 2 – Ventas de productos por día
//Un negocio desea analizar las ventas de sus productos durante la semana.

//Solicite al usuario el número de productos y el número de días
//. Luego de llenar la matriz con las cantidades vendidas, pida al usuario que indique un producto específico (fila) y muestre únicamente las ventas correspondientes a ese producto.
Console.Write("Ingrese la cantidad de productos: ");
int productos = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de días: ");
int dias = int.Parse(Console.ReadLine());

int[,] ventas = new int[productos, dias];
