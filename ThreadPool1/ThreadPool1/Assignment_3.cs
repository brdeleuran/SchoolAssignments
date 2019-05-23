using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPool1
{
    class Assignment_3
    {
        public void Thread1()
        {
            Console.WriteLine("Hello There From Task1!");
        }
        public void Thread2()
        {
            Console.WriteLine("Hello There From Task2!");
            Thread.Sleep(100);// Stops the thread for 100 milliseconds
        }
    }
}
