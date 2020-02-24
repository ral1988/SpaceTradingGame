using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceTrader
{
    class Fuel : Item
    {
        public List<double> currentFuelTank = new List<double> { };

        public Fuel()
        {

        }

        public void AddFuel(double buyFuel)
        {
            var newFuel = buyFuel;

            currentFuelTank.Add(newFuel);

            if (currentFuelTank.Sum() > 100.00)
            {
                currentFuelTank.Clear();
                currentFuelTank.Add(100.00);
            }
        }

        public void RemoveFuel(double distance)
        {
            
            var usedFuel = -1 * (distance * 2);
            currentFuelTank.Add(usedFuel);

            if ((currentFuelTank.Sum() < 0) || (currentFuelTank.Sum() == 0))
            {
                NoFuel();
            }
        }
        public void NoFuel()
        {
            Console.Clear();
            Console.WriteLine("You ran out of fuel, and have died");

            Environment.Exit(0);

        }

        public void SellFuel(int amount)
        {
            var usedFuel = -1 * (amount);
            currentFuelTank.Add(usedFuel);
        }
    }
}
