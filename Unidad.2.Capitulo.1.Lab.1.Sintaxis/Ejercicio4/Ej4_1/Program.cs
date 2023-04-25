internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el primer número entero:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número entero:");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("La suma de " + num1 + " con " + num2 + " da como resultado " + (num1 + num2) + ".");

    }
}