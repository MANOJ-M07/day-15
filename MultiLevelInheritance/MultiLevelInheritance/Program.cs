using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDev appDev = new AppDev();
            appDev.Register();
            appDev.Display();

            Console.WriteLine("Developer");
            Developer developer = new Developer();
            developer.Register();
            developer.Display();
            


            Console.WriteLine("Employee");
            Employee employee = new Employee();
            employee.Register();
            employee.Display();
            
            Console.ReadKey();
        }
    }
}
