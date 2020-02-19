using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceTrader
{
    class InventorySystem
    {
        // Array to store items
        public List<Item> Items = new List<Item>();

        // Inventory capacity is array length
        public int Capacity { get; set; }

        // Constructor
        public InventorySystem(int capacity = 20)
        {
            SetInventorySize(capacity);
        }

        // Set size of inventory, retaining contents where possible
        public void SetInventorySize(int capacity)
        {
            Capacity = capacity;
        }

        // Add item to array, returning index or -1 on failure
        public bool AddItem(Item item)
        {
            if (Items.Count < Capacity) 
            {
                Items.Add(item);
                return true;
            }

            return false;
        }

        public void RemoveItem(int output, InventorySystem inventory)
        {
            inventory.Items.RemoveAt(output - 1);
        }

        
    }
}
