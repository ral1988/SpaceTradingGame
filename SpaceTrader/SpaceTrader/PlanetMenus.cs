using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTrader
{
    class PlanetMenus
    {
        public static void Menus(List<Planet> StarChart, ref int currentPlanet, OreType Titanium, OreType Gold, OreType Platinum, OreType Vibranium)
        {
            //menu for the planet
            Console.WriteLine($"You are on the surface of {StarChart[currentPlanet].Name}");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine();
            Console.WriteLine("1. Go Mining");
            Console.WriteLine("2. Visit Trading Post");
            Console.WriteLine("3. Visit Fuel Depot");
            Console.WriteLine("4. Visit the Cantina.");
            Console.WriteLine("5. Leave Planet.");
            Console.WriteLine();
            Console.WriteLine("Enter a Menu Number to Proceed.");
            var input = Console.ReadKey();

            //input validation
            while (input.Key != ConsoleKey.D1 && input.Key != ConsoleKey.D2 && input.Key != ConsoleKey.D3 && input.Key != ConsoleKey.D4 && input.Key != ConsoleKey.D5)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input. Try Again.");
                input = Console.ReadKey();
            }

            //menu items
            if (input.Key == ConsoleKey.D1)
            {
                //calls the random generator
                Random rand = RandomGenerator.NewRand();

                //runs the results method
                OreType result = MiningResult.Results(rand, Titanium, Gold, Platinum, Vibranium);

                //Passes result to mining returns
                MiningReturns.Returns(result);

                //gets the result from MiningReturns
                int amount = MiningReturns.Returns(result);

                double timeToMine = MiningTime.TimeElapsed();

                for (int i = 0; i <= amount; ++i)
                {
                    new InventorySystem().FirstAvail();
                    new InventorySystem().AddItem(result);
                }

                //Displays mining result
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($"You have gone mining for {timeToMine} days and retrieved {amount} tons of {result.OreName}.");
                Menus(StarChart, ref currentPlanet, Titanium, Gold, Platinum, Vibranium);

            }
            else if (input.Key == ConsoleKey.D2)
            {
                Console.Clear();
                Console.WriteLine("You are in the trading post. What would you like to do?");
                Console.WriteLine();
                Console.WriteLine("1. Buy Items");
                Console.WriteLine("2. Sell Items");
                
            }
            else if (input.Key == ConsoleKey.D3)
            {

            }
            else if (input.Key == ConsoleKey.D4)
            {

            }
            else if (input.Key == ConsoleKey.D5)
            {
                Console.Clear();
                new SpaceTrader.MapAndTravel().DisplayMap(StarChart, ref currentPlanet, Titanium, Gold, Platinum, Vibranium);
            }
        }
    }
}
