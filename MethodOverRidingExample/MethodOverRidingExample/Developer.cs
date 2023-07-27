/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverRidingExample
{
    public class Developer:Employee
    {

    }
}
*/

//example-2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverRidingExample
{
    public class Developer : Employee
    {
        string domain;
        string project;

        public override void Register()
        {
            base.Register();
            Console.WriteLine("enter domain");
            domain = Console.ReadLine();
            Console.WriteLine("enter project");
            project = Console.ReadLine();
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("domain:"+domain);
            Console.WriteLine("project:"+project);
        }

    }
}
