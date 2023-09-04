using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Almacenamiento de datos de una canción en formato MP3");

        Console.Write("Digite la cantidad de canciones: ");
        int numCanciones = int.Parse(Console.ReadLine());

        string[] artistas = new string[numCanciones];
        string[] titulos = new string[numCanciones];
        int[] duraciones = new int[numCanciones];
        int[] tamanos = new int[numCanciones];

        Console.WriteLine("Digite los datos de las canciones:");

        for (int i = 0; i < numCanciones; i++)
        {
            Console.WriteLine($"Canción #{i + 1}:");
            Console.Write("Artista: ");
            artistas[i] = Console.ReadLine();
            Console.Write("Título: ");
            titulos[i] = Console.ReadLine();
            Console.Write("Duración (en segundos): ");
            duraciones[i] = int.Parse(Console.ReadLine());
            Console.Write("Tamaño del fichero (en KB): ");
            tamanos[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nDetalle de las canciones ingresadas:");

        for (int i = 0; i < numCanciones; i++)
        {
            Console.WriteLine($"Canción #{i + 1}:");
            Console.WriteLine($"Artista: {artistas[i]}");
            Console.WriteLine($"Título: {titulos[i]}");
            Console.WriteLine($"Duración (en segundos): {duraciones[i]}");
            Console.WriteLine($"Tamaño del fichero (en KB): {tamanos[i]}");
            Console.WriteLine();
        }
    }
}
