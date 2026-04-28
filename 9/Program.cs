//Ejercicio 9 – Ubicación de un error en sistema
//Un sistema registra códigos de error en una matriz de monitoreo.

//Solicite dimensiones de la matriz y luego los valores.//
//Pida un código de error específico y determine si existe y en qué posición se encuentra.
Console.Write("Ingrese el número de filas: ");
int filas = int.Parse(Console.ReadLine());

Console.Write("Ingrese el número de columnas: ");
int columnas = int.Parse(Console.ReadLine());

int[,] matriz = new int[filas, columnas];
for (int i = 0; i < filas; i++)
{
	for (int j = 0; j < columnas; j++)
	{
		Console.Write($"Ingrese el código en [{i + 1},{j + 1}]: ");
		matriz[i, j] = int.Parse(Console.ReadLine());
		Console.Write("Ingrese el código de error a buscar: ");
		int codigo = int.Parse(Console.ReadLine());

		bool encontrado = false;

		for (int i = 0; i < filas; i++)
		{
			for (int j = 0; j < columnas; j++)
			{
				if (matriz[i, j] == codigo)
				{
					Console.WriteLine($"Código encontrado en fila {i + 1}, columna {j + 1}");
					encontrado = true;
				}
			}
		}
	}
}