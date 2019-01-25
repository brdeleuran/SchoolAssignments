using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgangMedLøkker
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++) //Declares the variable i and loops as long as i is less than 100 and adds 1 to i for every loop
            {
                if (i < 50) //Checks if i is less than 50 and only moves on to writeLine if it is
                    Console.WriteLine(i); //Prints i for every loop
            } //Assignment a and b

            int a = 0; //Declares the variable a and gives it te value 0
            while (a < 100) //Declares that while a is less than 100 the loop should continue
            {
                Console.WriteLine(a); //Prints a for every loop
                a++; //adds 1 to a every loop
            } // Assignment c

            for (int j = 100; j >= 0; j--) //Declares the variable j and that as long as j is larger or equal to 0 the loop should continue. Also subtracts 1 from j
            {
                Console.WriteLine(j); //Prints the value of j for every loop
            } //Assignment d
        }
    }
}
