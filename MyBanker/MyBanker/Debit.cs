using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    abstract class Debit : Card
    {
        protected int expiryDate;

        public int ExpiryDate { get { return expiryDate; } }

        public virtual void SpendMoney(double amountSpent)
        {
            this.balance = Balance - amountSpent;
        }
    }
}
