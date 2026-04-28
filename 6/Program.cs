//Ejercicio 6 – Asistencia de estudiantes
//Se desea registrar la asistencia de estudiantes durante varios días (1 = asistió, 0 = no asistió).

//Solicite la cantidad de estudiantes y días.
// Luego de llenar la matriz, permita seleccionar un estudiante y muestre su registro completo de asistencia.
Console.Write("Ingrese la cantidad de estudiantes: ");
int estudiantes = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de días: ");
int dias = int.Parse(Console.ReadLine());

int[,] asistencia = new int[estudiantes, dias];
for (int i = 0; i < estudiantes; i++)
{
	Console.WriteLine($"Estudiante {i + 1}:");
	for (int j = 0; j < dias; j++)
	{
		Console.Write($"Día {j + 1} (1=Asistió, 0=No asistió): ");
		asistencia[i, j] = int.Parse(Console.ReadLine());
	}
