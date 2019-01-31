using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        
        static public void Main(string[] args)
        {
            Methods();
        }

        static void Methods()
        {
            
            int choice = Menu();
            while (choice != 7)
            {
                if (choice == 1)
                    CreateFile();
                else if (choice == 2)
                    DeleteFile();
                else if (choice == 3)
                    Console.WriteLine(ReadFile());
                else if (choice == 4)
                    CreateFolder();
                else if (choice == 5)
                    EnumerateFiles();
                else if (choice == 6)
                    DeleteFolder();
                else
                    Console.ReadLine();

                Console.ReadLine();
            }
            Environment.Exit(0);
        }

        static void CreateFile()
        {
            Console.WriteLine("Enter file name: ");
            string input = Console.ReadLine() + ".txt";

            Console.WriteLine("Enter text in file: ");
            string input2 = Console.ReadLine();

            File.WriteAllText(@".\"+ input, input2);

            
        }

        static string ReadFile()
        {
            Console.WriteLine("Enter the name of the file you wish to read, without '.txt': ");
            string input = Console.ReadLine() + ".txt";

            string content = File.ReadAllText(@".\" + input);
            return content;
        }

        static void DeleteFile()
        {
            Console.WriteLine("Enter the name of the file you wish to delete, without '.txt': ");

            File.Delete(@".\StarWars.txt");
            return;
        }

        static void CreateFolder()
        {
            Console.WriteLine("Enter the name of the folder you wish to create.");
            string input = Console.ReadLine();

            Directory.CreateDirectory(@".\" + input);

            return;
        }

        static void DeleteFolder()
        {
            Console.WriteLine("Enter the name of the folder you wish to delete: ");
            string input = Console.ReadLine();

            Directory.Delete(@".\" + input, true);

            return;
        }

        static void EnumerateFiles()
        {
            Console.WriteLine("Enter the name of the file you are searching for: ");
            string input = Console.ReadLine();

            string[] files = Directory.GetFiles(@".\", input + ".txt", SearchOption.AllDirectories);

            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine(files[i]);
            }
            return;
        }

        static int Menu()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("H1 Queue Operations Menu");
            Console.WriteLine("=========================");
            Console.WriteLine(" 1. Add file \r\n 2. Delete file\r\n 3. Read file\r\n 4. Add folder\r\n 5. Search file\r\n 6. Delete folder\r\n 7. Exit \r\n\r\n Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
    }
}
