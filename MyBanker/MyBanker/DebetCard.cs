using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class DebetCard : Card
    {
        public DebetCard(string name, string cardNumb, string accountNumb)
        {
            this.name = name;
            this.cardNumber = cardNumb;
            this.accountNumber = accountNumb;
        }

        public void SpendMoney(double amountSpent)
        {
            balance = Balance - amountSpent;
        }
    }
}
