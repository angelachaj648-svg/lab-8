//Ejercicio 8 – Control de puntajes en videojuego
//Un videojuego registra los puntajes de varios jugadores en diferentes niveles.

//Solicite número de jugadores y niveles. 
//Luego de llenar la matriz, determine el puntaje más alto obtenido en todo el juego.
Console.Write("Ingrese el número de jugadores: ");
int jugadores = int.Parse(Console.ReadLine());

Console.Write("Ingrese el número de niveles: ");
int niveles = int.Parse(Console.ReadLine());

int[,] puntajes = new int[jugadores, niveles];
for (int i = 0; i < jugadores; i++)
{
	Console.WriteLine($"Jugador {i + 1}:");
	for (int j = 0; j < niveles; j++)
	{
		Console.Write($"Nivel {j + 1}: ");
		puntajes[i, j] = int.Parse(Console.ReadLine());
	}
}
int puntajeMaximo = puntajes[0, 0];

for (int i = 0; i < jugadores; i++)
{
	for (int j = 0; j < niveles; j++)
	{
		if (puntajes[i, j] > puntajeMaximo)
		{
