namespace Homework
{
    class Rectangle : Shape
    {
        public virtual double Width{get; set;}
        public virtual double Length{get; set;}

        public Rectangle()
        {
            this.Width = 1.0;
            this.Length = 1.0;
        }

        public Rectangle(double width, double length)
        {
            this.Width = width;
            this.Length = length;
        }

        public Rectangle(double width, double length, string color, bool filled)
        {
            this.Width = width;
            this.Length = length;
            this.Color = color;
            this.Filled = filled;
        }

        public double GetArea()
        {            
            return Width*Length;
        }

        public double GetPerimeter()
        {            
            return (Width+Length)*2;
        }

        public override string ToString()
        {
            return "\nA Rectangle with width = " + this.Width + " and length = " + this.Length + ", which is subclass of " + base.ToString();
        }
    }
}