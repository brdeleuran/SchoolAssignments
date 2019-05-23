using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSyncronization
{
    class Program
    {
        public int num = 0;
        static void Main(string[] args)
        {
            #region Assignment_1

            //Assignment_1 as1 = new Assignment_1();
            //Thread thread1 = new Thread(new ThreadStart(as1.thread1));
            //Thread thread2 = new Thread(new ThreadStart(as1.thread2));
            //while (true)
            //{
            //    thread1.Start();
            //    thread2.Start();
            //    thread1.Join();
            //    thread2.Join();
            //}

            #endregion

            #region Assignment_2

            Assignment_2_3 as2_3 = new Assignment_2_3();
            for (int i = 0; i < 15; i++)
            {
                Thread threadStar = new Thread(new ThreadStart(as2_3.threadStar));
                Thread threadHash = new Thread(new ThreadStart(as2_3.threadHash));

                threadStar.Start();
                threadStar.Join();
                Thread.Sleep(500);
                threadHash.Start();
                threadHash.Join();
                Thread.Sleep(500);
                i++;
            }

            #endregion
        }
    }
}
