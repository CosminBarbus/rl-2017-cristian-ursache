using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class ProductCollection
    {
       
       int[,] Cells = new int[3, 3]; // row 0 - for soda , 1 - snack, 2 - sandwich; coll 0 - size 1, coll 1 - size 2, coll 2 - size 3

        //Categories
        static ProductCategory Soda = new ProductCategory("Soda");
        static ProductCategory Snack = new ProductCategory("Snack");
        static ProductCategory Sandwich = new ProductCategory("Sandwich");

        //Products
        /* Soda */
        static Product CocaCola = new Product("Coca-Cola 250", 0.5, 1, Soda);
        static Product Sprite = new Product("Sprite 330", 0.75, 2, Soda);
        static Product Fanta = new Product("Fanta 500", 1, 3, Soda);


        /* Snack */
        static Product Snickers = new Product("Snickers", 0.75, 1, Snack);
        static Product Cheetos = new Product("Cheetos", 1, 2, Snack);
        static Product Lays = new Product("Lays", 1.5, 3, Snack);

        /* Sandwich */
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


        public bool Add(ContainableItem Item)
        {

            if (Cells[Item.row, Item.col] < 10) //max space is 10
            {
                Cells[Item.row, Item.col]++;
                return true;
            }

            else
            {
                Console.WriteLine("Cannot add item!, row [%], coll [%] is full", Item.col, Item.row);
                return false;
            }
            
        }
       
       public bool Remove(ContainableItem Item)
       {
           if (Cells[Item.row, Item.col] > 0)
           {
               Cells[Item.row, Item.col]--;
               return true;
           }
           else
               Console.WriteLine("Out of stock");
               return false;
        }

       public int Count()
        {
            int count = 0;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    count += Cells[i, j];
                }
            return count;
        }

        public void GetItem()
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

        }
    }
}
