using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTrader
{
    class PlayerInfo
    {
        public PlayerInfo()
        {
            PlayerSetup();
        }

        public string PlayerSetup()
        {
            Console.Write("What is your name?: ");
            string endUserName = Console.ReadLine();
            Console.WriteLine($"Welcome to SpaceTrade {endUserName}!");

            return endUserName;
        }

        private void PlayerRace()
        {
            //
        }
    }
}
