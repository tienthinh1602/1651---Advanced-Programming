namespace ASM
{
    class Program
    {
        public static void Main(string[] args)
        {
            // PlanTraining planTraining = new PlanTraining();
            // double a = gymer.CaculateBMI();
            // Console.WriteLine(a);
            // IWorkoutFactory workout = new UpperBodyWorkoutFactory();
            // gymer.MyWorkout = workout.CreateWorkout(16);
            // Console.WriteLine(gymer.MyWorkout.PrintWorkout());
            int selection = chooseOption();
            while (selection != 0)
            {
                Console.WriteLine("kk");
                Console.Clear();
                switch (selection)
                {
                    
                    case 1:
                        Console.WriteLine("You choose to create workouts");
                        break;
                    case 2:
                        Console.WriteLine("You choose to display today workouts");
                        break;
                    case 3:
                        Console.WriteLine("You choose to divide the workout for the days");
                        break;
                    case 4:
                        Console.WriteLine("You choose to display tomorrow workouts");
                        break;
                    case 5:
                        Console.WriteLine("You choose to change the number of reps in the workouts");
                        break;
                    case 6:
                        Console.WriteLine("You choose to change the workouts tomorrow");
                        break;    
                    default:
                        break;
                }
                selection = chooseOption();
            }

            
        }

        static public int chooseOption(){
            int choice = 0;
            Console.WriteLine();
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
    
}
