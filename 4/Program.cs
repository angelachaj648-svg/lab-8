//Ejercicio 4 – Calificaciones más altas
//Un docente registra las calificaciones de sus estudiantes en diferentes evaluaciones.

//Solicite el número de estudiantes y evaluaciones.
// Después de llenar la matriz con las calificaciones, determine cuál es la nota más alta obtenida en todo el grupo y muéstrela.
Console.Write("Ingrese el número de estudiantes: ");
int estudiantes = int.Parse(Console.ReadLine());

Console.Write("Ingrese el número de evaluaciones: ");
int evaluaciones = int.Parse(Console.ReadLine());

double[,] calificaciones = new double[estudiantes, evaluaciones];
for (int i = 0; i < estudiantes; i++)
{
	for (int j = 0; j < evaluaciones; j++)
	{
		Console.Write($"Ingrese la calificación del estudiante {i + 1}, evaluación {j + 1}: ");
		calificaciones[i, j] = double.Parse(Console.ReadLine());
	}
}
double notaMaxima = calificaciones[0, 0];

for (int i = 0; i < estudiantes; i++)
{
	for (int j = 0; j < evaluaciones; j++)
	{
		if (calificaciones[i, j] > notaMaxima)
		{
			notaMaxima = calificaciones[i, j];