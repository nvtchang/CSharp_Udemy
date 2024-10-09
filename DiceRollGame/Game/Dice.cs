﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame.Game
{
    public class Dice
    {
        private readonly Random _random;
        private const int SidesCount = 6;
        public Dice(Random random)
        {
            _random = random;
        }

        public int Roll() => _random.Next(1, SidesCount + 1);

    }
}
