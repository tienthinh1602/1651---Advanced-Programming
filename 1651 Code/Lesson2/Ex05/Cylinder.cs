using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Cylinder : Circle
    {
        public double Height{ get; }

        public Cylinder()
        {
            this.Height = 1.0;
        }

         public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.Height = height;
        }

        public override double GetArea()
        {
            double area = Math.Round((2*Math.PI*radius*(radius+Height)),2);
            return area;
        }

        public double GetVolume()
        {
            double volume = Math.Round((Math.PI*Math.Pow(radius,2)*Height),2);
            return volume;
        }

        public override string ToString()
        {
            return "Cylinder["
                    + "Radius: " + this.radius + ", "
                    + "Height: " + this.Height + ", "
                    + "Area Surface: " + this.GetArea() + ", "
                    + "Volume: " + this.GetVolume() +"]";
        }

    }
}