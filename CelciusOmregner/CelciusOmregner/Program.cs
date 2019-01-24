using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelciusOmregner
{
    class Program
    {
        static void Main(string[] args)
        {
            double celcius;

            Console.WriteLine("Enter degrees in Celcius: ");
            celcius = double.Parse(Console.ReadLine());

            double Reamur = celcius * 0.8;
            double Fahrenheit = celcius * 1.8 + 32;

            Console.WriteLine("Degrees in Reamur: " + Reamur);
            Console.WriteLine("Degrees in Fahrenheit: " + Fahrenheit);
            Console.ReadKey();
        }
    }
}
