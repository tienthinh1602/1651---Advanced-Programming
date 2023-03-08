namespace Homework
{
    class Shape
    {
        public string Color { get; set; }
        public Shape()
        {
            this.Color = "unknown";
        }

        public virtual double GetArea()
        {
            return 0.0;
        }

        public override string ToString()
        {
            return "Shape[color=" + this.Color + "]";
        }
    }
}