using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class ProductCollection
    {

        /*
        //Categories
        static ProductCategory Soda = new ProductCategory("Soda");
        static ProductCategory Snack = new ProductCategory("Snack");
        static ProductCategory Sandwich = new ProductCategory("Sandwich");

        //Products
        // Soda 
        static Product CocaCola = new Product("Coca-Cola 250", 0.5, 1, Soda);
        static Product Sprite = new Product("Sprite 330", 0.75, 2, Soda);
        static Product Fanta = new Product("Fanta 500", 1, 3, Soda);


        // Snack 
        static Product Snickers = new Product("Snickers", 0.75, 1, Snack);
        static Product Cheetos = new Product("Cheetos", 1, 2, Snack);
        static Product Lays = new Product("Lays", 1.5, 3, Snack);

        // Sandwich
        static Product BaconSandwich = new Product("Bacon Sandwich", 1, 1, Sandwich);
        static Product Crisp = new Product("Crisp",1.5, 2, Sandwich);
        static Product Kebab = new Product("Kebab", 2, 3, Sandwich);

        
        //ContainableItem
        ContainableItem sprite = new ContainableItem(Sprite);
        ContainableItem cocacola = new ContainableItem(CocaCola);
        ContainableItem fanta = new ContainableItem(Fanta);
        ContainableItem snickers = new ContainableItem(Snickers);
        ContainableItem cheetos = new ContainableItem(Cheetos);
        ContainableItem lays = new ContainableItem(Lays);
        ContainableItem baconSandwich = new ContainableItem(BaconSandwich);
        ContainableItem crisp = new ContainableItem(Crisp);
        ContainableItem kebab = new ContainableItem(Kebab); 
        */
        //Dispensers
        /*
        Dispenser cocaColaBand = new Dispenser(1);
        Dispenser spriteBand = new Dispenser(2);
        Dispenser fantaBand = new Dispenser(3);

        Dispenser snickersBand = new Dispenser(1);
        Dispenser cheetosBand = new Dispenser(2);
        Dispenser laysBand = new Dispenser(3);

        Dispenser baconSandwichBand = new Dispenser(1);
        Dispenser CrispBand = new Dispenser(2);
        Dispenser KebabBand = new Dispenser(3);
        */

        public bool Add(Dispenser band)
        {
            if (band.AddItem())
                return true;
            else
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
        public void Payment(float dollars)
        {
            //if()
        }

        public float GetItem(Dispenser band, float money)
        {
            if (band.Product.price <= money)
            {
                money -= (float)band.Product.price;
                Remove(band);
            }
            return money;
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
