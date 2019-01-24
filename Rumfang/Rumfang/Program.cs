using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumfang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast længde: ");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Indtast højde: ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Indtast bredde: ");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Rumfanget = " + (length*height*width) + " m³");
            Console.ReadKey();
        }
    }
}
