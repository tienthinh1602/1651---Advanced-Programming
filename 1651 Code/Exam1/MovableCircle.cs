namespace Homework
{
    class MovableCircle : IMovable, MovablePoint
    {
        private int radius{get; set;}
        private MovableCircle center {get; set;}
       
        public MovableCircle()
        {
            this.x = 0;
            this.y = 0;
        }

        public MovableCircle(int x, int y, int xSpeed, int ySpeed, int radius)
        {
            this.x = x;
            this.y = y;
        }

        public void MoveUp() 
        { 
            
        }
        public void MoveDown() 
        {
           
        }
        public void MoveLeft() 
        { 
           
        }
        public void MoveRight() 
        { 
           
        }

         public override string ToString()
        {
            return "(" + this.x + "," + this.y + ")";
        }


    }    

}