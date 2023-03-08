using System;
namespace Homework
{
    class Author 
    {
        public string Name{ get; private set; }
        public string Email{ get; set; }
        public string Gender{ get; private set; }


        public Author (string name, string email, char gender)
        {
            this.Name = name;
            this.Email = email;
            if ( gender == 'm')
            {
                this.Gender = "Male";            
            }
            else 
            {
                this.Gender = "Female";
            }            
        }
        
        public override string ToString()
        {
            return "Author: "
                    + "Name: " + this.Name + ", "
                    + "Email: " + this.Email + ", "                    
                    + "Gender: " + this.Gender;
        }
    }
}