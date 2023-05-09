using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;


namespace Geometria
{
    public class Triangulo
    {

        private float ladoBase, lado2, lado3, altura;

        public float LadoBase {
            get => this.ladoBase;
            set {
                this.ladoBase = value;
            }
        }

        public float Lado2 {
            get => this.lado2;
            set {
                this.lado2 = value;
            }
        }

        public float Lado3 {
            get => this.lado3;
            set {
                this.lado3 = value;
            }
        }

        public float Altura {
            get => this.altura;
            set {
                this.altura = value;
            }
        }

        public float CalcularPerimetro()
        {
            return(this.ladoBase+this.lado2+this.lado3);
        }

        public float CalcularSuperficie()
        {
            return ((this.ladoBase * this.altura) / 2);
        }
    }

}




