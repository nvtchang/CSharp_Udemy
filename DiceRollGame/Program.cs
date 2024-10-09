using DiceRollGame.Game;

var random = new Random();
var dice = new Dice(random);
var guessGame = new GuessingGame(dice);

GameResult gameResult = guessGame.Play();
GuessingGame.PrintResult(gameResult);



