using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowingExample
{
    internal class Program
    {

        static int myVar = 15;
        static void Main(string[] args)
        {
            int myVar = 10;
            Console.WriteLine("inner myVarid:\t"+myVar);
            Console.WriteLine("outer myvar is:\t"+Program.myVar);
            Display();
            Console.ReadKey();
        }
        public static void Display()
        {
            //int myVar = 25;
            Console.WriteLine("value of local myVar in Display"+myVar);
            Console.WriteLine("Global Variable value is "+Program.myVar);
        }
    }
}
