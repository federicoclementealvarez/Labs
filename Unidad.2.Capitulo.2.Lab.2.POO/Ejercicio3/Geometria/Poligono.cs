using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public abstract class Poligono
        {
            protected float apotema;

            public float Apotema {
                get => this.apotema;
                set {
                    this.apotema = value;
                }
            }

            public abstract float CalcularPerimetro();
            

            public float CalcularSuperficie()
            {
                return((this.CalcularPerimetro()*this.apotema)/2);
            }
        }
}
