using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* OurClass obj = new OurClass();
            obj.Display("Same");
            obj.Display();
            Console.WriteLine(obj.Add("Raj","kumar"));
            Console.ReadKey();*/


            //example-2

            OurClass obj = new OurClass();
            int num = 34;
            
            obj.Increment(num);
            obj.Increment(ref num);

            Console.ReadKey();  
        }
    }
}
