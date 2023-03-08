/*
 * A test driver for the Point2D and Point3D classes
 */
namespace Homework
{
    public class TestPoint2DPoint3D {
    public static void Main(String[] args) {
        
        /* Test Point2D */
        // Test constructors and toString()
        Point2D p2a = new Point2D(1, 2);
        Console.WriteLine();
        Console.WriteLine(p2a);  // toString()
        Point2D p2b = new Point2D();  // default constructor
        Console.WriteLine(p2b);
        Console.WriteLine();

        // Test Setters and Getters
        p2a.X = 3;  // Test setters
        p2a.Y = 4;
        Console.WriteLine(p2a);  // toString()
        Console.WriteLine("X is: " + p2a.X);
        Console.WriteLine("Y is: " + p2a.Y);
        Console.WriteLine();

        /* Test Point3D */
        // Test constructors and toString()
        Point3D p3a = new Point3D(11, 12, 13);
        Console.WriteLine(p3a);  // toString()
        Point2D p3b = new Point3D();  // default constructor
        Console.WriteLine(p3b);
        Console.WriteLine();

        // Test Setters and Getters
        p3a.X = 21;  // in baseclass
        p3a.Y = 22;  // in baseclass
        p3a.Z = 23;  // in this class
        Console.WriteLine(p3a);  // toString()
        Console.WriteLine("X is: " + p3a.X);  // in baseclass
        Console.WriteLine("Y is: " + p3a.Y);  // in baseclass
        Console.WriteLine("Z is: " + p3a.Z);  // in this class
        Console.WriteLine();
    }
    }
}

