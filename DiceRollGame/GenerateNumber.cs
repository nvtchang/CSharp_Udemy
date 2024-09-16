using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame
{
    class GenerateNumber
    {
        public static int GetRandomNumber()
        {
            Random r = new Random();
            int dice = r.Next(1, 7);
            return dice;
        }
    }
}
