using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeandladder
{
    internal class SnakeLadderUC6
    {

        public static int dicecount = 0;
        public static int num1;
        public static int position = 0;
        public static void UC6()
        {
            while (position < 100)
            {



                Random obj = new Random();
                int rollDice = obj.Next(1, 7);
                Console.WriteLine("Dice Value: " + rollDice);

                Random num = new Random();
                int value = num.Next(1, 4);
                Console.WriteLine("case number is " + value);

                if (value == 1)
                {


                    dicecount++;
                    Console.WriteLine("You got NO PLAY Option  \n Dice value: {0} \n", rollDice);

                }
                else if (value == 2)
                {
                    Console.WriteLine("You got Ladder Option \n  Dice value: {0} \n", rollDice);
                    dicecount++;
                    position = position + rollDice;

                    if (position > 100)
                    {
                        dicecount++;
                        position = position - rollDice;
                        Console.WriteLine("You got Ladder  \n Dice value: {0} \n", rollDice);


                    }

                    Console.WriteLine(" your position: {0}", position);

                }
                else
                {

                    dicecount++;
                    position = position - rollDice;

                    Console.WriteLine("You got Snake Option\n Dice value: {0}\n", rollDice);

                    if (position < 0)
                    {

                        position = 0;

                        Console.WriteLine("\n Starting game  again \n");


                    }
                    Console.WriteLine("You got snake \n your position: {0} \n ", position);

                }
            }
            Console.WriteLine("Number of times dice Roll for winning 100 positin is : {0}", dicecount);
        }
    }
}
    

