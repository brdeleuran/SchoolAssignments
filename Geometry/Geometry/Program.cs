using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Square s1 = new Square(23.5);
            Square s2 = new Square(23.5);
            Square s3 = new Square(19.55);
            Square s4 = new Square(58.12);

            Console.WriteLine(s1.Perimeter());
            Console.WriteLine(s2.Perimeter());
            Console.WriteLine(s3.Size());
            Console.WriteLine(s4.Size());
            s1.Side = 100;
            s2.Side = 200;
            s3.Side = 300;
            s4.Side = 400;
            Console.WriteLine(s1.Perimeter());
            Console.WriteLine(s2.Perimeter());
            Console.WriteLine(s3.Size());
            Console.WriteLine(s4.Size());
            Console.ReadKey();
        }
    }
}
