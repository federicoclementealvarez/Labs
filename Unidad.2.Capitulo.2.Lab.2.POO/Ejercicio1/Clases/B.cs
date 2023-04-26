using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class B : A
    {
        public B()
        {
            nombre = "Instancia de B";
        }

        public void m4()
        {
            Console.WriteLine("Método del hijo invocado");
        }
    }
}
