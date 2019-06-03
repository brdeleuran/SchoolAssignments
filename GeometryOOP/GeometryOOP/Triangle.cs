using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryOOP
{
    class Triangle : Square
    {
        public Triangle(double side, double side1, double side2)
        {
            this.Side = side;
            this.Side1 = side1;
            this.Side2 = side2;
        }

        public override double Area() => 0.5 * Side * Side1;
        public override double Perimeter() => Side + Side1 + Side2;
    }
}
