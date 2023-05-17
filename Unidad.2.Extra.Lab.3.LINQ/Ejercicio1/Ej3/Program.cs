using System.Collections;
using System.Security.Cryptography;


public static class StringExtensions
{
    public static bool ContainsCaseInsensitive(this string source, string substring)
    {
        return source.IndexOf(substring, StringComparison.OrdinalIgnoreCase) > -1;
    }
}
internal class Program
{
    public class Ciudad
    {
        private string nombre;
        private int cod;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Cod
        {
            get { return cod; }
            set { cod = value; }
        }

    }

    private static void Main(string[] args)
    {
        ArrayList ciudades = new ArrayList();
        ciudades.Add(new Ciudad{Nombre="Rosario", Cod=2000});
        ciudades.Add(new Ciudad{ Nombre = "Córdoba", Cod = 3000 });
        ciudades.Add(new Ciudad{ Nombre = "CABA", Cod = 1000 });
        ciudades.Add(new Ciudad{ Nombre = "Tucumán", Cod = 4000 });
        ciudades.Add(new Ciudad{ Nombre = "Paraná", Cod = 5000 });
        ciudades.Add(new Ciudad{ Nombre = "La Plata", Cod = 6000 });
        ciudades.Add(new Ciudad{ Nombre = "Funes", Cod = 7000 });
        ciudades.Add(new Ciudad{ Nombre = "Pueblo Esther", Cod = 8000 });
        ciudades.Add(new Ciudad{ Nombre = "Mar del Plata", Cod = 9000 });
        ciudades.Add(new Ciudad{ Nombre = "Bariloche", Cod = 10000 });


        Console.WriteLine("Ingrese una descripcion parcial del nombre: ");
        string desc = Console.ReadLine();
        Console.WriteLine();

        var ciudadesDescPar = from Ciudad c in ciudades where c.Nombre.ContainsCaseInsensitive(desc) select c;

        foreach (var c in ciudadesDescPar) Console.WriteLine(c.Cod);
    }
}