using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadBottle
{
    class Threads
    {
        public string[] beerSodaBuffer = new string[6];
        public string[] beerBuffer = new string[3];
        public string[] sodaBuffer = new string[3];
        int runNumber = 0;
        public void ProducerThread()
        {
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    runNumber++;
                    beerSodaBuffer[i] = "Beer";
                    Console.WriteLine("Added beer");
                }
                for (int i = 3; i < 6; i++)
                {
                    beerSodaBuffer[i] = "Soda";
                    Console.WriteLine("Added Soda");
                }
                Console.WriteLine("Producer Thread Done");
                Thread.Sleep(500);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("Closing program");
                Environment.Exit(0);
            }
        }

        public void ConsumerSplitterThread()
        {
            try
            {
                for (int i = 0; i < beerSodaBuffer.Length; i++)
                {
                    if (beerSodaBuffer[i] == "Beer")
                    {
                        beerBuffer[i] = "Beer";
                        beerSodaBuffer[i] = "";
                    }
                    else if (beerSodaBuffer[i] == "Soda")
                    {
                        sodaBuffer[i - 3] = "Soda";
                        beerSodaBuffer[i] = "";
                    }
                    Thread.Sleep(500);
                }
                Console.WriteLine("Splitter Thread Done");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("Closing program");
                Environment.Exit(0);
            }
        }

        public void BeerConsumerThread()
        {
            try
            {
                for (int i = 0; i < beerBuffer.Length; i++)
                {
                    if (beerBuffer[i] == "Beer")
                    {
                        beerBuffer[i] = "";
                        Console.WriteLine("Removed Beer");
                    }
                    else
                        Thread.Sleep(500);

                }
                Console.WriteLine("Beer Consumer Thread Done");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("Closing program");
                Environment.Exit(0);
            }
        }

        public void SodaConsumerThread()
        {
            try
            {
                for (int i = 0; i < sodaBuffer.Length; i++)
                {
                    if (sodaBuffer[i] == "Soda")
                    {
                        sodaBuffer[i] = "";
                        Console.WriteLine("Removed Soda");
                    }                    
                    else
                        Thread.Sleep(500);
                }
                Console.WriteLine("Soda Consumer Thread Done");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("Closing program");
                Environment.Exit(0);
            }
        }


    }
}
