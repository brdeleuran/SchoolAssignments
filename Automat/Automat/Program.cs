using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat
{
    class Program
    {
        static void Main(string[] args) //Creates a GUI with all the options needed
        {
            VendingMachine vendingMachine = new VendingMachine(); //Instantiates the VendingMachine class to access the different functions

            do
            {
                Console.WriteLine("Press 1 to choose Foam Chocolate Banana");
                Console.WriteLine("Press 2 to choose Salted Platypus");
                Console.WriteLine("Press 3 to choose Coca Cola");
                Console.WriteLine("Press 4 to choose Sprite");
                Console.WriteLine("Press 5 to choose administration menu");
                int choiceUserMenu = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                if (choiceUserMenu < 5 && choiceUserMenu > 0)
                {
                    bool userMenu = true;

                    do
                    {
                        Console.WriteLine("Press 1 to insert 5 kr.");
                        Console.WriteLine("Press 2 to insert 10 kr.");
                        Console.WriteLine("Press 3 to insert 20 kr.");
                        Console.WriteLine("Press 4 to exit menu");
                        int moneyInsert = Convert.ToInt32(Console.ReadLine());
                        

                        switch (moneyInsert)
                        {
                            case 1:
                                vendingMachine.Dispense(choiceUserMenu, 5);
                                break;

                            case 2:
                                vendingMachine.Dispense(choiceUserMenu, 10);
                                break;

                            case 3:
                                vendingMachine.Dispense(choiceUserMenu, 20);
                                break;

                            case 4:
                                userMenu = false;
                                break;

                            default:
                                break;
                        }

                        Console.ReadKey();
                        Console.Clear();
                        
                    } while (userMenu == true);

                }

                else if (choiceUserMenu == 5)
                {
                    bool adminMenu = true;
                    do
                    {
                        Console.WriteLine("Press 1 to refill the machine");
                        Console.WriteLine("Press 2 to empty the moneybox");
                        Console.WriteLine("Press 3 to exit menu");
                        int choiceAdminMenu = Convert.ToInt32(Console.ReadLine());

                        Console.Clear();

                        switch (choiceAdminMenu)
                        {
                            case 1:
                                vendingMachine.Refill();
                                break;

                            case 2:
                                Console.WriteLine(vendingMachine.EmptyMoneyBox() + " kr. emptied from box");
                                break;

                            case 3:
                                adminMenu = false;
                                break;

                            default:
                                break;
                        }
                    } while (adminMenu == true);
                }
                else
                {
                    Console.WriteLine("Invalid input try again.");
                    Console.ReadKey();
                }
            } while (true);
        }
    }
}
