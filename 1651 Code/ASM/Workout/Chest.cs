namespace ASM
{
    class Chest  : IWorkout
    {
        private int DumbbellPress { get; set; }
        private int BarbellPress { get; set;}
        private int CableCrossover { get; set; }

        public Chest()
        {
            this.DumbbellPress = 10;
            this.BarbellPress = 10;
            this.CableCrossover = 10;
        }
       
        public void IncreaseReps()
        {
            this.DumbbellPress += 2;
            this.BarbellPress += 2;
            this.CableCrossover += 2;
        }
        public void ReduceReps()
        {
            this.DumbbellPress -= 2;
            this.BarbellPress -= 2;
            this.CableCrossover -= 2;
        }
        public string PrintWorkout()
        {
            return  "Dumbbell Press: "+ this.DumbbellPress + 
                    "\nBarbell Press: " + this.BarbellPress +  
                    "\nCable Crossover: " + this.CableCrossover;
        }
    }
}