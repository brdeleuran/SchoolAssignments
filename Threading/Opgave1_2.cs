using System;
using System.Collections.Generic;
using System.Text;

namespace Threading
{
    class Opgave1_2
    {
        public void WorkThreadFunction()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("C#-trådning er nemt!");
            }
        }

        public void WorkThreadFunction1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Også med flere tråde...");
            }
        }
    }
}
