using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTrader
{
    class PlanetMenus
    {
        public static void Menus(List<Planet> StarChart, ref int currentPlanet, OreType Titanium, OreType Gold, OreType Platinum, OreType Vibranium, InventorySystem inventory, TradingItems Food, TradingItems Water, TradingItems Textiles, TradingItems Electronics, TradingItems SpareParts, DangerousItems CapturedHydrogen, DangerousItems PoloniumFuel, IllegalItems Spice, IllegalItems Weapons, ref double Money)
        {
            PlanetSupply planetSupply = new PlanetSupply();

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

                //gets the result from MiningReturns
                int amount = MiningReturns.Returns(result);

                double timeToMine = MiningTime.TimeElapsed();


                //Displays mining result
                Console.Clear();
                Console.WriteLine();
                Console.Write($"You have gone mining for {timeToMine} days and retrieved {amount} tons of {result.OreName}");

                for (int i = 0; i < amount; ++i)
                {
                    var addedItem = inventory.AddItem(result);

                    if (!addedItem)
                    {
                        Console.Write($", but your inventory was full, so you had to throw away {amount - i} tons");
                        break;
                    }
                }

                Console.WriteLine(".");

                Menus(StarChart, ref currentPlanet, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CapturedHydrogen, PoloniumFuel, Spice, Weapons, ref Money);

            }
            else if (input.Key == ConsoleKey.D2)
            {
                Console.Clear();
                input = TradingPostMenu();
                

                while (input.Key != ConsoleKey.D1 && input.Key != ConsoleKey.D2)
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid Input. Try Again.");
                    input = Console.ReadKey();
                }

                if (input.Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    Console.WriteLine("What do you want to buy?"); //put it into a new class
                    Console.WriteLine();
                    Console.WriteLine("1. Textiles");
                    Console.WriteLine("2. Food");
                    Console.WriteLine("3. Water");
                    Console.WriteLine("4. Spare Parts");
                    Console.WriteLine("5. Electronics");
                    Console.WriteLine("6. Polonium Fuel Rods");
                    Console.WriteLine("7. Go Back");
                    Console.WriteLine();
                    Console.WriteLine("Enter a Menu Number to Proceed.");
                    var input2 = Console.ReadKey();

                    while (input2.Key != ConsoleKey.D1 && input2.Key != ConsoleKey.D2 && input2.Key != ConsoleKey.D3 && input2.Key != ConsoleKey.D4 && input2.Key != ConsoleKey.D5 && input2.Key != ConsoleKey.D6 && input2.Key != ConsoleKey.D7)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid Input. Try Again.");
                        input2 = Console.ReadKey();
                    }

                    if (input2.Key == ConsoleKey.D1)
                    {
                        Console.WriteLine();
                        int amount = AmountCalc(inventory);

                        var baseprice = Textiles.Price;
                        var price = planetSupply.PlanetPurchaseSelection(ref currentPlanet, baseprice, amount);

                        Console.WriteLine($"This will cost $\u03B2{price}. You have $\u03B2 {String.Format("{0:0,0.00}", Money)} Would you like to Continue?");
                        Console.WriteLine("Y or N?");
                        input = Console.ReadKey();
                        while (input.Key != ConsoleKey.Y && input.Key != ConsoleKey.N)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid Input. Try Again.");
                            input = Console.ReadKey();
                        }
                        if (input.Key == ConsoleKey.Y)
                        {
                            for (int i = 0; i < amount; ++i)
                            {
                                Money -= price;
                                
                                inventory.AddItem(Textiles);
                            }
                            if (Money < 0)
                            {
                                //Failure screen
                                new FailureScreen().Failure(ref Money);
                                
                            }
                        }
                        Console.Clear();
                        Menus(StarChart, ref currentPlanet, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CapturedHydrogen, PoloniumFuel, Spice, Weapons, ref Money);

                    }
                    else if (input2.Key == ConsoleKey.D2)
                    {
                        Console.WriteLine();
                        int amount = AmountCalc(inventory);

                        var baseprice = Food.Price;
                        var price = planetSupply.PlanetPurchaseSelection(ref currentPlanet, baseprice, amount);

                        Console.WriteLine($"This will cost $\u03B2{price}. Would you like to Continue?");
                        Console.WriteLine("Y or N?");
                        input = Console.ReadKey();
                        while (input.Key != ConsoleKey.Y && input.Key != ConsoleKey.N)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid Input. Try Again.");
                            input = Console.ReadKey();
                        }
                        if (input.Key == ConsoleKey.Y)
                        {
                            for (int i = 0; i < amount; ++i)
                            {
                                Money -= price;
                                
                                inventory.AddItem(Food);
                            }
                            if (Money < 0)
                            {
                                //Failure screen
                                new FailureScreen().Failure(ref Money);

                            }
                        }
                        Console.Clear();
                        Menus(StarChart, ref currentPlanet, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CapturedHydrogen, PoloniumFuel, Spice, Weapons, ref Money);

                    }
                    else if (input2.Key == ConsoleKey.D3)
                    {
                        Console.WriteLine();
                        int amount = AmountCalc(inventory);

                        var baseprice = Water.Price;
                        var price = planetSupply.PlanetPurchaseSelection(ref currentPlanet, baseprice, amount);

                        Console.WriteLine($"This will cost $\u03B2{price}. Would you like to Continue?");
                        Console.WriteLine("Y or N?");
                        input = Console.ReadKey();
                        while (input.Key != ConsoleKey.Y && input.Key != ConsoleKey.N)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid Input. Try Again.");
                            input = Console.ReadKey();
                        }
                        if (input.Key == ConsoleKey.Y)
                        {
                            for (int i = 0; i < amount; ++i)
                            {
                                Money -= price;
                                
                                inventory.AddItem(Water);
                            }
                            if (Money < 0)
                            {
                                //Failure screen
                                new FailureScreen().Failure(ref Money);

                            }
                        }
                        Console.Clear();
                        Menus(StarChart, ref currentPlanet, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CapturedHydrogen, PoloniumFuel, Spice, Weapons, ref Money);


                    }
                    else if (input2.Key == ConsoleKey.D4)
                    {
                        Console.WriteLine();
                        int amount = AmountCalc(inventory);

                        var baseprice = SpareParts.Price;
                        var price = planetSupply.PlanetPurchaseSelection(ref currentPlanet, baseprice, amount);

                        Console.WriteLine($"This will cost $\u03B2{price}. Would you like to Continue?");
                        Console.WriteLine("Y or N?");
                        input = Console.ReadKey();
                        while (input.Key != ConsoleKey.Y && input.Key != ConsoleKey.N)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid Input. Try Again.");
                            input = Console.ReadKey();
                        }
                        if (input.Key == ConsoleKey.Y)
                        {
                            for (int i = 0; i < amount; ++i)
                            {
                                Money -= price;
                                
                                inventory.AddItem(SpareParts);
                            }
                            if (Money < 0)
                            {
                                //Failure screen
                                new FailureScreen().Failure(ref Money);

                            }
                        }
                        Console.Clear();
                        Menus(StarChart, ref currentPlanet, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CapturedHydrogen, PoloniumFuel, Spice, Weapons, ref Money);

                    }
                    else if (input2.Key == ConsoleKey.D5)
                    {
                        Console.WriteLine();
                        int amount = AmountCalc(inventory);

                        var baseprice = Electronics.Price;
                        var price = planetSupply.PlanetPurchaseSelection(ref currentPlanet, baseprice, amount);

                        Console.WriteLine($"This will cost $\u03B2{price}. Would you like to Continue?");
                        Console.WriteLine("Y or N?");
                        input = Console.ReadKey();
                        while (input.Key != ConsoleKey.Y && input.Key != ConsoleKey.N)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid Input. Try Again.");
                            input = Console.ReadKey();
                        }
                        if (input.Key == ConsoleKey.Y)
                        {
                            for (int i = 0; i < amount; ++i)
                            {
                                Money -= price;
                                
                                inventory.AddItem(Electronics);
                            }
                            if (Money < 0)
                            {
                                //Failure screen
                                new FailureScreen().Failure(ref Money);

                            }
                        }
                        Console.Clear();
                        Menus(StarChart, ref currentPlanet, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CapturedHydrogen, PoloniumFuel, Spice, Weapons, ref Money);

                    }
                    else if (input2.Key == ConsoleKey.D6)
                    {
                        Console.WriteLine();
                        int amount = AmountCalc(inventory);

                        var baseprice = PoloniumFuel.Price;
                        var price = planetSupply.PlanetPurchaseSelection(ref currentPlanet, baseprice, amount);

                        Console.WriteLine($"This will cost $\u03B2{price}. Would you like to Continue?");
                        Console.WriteLine("Y or N?");
                        input = Console.ReadKey();
                        while (input.Key != ConsoleKey.Y && input.Key != ConsoleKey.N)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid Input. Try Again.");
                            input = Console.ReadKey();
                        }
                        if (input.Key == ConsoleKey.Y)
                        {
                            for (int i = 0; i < amount; ++i)
                            {
                                Money -= price;
                                
                                inventory.AddItem(PoloniumFuel);
                            }
                            if (Money < 0)
                            {
                                //Failure screen
                                FailureScreen.Failure(ref Money);

                            }
                        }
                        Console.Clear();
                        Menus(StarChart, ref currentPlanet, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CapturedHydrogen, PoloniumFuel, Spice, Weapons, ref Money);

                    }
                    else
                    {
                        Console.WriteLine();
                        Console.Clear();
                        Menus(StarChart, ref currentPlanet, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CapturedHydrogen, PoloniumFuel, Spice, Weapons, ref Money);

                    }

                }


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
                new SpaceTrader.MapAndTravel().DisplayMap(StarChart, ref currentPlanet, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CapturedHydrogen, PoloniumFuel, Spice, Weapons, ref Money);
            }
        }

        private static int AmountCalc(InventorySystem inventory)
        {
            Console.WriteLine("Amount you would like to purchase?");
            Console.WriteLine("Type 1, 2, 3, 4, etc. tons.");

            int output;
            do
            {
                var input3 = Console.ReadLine();
                while (!int.TryParse(input3, out output))
                {
                    Console.WriteLine("Invalid Input. Try Again.");
                    input3 = Console.ReadLine();
                }

                if (output + inventory.Items.Count > inventory.Capacity)
                    Console.WriteLine("Inventory Overflow. Type another amount.");

            } while (output + inventory.Items.Count > inventory.Capacity);
            return output;
        }

        private static ConsoleKeyInfo TradingPostMenu()
        {
            Console.WriteLine("You are in the trading post. What would you like to do?");
            Console.WriteLine();
            Console.WriteLine("1. Buy Items");
            Console.WriteLine("2. Sell Items");

            var input = Console.ReadKey();

            return input;
        }
    }
}
