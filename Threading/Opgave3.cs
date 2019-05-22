using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threading
{
    class Opgave3
    {
        public void TempThread()
        {
            Random tempGen = new Random(); // Creates a random generator
            int alarmCount = 0; // Creates a default value for the alarm count
            bool alarm = true; // Creates a default bool value for the alarm

            while (alarm == true) // Checks if the alarm bool is true
            {
                int randomTemp = tempGen.Next(-20, 120); // Creates an int value and gives it a random value between two numbers
                if (alarmCount < 3) // Checks if the alarmCount value is less than 3
                {
                    if (randomTemp < 0 || randomTemp > 100) // Checks if the randomTemp value is less than 0 or more than 100
                    {
                        Console.WriteLine("Temperature: " + randomTemp + " Temperature outside allowed margin!");
                        alarmCount++;
                    }
                    else
                    {
                        Console.WriteLine("Temperature " + randomTemp);
                    }

                }
                else
                {
                    alarm = false;
                }
                Thread.Sleep(1500);
            }
        }
    }
}
