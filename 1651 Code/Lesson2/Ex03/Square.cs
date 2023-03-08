namespace Homework
{
    class Square : Rectangle
    {
        public double Side{ get; set; }
        
        public override double Width
        { 
            get { return Side; }
            set { Side = value; }
        }
        public override double Length
        { 
            get { return Side; }
            set { Side = value;}           
        }
        public Square(double side): base(side, side)
        {
            this.Side = side; 
        }

        public override string ToString()
        {
            return "\nA Square with side = " + this.Side + ", which is subclass of " + base.ToString();
        }
    }
}