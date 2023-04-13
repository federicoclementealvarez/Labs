internal class Program
{
    private static void Main(string[] args)
    {
        int numero, miles, novecientos, quinientos, cuatrocientos, cientos, noventas, cincuentas, cuarentas, decenas, nueves, cincos, cuatros, unidades;
        string roman="";
        Console.WriteLine("Ingrese el número a convertir: ");
        numero = int.Parse(Console.ReadLine());
        miles = SumarCantidades(ref numero,1000);
        novecientos = SumarCantidades(ref numero, 900);
        quinientos = SumarCantidades(ref numero, 500);
        cuatrocientos = SumarCantidades(ref numero, 400);
        cientos = SumarCantidades(ref numero, 100);
        noventas = SumarCantidades(ref numero, 90);
        cincuentas = SumarCantidades(ref numero, 50);
        cuarentas = SumarCantidades(ref numero, 40);
        decenas = SumarCantidades(ref numero, 10);
        nueves = SumarCantidades(ref numero, 9);
        cincos = SumarCantidades(ref numero, 5);
        cuatros = SumarCantidades(ref numero, 4);
        unidades = SumarCantidades(ref numero, 1);
        Console.WriteLine(numero);
        ConcatenarCantidades(ref roman, miles, "M");
        ConcatenarCantidades(ref roman, novecientos, "CM");
        ConcatenarCantidades(ref roman, quinientos, "D");
        ConcatenarCantidades(ref roman, cuatrocientos, "CD");
        ConcatenarCantidades(ref roman, cientos, "C");
        ConcatenarCantidades(ref roman, noventas, "XC");
        ConcatenarCantidades(ref roman, cincuentas, "L");
        ConcatenarCantidades(ref roman, cuarentas, "XL");
        ConcatenarCantidades(ref roman, decenas, "X");
        ConcatenarCantidades(ref roman, nueves, "IX");
        ConcatenarCantidades(ref roman, cincos, "V");
        ConcatenarCantidades(ref roman, cuatros, "IV");
        ConcatenarCantidades(ref roman, unidades, "I");
        Console.WriteLine("El número convertido a romano es: "+roman);
    }

    private static int SumarCantidades(ref int numero,int cantOrden)
    {
        int cont=0;

       do {
            if (numero >= cantOrden)
            {
                numero -= cantOrden;
                cont++;
            }
        } while (numero >= cantOrden);

        return (cont);
    }

    private static void ConcatenarCantidades(ref string roman, int cantOrden, string caracterNumOrden)
    {
        for (int i = cantOrden;  i > 0 ; i--) {
            roman = roman+caracterNumOrden;        
        }
    }

}