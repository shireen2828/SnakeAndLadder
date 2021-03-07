using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class UC5_WinningPosition
    {
        public static void Win()
        {
            int Position1 = 0;
            int L1 = 1, L2 = 4, L3 = 8, L4 = 21, L5 = 28, L6 = 50, L7 = 71, L8 = 80;
            int S1 = 32, S2 = 62, S3 = 88, S4 = 95, S5 = 97;
            int NoPlay = 0;
            Random random = new Random();
            int Dice = random.Next(0, 7);
            Random random1 = new Random();
            int Option1 = random.Next(0, 100);
            for (Option1 = 1; Option1 <= 100; Option1++)
            {
                if (Option1 == L1 || Option1 == L2 || Option1 == L3 || Option1 == L4)
                    Position1 = Position1 + Dice;
                else if (Option1 == S1 || Option1 == S2 || Option1 == S3 || Option1 == S4)
                    Position1 = Position1 - Dice;
                else
                    Position1 = Option1;
                Console.WriteLine("place: " + Option1 + "players position: " + Position1);
            }
        }
    }
}
