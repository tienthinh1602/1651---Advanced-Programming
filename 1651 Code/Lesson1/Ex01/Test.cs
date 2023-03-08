using System;

namespace Homework
{
    class ex01test{
        public static void Main(String[] args)
        {
            Circle circle = new Circle(5);
            Console.WriteLine("\nArea: " + Math.Round(circle.Area(),2));
            Console.WriteLine("Circumference: " +  Math.Round(circle.Circumference(),2));
            Console.WriteLine(circle);
            Console.WriteLine();
        }
    }
}
