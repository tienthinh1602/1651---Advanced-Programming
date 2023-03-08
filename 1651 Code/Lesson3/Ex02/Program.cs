   namespace Homework
{
    public class TestMovable 
    {
        public static void Main(String[] args) {
            IMovable m;                    
            m = new MovablePoint();
            m.MoveUp();
            m.MoveUp();
            m.MoveUp();
            m.MoveLeft();
            m.MoveLeft();
            m.MoveRight();
            m.MoveDown();
            Console.WriteLine(m);


        }
    }

}