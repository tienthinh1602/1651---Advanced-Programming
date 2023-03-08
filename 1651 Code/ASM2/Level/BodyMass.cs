 namespace ASM2
 {
    public interface IBodyMass{
        int Rep(Workout workout);

    }
    public class UnderWeight : IBodyMass
    {
        public int Rep(Workout workout){
            return workout.BasicRep +2;
        }
    }  
    public class HealthyWeight : IBodyMass
    {
        public int Rep(Workout workout){
            return workout.BasicRep +3;
        }
    }  
    public class OverWeight : IBodyMass
    { 
        public int Rep(Workout workout){
             return workout.BasicRep +4;
        }
    }     
 }