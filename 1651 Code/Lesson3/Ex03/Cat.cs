namespace Homework
{
    class Cat : Animal, Pet
    {
        public string Name{get; set;}


        public Cat() : base(4)
        {
            this.Name = "";
        }
     
        public Cat(string name) : base(4)
        {
            this.Name = name;
        }

        public void Play(){
            Console.WriteLine("Cat: Play");
        }

        public override void Eat()
        {
                Console.WriteLine("Cat: Eat");
        }
    }
}