using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Circle
    {
        public double radius{ get; set; }

        public Circle()
        {
            this.radius = 1.0;
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }
        

        public virtual double GetArea()
        {
            double area = Math.Round((Math.PI*Math.Pow(radius,2)),2);
            return area;
        }

        public double Circumference()
        {
            double circumference = Math.PI*radius*2;
            return circumference;
        }

        public override string ToString()
        {
            return "Circle: "
                    + "Radius: " + this.radius + ", "
                    + "Area: " + this.GetArea() + ", "
                    + "Circumference: " + this.Circumference();
        }

    }
}