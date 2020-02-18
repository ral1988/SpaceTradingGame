using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTrader
{
    class PlanetSupplyInfo
    {
        public PlanetSupplyInfo()
        {

            SolSupply();
            ProximaCentauriBSupply();
            BarnardsStarBSupply();
            Ross128BSupply();
            LuytensStarBSupply();
            Wolf1061CSupply();
            Gliese832CSupply();
            HD8832GSupply();

        }

          
        private void SolSupply()
        {
            bool ore = false;
            bool commonGoods = false;
            bool illegal = false;
            if (!ore)
            {

                var price = basePrice * (localDemand + demandFactor * unitsInDemand) / (localSupply + supplyFactor * unitsSupplied);

            }
            if (!commonGoods)
            {

            }
            if (!illegal)
            {

            }

            

            /*var basePrice = 100;                    //baseprice is universal across the map based on the item type
                  var localDemand = PlanetInfo;          //planet determines the local demand
                  var demandFactor = ;                    //ratio: planets overall demand for item / planet total (7)
                  var unitsInDemand = PlanetInfo.;        //a ratio of how much the planet you are at wants this item
                  var localSupply = PlanetInfo.;          //What is in supply on the local planet
                  var supplyFactor = ;                    //How much of the item is currently available - how the universe started with
                  var unitsSupplied = a;                  //how many the end user is requesting

                  var price = basePrice * (localDemand + demandFactor * unitsInDemand) / (localSupply + supplyFactor * unitsSupplied);*/

            //Sol
            //Ore: Titanium, Gold, Platinum, Vibranium
            //Common goods:  Fuel, Food, Water, Textitles, Electronics, Space Parts, Polonlum Fuel Rods
            //Illegal: Spice, Weapons

        }
        private void ProximaCentauriBSupply()
        {
          

            //ProximaCentauriB 
            //Ore: Titanium, Gold, Platinum, Vibranium
            //Common goods:  Fuel, Food, Water, Textitles, Electronics, Space Parts, Captured Hydrogen, Polonlum Fuel Rods
            //Illegal: Spice, Weapons
        }

        private void BarnardsStarBSupply()
        {
            
            //BarnardsStarB
            //Ore: Titanium, Gold, Platinum, Vibranium
            //Common goods:  Fuel, Food, Water, Textitles, Electronics, Space Parts, Polonlum Fuel Rods
            //Illegal: Spice, Weapons

        }

        private void Ross128BSupply()
        {
           
            //Ross
            //Ore: Titanium, Gold, Platinum, Vibranium
            //Common goods:  Fuel, Food, Water, Textitles, Electronics, Space Parts, Polonlum Fuel Rods
            //Illegal: Spice, Weapons
        }

        private void LuytensStarBSupply()
        {
        
            //LuytensStar
            //Ore: Titanium, Gold, Platinum, Vibranium
            //Common goods:  Fuel, Food, Water, Textitles, Electronics, Space Parts, Polonlum Fuel Rods
            //Illegal: Spice, Weapons
        }

        private void Wolf1061CSupply()
        {
           
            //Wolf
            //Ore: Titanium, Gold, Platinum, Vibranium
            //Common goods:  Fuel, Food, Water, Textitles, Electronics, Space Parts, Polonlum Fuel Rods
            //Illegal: Spice, Weapons
        }

        private void Gliese832CSupply()
        {
           
            //Gliese
            //Ore: Titanium, Gold, Platinum, Vibranium
            //Common goods:  Fuel, Food, Water, Textitles, Electronics, Space Parts, Polonlum Fuel Rods
            //Illegal: Spice, Weapons
        }

        private void HD8832GSupply()
        {
            
            //HD
            //Ore: Titanium, Gold, Platinum, Vibranium
            //Common goods:  Fuel, Food, Water, Textitles, Electronics, Space Parts, Polonlum Fuel Rods
            //Illegal: Spice, Weapons
        }

    }
}
