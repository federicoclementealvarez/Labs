using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] meses = new string[] {"Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre" };
        Console.WriteLine("Ingrese el nombre del mes: ");
        string mes = Console.ReadLine();
        Boolean flag = false;
        int index = 0;
        while (flag == false && index<=11) {
            if (meses[index]==mes) {
                flag = true;
            }
            else index++;
        }
        Console.WriteLine();
        if (flag == false)
        {
            Console.WriteLine("El texto ingresado no es un mes.");
        }
        else
        {
            Console.WriteLine("Mes: " + meses[index] + "  Número: " + (index + 1)+".");
        }
        Console.ReadKey();
    }
}