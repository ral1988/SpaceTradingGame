using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTrader
{
    class Inspections
    {
        public Inspections()
        {

        }
        public static void InspectionScreen(Random rand, ref double Money, SmugglerHold hold, InventorySystem inventory, ref PlayerAge callAge)
        {
            int chance = rand.Next(10);

            if (chance == 1 && hold.Hold.Count > 0)
            {
                //inspection! gonna get wrecked
                Console.ResetColor();
                Console.WriteLine($"\u2554\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2557");
                Console.WriteLine("\u2551                                                                                                        \u2551");
                Console.WriteLine("\u2551 As you lower the ramp of your ship, you notice a group of uniformed guards approaching you menacingly. \u2551");
                Console.WriteLine("\u2551                                                                                                        \u2551");
                Console.WriteLine("\u2551 You know what they are here for. They know you have contraband. You immediatley run for your controls  \u2551");
                Console.WriteLine("\u2551 in order to take off, but it's too late. You feel the barbs of their stun guns pierce your back.       \u2551");
                Console.WriteLine("\u2551                                                                                                        \u2551");
                Console.WriteLine("\u2551 You piss your pants and forget your name for about 10 minutes.                                         \u2551");
                Console.WriteLine("\u2551                                                                                                        \u2551");
                Console.WriteLine("\u2551 You are immediately hauled to a detention center. You lose half your money and all your cargo due to   \u2551");
                Console.WriteLine("\u2551 Civil Asset Forfeiture. You can't fight it without spending more money than it was worth in court.     \u2551");
                Console.WriteLine("\u2551                                                                                                        \u2551");
                Console.WriteLine("\u2551 After a lengthy stay in the detention center, you are released and go to get your ship out of impound. \u2551");
                Console.WriteLine("\u2560\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2563");
                
                Console.Beep(440, 500);
                Console.Beep(440, 500);
                Console.Beep(440, 500);
                Console.Beep(349, 350);
                Console.Beep(523, 150);
                Console.Beep(440,500);
                Console.Beep(349, 350);
                Console.Beep(523, 150);
                Console.Beep(440, 1000);
                Console.Beep(659,500);
                Console.Beep(659, 500);
                Console.Beep(659, 500);
                Console.Beep(698, 350);
                Console.Beep(523, 150);
                Console.Beep(415, 500);
                Console.Beep(349, 350);
                Console.Beep(523, 150);
                Console.Beep(440, 1000);

                Console.WriteLine("\u2551                                                                                                        \u2551");
                Console.WriteLine("\u2551 Press C to Continue.                                                                                   \u2551");
                Console.WriteLine("\u2551                                                                                                        \u2551");
                Console.WriteLine("\u255A\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u255D");


                var input = Console.ReadKey();

                while (input.Key != ConsoleKey.C)
                {
                    Console.WriteLine("Invalid Input. Try Again.");

                    input = Console.ReadKey();
                }

                double time = rand.Next(5);

                callAge.TimeCalc(time);

                Money /= 2;

                hold.Reset();
                inventory.Reset();


                Console.Clear();
            }

            else
            {
                

                Console.Clear();

        
            }
        }
    }
}
