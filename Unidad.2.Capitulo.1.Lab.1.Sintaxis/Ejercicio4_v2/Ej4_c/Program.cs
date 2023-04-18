using System;

namespace Lbo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero de filas");
            int filas = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int cantEstrellitas = 1, totalEstrellitas = 1 + 2 * (filas - 1);
            for (int i = 1; i <= filas; i++)
            {
                blanco(totalEstrellitas, cantEstrellitas);
                estrellita(cantEstrellitas);
                blanco(totalEstrellitas, cantEstrellitas);
                cantEstrellitas += 2;
                Console.WriteLine();
            }
        }

        static void estrellita(int cantEstrellitas)
        {
            for (int j = 1; j <= cantEstrellitas; j++)
            {
                Console.Write("*");
            }
        }

        static void blanco(int totalEstrellitas, int cantEstrellitas)
        {
            int diferenciaEstrellitas = totalEstrellitas - cantEstrellitas;
            for (int j = 1; j <= (diferenciaEstrellitas / 2); j++)
            {
                Console.Write(" ");
            }
        }
    }
}