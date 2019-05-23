using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ThreadPool1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Assignment_0

            //Assignment_0 as0 = new Assignment_0();
            //for (int i = 0; i < 2; i++)
            //{
            //    ThreadPool.QueueUserWorkItem(as0.task1);
            //    /* Starts a threadpool with the task1 method from the Assignment_0 class as a parametre 
            //    and queues it for execution */
            //    ThreadPool.QueueUserWorkItem(as0.task2);
            //    /* Starts a threadpool with the task2 method from the Assignment_0 class as a parametre 
            //    and queues it for execution */
            //}

            #endregion

            #region Assignment_1

            //Assignment_1 assignment_1 = new Assignment_1();
            //Stopwatch newStopWatch = new Stopwatch();
            //Console.WriteLine("Thread Pool Execution");

            //newStopWatch.Start();
            //assignment_1.ProcessWithThreadPoolMethod();
            //newStopWatch.Stop();

            //Console.WriteLine("Time consumed by ProcessWithThreadPoolMethod is : " + newStopWatch.ElapsedTicks.ToString());
            //newStopWatch.Reset();
            //Console.WriteLine("Thread Execution");

            //newStopWatch.Start();
            //assignment_1.ProcessWithThreadMethod();
            //newStopWatch.Stop();

            //Console.WriteLine("Time consumed by ProcessWithThreadMethod is : " + newStopWatch.ElapsedTicks.ToString());
            //Console.Read();

            #endregion

            #region Assignment_2

            //Assignment_2 assignment_2 = new Assignment_2();
            //Stopwatch newStopWatch1 = new Stopwatch();
            //Console.WriteLine("Thread Pool Execution");

            //newStopWatch1.Start();
            //assignment_2.ProcessWithThreadPoolMethod();
            //newStopWatch1.Stop();

            //Console.WriteLine("Time consumed by ProcessWithThreadPoolMethod is : " + newStopWatch1.ElapsedTicks.ToString());
            //newStopWatch1.Reset();
            //Console.WriteLine("Thread Execution");

            //newStopWatch1.Start();
            //assignment_2.ProcessWithThreadMethod();
            //newStopWatch1.Stop();

            //Console.WriteLine("Time consumed by ProcessWithThreadMethod is : " + newStopWatch1.ElapsedTicks.ToString());
            //Console.Read();

            #endregion

            #region Assignment_3

            Assignment_3 as3 = new Assignment_3();
            Thread thread1 = new Thread(new ThreadStart(as3.Thread1));
            Thread thread2 = new Thread(new ThreadStart(as3.Thread2));
            thread1.Name = "Thread1"; // Gives the thread a name
            thread1.Priority = ThreadPriority.BelowNormal; // Sets the priority of the thread
            thread1.IsBackground = true; 
            // Sets the thread to be a background thread with a lower priority than non-background threads
            Console.WriteLine(thread1.Priority); // Prints the priority of the thread
            thread1.Start(); // Starts the thread
            thread1.Join(); // Joins the thread to the execution stack
            Console.WriteLine(thread1.IsAlive); // Prints the state of the thread
            thread1.Abort(); // Kills the thread

            thread2.Name = "Thread2";
            thread2.Priority = ThreadPriority.AboveNormal;
            thread2.IsBackground = false;
            thread2.Start();
            thread2.Suspend(); // Pauses the thread
            thread2.Resume(); // Resumes a suspended thread
            thread2.Join();


            #endregion

            Console.ReadKey();
        }
    }
}
