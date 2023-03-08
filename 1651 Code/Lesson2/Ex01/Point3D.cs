namespace Homework
{
    class Point3D :  Point2D
    {
        public int Z;

        public Point3D()
        {
            this.Z = 0;
        }

        public Point3D(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            return "(" + this.X + "," + this.Y + "," + this.Z + ")";
        }
    }
}