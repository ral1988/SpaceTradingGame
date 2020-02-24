using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SpaceTrader
{
    class PlanetMenus
    {
        public static void Menus(List<Planet> StarChart, ref int currentPlanet, ref PlayerAge callAge, OreType Titanium, OreType Gold, OreType Platinum, OreType Vibranium, InventorySystem inventory, TradingItems Food, TradingItems Water, TradingItems Textiles, TradingItems Electronics, TradingItems SpareParts, DangerousItems CompressedHydrogen, DangerousItems PoloniumFuel, IllegalItems Spice, IllegalItems Weapons, ref double Money, List<double> currentFuelTank, List<double> age, double endOfAge, SmugglerHold hold, Fuel fuel)
        {
            PlanetSupply planetSupply = new PlanetSupply();
            FailureScreen failureScreen = new FailureScreen();

            //menu for the planet
            Console.ForegroundColor = ConsoleColor.Green;
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

                callAge.TimeCalc(timeToMine / 365.25);

                new FailureScreen().Failure(ref Money, age, endOfAge);

                //Displays mining result
                Console.Clear();
                Console.WriteLine();
                Console.Write($"You have gone mining for {timeToMine} days and retrieved {amount} tons of {result.Name}");

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

                Menus(StarChart, ref currentPlanet, ref callAge, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CompressedHydrogen, PoloniumFuel, Spice, Weapons, ref Money, currentFuelTank, age, endOfAge, hold, fuel);

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
                    Console.WriteLine("6. Go Back");
                    Console.WriteLine();
                    Console.WriteLine("Enter a Menu Number to Proceed.");
                    var input2 = Console.ReadKey();

                    while (input2.Key != ConsoleKey.D1 && input2.Key != ConsoleKey.D2 && input2.Key != ConsoleKey.D3 && input2.Key != ConsoleKey.D4 && input2.Key != ConsoleKey.D5 && input2.Key != ConsoleKey.D6)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid Input. Try Again.");
                        input2 = Console.ReadKey();
                    }

                    if (input2.Key == ConsoleKey.D1)
                    {
                        input = BuyTextiles(StarChart, ref currentPlanet, ref callAge, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CompressedHydrogen, PoloniumFuel, Spice, Weapons, ref Money, currentFuelTank, age, endOfAge, hold, planetSupply, fuel);

                    }
                    else if (input2.Key == ConsoleKey.D2)
                    {
                        input = BuyFood(StarChart, ref currentPlanet, ref callAge, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CompressedHydrogen, PoloniumFuel, Spice, Weapons, ref Money, currentFuelTank, age, endOfAge, hold, planetSupply, fuel);

                    }
                    else if (input2.Key == ConsoleKey.D3)
                    {
                        input = BuyWater(StarChart, ref currentPlanet, ref callAge, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CompressedHydrogen, PoloniumFuel, Spice, Weapons, ref Money, currentFuelTank, age, endOfAge, hold, planetSupply, fuel);

                    }
                    else if (input2.Key == ConsoleKey.D4)
                    {
                        input = BuySpareParts(StarChart, ref currentPlanet, ref callAge, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CompressedHydrogen, PoloniumFuel, Spice, Weapons, ref Money, currentFuelTank, age, endOfAge, hold, planetSupply, fuel);

                    }
                    else if (input2.Key == ConsoleKey.D5)
                    {
                        input = BuyElectronics(StarChart, ref currentPlanet, ref callAge, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CompressedHydrogen, PoloniumFuel, Spice, Weapons, ref Money, currentFuelTank, age, endOfAge, hold, planetSupply, fuel);

                    }
                    
                    else
                    {
                        Console.WriteLine();
                        Console.Clear();
                        Menus(StarChart, ref currentPlanet, ref callAge, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CompressedHydrogen, PoloniumFuel, Spice, Weapons, ref Money, currentFuelTank, age, endOfAge, hold, fuel);

                    }

                }
                else if (input.Key == ConsoleKey.D2)
                {
                    
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("What would you like to sell?");
                    
                    for (int i = 0; i < inventory.Items.Count; ++i)
                    {
                        Console.WriteLine($"{i + 1}. {(inventory.Items[i]).Name} ");
                    }

                    Console.WriteLine("Enter the desired inventory slot or enter A for ALL.");
                    var slot = Console.ReadLine();

                    int output;
                    
                    if (slot == "a")
                    {
                        // Sells all
                        input = SellAll(StarChart, ref currentPlanet, ref callAge, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CompressedHydrogen, PoloniumFuel, Spice, Weapons, ref Money, currentFuelTank,age, endOfAge, hold, planetSupply, fuel);
                    }
                    else
                    {
                        while (!Int32.TryParse(slot, out output))
                        {
                            Console.WriteLine("Invalid input. Try again.");
                        }
                        int amount = 1;
                        int baseprice = (inventory.Items[output - 1]).Price;
                        double price = Math.Abs(planetSupply.PlanetSellingSelection(ref currentPlanet, baseprice, amount));
                        Console.WriteLine();
                        Console.WriteLine($"Would you like to sell selected item for $\u03B2 {String.Format("{0:0,0.00}", price)}?");

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
                                Money += price;

                                inventory.RemoveItem(output, inventory);

                                if (Money >= 10000000)
                                {
                                    VictoryScreen.Victory(ref Money);
                                }
                            }
                            
                        }
                    }
                    Console.Clear();
                    Menus(StarChart, ref currentPlanet, ref callAge, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CompressedHydrogen, PoloniumFuel, Spice, Weapons, ref Money, currentFuelTank, age, endOfAge, hold, fuel);

                }


            }
            else if (input.Key == ConsoleKey.D3)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Fuel Depot!");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine();
                Console.WriteLine("1. Buy Items");
                Console.WriteLine("2. Sell Items");
                Console.WriteLine("3. Go Back");

                input = Console.ReadKey();

                while (input.Key != ConsoleKey.D1 && input.Key != ConsoleKey.D2 && input.Key != ConsoleKey.D3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input. Try Again.");
                    input = Console.ReadKey();
                }

                if (input.Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    Console.WriteLine("What would you like to buy?");
                    Console.WriteLine();
                    Console.WriteLine("1. Spaceship Fuel");
                    Console.WriteLine("2. Compressed Hydrogen");
                    Console.WriteLine("3. Polonium Fuel Rods");
                    Console.WriteLine("4. Go Back");

                    input = Console.ReadKey();

                    while (input.Key != ConsoleKey.D1 && input.Key != ConsoleKey.D2 && input.Key != ConsoleKey.D3 && input.Key != ConsoleKey.D4)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid input. Try Again.");
                        input = Console.ReadKey();
                    }

                    if (input.Key == ConsoleKey.D1)
                    {
                        Console.WriteLine($"You have {String.Format("{0:0,0.00}", currentFuelTank.Sum())}/100.00. How many units of fuel would you like to buy?");

                        string fuelamount = Console.ReadLine();
                        int amount;
                        while (!int.TryParse(fuelamount, out amount))
                        {
                            Console.WriteLine("Invalid Input. Try again.");
                            fuelamount = Console.ReadLine();

                        }
                        
                        double buyfuel = Convert.ToDouble(amount);
                        var baseprice = fuel.Price;
                        var price = planetSupply.PlanetPurchaseSelection(ref currentPlanet, baseprice, amount);

                        Console.WriteLine($"This will cost $\u03B2{String.Format("{0:0,0.00}", price)}. You have $\u03B2 {String.Format("{0:0,0.00}", Money)} Would you like to Continue?");
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
                            fuel.AddFuel(buyfuel);
                            Money -= price;
                            if (Money < 0)
                            {
                                //Failure screen
                                new FailureScreen().Failure(ref Money, age, endOfAge);

                            }
                        }
                        Console.Clear();
                        Menus(StarChart, ref currentPlanet, ref callAge, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CompressedHydrogen, PoloniumFuel, Spice, Weapons, ref Money, currentFuelTank, age, endOfAge, hold, fuel);


                    }
                    else if (input.Key == ConsoleKey.D2)
                    {
                        Console.WriteLine();
                        int amount = AmountCalc(inventory);

                        var baseprice = CompressedHydrogen.Price;
                        var price = planetSupply.PlanetPurchaseSelection(ref currentPlanet, baseprice, amount);

                        Console.WriteLine($"This will cost $\u03B2{String.Format("{0:0,0.00}", price)}. You have $\u03B2 {String.Format("{0:0,0.00}", Money)} Would you like to Continue?");
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
                                inventory.AddItem(CompressedHydrogen);
                            }
                            Money -= price;
                            if (Money < 0)
                            {
                                //Failure screen
                                new FailureScreen().Failure(ref Money, age, endOfAge);

                            }
                        }
                        Console.Clear();
                        Menus(StarChart, ref currentPlanet, ref callAge, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CompressedHydrogen, PoloniumFuel, Spice, Weapons, ref Money, currentFuelTank, age, endOfAge, hold, fuel);

                    }
                    else if (input.Key == ConsoleKey.D3)
                    {
                        Console.WriteLine();
                        int amount = AmountCalc(inventory);

                        var baseprice = PoloniumFuel.Price;
                        var price = planetSupply.PlanetPurchaseSelection(ref currentPlanet, baseprice, amount);

                        Console.WriteLine($"This will cost $\u03B2{String.Format("{0:0,0.00}", price)}. You have $\u03B2 {String.Format("{0:0,0.00}", Money)} Would you like to Continue?");
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
                                inventory.AddItem(PoloniumFuel);
                            }
                            Money -= price;
                            if (Money < 0)
                            {
                                //Failure screen
                                new FailureScreen().Failure(ref Money, age, endOfAge);

                            }
                        }
                        Console.Clear();
                        Menus(StarChart, ref currentPlanet, ref callAge, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CompressedHydrogen, PoloniumFuel, Spice, Weapons, ref Money, currentFuelTank, age, endOfAge, hold, fuel);

                    }
                    else
                    {
                        Console.Clear();
                        Menus(StarChart, ref currentPlanet, ref callAge, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CompressedHydrogen, PoloniumFuel, Spice, Weapons, ref Money, currentFuelTank, age, endOfAge, hold, fuel);

                    }

                }
                else if (input.Key == ConsoleKey.D2)
                {
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Menus(StarChart, ref currentPlanet, ref callAge, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CompressedHydrogen, PoloniumFuel, Spice, Weapons, ref Money, currentFuelTank, age, endOfAge, hold, fuel);

                }

            }
            else if (input.Key == ConsoleKey.D4)
            {
                Console.Clear();
                input = CantinaOptions(StarChart, ref currentPlanet, ref callAge, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CompressedHydrogen, PoloniumFuel, Spice, Weapons, ref Money, currentFuelTank, age, endOfAge, hold, planetSupply, fuel);
            }
            else if (input.Key == ConsoleKey.D5)
            {
                Console.Clear();
                new SpaceTrader.MapAndTravel().DisplayMap(StarChart, ref currentPlanet, ref callAge, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CompressedHydrogen, PoloniumFuel, Spice, Weapons, ref Money, currentFuelTank, age, endOfAge, hold, fuel);
            }
        }

        private static ConsoleKeyInfo SellAll(List<Planet> StarChart, ref int currentPlanet, ref PlayerAge callAge, OreType Titanium, OreType Gold, OreType Platinum, OreType Vibranium, InventorySystem inventory, TradingItems Food, TradingItems Water, TradingItems Textiles, TradingItems Electronics, TradingItems SpareParts, DangerousItems CompressedHydrogen, DangerousItems PoloniumFuel, IllegalItems Spice, IllegalItems Weapons, ref double Money, List<double> currentFuelTank, List<double> age, double endOfAge, SmugglerHold hold, PlanetSupply planetSupply, Fuel fuel)
        {
            ConsoleKeyInfo input;
            Console.WriteLine("Are you sure you want to sell all items?");
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
                int amount = inventory.Items.Count;

                for (int i = 0; i < amount; ++i)
                {
                    int baseprice = (inventory.Items[i]).Price;

                    double price = Math.Abs(planetSupply.PlanetSellingSelection(ref currentPlanet, baseprice, amount));

                    Money += price;
                    if (Money >= 10000000)
                    {
                        VictoryScreen.Victory(ref Money);
                    }
                }

                inventory.Reset();

            }
            else
            {
                Console.Clear();
                Menus(StarChart, ref currentPlanet, ref callAge, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CompressedHydrogen, PoloniumFuel, Spice, Weapons, ref Money, currentFuelTank, age, endOfAge, hold, fuel);

            }

            return input;
        }

        private static ConsoleKeyInfo BuyElectronics(List<Planet> StarChart, ref int currentPlanet, ref PlayerAge callAge, OreType Titanium, OreType Gold, OreType Platinum, OreType Vibranium, InventorySystem inventory, TradingItems Food, TradingItems Water, TradingItems Textiles, TradingItems Electronics, TradingItems SpareParts, DangerousItems CompressedHydrogen, DangerousItems PoloniumFuel, IllegalItems Spice, IllegalItems Weapons, ref double Money, List<double> currentFuelTank, List<double> age, double endOfAge, SmugglerHold hold, PlanetSupply planetSupply, Fuel fuel)
        {
            ConsoleKeyInfo input;
            Console.WriteLine();
            int amount = AmountCalc(inventory);

            var baseprice = Electronics.Price;
            var price = planetSupply.PlanetPurchaseSelection(ref currentPlanet, baseprice, amount);

            Console.WriteLine($"This will cost $\u03B2{String.Format("{0:0,0.00}", price)}. Would you like to Continue?");
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
                    inventory.AddItem(Electronics);
                }

                Money -= price;

                if (Money < 0)
                {
                    //Failure screen
                    new FailureScreen().Failure(ref Money, age, endOfAge);

                }
            }
            Console.Clear();
            Menus(StarChart, ref currentPlanet, ref callAge, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CompressedHydrogen, PoloniumFuel, Spice, Weapons, ref Money, currentFuelTank, age, endOfAge, hold, fuel);
            return input;
        }

        private static ConsoleKeyInfo BuySpareParts(List<Planet> StarChart, ref int currentPlanet, ref PlayerAge callAge, OreType Titanium, OreType Gold, OreType Platinum, OreType Vibranium, InventorySystem inventory, TradingItems Food, TradingItems Water, TradingItems Textiles, TradingItems Electronics, TradingItems SpareParts, DangerousItems CompressedHydrogen, DangerousItems PoloniumFuel, IllegalItems Spice, IllegalItems Weapons, ref double Money, List<double> currentFuelTank, List<double> age, double endOfAge, SmugglerHold hold, PlanetSupply planetSupply, Fuel fuel)
        {
            ConsoleKeyInfo input;
            Console.WriteLine();
            int amount = AmountCalc(inventory);

            var baseprice = SpareParts.Price;
            var price = planetSupply.PlanetPurchaseSelection(ref currentPlanet, baseprice, amount);

            Console.WriteLine($"This will cost $\u03B2{String.Format("{0:0,0.00}", price)}. Would you like to Continue?");
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
                    inventory.AddItem(SpareParts);
                }

                Money -= price;

                if (Money < 0)
                {
                    //Failure screen
                    new FailureScreen().Failure(ref Money, age, endOfAge);

                }
            }
            Console.Clear();
            Menus(StarChart, ref currentPlanet, ref callAge, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CompressedHydrogen, PoloniumFuel, Spice, Weapons, ref Money, currentFuelTank, age, endOfAge, hold, fuel);
            return input;
        }

        private static ConsoleKeyInfo BuyWater(List<Planet> StarChart, ref int currentPlanet, ref PlayerAge callAge, OreType Titanium, OreType Gold, OreType Platinum, OreType Vibranium, InventorySystem inventory, TradingItems Food, TradingItems Water, TradingItems Textiles, TradingItems Electronics, TradingItems SpareParts, DangerousItems CompressedHydrogen, DangerousItems PoloniumFuel, IllegalItems Spice, IllegalItems Weapons, ref double Money, List<double> currentFuelTank, List<double> age, double endOfAge, SmugglerHold hold, PlanetSupply planetSupply, Fuel fuel)
        {
            ConsoleKeyInfo input;
            Console.WriteLine();
            int amount = AmountCalc(inventory);

            var baseprice = Water.Price;
            var price = planetSupply.PlanetPurchaseSelection(ref currentPlanet, baseprice, amount);

            Console.WriteLine($"This will cost $\u03B2{String.Format("{0:0,0.00}", price)}. Would you like to Continue?");
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
                    inventory.AddItem(Water);
                }

                Money -= price;

                if (Money < 0)
                {
                    //Failure screen
                    new FailureScreen().Failure(ref Money, age, endOfAge);

                }
            }
            Console.Clear();
            Menus(StarChart, ref currentPlanet, ref callAge, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CompressedHydrogen, PoloniumFuel, Spice, Weapons, ref Money, currentFuelTank, age, endOfAge, hold, fuel);
            return input;
        }

        private static ConsoleKeyInfo BuyFood(List<Planet> StarChart, ref int currentPlanet, ref PlayerAge callAge, OreType Titanium, OreType Gold, OreType Platinum, OreType Vibranium, InventorySystem inventory, TradingItems Food, TradingItems Water, TradingItems Textiles, TradingItems Electronics, TradingItems SpareParts, DangerousItems CompressedHydrogen, DangerousItems PoloniumFuel, IllegalItems Spice, IllegalItems Weapons, ref double Money, List<double> currentFuelTank, List<double> age, double endOfAge, SmugglerHold hold, PlanetSupply planetSupply, Fuel fuel)
        {
            ConsoleKeyInfo input;
            Console.WriteLine();
            int amount = AmountCalc(inventory);

            var baseprice = Food.Price;
            var price = planetSupply.PlanetPurchaseSelection(ref currentPlanet, baseprice, amount);

            Console.WriteLine($"This will cost $\u03B2{String.Format("{0:0,0.00}", price)}. Would you like to Continue?");
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
                    inventory.AddItem(Food);
                }
                Money -= price;

                if (Money < 0)
                {
                    //Failure screen
                    new FailureScreen().Failure(ref Money, age, endOfAge);

                }
            }
            Console.Clear();
            Menus(StarChart, ref currentPlanet, ref callAge, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CompressedHydrogen, PoloniumFuel, Spice, Weapons, ref Money, currentFuelTank, age, endOfAge, hold, fuel);
            return input;
        }

        private static ConsoleKeyInfo BuyTextiles(List<Planet> StarChart, ref int currentPlanet, ref PlayerAge callAge, OreType Titanium, OreType Gold, OreType Platinum, OreType Vibranium, InventorySystem inventory, TradingItems Food, TradingItems Water, TradingItems Textiles, TradingItems Electronics, TradingItems SpareParts, DangerousItems CompressedHydrogen, DangerousItems PoloniumFuel, IllegalItems Spice, IllegalItems Weapons, ref double Money, List<double> currentFuelTank, List<double> age, double endOfAge, SmugglerHold hold, PlanetSupply planetSupply, Fuel fuel)
        {
            ConsoleKeyInfo input;
            Console.WriteLine();
            int amount = AmountCalc(inventory);

            var baseprice = Textiles.Price;
            var price = planetSupply.PlanetPurchaseSelection(ref currentPlanet, baseprice, amount);

            Console.WriteLine($"This will cost $\u03B2{String.Format("{0:0,0.00}", price)}. You have $\u03B2 {String.Format("{0:0,0.00}", Money)} Would you like to Continue?");
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
                    inventory.AddItem(Textiles);
                }
                Money -= price;
                if (Money < 0)
                {
                    //Failure screen
                    new FailureScreen().Failure(ref Money, age, endOfAge);

                }
            }
            Console.Clear();
            Menus(StarChart, ref currentPlanet, ref callAge, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CompressedHydrogen, PoloniumFuel, Spice, Weapons, ref Money, currentFuelTank, age, endOfAge, hold, fuel);
            return input;
        }

        private static ConsoleKeyInfo CantinaOptions(List<Planet> StarChart, ref int currentPlanet, ref PlayerAge callAge, OreType Titanium, OreType Gold, OreType Platinum, OreType Vibranium, InventorySystem inventory, TradingItems Food, TradingItems Water, TradingItems Textiles, TradingItems Electronics, TradingItems SpareParts, DangerousItems CompressedHydrogen, DangerousItems PoloniumFuel, IllegalItems Spice, IllegalItems Weapons, ref double Money, List<double> currentFuelTank, List<double> age, double endOfAge, SmugglerHold hold, PlanetSupply planetSupply, Fuel fuel)
        {
            ConsoleKeyInfo input;
            Console.WriteLine("You have arrived at the Cantina. What would you like to do?");
            Console.WriteLine();
            Console.WriteLine("1. Buy Illicit Items");
            Console.WriteLine("2. Sell Illicit Items");
            Console.WriteLine("3. Go Back");
            Console.WriteLine("Type an item number.");
            input = Console.ReadKey();
            while (input.Key != ConsoleKey.D1 && input.Key != ConsoleKey.D2 && input.Key != ConsoleKey.D3)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid Input. Try Again.");
                input = Console.ReadKey();
            }

            if (input.Key == ConsoleKey.D1)
            {
                Console.Clear();
                BuyIllicitItems(StarChart, ref currentPlanet, ref callAge, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CompressedHydrogen, PoloniumFuel, Spice, Weapons, ref Money, currentFuelTank, age, endOfAge, hold, planetSupply, ref input, fuel);
            }
            else if (input.Key == ConsoleKey.D2)
            {
                Console.Clear();
                input = SellIllicitItems(StarChart, ref currentPlanet, ref callAge, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CompressedHydrogen, PoloniumFuel, Spice, Weapons, ref Money, currentFuelTank, age, endOfAge, hold, planetSupply, fuel);

            }
            else
            {
                Console.Clear();
                Menus(StarChart, ref currentPlanet, ref callAge, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CompressedHydrogen, PoloniumFuel, Spice, Weapons, ref Money, currentFuelTank, age, endOfAge, hold, fuel);

            }

            return input;
        }

        private static ConsoleKeyInfo SellIllicitItems(List<Planet> StarChart, ref int currentPlanet, ref PlayerAge callAge, OreType Titanium, OreType Gold, OreType Platinum, OreType Vibranium, InventorySystem inventory, TradingItems Food, TradingItems Water, TradingItems Textiles, TradingItems Electronics, TradingItems SpareParts, DangerousItems CompressedHydrogen, DangerousItems PoloniumFuel, IllegalItems Spice, IllegalItems Weapons, ref double Money, List<double> currentFuelTank, List<double> age, double endOfAge, SmugglerHold hold, PlanetSupply planetSupply, Fuel fuel)
        {
            ConsoleKeyInfo input;
            Console.WriteLine();
            Console.WriteLine("What would you like to sell?");

            for (int i = 0; i < hold.Hold.Count; ++i)
            {
                Console.WriteLine($"{i + 1}. {(hold.Hold[i]).Name} ");
            }

            Console.WriteLine("Enter the desired inventory slot or enter A for ALL.");
            var slot = Console.ReadLine();

            int output;

            if (slot == "a")
            {
                // Sells all
                Console.WriteLine("Are you sure you want to sell all items?");
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
                    int amount = hold.Hold.Count;

                    for (int i = 0; i < amount; ++i)
                    {
                        int baseprice = (hold.Hold[i]).Price;

                        double price = Math.Abs(planetSupply.PlanetSellingSelection(ref currentPlanet, baseprice, amount));

                        Money += price;
                        if (Money >= 10000000)
                        {
                            VictoryScreen.Victory(ref Money);
                        }
                    }

                    hold.Reset();

                }
                else
                {
                    Console.Clear();
                    Menus(StarChart, ref currentPlanet, ref callAge, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CompressedHydrogen, PoloniumFuel, Spice, Weapons, ref Money, currentFuelTank, age, endOfAge, hold, fuel);

                }
            }
            else
            {
                while ((!Int32.TryParse(slot, out output)) && (output != 1 || output != 2))
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
                
                int amount = 1;
                int baseprice = (hold.Hold[output - 1]).Price;
                double price = Math.Abs(planetSupply.PlanetSellingSelection(ref currentPlanet, baseprice, amount));
                Console.WriteLine();
                Console.WriteLine($"Would you like to sell selected item for $\u03B2 {String.Format("{0:0,0.00}", price)}?");

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
                        Money += price;

                        hold.RemoveItem(output, hold);

                        if (Money >= 10000000)
                        {
                            VictoryScreen.Victory(ref Money);
                        }
                    }

                }
            }
            Console.Clear();
            Menus(StarChart, ref currentPlanet, ref callAge, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CompressedHydrogen, PoloniumFuel, Spice, Weapons, ref Money, currentFuelTank, age, endOfAge, hold, fuel);
            return input;
        }

        private static void BuyIllicitItems(List<Planet> StarChart, ref int currentPlanet, ref PlayerAge callAge, OreType Titanium, OreType Gold, OreType Platinum, OreType Vibranium, InventorySystem inventory, TradingItems Food, TradingItems Water, TradingItems Textiles, TradingItems Electronics, TradingItems SpareParts, DangerousItems CompressedHydrogen, DangerousItems PoloniumFuel, IllegalItems Spice, IllegalItems Weapons, ref double Money, List<double> currentFuelTank, List<double> age, double endOfAge, SmugglerHold hold, PlanetSupply planetSupply, ref ConsoleKeyInfo input, Fuel fuel)
        {
            Console.WriteLine("What do you want to buy?"); //put it into a new class
            Console.WriteLine();
            Console.WriteLine("1. Spice");
            Console.WriteLine("2. Weapons");
            Console.WriteLine("3. Go Back");
            Console.WriteLine();
            Console.WriteLine("Enter a Menu Number to Proceed.");
            var input2 = Console.ReadKey();

            while (input2.Key != ConsoleKey.D1 && input2.Key != ConsoleKey.D2 && input2.Key != ConsoleKey.D3)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid Input. Try Again.");
                input2 = Console.ReadKey();
            }

            if (input2.Key == ConsoleKey.D1)
            {
                Console.WriteLine();
                int amount = HoldAmountCalc(hold);

                var baseprice = Spice.Price;
                var price = planetSupply.PlanetPurchaseSelection(ref currentPlanet, baseprice, amount);

                Console.WriteLine($"This will cost $\u03B2{String.Format("{0:0,0.00}", price)}. You have $\u03B2 {String.Format("{0:0,0.00}", Money)} Would you like to Continue?");
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

                        hold.AddItem(Spice);
                    }
                    if (Money < 0)
                    {
                        //Failure screen
                        new FailureScreen().Failure(ref Money, age, endOfAge);

                    }
                }
                Console.Clear();
                Menus(StarChart, ref currentPlanet, ref callAge, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CompressedHydrogen, PoloniumFuel, Spice, Weapons, ref Money, currentFuelTank, age, endOfAge, hold, fuel);

            }
            else if (input2.Key == ConsoleKey.D2)
            {
                Console.WriteLine();
                int amount = HoldAmountCalc(hold);

                var baseprice = Weapons.Price;
                var price = planetSupply.PlanetPurchaseSelection(ref currentPlanet, baseprice, amount);

                Console.WriteLine($"This will cost $\u03B2{String.Format("{0:0,0.00}", price)}. You have $\u03B2 {String.Format("{0:0,0.00}", Money)} Would you like to Continue?");
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

                        hold.AddItem(Weapons);
                    }
                    if (Money < 0)
                    {
                        //Failure screen
                        new FailureScreen().Failure(ref Money, age, endOfAge);

                    }
                    Console.Clear();
                    Menus(StarChart, ref currentPlanet, ref callAge, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CompressedHydrogen, PoloniumFuel, Spice, Weapons, ref Money, currentFuelTank, age, endOfAge, hold, fuel);


                }
                else
                {
                    Console.Clear();
                    Menus(StarChart, ref currentPlanet, ref callAge, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CompressedHydrogen, PoloniumFuel, Spice, Weapons, ref Money, currentFuelTank, age, endOfAge, hold, fuel);

                }
            }
            else
            {
                Console.Clear();
                Menus(StarChart, ref currentPlanet, ref callAge, Titanium, Gold, Platinum, Vibranium, inventory, Food, Water, Textiles, Electronics, SpareParts, CompressedHydrogen, PoloniumFuel, Spice, Weapons, ref Money, currentFuelTank, age, endOfAge, hold, fuel);

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
        private static int HoldAmountCalc(SmugglerHold hold)
        {
            Console.WriteLine("Amount you would like to purchase?");
            Console.WriteLine("Type 1 or 2 tons.");

            int output;
            do
            {
                var input3 = Console.ReadLine();
                while (!int.TryParse(input3, out output))
                {
                    Console.WriteLine("Invalid Input. Try Again.");
                    input3 = Console.ReadLine();
                }

                if (output + hold.Hold.Count > hold.Capacity)
                    Console.WriteLine("Inventory Overflow. Type another amount.");

            } while (output + hold.Hold.Count > hold.Capacity);
            return output;
        }
    }
}
