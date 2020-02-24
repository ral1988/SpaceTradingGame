using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTrader
{
    class RandomExplosion
    {
        public RandomExplosion()
        {

        }

        public static void Explosion(Random rand, InventorySystem inventory)
        {
            int chance = rand.Next(3);

            if (chance == 2 || chance == 1)
            {
                for (int i = 0; i < inventory.Items.Count; ++i)
                {
                    if ((inventory.Items[i]).Name == "Polonium Fuel Rods" || (inventory.Items[i]).Name == "Compressed Hydrogen")
                    {

                        Console.Clear();
                        Console.ResetColor();
                        Console.WriteLine($"\u2554\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2557");
                        Console.WriteLine("\u2551                                                                                                        \u2551");
                        Console.WriteLine("\u2551 While passing through a High Velocity Interstellar Cloud, your ship has an unexpected collision with   \u2551");
                        Console.WriteLine("\u2551 an unknown object.                                                                                     \u2551");
                        Console.WriteLine("\u2551                                                                                                        \u2551");
                        Console.WriteLine("\u2551 You check your dangerous cargo status and everything seems to be ok. You breathe a sigh of relief.     \u2551");
                        Console.WriteLine("\u2551                                                                                                        \u2551");
                        Console.WriteLine("\u2551 Suddenly, your ship jolts sideways, and you think you've hit something else, your warning panel lights \u2551");
                        Console.WriteLine("\u2551 up. Its not good. You rush back to the cargo hold to secure your dangerous cargo but it's too late.    \u2551");
                        Console.WriteLine("\u2551                                                                                                        \u2551");
                        Console.WriteLine("\u2551 Your cargo goes critical and you see a bright flash followed by intense heat. Then everthing goes dark.\u2551");
                        Console.WriteLine("\u2551                                                                                                        \u2551");
                        Console.WriteLine("\u2551 You have been obliterated. Maybe in another life.                                                      \u2551");
                        Console.WriteLine("\u255A\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u255D");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Environment.Exit(0);


                    }


                }



            }
        }
    }
}
