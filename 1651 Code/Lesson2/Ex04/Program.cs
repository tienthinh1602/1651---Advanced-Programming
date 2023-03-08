namespace Homework
{
    /*
    * A test driver for Shape and its subclasses
    */
    public class TestShape 
    {
        public static void Main(String[] args) {
            Shape s1 = new Rectangle("red", 4, 5);  // Upcast
            Console.WriteLine();
            Console.WriteLine(s1);  // Run Rectangle's toString()
            Console.WriteLine("Area is " + Math.Round(s1.GetArea(),2));  // Run Rectangle's getArea()
            
            Shape s2 = new Triangle("blue", 4, 5);  // Upcast
            Console.WriteLine(s2);  // Run Triangle's toString()
            Console.WriteLine("Area is " + Math.Round(s2.GetArea()),2);  // Run Triangle's getArea()
            Console.WriteLine();
        }
    }

}