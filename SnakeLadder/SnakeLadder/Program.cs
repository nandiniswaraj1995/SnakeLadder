using System;

namespace SnakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int position = 0;
            int dice;
            int sum = 0;

            SnakeLadderUtility snakeLadder = new SnakeLadderUtility();
            Console.WriteLine("=====================================");
            Console.WriteLine("***** Welcome Snake Ladder Game *****");
            Console.WriteLine("=====================================");
            Console.WriteLine("-----------For Single Player Mode------------");
            Console.WriteLine("Player Starting Position At: "+position);
            dice = snakeLadder.diceRoll();
            Console.WriteLine("Player Rolled Dice And Obtained Number: "+dice);
            Console.WriteLine("1.No Play  2.Ladder 3.Snake");
            int choice = random.Next(1, 4) ;
            sum = dice;
            Console.WriteLine("Player Chioce: "+choice);
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Player is At Same Position: " + sum); ; ;
                    break;
                case 2: sum = sum + dice;
                    Console.WriteLine("Ladder Climed At: "+sum);
                    break;
                case 3: sum = sum - dice;
                    Console.WriteLine("Snake bit and move backward: "+sum);
                    break;
                    
            }

        }
    }
}
