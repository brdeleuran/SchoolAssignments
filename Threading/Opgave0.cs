using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threading
{
    class Opgave0
    {
        public void WorkThreadFunction() //Creates the Thread function
        {

            for (int i = 0; i < 5; i++) //Loops 5 times and writes 'Simple Thread'
            {
                Console.WriteLine("Simple Thread");
                Thread thread1 = new Thread(new ThreadStart(Thread1));
                thread1.Name = "Thread1";
                thread1.Start();
                thread1.Join();
                Thread thread2 = new Thread(new ThreadStart(Thread2));
                thread2.Name = "Thread2";
                thread2.Start();
                thread2.Join();
            }

        }

        public void Thread1()
        {
            Console.WriteLine("Hello There!");
        }

        public void Thread2()
        {
            Console.WriteLine("Hello Again!");
        }
    }
}
