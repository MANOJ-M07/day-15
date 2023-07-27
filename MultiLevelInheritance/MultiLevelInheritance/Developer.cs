using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public class Developer:Employee
    {
        string project;
        string domain;

        public Developer()
        {
            Console.WriteLine("Developer Constructor");
            project = "not given";
            domain = "not given";
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Domain \t"+domain);
            Console.WriteLine("projects \t" +project);
        }

        public override void Register()
        {
            base.Register();
            Console.WriteLine("enter Domain");
            domain = Console.ReadLine();
            Console.WriteLine("enter project");
            project= Console.ReadLine();
        }
    }
}
