using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DiningPhilosophers
{
    class Program
    {
        static object fork1 = new object();
        static object fork2 = new object();
        static object fork3 = new object();
        static object fork4 = new object();
        static object fork5 = new object();

        static object[] philosophers = new object[5] {"Philosopher1", "Philosopher2", "Philosopher3", "Philosopher4", "Philosopher5" };
        static object[] fork = new object[5] { fork1, fork2, fork3, fork4, fork5 };
        static int[] philFood = new int[5];
        
        static void Main(string[] args)
        {
            try
            {
                FillFood();
                ForkValue();

                while (true)
                {
                    Thread thread = new Thread(new ThreadStart(Philosopher));
                    thread.Start();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        static void FillFood()
        {
            for (int i = 0; i < philFood.Length; i++)
            {
                philFood[i] = 20;
            }
        }

        static void ForkValue()
        {
            for (int i = 0; i < fork.Length; i++)
            {
                fork[i] = new object();
            }
        }

        static void IsFree(int i)
        {
            int j = i;
            Monitor.Enter(fork[i]);
            if (i == 4)
            {
                i = -1;
            }
            Monitor.Enter(fork[i + 1]);
            philFood[j] -= 2;
            Console.WriteLine("Philosopher " + philosophers[j].ToString() + " is eating 2.");
            Thread.Sleep(200);
            Monitor.Exit(fork[i + 1]);
            if (i == -1)
            {
                i = 4;
            }
            Monitor.Exit(fork[i]);
        }

        static void Philosopher()
        {
            for (int i = 0; i < philosophers.Length; i++)
            {
                IsFree(i);
            }
        }
    }
}
