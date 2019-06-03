using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryOOP
{
    class Parallelogram : Square
    {
        public Parallelogram(double side, double side1, double angle)
        {
            this.Side = side;
            this.Side1 = side1;
            this.Angle = angle;
        }
        public override double Area() => (Side * Side1) * Math.Sin(Angle);
    }
}
