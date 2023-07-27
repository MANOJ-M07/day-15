using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceShapeHierarchyAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(4, 6);
            Triangle triangle = new Triangle(3, 4, 5);

            
            Console.WriteLine("\nCircle Information:");
            circle.PrintInfo();
            Console.WriteLine("\nCircle Area: " + circle.Area);
            Console.WriteLine("Circle Perimeter: " + circle.Perimeter);
            Console.WriteLine("*******************************************");

            Console.WriteLine("\nRectangle Information:");
            rectangle.PrintInfo();
            Console.WriteLine("\nRectangle Area: " + rectangle.Area);
            Console.WriteLine("Rectangle Perimeter: " + rectangle.Perimeter);
            Console.WriteLine("*******************************************");

            Console.WriteLine("\nTriangle Information:");
            triangle.PrintInfo();
            Console.WriteLine("\nTriangle Area: " + triangle.Area);
            Console.WriteLine("Triangle Perimeter: " + triangle.Perimeter);

            Console.ReadKey();
        }

    }
}

