using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsumerProducerThreading
{
    class Program
    {
        static thr thr = new thr();
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    for (int i = 0; i < 6; i++)
            //    {
            //        Thread threadProduce = new Thread(new ThreadStart(thr.Producer));
            //        threadProduce.Start();
            //    }
            //    Thread.Sleep(2000);
            //    for (int i = 0; i < 6; i++)
            //    {
            //        Thread thrConsume = new Thread(new ThreadStart(thr.Consumer));
            //        thrConsume.Start();
            //    }
            //    Thread.Sleep(2000);
            //}

            while (true)
            {
                Thread thrprod1 = new Thread(new ThreadStart(thr.Producer1));
                Thread thrCons1 = new Thread(new ThreadStart(thr.Consumer1));
                thrprod1.Start();
                thrCons1.Start();
                Thread.Sleep(500);
            }
        }
    }
}
