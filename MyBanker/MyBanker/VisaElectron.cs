using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class VisaElectron : Debit
    {
        private int maxPerMonth = 10000;
        private double usedThisMonth;

        public override void SpendMoney(double amountSpent)
        {
            this.balance = Balance - amountSpent;
            usedThisMonth += amountSpent;
        }

        public VisaElectron(string name, string cardNumb, string accountNumb, int expiryDate)
        {
            this.name = name;
            this.cardNumber = cardNumb;
            this.accountNumber = accountNumb;
            this.expiryDate = expiryDate;
        }
    }
}
