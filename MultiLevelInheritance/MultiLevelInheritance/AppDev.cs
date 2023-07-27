using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    //public class AppDev:Developer,Employee //Error Multiple base class are not allowed
    //{
    //}
    public class AppDev:Developer
    {
        string osType;

        public AppDev()
        {
            Console.WriteLine("App Developer constructor");
            osType = "UnKnown";
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("OS Type: "+osType);
        }

        public override void Register()
        {
            base.Register();
            Console.WriteLine("Enter OS Type: ");
            osType = Console.ReadLine();    
        }
    }
}

//Multilevel Inheritance
//Multiple
//Sealed Class
//Sealed Method

