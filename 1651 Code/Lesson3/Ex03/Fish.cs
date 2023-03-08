namespace Homework
{
    class Fish : Animal, Pet
    {
        public string Name{get; set;}


        public Fish() : base(0)
        {
            this.Name = "";
        }

        // public Fish(string name)
        // {

        // }

        public Fish(string name) : base(0)
        {
            this.Name = name;
        }

        public void Play()
        {
            Console.WriteLine("Fish: Play");
        }

        public override void Walk()
        {
              Console.WriteLine("Fish: Swim");
        }

        public override void Eat()
        {
                Console.WriteLine("Fish: Eat");
        }
    }
}