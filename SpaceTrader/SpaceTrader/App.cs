using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTrader
{
    class App
    {
        public void Run()
        {
            var currentPlanet = 0;

            List<Planet> StarChart = new List<Planet>();
            
            Planet SOL = new Planet
            {
                Name = "SOL",
                Coord = new Location
                {
                    x = 0,
                    y = 0
                }

            };
            Planet PCB = new Planet
            {
                Name = "PC-B",
                Coord = new Location
                {
                    x = 2.646,
                    y = -3
                }

            };
            Planet BSB = new Planet
            {
                Name = "BS-B",
                Coord = new Location
                {
                    x = 4,
                    y = 4.472
                }

            };
            Planet ROSS128 = new Planet
            {
                Name = "ROSS-128",
                Coord = new Location
                {
                    x = 0,
                    y = -11
                }

            };
            Planet LSB = new Planet
            {
                Name = "LS-B",
                Coord = new Location
                {
                    x = -10.392,
                    y = -6
                }

            };
            Planet WOLF1061 = new Planet
            {
                Name = "WOLF-1061",
                Coord = new Location
                {
                    x = 9.798,
                    y = 10
                }

            };
            Planet GLIESE832 = new Planet
            {
                Name = "GLIESE-832",
                Coord = new Location
                {
                    x = 15,
                    y = -5.56776
                }

            };
            Planet HR8832G = new Planet
            {
                Name = "HR8832-G",
                Coord = new Location
                {
                    x = -13.601,
                    y = 16
                }

            };
            StarChart.Add(SOL);
            StarChart.Add(PCB);
            StarChart.Add(BSB);
            StarChart.Add(ROSS128);
            StarChart.Add(LSB);
            StarChart.Add(WOLF1061);
            StarChart.Add(GLIESE832);
            StarChart.Add(HR8832G);

            TradingItems Food = new TradingItems
            {
                TradingItemName = "Food"
            };
            TradingItems Textiles = new TradingItems
            {
                TradingItemName = "Textiles"
            };
            TradingItems Electronics = new TradingItems
            {
                TradingItemName = "Electronics"
            };
            TradingItems SpareParts = new TradingItems
            {
                TradingItemName = "Spare Parts"
            };

            OreType Titanium = new OreType
            {
                OreName = "Titanium"
            };
            OreType Gold = new OreType
            {
                OreName = "Gold"
            };
            OreType Platinum = new OreType
            {
                OreName = "Platinum"
            };
            OreType Vibranium = new OreType
            {
                OreName = "Vibranium"
            };

            DangerousItems CapturedHydrogen = new DangerousItems
            {
                DangerousItemName = "Captured Hydrogen"
            };
            DangerousItems PoloniumFuel = new DangerousItems
            {
                DangerousItemName = "Polonium Fuel Rods"
            };

            IllegalItems Spice = new IllegalItems
            {
                IllegalItemName = "Spice"
            };
            IllegalItems Weapons = new IllegalItems
            {
                IllegalItemName = "Weapons"
            };

            var inventory = new InventorySystem();

            new SpaceTrader.Menu();

            new SpaceTrader.Intro();

            new SpaceTrader.MapAndTravel().DisplayMap(StarChart, ref currentPlanet, Titanium, Gold, Platinum, Vibranium, inventory);

        }
    }
}
