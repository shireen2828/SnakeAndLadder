using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class UC2_DieRoll
    {
        public static void dieroll()
        {
            int Player1 = 0;
            Random random = new Random();
            int Position = random.Next(0, 7);
            Console.WriteLine("Dice roll: " + Position);
            Console.ReadKey();
            UC3_CheckForOption.option();
        }
    }
}
