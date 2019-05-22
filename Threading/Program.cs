using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threading
{
    class threprog
    {
        public static void Main(string[] args)
        {
            #region Opgave 0

            Opgave0 pg = new Opgave0(); //Instanciates the thread class
            Thread thread = new Thread(new ThreadStart(pg.WorkThreadFunction)); //Tells the thread to use the thread function as a parametre         
            thread.Start(); // Starts the Thread
            Console.Read();

            #endregion

            #region Opgave 1 & 2
            //Opgave1_2 pg = new Opgave1_2(); // Instanciates the Opgave1_2 class with the thread method
            //Thread thread = new Thread(new ThreadStart(pg.WorkThreadFunction)); // Creates a thread with a method from Opgave1_2 as a parametre
            //thread.Start(); // Starts the thread
            //Thread.Sleep(1000); // Stops the thread for 1000 milliseconds
            //pg.WorkThreadFunction1(); // Starts a method from the Opgave1_2 class
            #endregion

            #region Opgave 3
            //Opgave3 opgave3 = new Opgave3(); // Instanciates the Opgave3 class
            //Thread thread3 = new Thread(new ThreadStart(opgave3.TempThread)); // Creates a thread with a method from the Opgave3 class as a parametre
            //thread3.Start(); // Starts the thread
            //try // Tries to run the commands
            //{
            //    while (true)
            //    {
            //        if (!thread3.IsAlive) // Checks if thread3 is dead
            //        {
            //            Console.WriteLine("Alarm-thread terminated");
            //            break; // Breaks out of the while loop
            //        }
            //        Thread.Sleep(10000);
            //    }
            //}
            //catch (InvalidOperationException) // Catches an exception
            //{
            //   Console.WriteLine("Something went wrong"); // Only outputs if exception is caught
            //}
            //finally // Runs when all other threads or commands are dead
            //{
            //    Console.WriteLine("Closing program");
            //    Environment.Exit(0);
            //}
            #endregion

            #region Opgave 4
            //Opgave4 opgave4 = new Opgave4(); // Instanciates the class containing the thread methods
            //Thread threadOut = new Thread(new ThreadStart(opgave4.OutputThread)); // Creates a thread from the method
            //threadOut.Name = "Ouput"; // Gives the thread a name
            //threadOut.Priority = ThreadPriority.Normal; // Sets the priority of the thread
            //threadOut.Start(); // Starts the thread
            //Thread threadIn = new Thread(new ThreadStart(opgave4.InputThread));
            //threadIn.Name = "Input";
            //threadIn.Priority = ThreadPriority.Normal;
            //threadIn.Start();
            //threadIn.Join(); // Joins the thread with the current thread stack

            #endregion

            Console.ReadKey();
        }
    }
}
