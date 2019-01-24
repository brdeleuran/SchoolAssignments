using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValutaOmregner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an amount in DKK :");
            double DKK = double.Parse(Console.ReadLine());

            double USD = DKK / 6.57;
            double GBP = DKK / 8.56;
            double EU = DKK / 7.47;
            double SKK = DKK / 0.73;

            Console.WriteLine(DKK + " DKK is " + USD + " in US dollars");
            Console.WriteLine(DKK + " DKK is " + GBP +" in Pound Sterling");
            Console.WriteLine(DKK + " DKK is " + EU +" in Euros");
            Console.WriteLine(DKK + " DKK is " + SKK +" in Swedish kroner");
            Console.ReadKey();
        }
    }
}
