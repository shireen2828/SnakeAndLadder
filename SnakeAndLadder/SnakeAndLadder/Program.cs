using System;

namespace SnakeAndLadder
{
    class UC1_StartPosition
    {
        static void Main(string[] args)
        {
            int Player1 = 0;
            int Position = 0;
            Console.WriteLine("starting position: " + Position);
            Console.ReadKey();
            UC2_DieRoll.dieroll();
        }
    }
}
