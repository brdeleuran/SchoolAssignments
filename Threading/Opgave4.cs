using System;
using System.Collections.Generic;
using System.Text;

namespace Threading
{
    class Opgave4
    {
        char _input = '*';
        public void OutputThread() // Continously outputs the value of _input
        {
            while (true)
            {
                Console.Write(_input);
            }
        }
        public void InputThread() // Continuesly checks the input and then changes the _input value after enter has been pressed
        {
            while (true)
            {
                try
                {
                    char input = Convert.ToChar(Console.ReadLine());
                    _input = input;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    Console.WriteLine("Closing program");
                    Environment.Exit(0);
                }
            }
        }
    }
}
