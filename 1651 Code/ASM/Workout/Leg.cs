namespace ASM
{
    class Leg  : IWorkout
    {
        private int Squat { get; set;}
        private int LyingLegCurl { get; set; }
        private int LegExtention { get; set; }

        public Leg()
        {
            this.Squat = 12;
            this.LyingLegCurl = 12;
            this.LegExtention = 8;
        }
       
        public void IncreaseReps()
        {
            this.Squat += 2;
            this.LyingLegCurl += 2;
            this.LegExtention += 2;
        }
        public void ReduceReps()
        {
            this.Squat -= 2;
            this.LyingLegCurl -= 2;
            this.LegExtention -= 2;
        }
        public string PrintWorkout()
        {
            return  "Squat: " + this.Squat + 
                    "\nLying Leg Curl: " + this.LyingLegCurl +  
                    "\nLeg Extention: " + this.LegExtention;
        }
    }
}