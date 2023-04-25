internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el año a analizar:");
        int num = int.Parse(Console.ReadLine());
        Boolean bisiesto;
        if (num%4==0) { 
            if (num%100!=0) { 
                bisiesto=true;
            }
            else if (num%400 == 0)
            {
                bisiesto=true;
            }
            else
            {
                bisiesto = false;
            }
        }
        else
        {
            bisiesto=false;
        }
        if (bisiesto)
        {
            Console.WriteLine("El año "+num+" es bisiesto");
        }
        else
        {
            Console.WriteLine("El año " + num + " no es bisiesto");
        }
    }
}