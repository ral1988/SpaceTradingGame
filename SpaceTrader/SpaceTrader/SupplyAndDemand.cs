using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTrader
{
    class SupplyAndDemand
    {
        public SupplyAndDemand()
        {

        }


        public double Selling(double demandOfPlanet, int amount)
        {
            var demand = demandOfPlanet;
            var marketSize = demand * 7 + 1000;

            //selling
            var amountSelling = amount;
            var price = amountSelling * demand - marketSize ;

            return price;
        }

        public double Buying(double demandOfPlanet, int amount)
        {
            var demand = demandOfPlanet;
            var marketSize = demand * 7 + 1000;

            var amountBuying = amount;
            var price = amountBuying * marketSize + marketSize;


            return price; 
        }
    }
   
}
