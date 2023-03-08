namespace Homework
{
    class Shape 
    {
        public string Color;
        public bool Filled;

        public Shape() 
        {
            this.Color = "red";
            this.Filled = true;
        }

        public Shape(string color, bool filled)
        {
            this.Color = color;
            this.Filled = filled;
        }        

        public string checkFilled()
        {
            if (Filled == true)
            {
                return "filled";
            }
            else return "not filled";
        }

        public override string ToString()
        {
            return "\nA shape with color of " + this.Color + " and " + this.checkFilled();
        }


    }    

}