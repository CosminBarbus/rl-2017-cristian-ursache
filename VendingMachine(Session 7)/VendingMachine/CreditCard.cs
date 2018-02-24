using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class CreditCard
    {
        public string CardName;
        public float Balance;

        public CreditCard(string CardName, float Balance)
        {
            this.CardName = CardName;
            this.Balance = Balance;
        }


    }
}
