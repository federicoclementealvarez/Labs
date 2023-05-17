using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Clases
{
    internal class JugadaAyuda : Jugada
    {
        public JugadaAyuda(int maxNumero) : base(maxNumero){ }

        new public void comparar(int numIngresado)
        {
            _intentos++;
            if (numIngresado == _numero) _adivino = true;
            else
            {
                if (numIngresado > _numero) Console.Write("El número buscado es menor y ");
                else Console.Write("El número buscado es mayor y ");
                if (Math.Abs(numIngresado - _numero) > 50) Console.WriteLine("está lejos.");
                else if (Math.Abs(numIngresado - _numero) > 15 && Math.Abs(numIngresado - _numero) <= 50) Console.WriteLine("está a una distancia media.");
                else if (Math.Abs(numIngresado - _numero) <= 15) Console.WriteLine("está cerca.");
            }
        }

    }
}
