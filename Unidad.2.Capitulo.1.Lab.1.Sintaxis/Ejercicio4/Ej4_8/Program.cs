
internal class Program
{
    private static void Main(string[] args)
    {
        string pass = "password123";
        int intentos = 0;
        Boolean acierto = false;
        while (intentos < 4 && acierto == false)
        {
            intentos++;
            Console.WriteLine("Intento número "+intentos+":");
            Console.WriteLine("Ingrese la contraseña: ");
            string passIngresada = Console.ReadLine();
            if (passIngresada == pass)
            {
                Console.WriteLine("Contraseña correcta");
                Console.WriteLine();
                acierto = true;
            }
            else
            {
                Console.WriteLine("Contraseña incorrecta. Oprima cualquier tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }
        }
        Console.WriteLine("Finalizando...");
        Console.WriteLine();
        Console.ReadKey();
    }
}