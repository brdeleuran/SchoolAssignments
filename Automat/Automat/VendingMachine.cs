using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat
{
    class VendingMachine
    {
        //Instantiates int's and classes so we can access accross the methods in the class
        private int moneyInput;
        private int moneyOutput;
        private int moneyTotal;
        private int moneyTemp = 0;
        private Snack snack;
        private Drink drink;
        private Product product;
        private Info info = new Info();
        private WriteToFile writeTo = new WriteToFile();

        public void Refill() //Creates objects to put in to the stacks in the list
        {
            for (int i = 0; i < info.ProductList.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        for (int j = 0; j < 8; j++)
                        {
                            info.ProductList[0].Push(snack = new Snack(0));
                        }
                        break;

                    case 1:
                        for (int j = 0; j < 8; j++)
                        {
                            info.ProductList[1].Push(snack = new Snack(1));
                        }
                        break;

                    case 2:
                        for (int j = 0; j < 8; j++)
                        {
                            info.ProductList[2].Push(drink = new Drink(0));
                        }
                        break;

                    case 3:
                        for (int j = 0; j < 8; j++)
                        {
                            info.ProductList[3].Push(drink = new Drink(1));
                        }
                        break;

                    default:
                        break;
                }
            }

        }

        public string Dispense(int productType, int moneyIn) //Checks your choice and the amount of money you put in to decide if you have enough for the chosen snack/drink
        {
            try
            {
                productType = productType - 1;
                product = info.ProductList[productType].Peek();
                if (MoneyInOut(moneyIn) == true)
                {
                    switch (product.ID)
                    {
                        case 0:
                            snack = (Snack)info.ProductList[productType].Pop();
                            return snack.Name;

                        case 1:
                            drink = (Drink)info.ProductList[productType].Pop();
                            return drink.Name;

                    }
                    return "";
                }
                else
                {
                    return "Nothing bought!!! \r\nMoney returned " + moneyOutput;

                }

            }
            catch (FormatException)
            {
                return "Error in input!";
            }
            catch (InvalidOperationException)
            {
                return "Empty stack!";
            }
            
            
        }

        public string UserChoice(int choice) //Checks the price of the chosen item and returns the price
        {
            int userOutput = info.ProductList[choice].Peek().Price;
            return "" + userOutput;
        }

        private bool MoneyInOut(int moneyInput) //Checks the input money against the price of the item and either takes the money if you have enough or returns that the amount is insufficiant
        {
            
            moneyTemp += moneyInput;

            if (product.Price <= moneyTemp)
            {
                moneyTotal += product.Price;
                moneyOutput = moneyTemp - product.Price;
                return true;
            }
            else
            {
                moneyOutput = moneyInput;
                return false;
            }
            
        }

        public string MoneyBack() //Returns the money put in before purchase
        {
            return moneyTemp + "kr returned";
        }

        public void ChangePrice(int newPrice, int productType) //Changes the price of an itemType to the input price
        {
            foreach (Product item in info.ProductList[productType])
            {
                item.Price = newPrice;
            }
            
        }

        public string EmptyMoneyBox() //Calls the method to document the action and empties the stored value
        {
            int moneyEmptied = moneyTotal;
            writeTo.writeToFile(moneyTotal);
            moneyTotal = 0;
            return "" + moneyEmptied;
        }
    }
}
