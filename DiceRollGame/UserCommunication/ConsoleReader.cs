﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame.UserCommunication
{
    public class ConsoleReader
    {
        public static int ReadInteger(string message)
        {
            int result;
            do
            {
                Console.WriteLine($"{message}");
            }
            while (!int.TryParse(Console.ReadLine(), out result));
            return result;
        }
    }
}
