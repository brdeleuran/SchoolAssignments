using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Assignment 1
//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(calculations());
//            Console.ReadKey();
//        }

//        static string calculations() //Method that calculates the result
//        {
//            Console.WriteLine("Enter first number: ");
//            int input1 = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("Enter second number: ");
//            int input2 = Convert.ToInt32(Console.ReadLine());

//            int resultAdding = input1 + input2;
//            float resultDivision = input1 / input2;
//            float resultModulus = input1 % input2;
//            double resultUplifted = Math.Pow(Convert.ToDouble(input1), Convert.ToDouble(input2));

//            string result = ("\r\n" + "Adding " + resultAdding + "\r\n" + "Division " + resultDivision + "\r\n" + "Modulus " + resultModulus + "\r\n" + "Uplifted " + resultUplifted);
//            return result;
//        }
//    }
//}
#endregion

#region Assignment 2
//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(calculations());
//            Console.ReadKey();
//        }

//        static string calculations() //Method that calculates the result using Mat.Pow
//        {
//            Console.WriteLine("Enter first number: ");
//            double input1 = Convert.ToDouble(Console.ReadLine());

//            Console.WriteLine("Enter second number: ");
//            double input2 = Convert.ToDouble(Console.ReadLine());

//            double c = Math.Pow(input1, 2) + Math.Pow(input2, 2);

//            double largestNumber = 0;

//            if (input1 < input2)
//                largestNumber = input2;
//            else
//                largestNumber = input1;

//            string result = "\r\n" + c + "\r\n" + largestNumber;

//            return result;

//        }
//    }
//}
#endregion

#region Assignment 3
//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(allowed());
//            Console.ReadKey();
//        }

//        static string allowed() //If-Else method that tests what you are allowed to do depending on your input age
//        {
//            Console.WriteLine("Enter name: ");
//            string inputName = Console.ReadLine();

//            Console.WriteLine("Enter age: ");
//            string inputAge = Console.ReadLine();

//            while (!int.TryParse(inputAge, out int result))
//            {
//                Console.WriteLine("Please enter a numeric value.");
//                Console.WriteLine("Enter age: ");
//                inputAge = Console.ReadLine();

//            }

//            int intInputAge = Convert.ToInt32(inputAge);

//            string showResult = "";

//            if (intInputAge < 3)
//                showResult = inputName + ", du må gå med ble.";

//            else if (intInputAge <= 15)
//                showResult = inputName + ", du må ingenting.";

//            else if (intInputAge <= 17)
//                showResult = inputName + ", du må drikke.";

//            else
//                showResult = inputName + ", du må stemme og køre bil.";

//            return showResult;
//        }
//    }
//}
#endregion

#region Assignment 4
//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            loop();
//        }

//        static int loop() //Udskriver en stigende liste fra 1-10
//        {
//            int i = 0;

//            for (i = 1; i <= 10; i++)
//            {
//                Console.WriteLine(i);
//            }
//            Console.ReadKey();
//            return (i);
//        }
//    }
//}
#endregion

#region Assignment 5
//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            loop();
//        }

//        static int loop() //Udskriver en faldende liste fra 10-1
//        {
//            int i = 0;

//            for (i = 10; i > 0; i--)
//            {
//                Console.WriteLine(i);
//            }
//            Console.ReadKey();
//            return (i);
//        }
#endregion

#region Assignment 7
//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            array();
//        }

//        static void array() //Method that creates an array that doubles the value of the item in index nr. 5
//        {
//            int[] numbers = new int[9];

//            int i = 1;

//            foreach (int variable in numbers)
//            {
//                numbers[variable] = i;

//                if (numbers[variable] == 5)
//                    numbers[variable] = i * 2;

//                i++;
//                Console.WriteLine(numbers[variable]);
//            }
//            Console.ReadKey();
//        }
//    }
//}
#endregion

#region Assignment 8
//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            methods();
//        }

//        static void methods() //All methods are called and lists created
//        {
//            List<int> numbers = new List<int>();

//            listNumbers(numbers);

//            divide(numbers);

//            replace(numbers);

//            List<int> numbersReversed = new List<int>();

//            reverse(numbers, numbersReversed);
//        } 

//        static void listNumbers(List<int> numbers) //Outs the equal numbers between 1 and 20 in the list numbers
//        {
//            int i = 0;

//            for (i = 2; i <= 20; i = i + 2)
//            {
//                numbers.Add(i);
//                Console.WriteLine(i);
//            }
//            Console.ReadKey();
//            Console.WriteLine();

//            return;
//        } 

//        static void divide(List<int> numbers) //Divides the numbers in the list numbers with 3 and removes them using modulus
//        {
//            int currentNumb;
//            int divide;

