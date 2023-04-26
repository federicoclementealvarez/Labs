using Clases;
internal class Program
{
    private static void Main(string[] args)
    {
        A varA1 = new A();
        A varA2 = new A("Instancia A2");
        B varB = new B();

        Console.WriteLine(varB.nombreInstancia);
        Console.WriteLine(varA1.nombreInstancia);
        Console.WriteLine(varA2.nombreInstancia);
        varB.mostrarNombre();
        varA1.mostrarNombre();
        varA2.mostrarNombre();
        varB.nombreInstancia = Console.ReadLine();
        Console.WriteLine(varB.nombreInstancia);
        varB.m1();
        varB.m2();
        varB.m3();
        varB.m4();
    }
}