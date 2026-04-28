//Ejercicio 3 – Consumo eléctrico total
//En un edificio se registran los consumos eléctricos de diferentes apartamentos durante varios días.
//Solicite al usuario el número de apartamentos y días.
// Luego de llenar la matriz con los consumos, calcule y muestre el consumo total acumulado de todos los apartamentos.
Console.Write("Ingrese la cantidad de apartamentos: ");
int apartamentos = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de días: ");
int dias = int.Parse(Console.ReadLine());

double[,] consumo = new double[apartamentos, dias];
double total = 0;
for (int i = 0; i < apartamentos; i++)
{
	for (int j = 0; j < dias; j++)
	{
		Console.Write($"Ingrese el consumo del apartamento {i + 1}, día {j + 1}: ");
		consumo[i, j] = double.Parse(Console.ReadLine());
		total += consumo[i, j];
	}
}

Console.WriteLine($"El consumo total acumulado es: {total}");





