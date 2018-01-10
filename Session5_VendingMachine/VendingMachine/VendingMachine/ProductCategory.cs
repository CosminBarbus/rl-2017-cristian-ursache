using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class ProductCategory
    {
        private string Name;
        private string Description;

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

        public ProductCategory(string Name)
        {
            name = Name;
        }
    }
}
