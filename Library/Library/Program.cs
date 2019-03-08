using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static Stack<Book> loanerStack = new Stack<Book>();
        public Stack<Book> LoanerStack => loanerStack;
        
        static void Main(string[] args)
        {

            Book C = new Book(300, "Me", 1989, "C");
            Book HTML = new Book(212, "Me", 1889, "HTML");
            Book CSS = new Book(100, "Me", 1689, "CSS");
            Book PHP = new Book(500, "Me", 1500, "PHP");
            
            do
            {
                Console.WriteLine("Press 1 to see books available in library.");
                Console.WriteLine("Press 2 to see books presently in your loan stack.");
                Console.WriteLine("Press 3 to exit.");
                int j = Convert.ToInt32(Console.ReadLine());
                switch (j)
                {
                    case 1:

                        Console.WriteLine("Books in library \r\n");
                        foreach (Book i in C.Library)
                        {
                            Console.WriteLine("Book number: " + C.Library.IndexOf(i));
                            Console.WriteLine(" | Author: " + i.author + " | Title: " + i.title + " | Year: " + i.year + " | Pages: " + i.pages + "\r\n \r\n");
                        }
                        Console.WriteLine("Enter the number of the book you want to borrow or press 4 to exit");
                        int bookNumber = Convert.ToInt32(Console.ReadLine());
                        switch (bookNumber)
                        {
                            case 0:
                                loanerStack.Push(C);
                                C.Library.RemoveAt(bookNumber);
                                break;

                            case 1:
                                loanerStack.Push(HTML);
                                HTML.Library.RemoveAt(bookNumber);
                                break;

                            case 2:
                                loanerStack.Push(CSS);
                                CSS.Library.RemoveAt(bookNumber);
                                break;

                            case 3:
                                loanerStack.Push(PHP);
                                PHP.Library.RemoveAt(bookNumber);
                                break;

                            case 4:
                                
                                break;
                        }
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine("Books in loan stack \r\n");
                        foreach (Book i in loanerStack)
                        {
                            Console.WriteLine(" | Author: " + i.author + " | Title: " + i.title + " | Year: " + i.year + " | Pages: " + i.pages + "\r\n \r\n");
                        }
                        Console.WriteLine("Press 1 to return a book");
                        Console.WriteLine("Press 2 to exit");
                        int pop = Convert.ToInt32(Console.ReadLine());
                        switch (pop)
                        {
                            case 1:
                                C.Library.Add(loanerStack.Pop());
                                break;
                            case 2:
                                break;
                        }
                        Console.Clear();
                        break;

                    case 3:
                        Environment.Exit(0);
                        break;
                }
            } while (true);
        }
    }
}
