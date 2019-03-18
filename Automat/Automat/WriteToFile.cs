using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Automat
{
    class WriteToFile
    {
        private string[] data = new string[1]; //Creates an Array to store the dataOutput in

        public void writeToFile(int moneyEmptied) //Creates a .txt file and writes the amount emptied and the current dateTime to it
        {

            data[0] = moneyEmptied.ToString() + "kr";
            
            File.WriteAllLines(@".\MoneyEmptied.txt" + DateTime.Now, data);
        }
    }
}
