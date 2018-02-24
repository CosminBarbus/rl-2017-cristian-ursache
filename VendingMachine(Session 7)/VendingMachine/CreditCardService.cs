using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
     public static class CreditCardService
    {
        public static List<string> CardRegister;

        public static CreditCard card;
        public static PaymentTerminal Terminal;

       

        

        public static bool CreditCardValidation(CreditCard card, List<string> CardRegister)
        {
            foreach (var cardName in CardRegister)
            {
                if (cardName.Equals(card.CardName))
                    return true;
            }
            return false;
        }

        public static bool CheckMoney(CreditCard card, float itemPrice)
        {
            if (card.Balance >= itemPrice)
                return true;
            else
                return false;
        }
    }
}
