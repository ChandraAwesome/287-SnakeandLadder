using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder
{
    internal class ZeroPosition
    {
        public static void StarttheGame()
        {
            Random Dice = new Random();
            int RollDice = Dice.Next(0,7);

            if(RollDice==0)
            {
                Console.WriteLine("Player is at Zero Position");
            }
            else if (RollDice==6) 
            {
                Console.WriteLine("Player started the taking the steps with 6 ");
            }
            else
            {
                Console.WriteLine("Roll the dice again");
            }
        }
    }
}
