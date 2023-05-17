using Clases;
internal class Program
{
    private static void Main(string[] args)
    {
        Juego juego = new Juego();
        while (juego.comenzarJuego()) ;
        Console.WriteLine("\nFinalizando Juego...");
    }
}