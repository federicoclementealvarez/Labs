using Clases;

internal class Program
{
    private static void Main(string[] args)
    {
        B b = new B();
        A a = new B();
        //A a2 = new A();
        a.F();
        b.F();
        //a2.F();
        a.G();
        b.G();
        //a2.G();

        Console.ReadKey();

    }
}