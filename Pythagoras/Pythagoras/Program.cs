using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pythagoras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a second number: ");
            double b = double.Parse(Console.ReadLine());

            double c2 = ((a * a) + (b * b));
            double c = Math.Sqrt(c2);

            Console.WriteLine(a + "² + " + b + "² = " + c2);
            Console.WriteLine("c = " + c);

            Console.WriteLine("");

            if (a < b)
                Console.WriteLine(b);
            else
                Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}
