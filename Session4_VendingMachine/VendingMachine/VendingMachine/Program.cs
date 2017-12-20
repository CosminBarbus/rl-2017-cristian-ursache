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
            
            ProductCollection collection = new ProductCollection();
            collection.GetItem();
            Console.ReadKey();

            




        }
    }
}
