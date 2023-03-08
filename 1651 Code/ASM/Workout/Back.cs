namespace ASM
{
    class Back  : IWorkout
    {
        private int Deadlift { get; set;}
        private int LatPulldown { get; set; }
        private int DumbbellRow { get; set; }

        public Back()
        {
            this.Deadlift = 10;
            this.LatPulldown = 10;
            this.DumbbellRow = 12;
        }
       
        public void IncreaseReps()
        {
            this.Deadlift += 2;
            this.LatPulldown += 2;
            this.DumbbellRow += 2;
        }
        public void ReduceReps()
        {
            this.Deadlift -= 2;
            this.LatPulldown -= 2;
            this.DumbbellRow -= 2;
        }

        public string PrintWorkout()
        {
            return  "Deadlift: "+ this.Deadlift + 
                    "\nLat Pulldown: " + this.LatPulldown +  
                    "\nDumbbell Row: " + this.DumbbellRow;
        }
    }
}