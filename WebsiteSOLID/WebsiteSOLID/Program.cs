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
            Console.WriteLine("Please input url");
            string input = Console.ReadLine();
            logic.setRequest((IRequest)new Requester());
            string output = logic.GetData(input);
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
