namespace Clases
{
    public class A
    {
        protected string nombre;

        public A()
        {
            nombre = "Instancia sin nombre";
        }
        public A(string nomIngresado)
        {
            nombre = nomIngresado;
        }
        public string nombreInstancia
        {
            get
            {
                return (nombre);
            }
            set
            {
                nombre = value;
            }
        }

        public void mostrarNombre()
        {
            Console.WriteLine("El nombre es: " + nombre);
        }
        public void m1()
        {
            Console.WriteLine("El método M1 fue invocado");
        }
        public void m2()
        {
            Console.WriteLine("El método M2 fue invocado");
        }
        public void m3()
        {
            Console.WriteLine("El método M3 fue invocado");
        }

    }
}