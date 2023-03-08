namespace Homework
{
    class MovablePoint : IMovable
    {
        private int x ;
        private int y ;
       
        public MovablePoint()
        {
            this.x = 0;
            this.y = 0;
        }

        public MovablePoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void MoveUp() { y++; }
        public void MoveDown() { y--; }
        public void MoveLeft() { x--; }
        public void MoveRight() { x++; }

         public override string ToString()
        {
            return "(" + this.x + "," + this.y + ")";
        }


    }    

}