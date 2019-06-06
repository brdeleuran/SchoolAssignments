using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDHelpJakob
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Message to: ");
            string to = Console.ReadLine();
            Console.Write("Message from: ");
            string from = Console.ReadLine();
            Console.Write("Message: ");
            string message = Console.ReadLine();
            Console.Write("Subject: ");
            string subject = Console.ReadLine();
            Console.Write("Whom to cc: ");
            string cc = Console.ReadLine();
            Console.Clear();
            Message newMessage = new Message(to, from, message, subject, cc);

            Console.WriteLine("Message to : " + newMessage.To.ToString());
            Console.WriteLine("Message from: " + newMessage.From.ToString());
            Console.WriteLine("Cc: " + newMessage.Cc.ToString());
            Console.WriteLine("Subject: " + newMessage.Subject.ToString());
            Console.WriteLine("Message: " + newMessage.Body.ToString());

            Console.ReadKey();
        }
    }
}
