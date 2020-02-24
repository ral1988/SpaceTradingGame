using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTrader
{
    class Intro
    {
        public Intro()
        {
            Console.WriteLine("\u2554\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2557");
            Console.WriteLine("\u2551                                                                                                       \u2551");
            Console.WriteLine("\u2551 You have been in the SYNDICATE for as long as you can remember.                                       \u2551");
            Console.WriteLine("\u2551                                                                                                       \u2551");
            Console.WriteLine("\u2551 You have seen enough violence and death for a hundred lifetimes.                                      \u2551");
            Console.WriteLine("\u2551                                                                                                       \u2551");
            Console.WriteLine("\u2551 You have had enough. It is time for you to buy your freedom.                                          \u2551");
            Console.WriteLine("\u2551                                                                                                       \u2551");
            Console.WriteLine("\u2551 Glurut, Grand Master of Death, says if you pay him $\u03B2 10,000,000 Space Bucks he will set you free.    \u2551");
            Console.WriteLine("\u2551                                                                                                       \u2551");
            Console.WriteLine("\u2551 After your father died, he left you with his spaceship, the NOVIS, $\u03B2 1,000 and a small mining rig.   \u2551");
            Console.WriteLine("\u2551                                                                                                       \u2551");
            Console.WriteLine("\u2551 As you strap yourself into your seat, you feel the weight of your choice to leave the SYNDICATE on    \u2551");
            Console.WriteLine("\u2551 your chest. To fail is to die.                                                                        \u2551");
            Console.WriteLine("\u2551                                                                                                       \u2551");
            Console.WriteLine("\u2551 You set your eyes on your gauges and focus on the task ahead...                                       \u2551");
            Console.WriteLine("\u2560\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2563");
            Console.WriteLine("\u2551                                                                                                       \u2551");
            Console.WriteLine("\u2551 Press C to Continue.                                                                                  \u2551");
            Console.WriteLine("\u2551                                                                                                       \u2551");
            Console.WriteLine("\u255A\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u255D");

            var input = Console.ReadKey();

            while (input.Key != ConsoleKey.C)
            {
                Console.WriteLine("Invalid Input. Try Again.");

                input = Console.ReadKey();
            }

            Console.Clear();

           

        }
    }
}
