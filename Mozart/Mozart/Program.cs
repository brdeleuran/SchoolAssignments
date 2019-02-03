using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozart
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            byte randomnumber;
            //makes a random table
            byte[,] minuet = new byte[29, 6];
            for (int i = 0; i < 29; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    minuet[i, j] = Convert.ToByte(random.Next(1, 176));
                }
            }

            //makes the address to the sounds
            string[] files = new string[29];
            for (int i = 0; i < files.Length; i++)
            {
                randomnumber = Convert.ToByte(random.Next(0, 6));
                files[i] = @"C:\Mozart Sound Files\M-Files\" + minuet[i, randomnumber] + ".wav";
            }

            Console.Read();

            //plays the sounds
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
            foreach (string musicelement in files)
            {
                sp.SoundLocation = musicelement;
                Console.WriteLine(musicelement);
                sp.Load();
                sp.PlaySync();
            }
            Console.Read();
        }
    }
}
