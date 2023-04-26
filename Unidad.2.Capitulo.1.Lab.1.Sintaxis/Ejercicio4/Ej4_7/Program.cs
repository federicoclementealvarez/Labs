internal class Program
{
    private static void Main(string[] args)
    {
        int numero;
        string roman = "";
        Console.WriteLine("Ingrese el número a convertir: ");
        numero = int.Parse(Console.ReadLine());
        int[] numModernos = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string[] numRomanos = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        int[] sumas = new int[13];

        for (int i = 0; i < numModernos.Length; i++)
        {
            sumas[i] = SumarCantidades(ref numero, numModernos[i]);
        }

        for (int i = 0; i < numRomanos.Length; i++)
        {
            ConcatenarCantidades(ref roman, sumas[i], numRomanos[i]);
        }

        Console.WriteLine("El número convertido a romano es: " + roman);
        Console.ReadKey();
    }

    private static int SumarCantidades(ref int numero, int cantOrden)
    {
        int cont = 0;

        while (numero >= cantOrden)
        {
            numero -= cantOrden;
            cont++;
        }

        return (cont);
    }

    private static void ConcatenarCantidades(ref string roman, int cantOrden, string caracterNumOrden)
    {
        for (int i = cantOrden; i > 0; i--)
        {
            roman = roman + caracterNumOrden;
        }
    }

}