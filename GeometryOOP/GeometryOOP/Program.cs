using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Square> geometry = new List<Square>();

            geometry.Add(new Square(5));
            geometry.Add(new Rectangle(5, 6));
            geometry.Add(new Trapez(10, 9, 8, 9));
            geometry.Add(new Parallelogram(3, 5, 20));
            geometry.Add(new Triangle(2, 5, 6));

            for (int i = 0; i < geometry.Count; i++)
            {
                Console.WriteLine(geometry[i].Area());
                Console.WriteLine(geometry[i].Perimeter());
            }

            Console.ReadKey();
        }
    }
}
