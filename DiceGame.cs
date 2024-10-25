using DiceGame.Game;

var random = new Random();
var dice = new Dice(random);
var guessingGame = new GuessingGame(dice);
guessingGame.Play();
Console.ReadKey();