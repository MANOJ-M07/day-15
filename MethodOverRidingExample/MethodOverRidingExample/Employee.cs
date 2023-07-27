using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverRidingExample
{
    public class Employee
    {
        int id;
        string name;
        double sal;

        public virtual void Register()
        {
            Console.WriteLine("enter id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter sal");
            sal = double.Parse(Console.ReadLine());
        }

        public virtual void Display()
        {
            Console.WriteLine("id:"+id);
            Console.WriteLine("name:"+name);
            Console.WriteLine("salary:"+sal);
        }
    }
}
