using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public class Employee
    {
        int ID;
        string Name;
        public Employee()
        {
            Console.WriteLine("Employee Constructor");
            ID = -1;
            Name = "not given";
        }

        public virtual void Display()
        {
            Console.WriteLine("ID:\t"+ID);
            Console.WriteLine("Name:\t"+Name);
        }
        
        public virtual void Register()
        {
            Console.WriteLine("Enter ID");
            ID = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            Name = Console.ReadLine();

        }
    }
}
