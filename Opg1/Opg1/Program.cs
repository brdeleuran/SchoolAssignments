using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 16;
            double b = 5.1;

            Console.WriteLine(a+b);
            Console.ReadKey();

            //int c = a + b;
            //Den vil ikke compile c da den er af typen int og resultatet af a+b er et komma tal

            double d = a + b;
            //Den vil gerne compile d da den er af typen double som man skal bruge for at udskrive komma tal

            Console.WriteLine(d);
            Console.ReadKey();

        }
    }
}
