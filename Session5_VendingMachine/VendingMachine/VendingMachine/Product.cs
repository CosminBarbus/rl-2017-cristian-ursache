﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Product
    {
        private string Name;
        private double Price;
        private int Size;
        private ProductCategory Category;

        public Product(string Name, double Price, int Size, ProductCategory Category)
        {
            name = Name;
            price = Price;
            size = Size;
            category = Category;
        }

        public Product()
        {

        }

        public string name
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        public double price
        {
            get
            {
                return Price;
            }

            set
            {
                Price = value;
            }
        }

        public int size
        {
            get
            {
                return Size;
            }

            set
            {
                Size = value;
            }
        }

        internal ProductCategory category
        {
            get
            {
                return Category;
            }

            set
            {
                Category = value;
            }
        }
    }
}
