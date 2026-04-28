//Ejercicio 5 – Búsqueda de producto en inventario
//Una tienda lleva el control de productos en diferentes estantes y niveles.

//Solicite al usuario las dimensiones del inventario (filas y columnas).
// Luego de ingresar los valores (códigos o cantidades), pida un número a buscar. El sistema debe indicar si el valor existe y en qué posición se encuentra (fila y columna).

Console.Write("Ingrese el número de filas (estantes): ");
int filas = int.Parse(Console.ReadLine());

Console.Write("Ingrese el número de columnas (niveles): ");
int columnas = int.Parse(Console.ReadLine());

int[,] inventario = new int[filas, columnas];


for (int i = 0; i < filas; i++)
{
	for (int j = 0; j < columnas; j++)
	{
		Console.Write($"Ingrese el valor en la posición [{i + 1},{j + 1}]: ");
		inventario[i, j] = int.Parse(Console.ReadLine());
	}
}
Console.Write("Ingrese el número a buscar: ");
int buscado = int.Parse(Console.ReadLine());

bool encontrado = false;

for (int i = 0; i < filas; i++)
{
	for (int j = 0; j < columnas; j++)
	{
		if (inventario[i, j] == buscado)
		{

			Console.WriteLine($"Valor encontrado en la posición: fila {i + 1}, columna {j + 1}");
			encontrado = true;
		}
	}
}

if (!encontrado)
{
	Console.WriteLine("El valor no se encuentra en el inventario.");
}



