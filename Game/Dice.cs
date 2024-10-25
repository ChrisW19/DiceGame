namespace DiceGame.Game
{
    public class Dice
    {
        private readonly int DiceSides = 6;
        private readonly Random _random;

        public Dice(Random random)
        {
            _random = random;
        }

        public int Roll() => _random.Next(1, DiceSides + 1);

        public void Describe() =>
            Console.WriteLine($"Dice side is {DiceSides}");
    }
}
