using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsumerProducerThreading
{
    class thr
    {
        static int value = 0;
        static object key = new object();
        private bool block = true;
        public void Producer()
        {
            try
            {
                if (value <= 3)
                {
                    value++;
                    Console.WriteLine("Producer added 1, current amount: " + value);
                    
                }
                else
                {
                    Console.WriteLine("Producer was not allowed to add, current amount: " + value);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Consumer()
        {
            try
            {
                if (value > 0)
                {
                    value--;
                    Console.WriteLine("Consumer removed 1, current amount: " + value);
                }
                else
                {
                    Console.WriteLine("Consumer was not allowed to remove, current value: " + value);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Producer1()
        {
            try
            {
                lock (key)
                {
                    value++;
                    Console.WriteLine("Producer added 1, current amount: " + value);
                    block = true;
                    while (block)
                    {
                        Monitor.Wait(key);
                        Console.WriteLine("Producer Waits..");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Consumer1()
        {
            try
            {
                lock (key)
                {
                    value--;
                    Console.WriteLine("Consumer removed 1, current amount: " + value);

                    block = false;
                    Monitor.Pulse(key);

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
