using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryOOP
{
    public class Square
    {
        private double side;
        private double side1;
        private double side2;
        private double side3;
        private double angle;
        public double Side { get { return side; } set { side = value; } }
        public double Side1 { get { return side1; } set { side1 = value; } }

        public double Side2 { get { return side2; } set { side2 = value; } }

        public double Side3 { get { return side3; } set { side3 = value; } }

        public double Angle { get { return angle; } set { angle = value; } }
        public Square()
        {

        }
        public Square(double side)
        {
            this.side = side;
        }

        public virtual double Perimeter()
        {
            double perimeter = side * 4;
            return perimeter;
        }

        public virtual double Area()
        {
            double area = side * side;
            return area;
        }
    }
}
