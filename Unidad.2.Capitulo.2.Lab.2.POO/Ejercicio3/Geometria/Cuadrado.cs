using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Cuadrado : Rectangulo
    {
        private float lado;

        public float Lado {
            get => this.lado;
            set {
                this.lado = value;
            }
        }

        public override float CalcularPerimetro()
        {
            return(lado*4);
        }
    }
}