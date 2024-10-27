using DiceGame.Validation;

namespace DiceGame.Game
{
    public class GuessingGame
    {
        private readonly Dice _dice;
        private const int InitialTries = 3;

        public GuessingGame(Dice dice)
        {
            _dice = dice;
        }

        public bool Play()
        {
            var diceRollResult = _dice.Roll();
            Console.WriteLine($"Dice rolled. Guess what number it shows in {InitialTries} tries.");

            int triesLeft = InitialTries;
            
            while (triesLeft > 0)
            {
                
                Console.WriteLine($"Enter a number (between 1 and 6):");
                var userGuess = Console.ReadLine();

                if (!IsValid.IsValidNumber(userGuess))
                {
                    Console.WriteLine($"Invalid input.");
                    continue;
                }

                if (int.Parse(userGuess) == diceRollResult)
                {
                    Console.WriteLine("You win!");
                    return true;
                }

                triesLeft--;
                Console.WriteLine($"Incorrect. You have {triesLeft} tries left.");
            }

            Console.WriteLine($"You lose. Game Over. The correct number was {diceRollResult}.");
            return false;
        }
    }
}