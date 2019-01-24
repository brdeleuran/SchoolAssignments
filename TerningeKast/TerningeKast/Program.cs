using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerningeKast
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int terningekast = random.Next(1, 7);

            if (terningekast == 1)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Du slog en etter!");
            }

            else if (terningekast == 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Du slog en toer!");
            }

            else if (terningekast == 3)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Du slog en tréer!");
            }

            else if (terningekast == 4)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Du slog en firer!");
            }

            else if (terningekast == 5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Du slog en femmer!");
            }

            else if (terningekast == 6)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Du slog en sekser!");
            }

            Console.ReadKey();
        }
    }
}
