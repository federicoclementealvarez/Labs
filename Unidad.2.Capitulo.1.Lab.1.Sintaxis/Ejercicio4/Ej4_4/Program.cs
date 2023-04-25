internal class Program
{
    private static void Main(string[] args)
    {
        int num = 1;
        while (num <= 100)
        {
            if (num%2== 0)
            {
                Console.Write(num+", ");
            }
            num++;
        }
        Console.WriteLine();
        Console.ReadKey();
    }
}