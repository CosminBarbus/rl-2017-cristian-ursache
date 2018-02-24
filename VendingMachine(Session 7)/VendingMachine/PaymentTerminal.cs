using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class PaymentTerminal
    {
        private int nrCoins10;
        private int nrCoins50;
        private int nrBanknote1;
        private int nrBanknote5;

        private float balance;

        public int nrcoins10
        {
            get
            {
                return nrCoins10;
            }

            set
            {
                nrCoins10 = value;
            }
        }

        public int nrcoins50
        {
            get
            {
                return nrCoins50;
            }

            set
            {
                nrCoins50 = value;
            }
        }

        public int nrbanknote1
        {
            get
            {
                return nrBanknote1;
            }

            set
            {
                nrBanknote1 = value;
            }
        }

        public int nrbanknote5
        {
            get
            {
                return nrBanknote5;
            }

            set
            {
                nrBanknote5 = value;
            }
        }

        public float Balance
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
            }
        }

        public float ComputeTotal()
        {
            float total = nrcoins10 + nrcoins50 + nrbanknote1 + nrbanknote5;

            return total;
        }

        public void CollectMoney(int nrCoins10, int  nrCoins50, int nrBanknote1, int nrBanknote5)
        {
            nrcoins10 += nrCoins10;
            nrcoins50 += nrCoins50;
            nrbanknote1 += nrBanknote1;
            nrbanknote5 += nrBanknote5;
        }

        public bool GiveChange(float change)
        {
            int change10Coins = 0;
            int change50Coins = 0;
            int change1banknote = 0;
            int change5banknote = 0;
            if (change > ComputeTotal())
                return false;
            if (change / 5 >= 1)
            {
                change5banknote += (int)(change / 5);
                change -= (5.00f * change5banknote);
                nrbanknote5 -= change5banknote;
            }
            if (change / 1 >= 1)
            {
                change1banknote += (int)(change / 1);
                change -= (1.00f * change1banknote);
                nrbanknote1 -= change1banknote;
            }
            if (change / 0.5 >= 1)
            {
                change50Coins += (int)(change / 0.5);
                change -= (0.5f * change50Coins);
                nrcoins50 -= change50Coins;
            }
            if (change / 0.1 >= 1)
            {
                change10Coins += (int)(change / 0.1);
                change -= (0.1f * change5banknote);
                nrcoins10 -= change10Coins;
            }

            return true;

        }
    }
}
