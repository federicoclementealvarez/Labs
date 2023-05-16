using Clases;
internal class Program
{
    private static void Main(string[] args)
    {
        Persona pers = new Persona("Juan", "Perez", 20, 44000000);
        Persona p = new Persona("Juon", "Perez", 20, 44000000);
        pers = p;
    }
}