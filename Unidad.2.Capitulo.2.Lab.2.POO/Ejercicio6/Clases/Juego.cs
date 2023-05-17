using System.ComponentModel.Design;

namespace Clases
{
    public class Juego
    {
        private int _record;

        public Juego()
        {
            _record = int.MaxValue;
        }
        public Boolean comenzarJuego()
        {
            Console.Clear();
            JugadaAyuda jugada = new JugadaAyuda(preguntarMaximo());
            do
            {
                jugada.comparar(preguntarNumero());
                if (jugada.Adivino)
                {
                    Console.WriteLine("Usted ha adivinado! El número era: " + jugada.Numero);
                    if (compararRecord(jugada.Intentos))
                    {
                        Console.WriteLine("Usted ha superado el record de intentos! Ahora el record es de un mínimo de " + _record + " intentos");
                    }
                }
                else
                {
                    Console.WriteLine("Número incorrecto. Intente de nuevo:");
                }
            } while (!jugada.Adivino);

            return (continuar());
        }

        private Boolean compararRecord(int intentos)
        {
            if (intentos < _record)
            {
                _record = intentos;
                return (true);
            }
            else return (false);
        }

        private Boolean continuar()
        {
            Console.WriteLine("¿Desea seguir jugando? S/N");
            if (Console.ReadLine()=="S") return (true);
            else return (false);
        }

        private int preguntarMaximo()
        {
            Console.WriteLine("Máximo: ");
            return (int.Parse(Console.ReadLine()));
        }

        private int preguntarNumero()
        {
            Console.WriteLine("Número: ");
            return (int.Parse(Console.ReadLine()));
        }
    }
}