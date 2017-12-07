using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Animal
    {
        // Code review: breaks encapsulation
        public string name { get; set; }

        public string sound { get; set; }

        public Animal(string Name, string Sound)
        {
            name = Name;
            sound = Sound;
        }

        public override string ToString()
        {
            return name + " makes " + sound; 
        }

    }
}
