﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTrader
{
    class SupplyAndDemand
    {
        public SupplyAndDemand()
        {

        }


        private double Selling(double demandOfPlanet, int amount)
        {
            var demand = demandOfPlanet;
            var marketSize = demand * 7;

            //selling
            var amountSelling = amount;
            var price = amountSelling * demand - marketSize;

            return price;
        }

        private double Buying(double demandOfPlanet, int amount)
        {
            var demand = demandOfPlanet;
            var marketSize = demand * 7;

            var amountBuying = amount;
            var price = amountBuying * marketSize + marketSize;


            return price; 
        }
        public void ItemsForPurchase()
        {
            var food = 1000.00;
            var textiles = 1000.00;

            
            var electronics = 2000.00;
            var water = 2000.00;
            var spaceParts = 2000.00;
            var plarium = 4000.00;
            var gold = 4000.00;
            var capturedH = 4000.00; //risk
            var polonriumFuelRods = 8000.00; //safe
            var spice = 16000.00; //risk
            var weapons = 16000.00; //risk
        }
    }
   
}
