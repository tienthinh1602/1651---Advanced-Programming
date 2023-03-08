namespace ASM
{
    public interface IWorkoutFactory
    {
        IWorkout CreateWorkout();
    }

    public class AbsWorkoutF : IWorkoutFactory
    {
        public IWorkout CreateWorkout()
        {
            var absWorkout = new Abs();
            return absWorkout;
        }
    }

    public class ArmWorkoutF : IWorkoutFactory
    {
        public IWorkout CreateWorkout()
        {
            var armWorkout = new Arm();
            return armWorkout;
        }
    }
    public class BackWorkoutF : IWorkoutFactory
    {
        public IWorkout CreateWorkout()
        {
            var backWorkout = new Back();
            return backWorkout;
        }
    }
    public class ChestWorkoutF : IWorkoutFactory
    {
        public IWorkout CreateWorkout()
        {
            var chestWorkout = new Chest();
            return chestWorkout;
        }
    }
    public class LegWorkoutF : IWorkoutFactory
    {
        public IWorkout CreateWorkout()
        {
            var legWorkout = new Leg();
            return legWorkout;
        }
    }
    public class ShoulderWorkoutF : IWorkoutFactory
    {
        public IWorkout CreateWorkout()
        {
            var shoulderWorkout = new Shoulder();
            return shoulderWorkout;
        }
    }

}