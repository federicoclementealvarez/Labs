using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Rectangulo : Poligono
    {
        private float lado1, lado2;

        public float Lado1 {
            get => this.lado1;
            set {
                this.lado1 = value;
            }
        }

        public float Lado2 {
            get => this.lado2;
            set {
                this.lado2 = value;
            }
        }

        public override float CalcularPerimetro()
        {
            return (this.lado1 + this.lado2)*2;
        }
    }
}