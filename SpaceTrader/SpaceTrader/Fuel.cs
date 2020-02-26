using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SpaceTrader
{
    class Fuel : Item
    {
        public List<double> currentFuelTank = new List<double> { };

        public Fuel()
        {

        }

        public void AddFuel(double buyFuel)
        {
            var newFuel = buyFuel;

            currentFuelTank.Add(newFuel);

            if (currentFuelTank.Sum() > 100.00)
            {
                currentFuelTank.Clear();
                currentFuelTank.Add(100.00);
            }
        }

        public void RemoveFuel(double distance)
        {
            
            var usedFuel = -1 * (distance * 3);
            currentFuelTank.Add(usedFuel);

            if ((currentFuelTank.Sum() < 0) || (currentFuelTank.Sum() == 0))
            {
                NoFuel();
            }
        }
        public void NoFuel()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\u2554\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2557");
            Console.WriteLine("\u2551                                                                                                        \u2551");
            Console.WriteLine("\u2551 As you fly along through interstellar space, your ship suddenly loses thrust.                          \u2551");
            Console.WriteLine("\u2551                                                                                                        \u2551");
            Console.WriteLine("\u2551 You check your gauges and you realize you misjudged how much fuel you had. You are completely out of   \u2551");
            Console.WriteLine("\u2551 fuel. You have about 36 hours before your batteries are dead. You immedieatly send out a distress call.\u2551");
            Console.WriteLine("\u2551                                                                                                        \u2551");
            Console.WriteLine("\u2551 You wait for a ship to respond to your beacon but as time passes, you get increasingly worried.        \u2551");
            Console.WriteLine("\u2551                                                                                                        \u2551");
            Console.WriteLine("\u2551 12 hours pass...                                                                                       \u2551");
            Console.WriteLine("\u2551 18...                                                                                                  \u2551");
            Console.WriteLine("\u2551 24...                                                                                                  \u2551");
            Console.WriteLine("\u2551 32...                                                                                                  \u2551");
            Console.WriteLine("\u2551                                                                                                        \u2551");
            Console.WriteLine("\u2551 As your ship begins to lose power completely, you realize you aren't going to survive.                 \u2551");
            Console.WriteLine("\u2551                                                                                                        \u2551");
            Console.WriteLine("\u2551 You regret being so careless as your lights go out and the temperature drops...                        \u2551");
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

            Environment.Exit(0);

        }

        public void SellFuel(int amount)
        {
            var usedFuel = -1 * (amount);
            currentFuelTank.Add(usedFuel);
        }
    }
}
