namespace Geometria
{
    public class Circulo
    {
        private int m_radio;

        public int Radio {
            get => this.m_radio;
            set {
                this.m_radio = value;
            }
        }

        public double CalcularPerimetro()
        {
            return((this.m_radio)*2*Math.PI);
        }

        public double CalcularSuperficie()
        {
            return(this.m_radio*this.m_radio*Math.PI);
        }
    }
}