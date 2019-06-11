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
            Console.WriteLine("Press 1 for file request");
            Console.WriteLine("Press 2 for web request");
            int destination = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input url");
            string input = Console.ReadLine();
            if (destination == 1)
                logic.setRequest((IRequest)new TextRequester());

            else if (destination == 2)
                logic.setRequest((IRequest)new WebRequester());

            else
                Console.WriteLine("Input valid number");

            string output = logic.GetData(input);
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
