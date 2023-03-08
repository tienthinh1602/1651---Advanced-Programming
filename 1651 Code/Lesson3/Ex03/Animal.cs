namespace Homework
{
    abstract class Animal
    {
        public int Legs {get; }
       

        protected Animal(int legs)
        {
            this.Legs = legs;
        }   

        public virtual void Walk()
        {
            Console.WriteLine("Walk");
        }  

        public abstract void Eat();

    }    

}