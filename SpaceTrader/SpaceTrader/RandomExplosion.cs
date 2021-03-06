﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SpaceTrader
{
    class RandomExplosion
    {
        public RandomExplosion()
        {

        }

        public static void Explosion(Random rand, InventorySystem inventory)
        {
            int chance = rand.Next(100);

            if (chance == 25 || chance == 75)
            {
                for (int i = 0; i < inventory.Items.Count; ++i)
                {
                    if ((inventory.Items[i]).Name == "Polonium Fuel Rods" || (inventory.Items[i]).Name == "Compressed Hydrogen")
                    {

                        Console.Clear();
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
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
                        Console.Beep(174, 1500);
                        Console.Beep(174, 500);
                        Console.Beep(233, 2500);
                        Thread.Sleep(100);
                        Console.Beep(174, 1000);
                        Console.Beep(233, 500);
                        Console.Beep(293, 1500);
                        Thread.Sleep(100);
                        Console.Beep(174, 1000);
                        Console.Beep(233, 500);
                        Console.Beep(293, 1500);
                        Thread.Sleep(100);
                        Console.Beep(174, 1000);
                        Console.Beep(233, 500);
                        Console.Beep(293, 1500);
                        Thread.Sleep(100);
                        Console.Beep(174, 1000);
                        Console.Beep(233, 500);
                        Console.Beep(293, 3000);
                        Thread.Sleep(100);
                        Console.Beep(233, 1000);
                        Console.Beep(293, 500);
                        Console.Beep(349, 1500);
                        Thread.Sleep(100);
                        Console.Beep(293, 1000);
                        Console.Beep(233, 500);
                        Console.Beep(174, 2000);
                        Thread.Sleep(100);
                        Console.Beep(174, 1500);
                        Console.Beep(174, 500);
                        Console.Beep(233, 3000);
                        Console.WriteLine();
                        Console.WriteLine();
                        Environment.Exit(0);


                    }


                }



            }
        }
    }
}
