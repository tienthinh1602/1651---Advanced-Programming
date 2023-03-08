using System;
namespace Homework
{
    class Book 
    {
        public string Name{ get; private set; }
        public Author[] Author{ get; private set; }
        public double Price{ get; set; }
        public int Qty
        { 
            get;
            set ;
        }
        // public int Qty
        // { 
        //     get {return Qty;} 
        //     set { Qty = 0; } 
        // }


        public Book (string name, Author[] authors, double price)
        {
            this.Name = name;
            this.Author = authors;
            this.Price = price;
            
        }
        
        public Book (string name, Author[] authors, double price, int qty)
        {
            this.Name = name;
            this.Author = authors;
            this.Price = price;
            this.Qty = qty;            
        }
        
        public void authorNames()
        {
            foreach(var item in Author)
            {
                Console.WriteLine(item.Name);
            }
        }

        public string authorinfo()
        {
            string s = "";
            for (int i = 0; i < Author.Length; i++)
            {
                s += Author[i];
            }
            return s;
        }

        public override string ToString()
        {
            return "Book: "
                + "Name: " + this.Name 
                + this.authorinfo()                   
                + "\nPrice: " + this.Price + ", "    
                + "Qty: " + this.Qty;
        }
    }
}