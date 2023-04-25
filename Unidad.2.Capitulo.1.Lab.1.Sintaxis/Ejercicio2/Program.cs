
using System.Net;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un texto:");
        string inputTexto = Console.ReadLine();
        if (inputTexto == "" || inputTexto == null)
        {
            Console.WriteLine("Texto no ingresado. Finalizando...");
        }
        else
        {
            Boolean flag = false;
            do
            {
                ConsoleKeyInfo opcion = election();
                Console.WriteLine();
                Console.WriteLine();
                switch (opcion.Key){
                    case (ConsoleKey.D1):
                        Console.WriteLine(inputTexto.ToUpper());
                        break;
                    case (ConsoleKey.D2):
                        Console.WriteLine(inputTexto.ToLower());
                        break;
                    case (ConsoleKey.D3):
                        Console.WriteLine("Longitud: " + inputTexto.Length);
                        break;
                    default:
                        Console.WriteLine("Finalizando...");
                        flag = true;
                        break;
            }
            } while (flag == false);
        }
        Console.ReadKey();
    }

    public static ConsoleKeyInfo election()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Menú:");
        Console.WriteLine("   (1) - Mayúsculas");
        Console.WriteLine("   (2) - Minúsculas");
        Console.WriteLine("   (3) - Cantidad de caracteres");
        Console.WriteLine("   (0) - Salir");
        Console.WriteLine("Elija una opción:");
        ConsoleKeyInfo opcion = Console.ReadKey();
        return (opcion);
    }
}