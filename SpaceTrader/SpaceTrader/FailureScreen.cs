using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SpaceTrader
{
    class FailureScreen
    {
        public FailureScreen()
        {

        }
        public void Failure(ref double Money, List<double> age, double endOfAge)
        {
            if (Money <= 0)
            {
                
                Console.Clear();
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\u2554\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2557");
                Console.WriteLine("\u2551                                                                                                        \u2551");
                Console.WriteLine("\u2551 You ran out of Space Bucks and Glurut, Grand Master of Death, has sent 42 assassins to rip out your    \u2551");
                Console.WriteLine("\u2551 spleen for him to feast on.                                                                            \u2551");
                Console.WriteLine("\u2551                                                                                                        \u2551");
                Console.WriteLine("\u2551 You try and run for a little while, hiding in remote mining settlements on inhospitable places like    \u2551");
                Console.WriteLine("\u2551 Gliese 832, but they keep finding you.                                                                 \u2551");
                Console.WriteLine("\u2551                                                                                                        \u2551");
                Console.WriteLine("\u2551 One day, you find a note on the side if your pillow.  'Its time. No use running. You are already dead.'\u2551");
                Console.WriteLine("\u2551                                                                                                        \u2551");
                Console.WriteLine("\u2551 You start to feel your throat swell as the neurotoxin on the note seeps into your skin. Your time is   \u2551");
                Console.WriteLine("\u2551 up. Your vision begins to get blurry as you fade into the cold embrace of death.                       \u2551");
                Console.WriteLine("\u2551                                                                                                        \u2551");
                Console.WriteLine("\u255A\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u255D");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Environment.Exit(0);



            }

            if (age.Sum() >= endOfAge)
            {
                Console.Clear();
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\u2554\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2557");
                Console.WriteLine("\u2551                                                                                                        \u2551");
                Console.WriteLine("\u2551 You ran out of Time and Glurut, Grand Master of Death, has sent 42 assassins to rip out your spleen    \u2551");
                Console.WriteLine("\u2551 for him to feast on.                                                                                   \u2551");
                Console.WriteLine("\u2551                                                                                                        \u2551");
                Console.WriteLine("\u2551 You try and run for a little while, hiding in remote mining settlements on inhospitable places like    \u2551");
                Console.WriteLine("\u2551 Gliese 832, but they keep finding you.                                                                 \u2551");
                Console.WriteLine("\u2551                                                                                                        \u2551");
                Console.WriteLine("\u2551 One day, you find a note on the side if your pillow.  'Its time. No use running. You are already dead.'\u2551");
                Console.WriteLine("\u2551                                                                                                        \u2551");
                Console.WriteLine("\u2551 Panicked, you look around your room when you feel a sting on your neck. You reach and pull a poison    \u2551");
                Console.WriteLine("\u2551 dart from your neck. As you slump to the floor, a dark figure approaches with a knife and starts to    \u2551");
                Console.WriteLine("\u2551 remove your spleen. The pain is unbearable, but you can only moan as the poison rendered you paralyzed.\u2551");
                Console.WriteLine("\u2551                                                                                                        \u2551");
                Console.WriteLine("\u2551 After your spleen is removed, the assassin walks away, leaving behind an incendiary grenade to burn    \u2551");
                Console.WriteLine("\u2551 all evidence of the crime. You breathe your last breath as a blinding light engulfs the room.          \u2551");
                Console.WriteLine("\u2551                                                                                                        \u2551");
                Console.WriteLine("\u255A\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u255D");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Environment.Exit(0);
            }
        }
    }
}
