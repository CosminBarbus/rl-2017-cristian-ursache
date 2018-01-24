using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class ProductCollection
    {
        private PaymentTerminal terminal = new PaymentTerminal();

        internal PaymentTerminal Terminal
        {
            get
            {
                return terminal;
            }

            set
            {
                terminal = value;
            }
        }

        public bool Add(Dispenser band)
        {
            for (int i = 0; i < 10; i++)
            {
                if (band.Slot[i] == 0)
                {
                    band.Slot[i] = 1;
                    return true;
                }

            }
            return false;

        }
       
       public bool Remove(Dispenser band)
       {
           if (band.Dispose()) 
               return true; 
           else
               return false;
        }

        public int Count(List<Dispenser> dispensers)
        {
            int count = 0;
            foreach (var disp in dispensers)
            {
                count += disp.Count();
            }
            return count;
        }


        public bool GetItem(Dispenser band, float money)
        {
            if (band.Item.price <= money)
            {
                Remove(band);
                Terminal.GiveChange(money - (float)band.Item.price);
                return true;
            }
            return false;
        }
        /*public void GetItem()
        {
            ProductCategory category;
            ContainableItem item = null;
            double money = Program.Money();

            Console.WriteLine("Choose a category of product: ");
            Console.WriteLine("1 - Soda, 2 - Snacks, 3 - Sandwiches");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    category = new ProductCategory("Soda");
                    break;
                case "2":
                    category = new ProductCategory("Snack");
                    break;
                case "3":
                    Console.WriteLine("Sandwich");
                    break;
                default:
                    Console.WriteLine("Invalid category");
                    break;
            }

            Console.WriteLine("Choose desired product: ");
            if (input == "1")
            {
                Console.WriteLine("1 - Coca Cola 250, price: 0.5$");
                Console.WriteLine("2 - Sprite 330, price: 0.75$");
                Console.WriteLine("3 - Fanta 500, price: 1$");

                input = Console.ReadLine();
                if (input == "1")
                    item = cocacola;
                else if (input == "2")
                    item = sprite;
                else if (input == "3")
                    item = fanta;

            }
            else if (input == "2")
            {
                Console.WriteLine("1 - Snickers, price: 0.75$");
                Console.WriteLine("2 - Cheetos, price:1$");
                Console.WriteLine("3 - Lays, price: 1.5$");

                input = Console.ReadLine();
                if (input == "1")
                    item = snickers;
                else if (input == "2")
                    item = cheetos;
                else if (input == "3")
                    item = lays;

            }
            else if (input == "3")
            {
                Console.WriteLine("1 - Bacon Sandwich, price: 1$");
                Console.WriteLine("2 - Crisp, price: 1.5$");
                Console.WriteLine("3 - Kebab, price: 2$");

                input = Console.ReadLine();
                if (input == "1")
                    item = baconSandwich;
                else if (input == "2")
                    item = crisp;
                else if (input == "3")
                    item = kebab;
            }
            if(Remove(item))
            {   
            if (money < item.product.price)
                Console.WriteLine("Insufficient funds"); 
            else
            {
                Console.WriteLine("Your change is {0} $", (money - item.product.price));
                Console.WriteLine("Please pick up: {0} ", item.product.name);
            }
            }

        }*/
    }
}
