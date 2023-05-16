namespace Clases
{
    public class Persona
    {
        private string nombre;
        private int edad;
        private string apellido;
        private int dni;

        public Persona(string nombre, string apellido, int edad, int dni)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.apellido = apellido;
            this.dni = dni;
            Console.WriteLine("El objeto se ha creado correctamente");
        }

        public Persona()
        {
            nombre = string.Empty;
            apellido = string.Empty;
        }

        ~Persona()
        {
            Console.WriteLine("Eliminado");
        }

        public string Apellido
        {
            get => apellido;
            set
            {
                apellido = value;
            }
        }

        public int Dni
        {
            get => dni;
            set
            {
                dni = value;
            }
        }

        public int Edad
        {
            get => edad;
            set
            {
                edad = value;
            }
        }

        public string Nombre
        {
            get => nombre;
            set
            {
                nombre = value;
            }
        }

        public string getFullName()
        {
            return (nombre + apellido);
        }

        public int getAge(int añoNac, int añoActual)
        {
            return (añoActual - añoNac);
        }
    }
}