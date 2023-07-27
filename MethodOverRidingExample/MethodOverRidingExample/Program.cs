using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverRidingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("employee");
            Employee employee = new Employee();
            employee.Register();
            employee.Display();
            Console.WriteLine("Developer");
            Developer developer = new Developer();
            developer.Register();
            developer.Display();
            Console.ReadKey();  
        }
    }
}
