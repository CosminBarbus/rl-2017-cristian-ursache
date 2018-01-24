﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Dispenser
    {
        private int[] slot = new int[10];
        private ContainableItem item;
        

        public int[] Slot
        {
            get
            {
                return slot;
            }

            set
            {
                slot = value;
            }
        }

        internal ContainableItem Item
        {
            get
            {
                return item;
            }

            set
            {
                item = value;
            }
        }

        
        public bool Dispose()
        {
            for (int i = 9; i >= 0; i--)
            {
                if (slot[i] == 1)
                {
                    slot[i] = 0;
                    return true;
                }

            }
            return false;
        }

        public int Count()
        {
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                if (slot[i] == 0)
                    return count;
                if (slot[i] == 1)
                    count++;
            }
            return count;
        }

        public Dispenser(ContainableItem Item)
        {
            item = Item;
        }
    }
}
