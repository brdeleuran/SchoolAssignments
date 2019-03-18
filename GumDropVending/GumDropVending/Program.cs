using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumDropVending
{
    class Program
    {
        static void Main(string[] args)
        {
            Dispenser dispenser = new Dispenser();
            Gum gums = new Gum();
            dispenser.Fill();

            do
            {
                try
                {
                    Console.WriteLine("Press 1 to get a gum");
                    Console.WriteLine("Press 2 to check amount of gums left of each flavor");
                    Console.WriteLine("Press 3 to re-fill the gum machine");
                    Console.WriteLine("Press 4 to exit");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine(dispenser.Dispense());
                            break;

                        case 2:
                            Console.WriteLine("Blueberry amount: " + gums.Blueberry.Count);
                            Console.WriteLine("Blackberry amount: " + gums.Blackberry.Count);
                            Console.WriteLine("Tutti Frutti amount: " + gums.TuttiFrutti.Count);
                            Console.WriteLine("Orange amount: " + gums.Orange.Count);
                            Console.WriteLine("Strawberry amount: "+ gums.Strawberry.Count);
                            Console.WriteLine("Apple amount: " + gums.Apple.Count);
                            break;

                        case 3:
                            dispenser.ReFill();
                            break;

                        case 4:
                            Environment.Exit(0);
                            break;

                        default:
                            break;
                    }
                    
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong input");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Error");
                }
            } while (true);
        } //Creates a small GUI for the user to check the amount of gums in the machine, refill it or dispense a gum
    }
}
