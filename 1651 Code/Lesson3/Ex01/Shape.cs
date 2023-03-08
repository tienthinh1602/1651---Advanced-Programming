namespace Homework
{
    abstract class Shape
    {
        private string Color;
       

        public Shape()
        {
            this.Color = "red";
        }

        public Shape(string color)
        {
            this.Color = color;

        }        

        public abstract double GetArea();

        public override string ToString()
        {
            return "\nA shape with color of " + this.Color;
        }


    }    

}