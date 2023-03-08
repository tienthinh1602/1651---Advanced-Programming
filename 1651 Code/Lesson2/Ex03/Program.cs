using System;
namespace Homework
{
    class testex03
    {
        public static void Main(String[] args)
        {     
            // Shape heart = new Shape();     
            // Console.WriteLine(heart); 
            // Shape tree = new Shape("green", true); 
            // Console.WriteLine(tree);             

            // Circle circle = new Circle(1.5, "yellow", false);                     
            // Console.WriteLine(circle);
            // Console.WriteLine("Area of shape = " + circle.GetArea());
            // Console.WriteLine("Perimeter of shape = " + circle.GetPerimeter());
            // Console.WriteLine(); 

            // Rectangle rectangle = new Rectangle(8, 6, "orange", false);            
            // Console.WriteLine(rectangle);
            // Console.WriteLine("Area of shape = " + rectangle.GetArea());
            // Console.WriteLine("Perimeter of shape = " + rectangle.GetPerimeter());
            // Console.WriteLine(); 

            Square square = new Square(2);            
            Console.WriteLine("\nArea of shape = " + square.GetArea());
            Console.WriteLine("Perimeter of shape = " + square.GetPerimeter());

            square.Side = 3;
            Console.WriteLine("\nArea of shape = " + square.GetArea());
            Console.WriteLine("Perimeter of shape = " + square.GetPerimeter());

            square.Length = 4;
            Console.WriteLine("\nArea of shape = " + square.GetArea());
            Console.WriteLine("Perimeter of shape = " + square.GetPerimeter());
            
            square.Width = 5;
            Console.WriteLine("\nArea of shape = " + square.GetArea());
            Console.WriteLine("Perimeter of shape = " + square.GetPerimeter());

            Console.WriteLine(); 

        }
    }
}