using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPVaskemaskine
{
    class Program
    {
        static void Main(string[] args)
        {
            Washer washer = new Washer();

            do
            {
                Console.WriteLine("----------------Menu----------------");
                Console.WriteLine("Press 1 to turn the power on/off.");
                Console.WriteLine("Press 2 to fill with water.");
                Console.WriteLine("Press 3 to use the spin program.");
                Console.WriteLine("Press 4 to use the wash program.");
                Console.WriteLine("Press 5 to use the EcoWash program.");
                Console.WriteLine("Press 6 to stop current program.");
                Console.WriteLine("Press 7 to exit.");
                Console.WriteLine("------------------------------------");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice){
                    case (1):
                        Console.Clear();
                        Console.WriteLine(washer.Power());
                        break;

                    case (2):
                        Console.Clear();
                        Console.WriteLine(washer.Fill(30));
                        break;

                    case (3):
                        Console.Clear();
                        Console.WriteLine(washer.Spin(50));
                        break;

                    case (4):
                        Console.Clear();
                        Console.WriteLine(washer.Wash(180));
                        break;

                    case (5):
                        Console.Clear();
                        Console.WriteLine(washer.EcoWash(120));
                        break;

                    case (6):
                        Console.Clear();
                        Console.WriteLine(washer.StopProgram());
                        break;

                    case (7):
                        Environment.Exit(0);
                        break;
                }
                
            } while (true);
        }
    }
}
