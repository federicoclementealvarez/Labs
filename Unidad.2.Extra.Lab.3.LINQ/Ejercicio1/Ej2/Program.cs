using System.Security.Cryptography;
using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> lista = new List<int>();
        Boolean flag=false;
        do
        {
            Console.WriteLine("Ingrese un número:");
            lista.Add(int.Parse(Console.ReadLine()));
            Console.WriteLine("¿Desea seguir? S(<<Enter>>)/N ");
            if(Console.ReadLine()=="N") flag=true;
            Console.WriteLine();
        } while (!flag);

        var mostrables = from num in lista where num>20 select num;
        foreach (var num in mostrables) Console.WriteLine(num);
        //foreach (int num in lista) { if (num > 20) Console.WriteLine(num); }

    }
}