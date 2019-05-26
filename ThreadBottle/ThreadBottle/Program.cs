using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadBottle
{
    class Program
    {
        static Threads tr = new Threads();
        static void Main(string[] args)
        {
            while (true)
            {
                Thread trProducer = new Thread(new ThreadStart(tr.ProducerThread));
                Thread trSplitter = new Thread(new ThreadStart(tr.ConsumerSplitterThread));
                Thread trBeer = new Thread(new ThreadStart(tr.BeerConsumerThread));
                Thread trSoda = new Thread(new ThreadStart(tr.SodaConsumerThread));
                trProducer.Start();
                trProducer.Join();
                trSplitter.Start();
                trSplitter.Join();
                trBeer.Start();
                trBeer.Join();
                trSoda.Start();
                trSoda.Join();

                Thread.Sleep(4000);
            }
        }
    }
}
