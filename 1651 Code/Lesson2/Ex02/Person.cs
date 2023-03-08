namespace Homework
{
    class Person
    {
        public string Address{ get; set; }
        public string Name{ get; set; }

        public Person()
        {
            this.Name = "";
            this.Address = "";
        }

        public override string ToString()
        {
            return "Name " + this.Name + "Address: " + this.Address;
        }

    }
}