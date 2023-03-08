namespace Homework
{
    class Circle : Shape
    {
        public double Radius;

        public Circle()
        {
            this.Radius = 1.0;
        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public Circle(double radius, string color, bool filled)
        {
            this.Radius = radius;
            this.Color = color;
            this.Filled = filled;            
        }

        public double GetArea()
        {
            double area = Math.PI*Math.Pow(Radius,2);
            return area;
        }

        public double GetPerimeter()
        {
            double perimeter = Math.PI*Radius*2;
            return perimeter;
        }

        public override string ToString()
        {
            return "\nA circle with radius = " + this.Radius + ", which is subclass of " + base.ToString();
        }
    }
}