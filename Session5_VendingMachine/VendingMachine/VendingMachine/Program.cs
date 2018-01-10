using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Program
    {

        public static double Money()
        {
            Console.WriteLine("Introduce an amount of money: ");
            string output = Console.ReadLine();
            return double.Parse(output);

        }

   
        static void Main(string[] args)
        {
            //Categories
            ProductCategory Soda = new ProductCategory("Soda");
            ProductCategory Snack = new ProductCategory("Snack");
            ProductCategory Sandwich = new ProductCategory("Sandwich");

            //Products
            /* Soda */
            Product CocaCola = new Product("Coca-Cola 250", 0.5, 1, Soda);
            Product Sprite = new Product("Sprite 330", 0.75, 2, Soda);
            Product Fanta = new Product("Fanta 500", 1, 3, Soda);


            /* Snack */
            Product Snickers = new Product("Snickers", 0.75, 1, Snack);
            Product Cheetos = new Product("Cheetos", 1, 2, Snack);
            Product Lays = new Product("Lays", 1.5, 3, Snack);

            /* Sandwich */
            Product BaconSandwich = new Product("Bacon Sandwich", 1, 1, Sandwich);
            Product Crisp = new Product("Crisp", 1.5, 2, Sandwich);
            Product Kebab = new Product("Kebab", 2, 3, Sandwich);

            //Dispenser
            Dispenser cocaColaBand = new Dispenser(CocaCola);
            Dispenser spriteBand = new Dispenser(Sprite);
            Dispenser fantaBand = new Dispenser(Fanta);

            Dispenser snickersBand = new Dispenser(Snickers);
            Dispenser cheetosBand = new Dispenser(Cheetos);
            Dispenser laysBand = new Dispenser(Lays);

            Dispenser baconSandwichBand = new Dispenser(BaconSandwich);
            Dispenser CrispBand = new Dispenser(Crisp);
            Dispenser KebabBand = new Dispenser(Kebab);

            List<Dispenser> dispensers = new List<Dispenser>();
            dispensers.Add(cocaColaBand);
            dispensers.Add(spriteBand);
            dispensers.Add(fantaBand);
            dispensers.Add(snickersBand);
            dispensers.Add(cheetosBand);
            dispensers.Add(laysBand);
            dispensers.Add(baconSandwichBand);
            dispensers.Add(CrispBand);
            dispensers.Add(KebabBand);
            


            ProductCollection collection = new ProductCollection();
            collection.Add(cocaColaBand);
            collection.Add(spriteBand);
            int r = collection.Count(dispensers);
            collection.Remove(cocaColaBand);
            r = collection.Count(dispensers);

            float money = 3;
            collection.GetItem(cocaColaBand, money);
            Console.WriteLine(money);
            Console.ReadKey();

           




        }
    }
}
