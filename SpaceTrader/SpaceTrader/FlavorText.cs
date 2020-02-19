using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTrader
{
    class FlavorText
    {
        public static void FlavorPicker(ref int currentPlanet)
        {
            if (currentPlanet == 0)
            {
                SolMain();
            }
            else if (currentPlanet == 1)
            {
                PCBMain();
            }
            else if (currentPlanet == 2)
            {
                BSBMain();
            }
            else if (currentPlanet == 3)
            {
                Ross128Main();
            }
            else if (currentPlanet == 4)
            {
                LSBMain();
            }
            else if (currentPlanet == 5)
            {
                Wolf1061Main();
            }
            else if (currentPlanet == 6)
            {
                Gliese832Main();
            }
            else if (currentPlanet == 7)
            {
                HR8832Main();
            }
        }

        static void SolMain()
        {
            Console.WriteLine($"\u2554\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2557");
            Console.WriteLine("\u2551                                                                                                        \u2551");
            Console.WriteLine("\u2551 As your ship flys through the atmosphere down to the surface, you look out your window and admire the  \u2551");
            Console.WriteLine("\u2551 beauty of the mountains, rivers and oceans of Earth. No matter what planet you visit, none really      \u2551");
            Console.WriteLine("\u2551 compare to it's simple beauty.                                                                         \u2551");
            Console.WriteLine("\u2551                                                                                                        \u2551");
            Console.WriteLine("\u2551 You hear the tower hailing you as you get closer to the Columbus Eperopolitan Interstellar Spaceport.  \u2551");
            Console.WriteLine("\u2551 'Roma-Seven-Aught-Three-Niner, report to Landing Section 33, Pad 104.'        'Roger, Tower. 3 mikes.' \u2551");
            Console.WriteLine("\u2551                                                                                                        \u2551");
            Console.WriteLine("\u2551 You steer your ship toward the designated pad and admire the Super-Scrapers near the Bos-Was Mega-City.\u2551");
            Console.WriteLine("\u2551 While coming in for your final approach, you see the Ultima Tower which stands at an imposing 2 miles  \u2551");
            Console.WriteLine("\u2551 tall. You remember a time when you were young and watching your father lead the contruction of that    \u2551");
            Console.WriteLine("\u2551 incredible feat of engineering. A tear rolls down your face as you think of him...                     \u2551");
            Console.WriteLine("\u2560\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2563");
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

            Console.Clear();

        }

        static void PCBMain()
        {
            Console.WriteLine($"\u2554\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2557");
            Console.WriteLine("\u2551                                                                                                        \u2551");
            Console.WriteLine("\u2551 As your ship flys through the atmosphere down to the surface, you look out your window and admire the  \u2551");
            Console.WriteLine("\u2551 beauty of the mountains, rivers and oceans of Earth. No matter what planet you visit, none really      \u2551");
            Console.WriteLine("\u2551 compare to it's simple beauty.                                                                         \u2551");
            Console.WriteLine("\u2551                                                                                                        \u2551");
            Console.WriteLine("\u2551 You hear the tower hailing you as you get closer to the Columbus Eperopolitan Interstellar Spaceport.  \u2551");
            Console.WriteLine("\u2551 'Roma-Seven-Aught-Three-Niner, report to Landing Section 33, Pad 104.'        'Roger, Tower. 3 mikes.' \u2551");
            Console.WriteLine("\u2551                                                                                                        \u2551");
            Console.WriteLine("\u2551 You steer your ship toward the designated pad and admire the Super-Scrapers near the Bos-Was Mega-City.\u2551");
            Console.WriteLine("\u2551 While coming in for your final approach, you see the Ultima Tower which stands at an imposing 2 miles  \u2551");
            Console.WriteLine("\u2551 tall. You remember a time when you were young and watching your father lead the contruction of that    \u2551");
            Console.WriteLine("\u2551 incredible feat of engineering. A tear rolls down your face as you think of him...                     \u2551");
            Console.WriteLine("\u2560\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2563");
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

            Console.Clear();

        }

        static void BSBMain()
        {
            Console.WriteLine($"\u2554\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2557");
            Console.WriteLine("\u2551                                                                                                        \u2551");
            Console.WriteLine("\u2551 As your ship flys through the atmosphere down to the surface, you look out your window and admire the  \u2551");
            Console.WriteLine("\u2551 beauty of the mountains, rivers and oceans of Earth. No matter what planet you visit, none really      \u2551");
            Console.WriteLine("\u2551 compare to it's simple beauty.                                                                         \u2551");
            Console.WriteLine("\u2551                                                                                                        \u2551");
            Console.WriteLine("\u2551 You hear the tower hailing you as you get closer to the Columbus Eperopolitan Interstellar Spaceport.  \u2551");
            Console.WriteLine("\u2551 'Roma-Seven-Aught-Three-Niner, report to Landing Section 33, Pad 104.'        'Roger, Tower. 3 mikes.' \u2551");
            Console.WriteLine("\u2551                                                                                                        \u2551");
            Console.WriteLine("\u2551 You steer your ship toward the designated pad and admire the Super-Scrapers near the Bos-Was Mega-City.\u2551");
            Console.WriteLine("\u2551 While coming in for your final approach, you see the Ultima Tower which stands at an imposing 2 miles  \u2551");
            Console.WriteLine("\u2551 tall. You remember a time when you were young and watching your father lead the contruction of that    \u2551");
            Console.WriteLine("\u2551 incredible feat of engineering. A tear rolls down your face as you think of him...                     \u2551");
            Console.WriteLine("\u2560\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2563");
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

            Console.Clear();
        }

        static void Ross128Main()
        {
            Console.WriteLine($"\u2554\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2557");
            Console.WriteLine("\u2551                                                                                                        \u2551");
            Console.WriteLine("\u2551 As your ship flys through the atmosphere down to the surface, you look out your window and admire the  \u2551");
            Console.WriteLine("\u2551 beauty of the mountains, rivers and oceans of Earth. No matter what planet you visit, none really      \u2551");
            Console.WriteLine("\u2551 compare to it's simple beauty.                                                                         \u2551");
            Console.WriteLine("\u2551                                                                                                        \u2551");
            Console.WriteLine("\u2551 You hear the tower hailing you as you get closer to the Columbus Eperopolitan Interstellar Spaceport.  \u2551");
            Console.WriteLine("\u2551 'Roma-Seven-Aught-Three-Niner, report to Landing Section 33, Pad 104.'        'Roger, Tower. 3 mikes.' \u2551");
            Console.WriteLine("\u2551                                                                                                        \u2551");
            Console.WriteLine("\u2551 You steer your ship toward the designated pad and admire the Super-Scrapers near the Bos-Was Mega-City.\u2551");
            Console.WriteLine("\u2551 While coming in for your final approach, you see the Ultima Tower which stands at an imposing 2 miles  \u2551");
            Console.WriteLine("\u2551 tall. You remember a time when you were young and watching your father lead the contruction of that    \u2551");
            Console.WriteLine("\u2551 incredible feat of engineering. A tear rolls down your face as you think of him...                     \u2551");
            Console.WriteLine("\u2560\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2563");
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

            Console.Clear();
        }

        static void LSBMain()
        {
            Console.WriteLine($"\u2554\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2557");
            Console.WriteLine("\u2551                                                                                                        \u2551");
            Console.WriteLine("\u2551 As your ship flys through the atmosphere down to the surface, you look out your window and admire the  \u2551");
            Console.WriteLine("\u2551 beauty of the mountains, rivers and oceans of Earth. No matter what planet you visit, none really      \u2551");
            Console.WriteLine("\u2551 compare to it's simple beauty.                                                                         \u2551");
            Console.WriteLine("\u2551                                                                                                        \u2551");
            Console.WriteLine("\u2551 You hear the tower hailing you as you get closer to the Columbus Eperopolitan Interstellar Spaceport.  \u2551");
            Console.WriteLine("\u2551 'Roma-Seven-Aught-Three-Niner, report to Landing Section 33, Pad 104.'        'Roger, Tower. 3 mikes.' \u2551");
            Console.WriteLine("\u2551                                                                                                        \u2551");
            Console.WriteLine("\u2551 You steer your ship toward the designated pad and admire the Super-Scrapers near the Bos-Was Mega-City.\u2551");
            Console.WriteLine("\u2551 While coming in for your final approach, you see the Ultima Tower which stands at an imposing 2 miles  \u2551");
            Console.WriteLine("\u2551 tall. You remember a time when you were young and watching your father lead the contruction of that    \u2551");
            Console.WriteLine("\u2551 incredible feat of engineering. A tear rolls down your face as you think of him...                     \u2551");
            Console.WriteLine("\u2560\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2563");
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

            Console.Clear();
        }

        static void Wolf1061Main()
        {
            Console.WriteLine($"\u2554\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2557");
            Console.WriteLine("\u2551                                                                                                        \u2551");
            Console.WriteLine("\u2551 As your ship flys through the atmosphere down to the surface, you look out your window and admire the  \u2551");
            Console.WriteLine("\u2551 beauty of the mountains, rivers and oceans of Earth. No matter what planet you visit, none really      \u2551");
            Console.WriteLine("\u2551 compare to it's simple beauty.                                                                         \u2551");
            Console.WriteLine("\u2551                                                                                                        \u2551");
            Console.WriteLine("\u2551 You hear the tower hailing you as you get closer to the Columbus Eperopolitan Interstellar Spaceport.  \u2551");
            Console.WriteLine("\u2551 'Roma-Seven-Aught-Three-Niner, report to Landing Section 33, Pad 104.'        'Roger, Tower. 3 mikes.' \u2551");
            Console.WriteLine("\u2551                                                                                                        \u2551");
            Console.WriteLine("\u2551 You steer your ship toward the designated pad and admire the Super-Scrapers near the Bos-Was Mega-City.\u2551");
            Console.WriteLine("\u2551 While coming in for your final approach, you see the Ultima Tower which stands at an imposing 2 miles  \u2551");
            Console.WriteLine("\u2551 tall. You remember a time when you were young and watching your father lead the contruction of that    \u2551");
            Console.WriteLine("\u2551 incredible feat of engineering. A tear rolls down your face as you think of him...                     \u2551");
            Console.WriteLine("\u2560\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2563");
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

            Console.Clear();
        }

        static void Gliese832Main()
        {
            Console.WriteLine($"\u2554\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2557");
            Console.WriteLine("\u2551                                                                                                        \u2551");
            Console.WriteLine("\u2551 As your ship flys through the atmosphere down to the surface, you look out your window and admire the  \u2551");
            Console.WriteLine("\u2551 beauty of the mountains, rivers and oceans of Earth. No matter what planet you visit, none really      \u2551");
            Console.WriteLine("\u2551 compare to it's simple beauty.                                                                         \u2551");
            Console.WriteLine("\u2551                                                                                                        \u2551");
            Console.WriteLine("\u2551 You hear the tower hailing you as you get closer to the Columbus Eperopolitan Interstellar Spaceport.  \u2551");
            Console.WriteLine("\u2551 'Roma-Seven-Aught-Three-Niner, report to Landing Section 33, Pad 104.'        'Roger, Tower. 3 mikes.' \u2551");
            Console.WriteLine("\u2551                                                                                                        \u2551");
            Console.WriteLine("\u2551 You steer your ship toward the designated pad and admire the Super-Scrapers near the Bos-Was Mega-City.\u2551");
            Console.WriteLine("\u2551 While coming in for your final approach, you see the Ultima Tower which stands at an imposing 2 miles  \u2551");
            Console.WriteLine("\u2551 tall. You remember a time when you were young and watching your father lead the contruction of that    \u2551");
            Console.WriteLine("\u2551 incredible feat of engineering. A tear rolls down your face as you think of him...                     \u2551");
            Console.WriteLine("\u2560\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2563");
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

            Console.Clear();
        }

        static void HR8832Main()
        {
            Console.WriteLine($"\u2554\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2557");
            Console.WriteLine("\u2551                                                                                                        \u2551");
            Console.WriteLine("\u2551 As your ship flys through the atmosphere down to the surface, you look out your window and admire the  \u2551");
            Console.WriteLine("\u2551 beauty of the mountains, rivers and oceans of Earth. No matter what planet you visit, none really      \u2551");
            Console.WriteLine("\u2551 compare to it's simple beauty.                                                                         \u2551");
            Console.WriteLine("\u2551                                                                                                        \u2551");
            Console.WriteLine("\u2551 You hear the tower hailing you as you get closer to the Columbus Eperopolitan Interstellar Spaceport.  \u2551");
            Console.WriteLine("\u2551 'Roma-Seven-Aught-Three-Niner, report to Landing Section 33, Pad 104.'        'Roger, Tower. 3 mikes.' \u2551");
            Console.WriteLine("\u2551                                                                                                        \u2551");
            Console.WriteLine("\u2551 You steer your ship toward the designated pad and admire the Super-Scrapers near the Bos-Was Mega-City.\u2551");
            Console.WriteLine("\u2551 While coming in for your final approach, you see the Ultima Tower which stands at an imposing 2 miles  \u2551");
            Console.WriteLine("\u2551 tall. You remember a time when you were young and watching your father lead the contruction of that    \u2551");
            Console.WriteLine("\u2551 incredible feat of engineering. A tear rolls down your face as you think of him...                     \u2551");
            Console.WriteLine("\u2560\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2563");
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

            Console.Clear();
        }




    }
}
