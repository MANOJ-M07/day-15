using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingExample
{
    //method overloading is a concept of single class, we have same name method but 
    //methods are diff method parameter
    public class OurClass
    {//no.of parameters
       /* public void Display()
        {
            Console.WriteLine("Dispaly of our Class");
        }

        public void Display(string name)
        {
            Console.WriteLine("Welcome to display" +name);
        }
        public void Display(string fname, string lname )
        {
            Console.WriteLine("welcom to display"+fname+""+lname);
        }

        //type of parameters
        public double Add(double num1, double num2)
        {
            Console.WriteLine("Double Method Call");
            return num1+num2;
        }

        public int Add(int num1, int num2)
        {
            Console.WriteLine("int method call");
            return num1+num2;
        }

        public string Add(string fname, string lname)
        {
            Console.WriteLine("string method call");
            return fname+lname;
        }*/

        public void Increment(int num1)
        {
            num1 += 2;
            Console.WriteLine("number after increment\t"+num1);
        }

        public void Increment(ref int num1 )
        {
            num1 += 5;
            Console.WriteLine("number after increment\t"+num1);
        }
        /*public void Increment(out int num1 ) //if we are using call and ref method then the  out method can not be used there 
        {
            num1 = 120;
            Console.WriteLine("number after increment\t"+num1);
        }*/
    }
}
