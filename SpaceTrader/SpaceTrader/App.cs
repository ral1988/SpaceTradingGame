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

            double Money = 1000.0;

            var callAge = new PlayerAge();
            callAge.age.Add(18);


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

            Fuel Fuel = new Fuel
            {
                Name = "Fuel",
                Price = 10
            };

            Fuel.Add(100);

            

            TradingItems Food = new TradingItems
            {
                Name = "Food",
                Price = 1000
            };
            TradingItems Textiles = new TradingItems
            {
                Name = "Textiles",
                Price = 1000
            };
            TradingItems Electronics = new TradingItems
            {
                Name = "Electronics",
                Price = 2000
            };
            TradingItems SpareParts = new TradingItems
            {
                Name = "Spare Parts",
                Price = 2000
            };
            TradingItems Water = new TradingItems
            {
                Name = "Water",
                Price = 2000
            };

            OreType Titanium = new OreType
            {
                Name = "Titanium",
                Price = 3000
            };
            OreType Gold = new OreType
            {
                Name = "Gold",
                Price = 4000
            };
            OreType Platinum = new OreType
            {
                Name = "Platinum",
                Price = 5000
            };
            OreType Vibranium = new OreType
            {
                Name = "Vibranium",
                Price = 7000
            };

            DangerousItems CapturedHydrogen = new DangerousItems
            {
                Name = "Captured Hydrogen",
                Price = 6000
            };
            DangerousItems PoloniumFuel = new DangerousItems
            {
                Name = "Polonium Fuel Rods",
                Price = 8000
            };

            IllegalItems Spice = new IllegalItems
            {
                Name = "Spice",
                Price = 10000
            };
            IllegalItems Weapons = new IllegalItems
            {
                Name = "Weapons",
                Price = 12000
            };

            var inventory = new InventorySystem();

            new SpaceTrader.Menu();

            new SpaceTrader.Intro();

            new SpaceTrader.MapAndTravel().DisplayMap(StarChart, ref currentPlanet, ref callAge, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CapturedHydrogen, PoloniumFuel, Spice, Weapons, ref Money, ref Fuel.FuelTank);

        }
    }
}
