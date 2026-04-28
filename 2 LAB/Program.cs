//Ejercicio 2 – Ventas de productos por día
//Un negocio desea analizar las ventas de sus productos durante la semana.

//Solicite al usuario el número de productos y el número de días
//. Luego de llenar la matriz con las cantidades vendidas, pida al usuario que indique un producto específico (fila) y muestre únicamente las ventas correspondientes a ese producto.
Console.Write("Ingrese la cantidad de productos: ");
int productos = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de días: ");
int dias = int.Parse(Console.ReadLine());

int[,] ventas = new int[productos, dias];
for (int i = 0; i < productos; i++)
{
	for (int j = 0; j < dias; j++)
	{
		Console.Write($"Ingrese ventas del producto {i + 1}, día {j + 1}: ");
		ventas[i, j] = int.Parse(Console.ReadLine());
	}
}
Console.Write("Ingrese el número de producto que desea consultar: ");

int productoSeleccionado = int.Parse(Console.ReadLine());
if (productoSeleccionado < 1 || productoSeleccionado > productos)
{
	Console.WriteLine("Producto inválido.");
}
else
{
	Console.WriteLine($"Ventas del producto {productoSeleccionado}:");

	int fila = productoSeleccionado - 1;

	for (int j = 0; j < dias; j++)
	{
		Console.WriteLine($"Día {j + 1}: {ventas[fila, j]}");
	}
}