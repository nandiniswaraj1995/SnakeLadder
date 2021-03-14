using System;

namespace SnakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            int position = 0;
            int dice;

            SnakeLadderUtility snakeLadder = new SnakeLadderUtility();
            Console.WriteLine("=====================================");
            Console.WriteLine("***** Welcome Snake Ladder Game *****");
            Console.WriteLine("=====================================");
            Console.WriteLine("-----------For Single Player Mode------------");
            Console.WriteLine("Player Starting Position Is: "+position);
            dice = snakeLadder.diceRoll();
            Console.WriteLine("Player Rolled Dice And Obtained Number: "+dice);
        }
    }
}
