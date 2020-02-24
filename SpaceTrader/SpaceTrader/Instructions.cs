using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTrader
{
    class Instructions
    {
        public Instructions()
        {
            Console.WriteLine("\u2554\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2557");
            Console.WriteLine("\u2551                                                                                                       \u2551");
            Console.WriteLine("\u2551 This is a game that is all about trading. Your goal is to buy and sell items and make a profit.       \u2551");
            Console.WriteLine("\u2551                                                                                                       \u2551");
            Console.WriteLine("\u2551 There are several ways to make money. Mining, Buying/Selling Commodities, Buying/Selling Fuel Items,  \u2551");
            Console.WriteLine("\u2551 and Buying/Selling Illicit Items.                                                                     \u2551");
            Console.WriteLine("\u2551                                                                                                       \u2551");
            Console.WriteLine("\u2551 You can buy/sell mined Ore, Commodities, and some Fuel items at the Trading Post.                     \u2551");
            Console.WriteLine("\u2551 You can you can buy Polonium Fuel Rods and Compressed Hydrogen and buy/sell Spaceship Fuel at the     \u2551");
            Console.WriteLine("\u2551 Fuel Depot. Be Careful! Polonium Fuel Rods and Compressed Hydrogen can explode if you're not careful! \u2551");
            Console.WriteLine("\u2551 Also, your ship has a max inventory of 20 tons of cargo so be wise with your purchases!               \u2551");
            Console.WriteLine("\u2551                                                                                                       \u2551");
            Console.WriteLine("\u2551 You can buy/sell Illicit Items at the Cantina. Be careful, if your ship gets inspected, you will be   \u2551");
            Console.WriteLine("\u2551 arrested, half your money and all of your cargo will be seized! Also, you can only store 2 tons of    \u2551");
            Console.WriteLine("\u2551 items in your smugglers hold.                                                                         \u2551");
            Console.WriteLine("\u2551                                                                                                       \u2551");
            Console.WriteLine("\u2551 Each Star System has a planet you can land on. Each has different prices on goods so the name of the  \u2551");
            Console.WriteLine("\u2551 game is buy low, sell high!                                                                           \u2551");
            Console.WriteLine("\u2551                                                                                                       \u2551");
            Console.WriteLine("\u2551 Good luck and have fun!                                                                               \u2551");
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
