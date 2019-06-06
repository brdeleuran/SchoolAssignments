using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    abstract class Card
    {
        protected string cardNumber;
        protected string accountNumber;
        protected string name;
        protected double balance;

        public string CardNumber { get { return cardNumber; } }
        public string AccountNumber { get { return accountNumber; } }
        public string Name { get { return name; } }
        public double Balance { get { return balance; } }

        public void InsertCash(double insertedMoney)
        {
            balance = Balance + insertedMoney;
        }

    }
}
