using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    abstract class Credit : Card
    {
        protected int maxPerMonth;
        protected double usedThisMonth;
        protected int expiryDate;
        protected int overdraftMax;

        public int ExpiryDate { get { return expiryDate; } }

        public virtual void SpendMoney(double amountSpent)
        {
            this.balance = Balance - amountSpent;
        }
    }
}
