using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat
{
    class Snack: Product //Creates a connection to the Product superclass
    {
        List<string> typeOfSnack = new List<string> {"Foam Chocolate Banana", "Salted Platypus" };

        //Creating a string List and a Switch case to properly differentiate between the two snack types.

        public Snack(int snackID)
        {
            ID = 0;

            switch (snackID)
            {
                case 0:
                    Name = typeOfSnack[0];
                    Price = 20;
                    break;

                case 1:
                    Name = typeOfSnack[1];
                    Price = 10;
                    break;

                default:
                    break;
            }
        }

    }
}
