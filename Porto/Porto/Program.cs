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
            Console.WriteLine("Select country from list to send a letter or package to: ");
            int selection = int.Parse(Console.ReadLine());

            Console.ReadKey();

            Console.WriteLine("1. Package");
            Console.WriteLine("2. Letter");
            Console.WriteLine("Please select the type of mail you are sending: ");
            int typeSelect = int.Parse(Console.ReadLine());

            Console.ReadKey();

            if (typeSelect == 2)
            {
                Console.WriteLine("Please select the closest approximate weight of your letter:");
                Console.WriteLine("1. 50 gr");
                Console.WriteLine("2. 100 gr");
                Console.WriteLine("3. 250 gr");
                Console.WriteLine("4. 500 gr");
                Console.WriteLine("5. 1 kg");
                Console.WriteLine("6. 2 kg");

            }


            else if (typeSelect == 1)
            {
                Console.WriteLine("Please select the closest approximate weight of your Package:");
                Console.WriteLine("1. 50 gr");
                Console.WriteLine("2. 100 gr");
                Console.WriteLine("3. 250 gr");
                Console.WriteLine("4. 500 gr");
                Console.WriteLine("5. 1 kg");
                Console.WriteLine("6. 2 kg");
                Console.WriteLine("7. 5 kg");
                Console.WriteLine("8. 10 kg");
                Console.WriteLine("9. 15 kg");
                Console.WriteLine("10. 20 kg");
                Console.WriteLine("11. 25 kg");
                Console.WriteLine("12. 30 kg");
                Console.WriteLine("13. 35 kg");
            }

            int selectionWeight = int.Parse(Console.ReadLine());
            Console.ReadKey();

            int resultPrice = Price(typeSelect ,selection, selectionWeight);
            Console.WriteLine("Cost of sending is " + resultPrice + " DKK");
            Console.ReadKey();
        }

        public static int Price (int type ,int country, int weight)
        {
            int result = 0;

            if (country == 1)
            {
                if (type == 2)
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

                else if (type == 1)
                {
                    if (weight == 1)
                        result = 60;

                    else if (weight == 2)
                        result = 60;

                    else if (weight == 3)
                        result = 60;

                    else if (weight == 4)
                        result = 60;

                    else if (weight == 5)
                        result = 60;

                    else if (weight == 6)
                        result = 65;

                    else if (weight == 7)
                        result = 70;

                    else if (weight == 8)
                        result = 90;

                    else if (weight == 9)
                        result = 160;

                    else if (weight == 10)
                        result = 160;

                    else if (weight == 11)
                        result = 200;

                    else if (weight == 12)
                        result = 225;

                    else if (weight == 13)
                        result = 250;

                    else
                        Console.WriteLine("Please select a number from the list!");
                }
            }

            else if (country == 2)
            {
                if (type == 2)
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

                else if (type == 1)
                {
                    if (weight == 1)
                        result = 275;

                    else if (weight == 2)
                        result = 275;

                    else if (weight == 3)
                        result = 275;

                    else if (weight == 4)
                        result = 275;

                    else if (weight == 5)
                        result = 275;

                    else if (weight == 6)
                        result = 517;

                    else if (weight == 7)
                        result = 517;

                    else if (weight == 8)
                        result = 840;

                    else if (weight == 9)
                        result = 1244;

                    else if (weight == 10)
                        result = 1648;

                    else if (weight == 11)
                        result = 1648;

                    else if (weight == 12)
                        result = 1648;

                    else if (weight == 13)
                        result = 1648;

                    else
                        Console.WriteLine("Please select a number from the list!");
                }
            }

            else if (country == 3)
            {
                if (type == 2)
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

                else if (type == 1)
                {
                    if (weight == 1)
                        result = 275;

                    else if (weight == 2)
                        result = 275;

                    else if (weight == 3)
                        result = 275;

                    else if (weight == 4)
                        result = 275;

                    else if (weight == 5)
                        result = 275;

                    else if (weight == 6)
                        result = 517;

                    else if (weight == 7)
                        result = 517;

                    else if (weight == 8)
                        result = 840;

                    else if (weight == 9)
                        result = 1244;

                    else if (weight == 10)
                        result = 1648;

                    else if (weight == 11)
                        result = 1648;

                    else if (weight == 12)
                        result = 1648;

                    else if (weight == 13)
                        result = 1648;

                    else
                        Console.WriteLine("Please select a number from the list!");
                }
            }

            else
                Console.WriteLine("Please select a number from the list!");

            return result;
        }
    }
}
