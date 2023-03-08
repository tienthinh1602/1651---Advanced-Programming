namespace ASM2 {
    public abstract class Workout
    {
        public int BasicRep{ get; set; }
        public abstract void SetRep();
    }
    public class Beginer : Workout
    {
        public override void SetRep()
        {

        }
    }
    public class Experienced : Workout
    {
        public override void SetRep()
        {

        }
    }
    public class Master : Workout
    {
        public override void SetRep()
        {

        }
    }
}