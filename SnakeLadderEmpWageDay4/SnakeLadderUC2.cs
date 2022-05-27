using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeandladder
{
    internal class snakeladderUC2
    {
        public static void UC2()
        {
            Console.WriteLine("**Welcome to the Snake and Ladder Game**");

            int position = 0;
            Console.WriteLine("You are at Starting Position: " + position);

            Random obj = new Random();
            int rollDice = obj.Next(1, 7);

            Console.WriteLine("Dice Value: " + rollDice);

        }
    }
}
