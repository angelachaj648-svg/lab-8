//Ejercicio 5 – Búsqueda de producto en inventario
//Una tienda lleva el control de productos en diferentes estantes y niveles.

//Solicite al usuario las dimensiones del inventario (filas y columnas).
// Luego de ingresar los valores (códigos o cantidades), pida un número a buscar. El sistema debe indicar si el valor existe y en qué posición se encuentra (fila y columna).
Console.Write("Ingrese el número de estudiantes: ");
int estudiantes = int.Parse(Console.ReadLine());

Console.Write("Ingrese el número de evaluaciones: ");
int evaluaciones = int.Parse(Console.ReadLine());

double[,] calificaciones = new double[estudiantes, evaluaciones];
for(int i = 0; i < estudiantes; i++)
        {
	for (int j = 0; j < evaluaciones; j++)
	{
		Console.Write($"Ingrese la calificación del estudiante {i + 1}, evaluación {j + 1}: ");
		calificaciones[i, j] = double.Parse(Console.ReadLine());
	}