using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            string lottoStart = "";
            lotto(lottoStart);
        }

        static string lotto(string lottoStart) //Calls methods
        {
            int correct = 0;
            int corrected = inputCheck(correct);

            string winning = "";
            lottoStart = winnings(corrected, winning);

            return lottoStart;
        }

        static int inputCheck(int correct) //Checks if input numbers are within the parametres and checks them against the randomly picked numbers
        {
            Random r = new Random();

            int[] userLottoNumbers = new int[7];

            for (int i = 0; i <= userLottoNumbers.Length - 1; i++)
            {
                Console.WriteLine("Enter your " + i + ". number: ");
                userLottoNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();

            int[] lottoNumbers = new int[7];

            for (int j = 0; j < 7; j++)
            {
                int winner = r.Next(1, 21);
                lottoNumbers[j] = winner;
                Console.WriteLine(lottoNumbers[j]);
            }

            Console.WriteLine();

            Console.ReadKey();

            for (int aK = 0; aK < 7; aK++)
            {
                for (int aT = 0; aT < 7; aT++)
                {
                    if (lottoNumbers[aK] == userLottoNumbers[aT])
                    {
                        correct++;
                    }
                }
            }

            return correct;
        }

        static string winnings(int corrected, string winning) //Outputs a string with how much the user won by checking how many correct numbers they had
        {
            Console.WriteLine("You had " + corrected + " numbers correct!");

            if (corrected == 1)
                winning = "You win 10 dollars";

            else if (corrected == 2)
                winning = "You win 20 dollars";

            else if (corrected == 3)
                winning = "You win 30 dollars";

            else if (corrected == 4)
                winning = "You win 40 dollars";

            else if (corrected == 5)
                winning = "You win 50 dollars";

            else if (corrected == 6)
                winning = "You win 60 dollars";

            else if (corrected == 7)
                winning = "You win 70 dollars";

            else
                winning = "You lost";

            Console.WriteLine(winning);

            Console.ReadKey();

            return winning;
        }
    }
}
