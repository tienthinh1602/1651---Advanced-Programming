namespace ASM
{
    class Abs  : IWorkout
    {
        private int Crunch { get; set; } 
        private int VerticalLegCrunch { get; set;  }
        private int ReverseCrunch { get; set; }

        public Abs()
        {
            this.Crunch = 12;
            this.VerticalLegCrunch = 12;
            this.ReverseCrunch = 12;
        }
       
        public void IncreaseReps()
        {
            this.Crunch += 2;
            this.VerticalLegCrunch += 2;
            this.ReverseCrunch += 2;
        }
        public void ReduceReps()
        {
            this.Crunch -= 2;
            this.VerticalLegCrunch -= 2;
            this.ReverseCrunch -= 2;
        }
        public string PrintWorkout()
        {
            return  "Crunch: "+ this.Crunch + 
                    "\nVertical Leg Crunch: " + this.VerticalLegCrunch +  
                    "\nReverse Crunch: " + this.ReverseCrunch;
        }
    }
}