//            for (int j = 0; j < numbers.Count; j++)
//            {
//                currentNumb = numbers[j];
//                divide = numbers[j] % 3;
//                if (divide == 0)
//                    numbers.Remove(currentNumb);
//            }

//            foreach (int lol in numbers)
//            {
//                Console.WriteLine(lol);
//            }
//            Console.ReadKey();
//            Console.WriteLine();

//            return;
//        } 

//        static void replace(List<int> numbers) //Inserts the number 17 in the 3rd spot in the list numbers
//        {
//            int replace = 17;
//            numbers.Insert(2, replace);

//            foreach (int lol in numbers)
//            {
//                Console.WriteLine(lol);
//            }
//            Console.ReadKey();
//            Console.WriteLine();
//        } 

//        static void reverse(List<int> numbers, List<int> numbersReversed) //Inserts the numbers in the list numbers in reverse in to the list numbersReversed
//        {
//            int reversed = numbers.Count;

//            for (int original = 0; original < numbers.Count; original++)
//            {
//                reversed--;
//                numbersReversed.Add(numbers[reversed]);
//            }

//            foreach (int lol in numbersReversed)
//            {
//                Console.WriteLine(lol);
//            }
//            Console.ReadKey();
//            Console.WriteLine();
//        } 
//    }
//}
#endregion

#region Assignment 9
//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string lottoStart = "";
//            lotto(lottoStart);
//        }

//        static string lotto(string lottoStart) //Calls methods
//        {
//            int correct = 0;
//            int corrected = inputCheck(correct);

//            string winning = "";
//            lottoStart = winnings(corrected, winning);

//            return lottoStart;
//        }

//        static int inputCheck(int correct) //Checks if input numbers are within the parametres and checks them against the randomly picked numbers
//        {
//            Random r = new Random();

//            int[] userLottoNumbers = new int[7];

//            for (int i = 0; i <= userLottoNumbers.Length - 1; i++)
//            {
//                Console.WriteLine("Enter your " + i + ". number: ");
//                userLottoNumbers[i] = Convert.ToInt32(Console.ReadLine());
//            }

//            Console.WriteLine();

//            int[] lottoNumbers = new int[7];

//            for (int j = 0; j < 7; j++)
//            {
//                int winner = r.Next(1, 21);
//                lottoNumbers[j] = winner;
//                Console.WriteLine(lottoNumbers[j]);
//            }

//            Console.WriteLine();

//            Console.ReadKey();

//            for (int aK = 0; aK < 7; aK++)
//            {
//                for (int aT = 0; aT < 7; aT++)
//                {
//                    if (lottoNumbers[aK] == userLottoNumbers[aT])
//                    {
//                        correct++;
//                    }
//                }
//            }

//            return correct;
//        }

//        static string winnings(int corrected, string winning) //Outputs a string with how much the user won by checking how many correct numbers they had
//        {
//            Console.WriteLine("You had " + corrected + " numbers correct!");

//            if (corrected == 1)
//                winning = "You win 10 dollars";

//            else if (corrected == 2)
//                winning = "You win 20 dollars";

//            else if (corrected == 3)
//                winning = "You win 30 dollars";

//            else if (corrected == 4)
//                winning = "You win 40 dollars";

//            else if (corrected == 5)
//                winning = "You win 50 dollars";

//            else if (corrected == 6)
//                winning = "You win 60 dollars";

//            else if (corrected == 7)
//                winning = "You win 70 dollars";

//            else
//                winning = "You lost";

//            Console.WriteLine(winning);

//            Console.ReadKey();

//            return winning;
//        }
//    }
//}
#endregion

#region Assignment 10
//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            methods();
//        }

//        static void methods() //Calls methods
//        {
//            int secretNumber = 0;
//            secretNumber = createSecretNumber(secretNumber);


//            check(secretNumber);
//        }

//        static int userInput(string question) //Checks if user input is convertible to int
//        {
//            Console.Write(question);
//            string input;
//            int result;
//            input = Console.ReadLine();

//            while (!int.TryParse(input, out result))
//            {
//                Console.Write("Whatever you wrote, cannot be accpeted, try again: ");
//                input = Console.ReadLine();
//            }
//            return result;
//        } 
//        static int createSecretNumber(int secretNumber) //Creates a secret number between 1 and 30 using a random generator
//        {
//            Random generateSecretNumber = new Random();
//            secretNumber = generateSecretNumber.Next(1, 31);
//            return secretNumber;
//        } 

//        static void check(int secretNumber) //checks the user input against the secret number
//        {
//            int guess;
//            int tries = 0;

//            do
//            {
//                guess = userInput("Guess the number between 1 and 30 both included: ");
//                Console.WriteLine();

