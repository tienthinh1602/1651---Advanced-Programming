namespace ASM
{
    class Arm  : IWorkout
    {
        private int DumbbellCurl { get; set;}
        private int OverheadTricepExtension { get; set; }
        private int CableTricepsPushdown  { get; set; }

        public Arm()
        {
            this.DumbbellCurl = 8;
            this.OverheadTricepExtension = 8;
            this.CableTricepsPushdown  = 10;
        }

        public void IncreaseReps()
        {
            this.DumbbellCurl += 2;
            this.OverheadTricepExtension += 2;
            this.CableTricepsPushdown += 2;
        }
        public void ReduceReps()
        {
            this.DumbbellCurl -= 2;
            this.OverheadTricepExtension -= 2;
            this.CableTricepsPushdown -= 2;
        }
        public string PrintWorkout()
        {
            return  "Dumbbell Curl: "+ this.DumbbellCurl + 
                    "\nOverhead Tricep Extension: " + this.OverheadTricepExtension +  
                    "\nCable Triceps Pushdown: " + this.CableTricepsPushdown ;
        }
    }
}