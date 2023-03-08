namespace ASM
{
    class Shoulder : IWorkout
    {
        private int LateralRaise { get; set; }
        private int OverheadDumbbellPress { get; set; }
        private int SideLateralRaises { get; set; }

        public Shoulder()
        {
            this.LateralRaise = 8;
            this.OverheadDumbbellPress = 10;
            this.SideLateralRaises = 10;
        }
        public void IncreaseReps()
        {
            this.LateralRaise += 2;
            this.OverheadDumbbellPress += 2;
            this.SideLateralRaises += 2;
        }
        public void ReduceReps()
        {
            this.LateralRaise -= 2;
            this.OverheadDumbbellPress -= 2;
            this.SideLateralRaises -= 2;
        }
        public string PrintWorkout()
        {
            return  "Lateral Raise: "+ this.LateralRaise + 
                    "\nOverhead Dumbbell Press: " + this.OverheadDumbbellPress +  
                    "\nSide Lateral Raises: " + this.SideLateralRaises;
        }
    }
}