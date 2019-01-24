using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Denmark");
            Console.WriteLine("2. USA");
            Console.WriteLine("3. Japan");
            Console.WriteLine("Select country from list to send a letter to: ");
            int selection = int.Parse(Console.ReadLine());

            Console.ReadKey();

            Console.WriteLine("Please select the closest approximate weight of your letter:");
            Console.WriteLine("1. 50 gr");
            Console.WriteLine("2. 100 gr");
            Console.WriteLine("3. 250 gr");
            Console.WriteLine("4. 500 gr");
            Console.WriteLine("5. 1 kg");
            Console.WriteLine("6. 2 kg");
            int selectionWeight = int.Parse(Console.ReadLine());


            int resultPrice = Price(selection, selectionWeight);
            Console.WriteLine(resultPrice);
            Console.ReadKey();
        }

        public static int Price (int country, int weight)
        {
            int result = 0;

            if (country == 1)
            {
                if (weight == 1)
                    result = 10;

                else if (weight == 2)
                    result = 20;

                else if (weight == 3)
                    result = 40;

                else if (weight == 4)
                    result = 60;

                else if (weight == 5)
                    result = 60;

                else if (weight == 6)
                    result = 60;

                else
                    Console.WriteLine("Please select a number from the list!");
            }

            else if (country == 2)
            {
                if (weight == 1)
                    result = 30;

                else if (weight == 2)
                    result = 30;

                else if (weight == 3)
                    result = 60;

                else if (weight == 4)
                    result = 90;

                else if (weight == 5)
                    result = 90;

                else if (weight == 6)
                    result = 90;

                else
                    Console.WriteLine("Please select a number from the list!");
            }

            else if (country == 3)
            {
                if (weight == 1)
                    result = 30;

                else if (weight == 2)
                    result = 30;

                else if (weight == 3)
                    result = 60;

                else if (weight == 4)
                    result = 90;

                else if (weight == 5)
                    result = 90;

                else if (weight == 6)
                    result = 90;

                else
                    Console.WriteLine("Please select a number from the list!");
            }

            else
                Console.WriteLine("Please select a number from the list!");

            return result;
        }
    }
}
