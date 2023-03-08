using System;
namespace Homework
{
    class Book 
    {
        public string Name{ get; private set; }
        public Author Author{ get; private set; }
        public double Price{ get; set; }
        public int Qty{ get; set; }



        // public Book ()
        // {
        //     this.Qty = 0;            
        // }
        public Book (string name, Author author, double price)
        {
            this.Name = name;
            this.Author = author;
            this.Price = price;            
        }
        
        public Book (string name, Author author, double price, int qty)
        {
            this.Name = name;
            this.Author = author;
            this.Price = price;
            this.Qty = qty;            
        }
        

        public override string ToString()
        {
            return "Book: "
                    + "Name: " + this.Name + ", "
                    + this.Author + ", "                    
                    + "Price: " + this.Price + ", "    
                    + "Qty: " + this.Qty;
        }
    }
}