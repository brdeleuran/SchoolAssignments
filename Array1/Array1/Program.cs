using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            Array();
        }

        /// <summary>
        /// Method that creates an array that doubles the value of the item in index nr. 5
        /// </summary>
        static void Array()
        {
            int[] numbers = new int[9];

            int i = 1;

            foreach (int variable in numbers)
            {
                numbers[variable] = i;

                if (numbers[variable] == 5)
                    numbers[variable] = i * 2;

                i++;
                Console.WriteLine(numbers[variable]);
            }
            Console.ReadKey();
        }
    }
}
