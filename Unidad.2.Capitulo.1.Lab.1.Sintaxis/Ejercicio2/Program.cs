namespace Lab01
{
        internal class Program
    {
        private static void Main(string[] args)
        {
            int cantIteraciones = 5;
            string[] arreglo = new string[cantIteraciones];

            for (int i = 0; i < cantIteraciones; i++)
            {
                Console.WriteLine("Ingrese el elemento número "+i+":");
                arreglo[i] = Console.ReadLine();
            }
            Console.WriteLine();
            for (int i = (cantIteraciones-1); i >= 0; i--)
            {
                Console.WriteLine("Elemento número " + i + ": " + arreglo[i]);
            }
        }
    }
}