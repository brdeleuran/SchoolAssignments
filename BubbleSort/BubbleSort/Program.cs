using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Method();
            
            Console.ReadKey();

        }

        static void Method()
        {
            int[] array = new int[99]; //Establishes an array
            Random randomNum = new Random(); //Establishes a random generator

            for (int i = 0; i < array.Length; i++) //Uses the random generator to fill the array
            {
                int j = randomNum.Next(0, 500);
                array[i] = j;
                Console.WriteLine(array[i]);
            }

            Console.WriteLine();
            for (int j = 0; j < array.Length; j++) //Sorts the array with BubbleSort
            {
                for (int k = 0; k < (array.Length-1) - j; k++)
                {
                    if (array[k] > array[k + 1])
                    {
                        int temp = array[k + 1];
                        array[k + 1] = array[k];
                        array[k] = temp;
                    }

                }
                Console.WriteLine(array[j]);
            }

            Console.WriteLine();

            Array.Reverse(array); //Reverses the order of the array

            for (int l = 0; l < array.Length; l++) //Prints the array
            {
                Console.WriteLine(array[l]);
            }
        }
    }
}
