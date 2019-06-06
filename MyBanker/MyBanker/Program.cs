using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 0 for debet card.");
            Console.WriteLine("Press 1 for visa electron.");
            Console.WriteLine("Press 2 for visa.");
            Console.WriteLine("Press 3 for master card.");
            Console.WriteLine("Press 4 for maestro card.");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            CardCreater newCard = new CardCreater(name, choice);

            foreach (Card item in CardCreater.accounts)
            {
                Console.WriteLine(item.Name + "\r\n" + item.CardNumber.ToString() + "\r\n" + item.AccountNumber + "\r\n" + item.GetType().ToString());
            }

            Console.ReadKey();
        }
    }
}
