﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceTrader
{
    class Fuel : Item
    {
        public double FuelTank = 0;
        public List<double> currentFuelTank = new List<double> { };

        public double Capacity { get; set; }

        // Constructor
        public Fuel(double capacity = 100.00)
        {
            SetInventorySize(capacity);
        }

        // Set size of fuel tank, retaining contents where possible
        public void SetInventorySize(double capacity)
        {
           var Capacity = capacity;

            if (Capacity > 100)
            {
                Capacity = 100;
            }
             
        }

        public void Add(double newfuel)
        {
            FuelTank += newfuel;

            currentFuelTank.Add(FuelTank);

            if (currentFuelTank.Sum() > 100.00)
            {
                currentFuelTank.Clear();
                currentFuelTank.Add(100.00);
            }
        }

        public void Remove(double usedFuel)
        {
            FuelTank -= usedFuel / 20;

            currentFuelTank.Add(FuelTank);

            if ((currentFuelTank.Sum() < 0) || (currentFuelTank.Sum() == 0))
            {
                Console.WriteLine("You ran out of fuel, and have died");
            }


        }
    }
}
