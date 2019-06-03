using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryOOP
{
    class Trapez : Square
    {
        private double s;
        private double h;

        public Trapez(double side, double side1, double side2, double side3)
        {
            this.Side = side;
            this.Side1 = side1;
            this.Side2 = side2;
            this.Side3 = side3;
        }

        public override double Area()
        {
            s = (Side + Side1 - Side2 + Side3) / 2;
            h = (2 / (Side - Side2)) * Math.Sqrt(s * (s - Side + Side2) * (s - Side1) * (s - Side3));
            double total = 0.5 * (Side + Side2) * h;
            return total;
        }
    }
}
