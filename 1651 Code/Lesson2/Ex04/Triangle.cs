namespace Homework
{
    class Triangle : Shape
    {
        private int Base{get;set;}
        private int Height{get;set;}

        public Triangle (string color, int Base, int height)
        {
            this.Color = color;
            this.Base = Base;
            this.Height = height;
        }

        public override double GetArea()
        {
            return Base*Height/2;
        }

        public override string ToString()
        {
            return "Triangle[base=" + this.Base + ",height=" + this.Height + "," + base.ToString();
        }
    }
}