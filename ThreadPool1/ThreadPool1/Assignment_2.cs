using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPool1
{
    class Assignment_2
    {
        static void Process(object obj)
        {
            for (int i = 0; i < 100000; i++) // Time to completion is increased for the ProcessWithThreadMethod
            {
                for (int j = 0; j < 100000; j++) // Time to completion is increased drastically for the ProcessWithThreadMethod
                {

                }

            }
        }

        public void ProcessWithThreadMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                Thread obj = new Thread(Process); // Creates a thread that uses the Process method as a parametre
                obj.Start(); // Starts the Thread
            }
        }

        public void ProcessWithThreadPoolMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                // Starts a threadpool with the Process method as a parametre and queues it for execution 
                ThreadPool.QueueUserWorkItem(Process); 
            }
        }
    }
}
