using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTrader
{
    class Fuel : Item
    {
        public double FuelTank = 0;

        public double Capacity { get; set; }

        // Constructor
        public Fuel(double capacity = 100.00)
        {
            SetInventorySize(capacity);
        }

        // Set size of fuel tank, retaining contents where possible
        public void SetInventorySize(double capacity)
        {
            Capacity = capacity;
        }

        internal void Add(double newfuel)
        {
            FuelTank += newfuel;
        }

        internal void Remove(double usedFuel)
        {
            FuelTank -= usedFuel / 20;
        }
    }
}
