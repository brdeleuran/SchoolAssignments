using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumDropVending
{
    class Dispenser
    {
        Gum gums = new Gum();

        public Dispenser()
        {

        }

        public void Fill()
        {
            for (int i = 0; i < 14; i++)
            {
                gums.Blueberry.Add("Blueberry Gum");
            }

            for (int i = 0; i < 7; i++)
            {
                gums.Blackberry.Add("Blackberry Gum");
            }

            for (int i = 0; i < 11; i++)
            {
                gums.TuttiFrutti.Add("Tutti Frutti Gum");
            }

            for (int i = 0; i < 10; i++)
            {
                gums.Orange.Add("Orange Gum");
            }

            for (int i = 0; i < 8; i++)
            {
                gums.Strawberry.Add("Strawberry Gum");
            }

            for (int i = 0; i < 5; i++)
            {
                gums.Apple.Add("Apple Gum");
            }
        } //Fills the lists with a specific amount of each item

        public void ReFill()
        {
            Random randomBlueberry = new Random();
            Random randomBlackberry = new Random();
            Random randomTuttiFrutti = new Random();
            Random randomOrange = new Random();
            Random randomStrawberry = new Random();
            Random randomApple = new Random();

            int randomBlue = randomBlueberry.Next(13, 15);
            int randomBlack = randomBlackberry.Next(6, 8);
            int randomTutti = randomTuttiFrutti.Next(11, 13);
            int randomOrang = randomOrange.Next(9, 11);
            int randomStrawberr = randomStrawberry.Next(7, 9);
            int randomApll = randomApple.Next(4, 6);

            bool empty = true;
            int currentSum = gums.Blueberry.Count() + gums.Blackberry.Count() + gums.TuttiFrutti.Count() + gums.Orange.Count() + gums.Strawberry.Count() + gums.Apple.Count();

            int randomSum = randomBlue + randomBlack + randomTutti + randomOrang + randomStrawberr + randomApll;
            bool amount = true;
            
            if (currentSum != 0)
            {
                empty = false;
            }
            do
            {
                if (randomSum > 55)
                {
                    if (randomBlue > 13)
                    {
                        randomBlue = randomBlue - 1;
                        randomSum = randomSum - 1;
                    }

                    else if (randomBlack > 6)
                    {
                        randomBlack = randomBlack - 1;
                        randomSum = randomSum - 1;
                    }

                    else if (randomTutti > 11)
                    {
                        randomTutti = randomTutti - 1;
                        randomSum = randomSum - 1;
                    }

                    else if (randomOrang > 9)
                    {
                        randomOrang = randomOrang - 1;
                        randomSum = randomSum - 1;
                    }

                    else if (randomStrawberr > 7)
                    {
                        randomStrawberr = randomStrawberr - 1;
                        randomSum = randomSum - 1;
                    }

                    else if (randomApll > 4)
                    {
                        randomApll = randomApll - 1;
                        randomSum = randomSum - 1;
                    }
                    else
                    {
                        amount = false;
                    }

                }
                else if (randomSum < 55)
                {
                    if (randomBlue < 15 && randomBlue >= 13)
                    {
                        randomBlue = randomBlue + 1;
                        randomSum = randomSum + 1;
                    }

                    else if (randomBlack < 8 && randomBlack >= 6)
                    {
                        randomBlack = randomBlack + 1;
                        randomSum = randomSum + 1;
                    }

                    else if (randomTutti < 13 && randomTutti >= 11)
                    {
                        randomTutti = randomTutti + 1;
                        randomSum = randomSum + 1;
                    }

                    else if (randomOrang < 11 && randomOrang >= 9)
                    {
                        randomOrang = randomOrang + 1;
                        randomSum = randomSum + 1;
                    }

                    else if (randomStrawberr < 9 && randomStrawberr >= 7)
                    {
                        randomStrawberr = randomStrawberr + 1;
                        randomSum = randomSum + 1;
                    }

                    else if (randomApll < 6 && randomApll >= 4)
                    {
                        randomApll = randomApll + 1;
                        randomSum = randomSum + 1;
                    }
                    else
                    {
                        amount = false;
                    }
                }
                else
                {
                    amount = false;
                }

            } while (amount == true && empty == true);

            if (empty == true)
            {
                for (int i = 0; i < randomBlue; i++)
                {
                    gums.Blueberry.Add("Blueberry Gum");
                }

                for (int i = 0; i < randomBlack; i++)
                {
                    gums.Blackberry.Add("Blackberry Gum");
                }

                for (int i = 0; i < randomTutti; i++)
                {
                    gums.TuttiFrutti.Add("Tutti Frutti Gum");
                }

                for (int i = 0; i < randomOrang; i++)
                {
                    gums.Orange.Add("Orange Gum");
                }

                for (int i = 0; i < randomStrawberr; i++)
                {
                    gums.Strawberry.Add("Strawberry Gum");
                }

                for (int i = 0; i < randomApll; i++)
                {
                    gums.Apple.Add("Apple Gum");
                }
            }
        } //ReFills the lists with a sligtly randomized amount of each item but with exactly 55 in total
        
        public string Dispense()
        {
            Random randomGen = new Random();
            
            string returnMessage = "";
            
            switch (randomGen.Next(1, 7))
            {
                case (1):
                    if (gums.Blueberry.Count < 1)
                        returnMessage = "No more blueberry gumDrops";
                    else
                    {
                        returnMessage = "You got a blueberry gumDrop";
                        gums.Blueberry.RemoveAt(0);
                    }
                    break;

                case (2):
                    if (gums.Blackberry.Count < 1)
                        returnMessage = "No more blackberry gumDrops";
                    else
                    {
                        returnMessage = "You got a blackberry gumDrop";
                        gums.Blackberry.RemoveAt(0);
                    }
                    break;

                case (3):
                    if (gums.TuttiFrutti.Count < 1)
                        returnMessage = "No more tuttiFrutti gumDrops";
                    else
                    {
                        returnMessage = "You got a tuttiFrutti gumDrop";
                        gums.TuttiFrutti.RemoveAt(0);
                    }
                    break;

                case (4):
                    if (gums.Orange.Count < 1)
                        returnMessage = "No more orange gumDrops";
                    else
                    {
                        returnMessage = "You got an orange gumDrop";
                        gums.Orange.RemoveAt(0);
                    }
                    break;

                case (5):
                    if (gums.Strawberry.Count < 1)
                        returnMessage = "No more strawberry gumDrops";
                    else
                    {
                        returnMessage = "You got a strawberry gumDrop";
                        gums.Strawberry.RemoveAt(0);
                    }
                    break;

                case (6):
                    if (gums.Apple.Count < 1)
                        returnMessage = "No more apple gumDrops";
                    else
                    {
                        returnMessage = "You got an apple gumDrop";
                        gums.Apple.RemoveAt(0);
                    }
                    break;
            }
            return returnMessage;
        } //Removes an item from a random list if there are any items left and returns a message 
    }
}
