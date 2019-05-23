using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSyncronization
{
    class Assignment_2_3
    {
        Program mainProg = new Program();
        static object padlock = new object();
        public void threadStar()
        {
            lock (padlock)
            {
                for (int i = 0; i < 60; i++)
                {
                    Console.Write("*");
                    mainProg.num++;
                }
                Console.WriteLine(" {0}", mainProg.num);
            }
        }

        public void threadHash()
        {
            lock (padlock)
            {
                for (int i = 0; i < 60; i++)
                {
                    Console.Write("#");
                    mainProg.num++;
                }
                Console.WriteLine(" {0}", mainProg.num);
            }
        }
    }
}
