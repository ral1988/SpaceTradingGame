using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTrader
{
    class SmugglerHold
    {
        // Array to store items
        public List<IllegalItems> Hold = new List<IllegalItems>();

        // Inventory capacity is array length
        public int Capacity { get; set; }

        // Constructor
        public SmugglerHold(int capacity = 2)
        {
            SetHoldSize(capacity);
        }

        // Set size of inventory, retaining contents where possible
        public void SetHoldSize(int capacity)
        {
            Capacity = capacity;
        }

        // Add item to array, returning index or -1 on failure
        public bool AddItem(IllegalItems item)
        {
            if (Hold.Count < Capacity)
            {
                Hold.Add(item);
                return true;
            }

            return false;
        }

        public void RemoveItem(int output, SmugglerHold hold)
        {
            hold.Hold.RemoveAt(output - 1);
        }

        internal void Reset()
        {
            Hold = new List<IllegalItems>();
        }
    }
}
