using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame
{
    class Validation
    {
        public static bool Number(string value)
        {
            var isNumeric = int.TryParse(value, out int n);
            if(!isNumeric)
            {
                return false;
            } 
            return true;
        }
    }
}
