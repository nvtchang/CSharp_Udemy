using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame
{
    class NumberComparison
    {
        public static void Check(int random, int input)
        {
            if (random == input)
            {
                Console.WriteLine("You win");
            } else
            {
                Console.WriteLine("Wrong number");
            }
        }
    }
}
