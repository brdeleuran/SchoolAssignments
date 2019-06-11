using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic logic = new Logic();
            Console.WriteLine("Press 1 for webrequest.");

            int destination = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input url");
            string input = Console.ReadLine();
            string output = logic.GetData(input, destination);
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
