namespace Homework
{
    class Point2D
    {
        public int X;
        public int Y;

        public Point2D()
        {
            this.X = 0;
            this.Y = 0;
        }

        public Point2D(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return "(" + this.X + "," + this.Y + ")";
        }
    }
}