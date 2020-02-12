using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTrader
{
    class SpaceShip
    {
        public SpaceShip()
        {
            ShipStorage();
            ShipWeapons();
            ShipFuelInUse();
        }

        private void ShipStorage()
        {
            List<(double, string)> storage = new List<(double, string)>(); //a list has been created. Maybe an array would be better? 
                                                                           //If array, how do we change to a new array if we modify the ship
                                                                           //through upgrades



        }

        private void ShipWeapons()
        {
            //stretch goal to add function
        }

        private void ShipFuelInUse()
        {
            //Will need to define how much fuel is on the ship,
            //the ratio of use of the fuel in travel,
            //and a way to graphically display it.
        }
        
    }
}