//                if (guess == secretNumber)
//                {
//                    Console.WriteLine("Congratulations you got it!");
//                    Console.WriteLine();
//                    if (tries == 1)
//                        Console.WriteLine("Wow only 1 try!! Did you cheat?");
//                    else if (tries > 1 && tries <= 3)
//                        Console.WriteLine("In under 3 tries! But can you get it in 1?");
//                    else if (tries > 3 && tries <= 5)
//                        Console.WriteLine("Under 5 tries. You can do better.");
//                    else if (tries > 5 && tries <= 10)
//                        Console.WriteLine("Under 10 tries. You have to practice.");
//                    else
//                        Console.WriteLine("Over 10 tries..... Are you even trying?");
//                }
//                else if (guess < secretNumber)
//                {
//                    Console.WriteLine("The secret number is higher than that");
//                    tries++;
//                }
//                else
//                {
//                    Console.WriteLine("The secret number is lower than that");
//                    tries++;
//                }
//            } while (!(guess == secretNumber));
//            Console.ReadKey();
//        } 
//    }
//}
#endregion

#region Assignment 11
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            methods();
        }

        static void methods() //Calls methods, makes a list using random and calls for user input
        {
            List<int> list1 = new List<int>();

            Random randomGen = new Random();

            for (int i = 0; i < 11; i++)
            {
                int listNumbers = randomGen.Next(1, 101);
                list1.Add(listNumbers);
            }

            string input1;
            string input2;

            int result1;
            int result2;

            Console.Write("Enter your 1. number: ");
            input1 = Console.ReadLine();
            while (!int.TryParse(input1, out result1))
            {
                Console.Write("Whatever you wrote, cannot be accpeted, try again: ");
                input1 = Console.ReadLine();
            }

            Console.Write("Enter your 2. number: ");
            input2 = Console.ReadLine();
            while (!int.TryParse(input2, out result2))
            {
                Console.Write("Whatever you wrote, cannot be accpeted, try again: ");
                input2 = Console.ReadLine();
            }

            int numb1 = result1;
            int numb2 = result2;

            int resultAdding = adding(numb1, numb2);

            int resultDivision = division(numb1, numb2);

            int resultDivisionReversed = divisionReversed(numb1, numb2);

            int listHighest = listFindHighest(list1);

            string trueOrFalse = listBool(list1);

            string averageOfList = listAverage(list1);

            string listSortedTrueFalse = listSorted(list1);

            Console.WriteLine("Adding = " + resultAdding + "\r\n" + "Divide number 1 with number 2 = " + resultDivision);
            Console.WriteLine("Divide number 2 with number 1 = " + resultDivisionReversed);
            Console.WriteLine("The highest number on the current list is: " + listHighest + "\r\n" + trueOrFalse);
            Console.WriteLine(averageOfList + "\r\n" + listSortedTrueFalse);
            Console.ReadLine();
        }

        static int adding(int numb1, int numb2) //Adds the two user input numbers
        {
            int resultAdding = numb1 + numb2;
            return resultAdding;
        }

        static int division(int numb1, int numb2) //Divides the two user input numbers
        {
            int resultDivision = numb1 / numb2;
            return resultDivision;
        }

        static int divisionReversed(int numb1, int numb2) //Divides the two user input numbers in reverse order
        {
            int resultDivisionReversed = numb2 / numb1;
            return resultDivisionReversed;
        }

        static int listFindHighest(List<int> list1) //Finds the highest number in the list
        {
            int listLength;
            int listHighest = 0;

            list1.Sort();
            listLength = list1.Count();
            listLength--;

            foreach (int i in list1)
            {
                if (i > listHighest)
                {
                    listHighest = i;
                }
            }

            return listHighest;
        }

        static string listBool(List<int> list1) //Searches for a user input number in the list
        {
            Console.Write("Please enter your search parametre: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            bool containsX = false;
            string resultBool = "";

            if (list1.Contains(userInput))
            {
                containsX = true;
            }
            else
            {
                containsX = false;
            }

            resultBool = "Does the list contain the number you specified? " + containsX;

            return resultBool;
        }

        static string listAverage(List<int> list1) //Averages the numbers in the list
        {
            int listTotal = 0;

            foreach (int j in list1)
            {
                listTotal = listTotal + j;
            }

            int average = listTotal / list1.Count;
            string listAverage = "The average number of the current list is: " + average;

            return listAverage;
        }

        static string listSorted(List<int> list1) //Checks if the list is sorted or not
        {
            bool listSortedTrueFalse = false;
            int listHighest = 0;
            int k = 0;

            foreach (int j in list1)
            {
                listHighest = j;
                if (k <= listHighest)
                {
                    k = listHighest;
                    listSortedTrueFalse = true;
                }
                else
                    listSortedTrueFalse = false;
            }

            string isItSorted = "Is the current list sorted? " + listSortedTrueFalse;
            return isItSorted;
        }
    }
}
#endregion