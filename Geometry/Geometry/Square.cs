using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Square
    {
        private double side;

        public double Side
        {
            get
            {
                return this.side;
            }
            set
            {
                this.side = value;
            }

        }

        public Square()
        {

        }

        public Square(double side)
        {
            this.side = side;
        }

        public double Perimeter()
        {
            double perimeter = side * 4;

            return perimeter;
        }

        public double Size()
        {
            double size = Math.Pow(side, 2);

            return size;
        }
    }
      
}
