internal class Program
{
    private static void Main(string[] args)
    {
        string[] provincias = { "Santa Fe", "Buenos Aires", "Córdoba", "Entre Ríos", "Corrientes", "Salta", "Jujuy", "Formosa", "Tucumán", "San Juan", 
                                "San Luis", "Mendoza", "La Pampa", "La Rioja", "Chaco", "Río Negro", "Santa Cruz", "Tierra del Fuego", "Neuquén",
                                "Misiones", "Santiago del Estero", "Catamarca", "Chubut"};

        var seleccionadas= from p in provincias where p[0]=='S' || p[0]=='T' select p;

        foreach (var prov in seleccionadas) Console.WriteLine(prov);
    }
}