using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GætEtTal
{
    class Program
    {
        static void Main(string[] args)
        {
            methods();
        }

        static void methods() //Calls methods
        {
            int secretNumber = 0;
            secretNumber = createSecretNumber(secretNumber);


            check(secretNumber);
        }

        static int userInput(string question) //Checks if user input is convertible to int
        {
            Console.Write(question);
            string input;
            int result;
            input = Console.ReadLine();

            while (!int.TryParse(input, out result))
            {
                Console.Write("Whatever you wrote, cannot be accpeted, try again: ");
                input = Console.ReadLine();
            }
            return result;
        }
        static int createSecretNumber(int secretNumber) //Creates a secret number between 1 and 30 using a random generator
        {
            Random generateSecretNumber = new Random();
            secretNumber = generateSecretNumber.Next(1, 31);
            return secretNumber;
        }

        static void check(int secretNumber) //checks the user input against the secret number
        {
            int guess;
            int tries = 0;

            do
            {
                guess = userInput("Guess the number between 1 and 30 both included: ");
                Console.WriteLine();

                if (guess == secretNumber)
                {
                    Console.WriteLine("Congratulations you got it!");
                    Console.WriteLine();
                    if (tries == 1)
                        Console.WriteLine("Wow only 1 try!! Did you cheat?");
                    else if (tries > 1 && tries <= 3)
                        Console.WriteLine("In under 3 tries! But can you get it in 1?");
                    else if (tries > 3 && tries <= 5)
                        Console.WriteLine("Under 5 tries. You can do better.");
                    else if (tries > 5 && tries <= 10)
                        Console.WriteLine("Under 10 tries. You have to practice.");
                    else
                        Console.WriteLine("Over 10 tries..... Are you even trying?");
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("The secret number is higher than that");
                    tries++;
                }
                else
                {
                    Console.WriteLine("The secret number is lower than that");
                    tries++;
                }
            } while (!(guess == secretNumber));
            Console.ReadKey();
        }
    }
}
