//Ejercicio 10 – Control de inventario por sucursal
//Una empresa tiene varias sucursales y cada una maneja distintos productos.

//Solicite número de sucursales y productos.
// Luego de llenar la matriz con cantidades, permita seleccionar una sucursal y mostrar su inventario completo.
Console.Write("Ingrese el número de sucursales: ");
int sucursales = int.Parse(Console.ReadLine());

Console.Write("Ingrese el número de productos: ");
int productos = int.Parse(Console.ReadLine());

int[,] inventario = new int[sucursales, productos];
for (int i = 0; i < sucursales; i++)
{
	Console.WriteLine($"Sucursal {i + 1}:");
	for (int j = 0; j < productos; j++)
	{
		Console.Write($"Producto {j + 1}: ");
		inventario[i, j] = int.Parse(Console.ReadLine());
	}
}
Console.Write("Ingrese el número de la sucursal a consultar: ");
int sucursalSeleccionada = int.Parse(Console.ReadLine());

if (sucursalSeleccionada < 1 || sucursalSeleccionada > sucursales)
{
	Console.WriteLine("Sucursal no válida.");
}
else
{
	Console.WriteLine($"Inventario de la sucursal {sucursalSeleccionada}:");
}
