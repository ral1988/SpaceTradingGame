using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTrader
{
    class Fuel : Item
    {
        public int FuelTank = 0;

        public int Capacity { get; set; }

        // Constructor
        public Fuel(int capacity = 100)
        {
            SetInventorySize(capacity);
        }

        // Set size of fuel tank, retaining contents where possible
        public void SetInventorySize(int capacity)
        {
            Capacity = capacity;
        }

        internal void Add(int newfuel)
        {
            FuelTank += newfuel;
        }

        internal void Remove(int usedFuel)
        {
            FuelTank -= usedFuel / 20;
        }
    }
}
