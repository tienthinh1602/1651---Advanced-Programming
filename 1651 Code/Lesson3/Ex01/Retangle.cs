namespace Homework
{
    class Rectangle : Shape
    {
        private int Length{get;set;}
        private int Width{get;set;}

        public Rectangle (string color, int length, int width) : base(color)
        {
            this.Length = length;
            this.Width = width;
        }

        public override double GetArea()
        {
            return Length*Width;
        }

        public override string ToString()
        {
            return "Triangle[length=" + this.Length + ",width=" + this.Width + "," + base.ToString();
        }
    }
}