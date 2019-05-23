using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSyncronization
{
    class Assignment_1
    {
        static object padlock = new object();
        int sharedRessource = 0;

        public void thread1()
        {
            Thread.Sleep(1000);
            Monitor.Enter(padlock);
            sharedRessource += 2;
            Monitor.Exit(padlock);
        }

        public void thread2()
        {
            Thread.Sleep(1000);
            Monitor.Enter(padlock);
            sharedRessource -= 1;
            Monitor.Exit(padlock);
        }
    }
}
