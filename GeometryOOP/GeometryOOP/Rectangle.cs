using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryOOP
{
    class Rectangle : Square
    {
        public Rectangle(double side, double side1)
        {
            this.Side = side;
            this.Side1 = side1;
        }

        public override double Area() => Side * Side1;
    }
}
