internal class Program
{
    private static void Main(string[] args)
    {
        int limite = 1700;
        int num1 = 0, num2 = 1, aux, acum = num1+num2;
        Console.Write(num1+", "); Console.Write(num2);
        while ((num1 + num2) <= limite)
        {
            Console.Write(", ");
            aux =num1 + num2;
            num1 = num2;
            num2 = aux;
            Console.Write(num2);
            acum += num2;
        }
        Console.WriteLine();
        Console.WriteLine("La suma de la lista mostrada da como resultado: "+ acum);
        Console.ReadKey();
    }
}