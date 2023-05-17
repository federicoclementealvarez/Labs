internal class Program
{
    public class Empleado
    {
        private int id;
        private string name;
        private decimal salary;

        public Empleado(int idI, string nameI, decimal salaryI)
        {
            id= idI;
            name= nameI;
            salary= salaryI;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public decimal Salary
        {
            get { return salary; }  
            set { salary = value; }
        }

        public string toString()
        {
            return ("[ID: " + id + ", Name: " + name + ", Salary: " + salary + "]");
        }
    }

    private static void Main(string[] args)
    {
        List<Empleado> lista = new List<Empleado>();
        Boolean flag = false;
        int idAcum = 0;
        do
        {
            Console.WriteLine("Nombre: ");
            string name = Console.ReadLine();
            Console.WriteLine("Salario: ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());
            idAcum++;
            Empleado emp = new Empleado(idAcum,name,salary);
            lista.Add(emp);
            Console.WriteLine();
            Console.WriteLine("Desea cargar otro empleado? S(<<Enter>>/N)");
            if(Console.ReadLine()=="N") flag = true;
            Console.WriteLine();
            Console.WriteLine();
        } while (!flag);
        Console.WriteLine();
        Console.WriteLine();
        var ascendentes = from emp in lista orderby emp.Salary ascending select emp;
        var descendentes = from emp in lista orderby emp.Salary descending select emp;
        Console.WriteLine("Ascendente:");
        foreach ( Empleado emp in ascendentes ) Console.WriteLine(emp.toString());
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Descendente:");
        foreach (Empleado emp in descendentes) Console.WriteLine(emp.toString());
    }
}