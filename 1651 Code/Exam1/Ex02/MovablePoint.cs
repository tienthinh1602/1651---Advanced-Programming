namespace Homework
{
    class MovablePoint : IMovable
    {
        internal int x ;
        internal int y ;
        internal int xSpeed;
        internal int ySpeed;

       
        public MovablePoint()
        {
            this.x = 0;
            this.y = 0;
            this.xSpeed = 0;
            this.ySpeed = 0;
        }

        public MovablePoint(int x, int y, int xSpeed, int ySpeed)
        {
            this.x = x;
            this.y = y;
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;
        }

        public void MoveUp() 
        { 
            y += ySpeed; 
        }
        public void MoveDown() 
        {
            y -= ySpeed; 
        }
        public void MoveLeft() 
        { 
            x -= xSpeed; 
        }
        public void MoveRight() 
        { 
            x += xSpeed; 
        }

         public override string ToString()
        {
            return "(" + this.x + "," + this.y + ")";
        }


    }    

}