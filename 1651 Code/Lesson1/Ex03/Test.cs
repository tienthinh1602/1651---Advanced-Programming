using System;

namespace Homework
{
    class ex03test{
        public static void Main(String[] args)
        {
            Author ahTeck = new Author("Tan Ah Teck", "ahteck@nowhere.com", 'm'); // Test the constructor
            // Console.WriteLine();
            // Console.WriteLine(ahTeck);  // Test ToString()
            // ahTeck.Email = "paulTan@nowhere.com";  // Test setter
            // Console.WriteLine("\nName is: " + ahTeck.Name);     // Test getter
            // Console.WriteLine("Email is: " + ahTeck.Email);   // Test getter
            // Console.WriteLine("Gender is: " + ahTeck.Gender); 
            // Console.WriteLine();

            Book dummyBook = new Book("Java for dummy", ahTeck, 19.95, 99);  // Test Book's Constructor
            Console.WriteLine();
            Console.WriteLine(dummyBook);  // Test Book's ToString()
            Console.WriteLine();

            // Test Getters and Setters
            dummyBook.Price = 29.95;
            dummyBook.Qty = 28;
            Console.WriteLine("Name is: " + dummyBook.Name);
            Console.WriteLine("Price is: " + dummyBook.Price);
            Console.WriteLine("Qty is: " + dummyBook.Qty);
            Console.WriteLine("Author is: " + dummyBook.Author);  // Author's ToString()
            Console.WriteLine("Author's name is: " + dummyBook.Author.Name);
            Console.WriteLine("Author's email is: " + dummyBook.Author.Email);
            Console.WriteLine();
            
            // Use an anonymous instance of Author to construct a Book instance
            Book anotherBook = new Book("more Java", 
                new Author("Paul Tan", "paul@somewhere.com", 'm'), 29.95);
            Console.WriteLine(anotherBook);  // ToString()
            Console.WriteLine();


        }
    }
}