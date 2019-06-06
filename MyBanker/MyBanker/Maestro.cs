using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class Maestro : Debit
    {
        public override void SpendMoney(double amountSpent)
        {
            base.SpendMoney(amountSpent);
        }

        public Maestro(string name, string accountNumb, string cardNumb, int expiryDate)
        {
            this.name = name;
            this.accountNumber = accountNumb;
            this.cardNumber = cardNumb;
            this.expiryDate = expiryDate;
        }
    }
}
