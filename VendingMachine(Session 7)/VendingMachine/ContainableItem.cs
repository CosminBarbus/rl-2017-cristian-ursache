using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class ContainableItem : Product
    {
        private sbyte Row;
        private sbyte Column;
        private Product Product;

        public sbyte row
        {
            get
            {
                return Row;
            }

            set
            {
                Row = value;
            }
        }

        public sbyte col
        {
            get
            {
                return Column;
            }

            set
            {
                Column = value;
            }
        }

        internal Product product
        {
            get
            {
                return Product;
            }

            set
            {
                Product = value;
            }
        }

        public void SetRowCol()
        {
            //set row
            if (product.category.name == "Soda")
            {
                row = 0;
            }

            else if (product.category.name == "Snack")
            {
                row = 1;
            }

            else if (product.category.name == "Sancwich")
            {
                row = 2;
            }

            //set collumn
            if (product.size == 1)
            {
                col = 0;
            }

            else if (product.size == 2)
            {
                col = 1;
            }

            else if (product.size == 3)
            {
                col = 2;
            }



        }


        public ContainableItem(Product Prod)
        {
            product = Prod;

            SetRowCol();

        }

        public ContainableItem(string Name, float Price, int Size, ProductCategory Category)
            {
            Product prod = new Product(Name, Price, Size, Category);
            product = prod;
            }
    }
}
