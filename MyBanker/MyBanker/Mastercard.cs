using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class Mastercard : Credit
    {
        private int maxPerDay = 5000;
        private double usedToday;

        public override void SpendMoney(double amountSpent)
        {
            this.balance = Balance - amountSpent;
        }

        public Mastercard(string name, string accountNumb, string cardNumb, int expiryDate)
        {
            this.name = name;
            this.accountNumber = accountNumb;
            this.cardNumber = cardNumb;
            this.expiryDate = expiryDate;
        }
    }
}
