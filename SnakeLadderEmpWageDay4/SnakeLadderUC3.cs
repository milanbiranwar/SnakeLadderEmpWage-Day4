using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeandladder
{
    internal class snakeladderUC3
    {
       public static int dicecount = 0;
        public static int num1;
        public static void UC3()
        {
            int position = 0;
            
            //Random number for rolldice
            Random obj = new Random();
            int rollDice = obj.Next(1, 7);
            Console.WriteLine("Dice Value: " + rollDice);

            //Random numbers for position
            Random num = new Random();
            int value = num.Next(1, 4);
            Console.WriteLine("case number is " + value);

            
            if (value == 1)  
            {
           
               Console.WriteLine("You got NO PLAY Option");

            }
            else if (value == 2)
            {
              Console.WriteLine("You got Ladder Option");
               
                position = position + rollDice;
                Console.WriteLine(" your position: {0}", position);

            }
            else
            {
                Console.WriteLine("You got Snake Option");

                
                position = position - rollDice;
                Console.WriteLine("You got snake \n your position: {0} \n ", position);

            }

        }
           
    }
}

                
    