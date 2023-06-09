using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder
{
    internal class PlayerCheck
    {
        public static void Check()
        {
           // int move = 0;
            Random Dice = new Random();
            int RollDice = Dice.Next(0,7);

            Console.WriteLine("The player started the game with " + RollDice);
            Console.WriteLine("After the second Roll");
            Random Dice2= new Random();
            int RollDice2= Dice2.Next(1,7);

            if(RollDice==RollDice2)
            {
                Console.WriteLine("The player with No Play Position");
            }
            else if (RollDice<RollDice2)
            {
                 //move = RollDice + RollDice2;
                Console.WriteLine("The Player move forward with Ladder Position with "+RollDice2);
            }
            else
            {
               // move = RollDice - RollDice2;
                Console.WriteLine("The Player move backward with Snake Position with " + RollDice2);
            }
        }

        public static void RepeatTillWinning()
        {
            int move = 0;
            Random Dice = new Random();
            int RollDice = Dice.Next(0, 7);

            Console.WriteLine("The player started the game with " + RollDice);
            Console.WriteLine("After the second Roll");

            while (move < 100)
            {
                Random Dice2 = new Random();
                int RollDice2 = Dice2.Next(1, 7);

                if (RollDice == RollDice2)
                {
                    Console.WriteLine("The player with No Play Position");
                }
                else if (RollDice < RollDice2)
                {
                    move = move + RollDice2;
                    Console.WriteLine("The Player move forward with Ladder Position with " + move);
                }
                else
                {
                    move = move - RollDice2;
                    Console.WriteLine("The Player move backward with Snake Position with " + move);
                }
                RollDice= RollDice2;
                Console.WriteLine("Current Position "+move);
            }

        }

        public static void Exact100Position()
        {
            int move = 0;
            Random Dice = new Random();
            int RollDice = Dice.Next(0, 7);

            Console.WriteLine("The player started the game with " + RollDice);
            Console.WriteLine("After the second Roll");

            while (move < 100){
                Random Dice2 = new Random();
                 int RollDice2 = Dice2.Next(1, 7);

                if (RollDice == RollDice2)
                {
                    Console.WriteLine("The player with No Play Position");
                }
                else if (move + RollDice2 <= 100)
                {
                    move = move + RollDice2;
                    Console.WriteLine("The Player move forward with  Position with " + move + " with dice " + RollDice2);
                }
                else
                {
                    Console.WriteLine("The Player move backward with Snake Position with " + move + " with dice " + RollDice2 + " Exceeds 100");
                }   
                RollDice = RollDice2;
                Console.WriteLine("Current Position " + move);
            }
        }
    }
}
