using DiceRollGame.UserCommunication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame.Game
{
    public class GuessingGame
    {
        private readonly Dice _dice;
        private const int IntitialTries = 3;
        public GuessingGame(Dice dice)
        {
            _dice = dice;
        }
        public GameResult Play()
        {
            var diceRollResult = _dice.Roll();
            Console.WriteLine($"Dice rolled. Guess what number it shows in {IntitialTries} tries.");
            var guessNumber = Console.ReadLine();
            int triesLeft = IntitialTries;
            while (triesLeft > 0)
            {
                var guess = ConsoleReader.ReadInteger("Enter a number:");
                if (guess == diceRollResult)
                {
                    return GameResult.Victory;
                }
                Console.WriteLine("Wrong number.");
                --triesLeft;
            }
            return GameResult.Loss;
        }

        public static void PrintResult(GameResult gameResult)
        {
            string message = gameResult == GameResult.Victory
                ? "You win"
                : "You lose :(";

            Console.WriteLine(message);
        }
    }
}
