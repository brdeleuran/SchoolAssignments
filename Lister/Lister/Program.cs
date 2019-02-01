using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lister
{
    class Program
    {
        static void Main(string[] args)
        {
            methods();
        }

        static void methods() //All methods are called and lists created
        {
            List<int> numbers = new List<int>();

            listNumbers(numbers);

            divide(numbers);

            replace(numbers);

            List<int> numbersReversed = new List<int>();

            reverse(numbers, numbersReversed);
        }

        static void listNumbers(List<int> numbers) //Outs the equal numbers between 1 and 20 in the list numbers
        {
            int i = 0;

            for (i = 2; i <= 20; i = i + 2)
            {
                numbers.Add(i);
                Console.WriteLine(i);
            }
            Console.ReadKey();
            Console.WriteLine();

            return;
        }

        static void divide(List<int> numbers) //Divides the numbers in the list numbers with 3 and removes them using modulus
        {
            int currentNumb;
            int divide;

            for (int j = 0; j < numbers.Count; j++)
            {
                currentNumb = numbers[j];
                divide = numbers[j] % 3;
                if (divide == 0)
                    numbers.Remove(currentNumb);
            }

            foreach (int lol in numbers)
            {
                Console.WriteLine(lol);
            }
            Console.ReadKey();
            Console.WriteLine();

            return;
        }

        static void replace(List<int> numbers) //Inserts the number 17 in the 3rd spot in the list numbers
        {
            int replace = 17;
            numbers.Insert(2, replace);

            foreach (int lol in numbers)
            {
                Console.WriteLine(lol);
            }
            Console.ReadKey();
            Console.WriteLine();
        }

        static void reverse(List<int> numbers, List<int> numbersReversed) //Inserts the numbers in the list numbers in reverse in to the list numbersReversed
        {
            int reversed = numbers.Count;

            for (int original = 0; original < numbers.Count; original++)
            {
                reversed--;
                numbersReversed.Add(numbers[reversed]);
            }

            foreach (int lol in numbersReversed)
            {
                Console.WriteLine(lol);
            }
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
