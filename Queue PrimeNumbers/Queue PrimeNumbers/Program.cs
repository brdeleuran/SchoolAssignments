using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> primes = new Queue<int>();

            primes.Enqueue(2);
            primes.Enqueue(3);
            primes.Enqueue(5);
            primes.Enqueue(7);
            primes.Enqueue(11);
            
            int total = 0;
            while (primes.Count > 0)
            {
                total += primes.Dequeue();
            }
            Console.WriteLine(total);
            Console.ReadKey();
        }
    }
}
