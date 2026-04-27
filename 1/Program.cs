//Registro de temperaturas por zonas
//Solicite al usuario la cantidad de zonas (filas) y la cantidad de días (columnas).//
//Luego, permita ingresar las temperaturas registradas y muestre la información en forma de tabla organizada.
Console.WriteLine("Ingrese la cantidad de zonas filas");
int zonas  = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de dias ");
int dias = int.Parse(Console.ReadLine());

double[,] temperaturas = new double[zonas, dias];
for (int i = 0; i < zonas; i++)
{
	for (int j = 0; j < dias; j++)
	{
		Console.Write($"Ingrese la temperatura de la zona: {i + 1}, día {j + 1} ");
		temperaturas[i, j] = double.Parse(Console.ReadLine());
	}
}
Console.WriteLine("Tabla de temperaturas");

Console.Write("Zona:Día");
for (int j = 0; j < dias; j++)
{
	Console.Write($"Día {j + 1}");
}
Console.WriteLine();

for (int i = 0; i < zonas; i++)
{
	Console.Write($"Zona {i + 1}");
	for (int j = 0; j < dias; j++)
	{
		Console.Write($"{temperaturas[i, j]} ");
	}
	Console.WriteLine();
}


		
























