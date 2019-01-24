using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(allowed());
            Console.ReadKey();
        }

        static string allowed() //If-Else method that tests what you are allowed to do depending on your input age
        {
            Console.WriteLine("Enter name: ");
            string inputName = Console.ReadLine();

            Console.WriteLine("Enter age: ");
            string inputAge = Console.ReadLine();

            while (!int.TryParse(inputAge, out int result))
            {
                Console.WriteLine("Please enter a numeric value.");
                Console.WriteLine("Enter age: ");
                inputAge = Console.ReadLine();

            }

            int intInputAge = Convert.ToInt32(inputAge);

            string showResult = "";

            if (intInputAge < 3)
                showResult = inputName + ", du må gå med ble.";

            else if (intInputAge <= 15)
                showResult = inputName + ", du må ingenting.";

            else if (intInputAge <= 17)
                showResult = inputName + ", du må drikke.";

            else
                showResult = inputName + ", du må stemme og køre bil.";

            return showResult;
        }
    }
}
