//Ejercicio 7 – Producción de una fábrica
//Una fábrica registra la cantidad de productos fabricados por máquina en distintos turnos.

//Solicite número de máquinas y turnos. 
//Luego de ingresar los datos, calcule la producción total de toda la fábrica.
Console.Write("Ingrese el número de máquinas: ");
int maquinas = int.Parse(Console.ReadLine());

Console.Write("Ingrese el número de turnos: ");
int turnos = int.Parse(Console.ReadLine());

int[,] produccion = new int[maquinas, turnos];
int totalProduccion = 0;
for (int i = 0; i < maquinas; i++)
{
	Console.WriteLine($"Máquina {i + 1}:");
	for (int j = 0; j < turnos; j++)
	{
		Console.Write($"Turno {j + 1}: ");
		produccion[i, j] = int.Parse(Console.ReadLine());
