using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some text you want translated: ");
            string text = Console.ReadLine();




            char[] ar = text.ToCharArray();



            for (int i = 0; i < ar.Length; i++)
            {
                switch (ar[i].ToString())
                {
                    case "a":
                        {
                            Console.Write(".-");
                        }
                        break;

                    case "b":
                        {
                            Console.Write("-...");
                        }
                        break;

                    case "c":
                        {
                            Console.Write("-.-.");
                        }
                        break;

                    case "d":
                        {
                            Console.Write("-..");
                        }
                        break;

                    case "e":
                        {
                            Console.Write(".");
                        }
                        break;

                    case "f":
                        {
                            Console.Write("..-");
                        }
                        break;

                    case "g":
                        {
                            Console.Write("--.");
                        }
                        break;

                    case "h":
                        {
                            Console.Write("....");
                        }
                        break;

                    case "i":
                        {
                            Console.Write("..");
                        }
                        break;

                    case "j":
                        {
                            Console.Write(".---");
                        }
                        break;

                    case "k":
                        {
                            Console.Write("-.-");
                        }
                        break;

                    case "l":
                        {
                            Console.Write(".-..");
                        }
                        break;

                    case "m":
                        {
                            Console.Write("--");
                        }
                        break;

                    case "n":
                        {
                            Console.Write("-.");
                        }
                        break;

                    case "o":
                        {
                            Console.Write("---");
                        }
                        break;

                    case "p":
                        {
                            Console.Write(".--.");
                        }
                        break;

                    case "q":
                        {
                            Console.Write("--.-");
                        }
                        break;

                    case "r":
                        {
                            Console.Write(".-.");
                        }
                        break;

                    case "s":
                        {
                            Console.Write("...");
                        }
                        break;

                    case "t":
                        {
                            Console.Write("-");
                        }
                        break;

                    case "u":
                        {
                            Console.Write("..-");
                        }
                        break;

                    case "v":
                        {
                            Console.Write("...-");
                        }
                        break;

                    case "w":
                        {
                            Console.Write(".--");
                        }
                        break;

                    case "x":
                        {
                            Console.Write("-..-");
                        }
                        break;

                    case "y":
                        {
                            Console.Write("-.--");
                        }
                        break;

                    case "z":
                        {
                            Console.Write("--..");
                        }
                        break;

                    case "æ":
                        {
                            Console.Write(".-.-");
                        }
                        break;

                    case "ø":
                        {
                            Console.Write("---.");
                        }
                        break;

                    case "å":
                        {
                            Console.Write(".--.-");
                        }
                        break;
                }
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
}
