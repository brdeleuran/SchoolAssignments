using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat
{
    class Drink: Product //Creates a connection to the Product superclass
    {
        List<string> typeOfDrink = new List<string> { "Coca Cola", "Sprite" };

        //Creating a string List and a Switch case to properly differentiate between the two drink types.

        public Drink(int drinkID)
        {
            ID = 1;

            switch (drinkID)
            {
                case 0:
                    Name = typeOfDrink[0];
                    Price = 20;
                    break;

                case 1:
                    Name = typeOfDrink[1];
                    Price = 20;
                    break;

                default:
                    break;
            }
        }
    }
}
