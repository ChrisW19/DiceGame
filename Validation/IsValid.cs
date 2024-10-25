namespace DiceGame.Validation
{
    public class IsValid
    {
        public static bool IsValidNumber(string? userGuess)
        {
            bool isValid = false;
            if (int.TryParse(userGuess, out int guess) && guess >= 1 && guess <= 6)
            {
                isValid = true;
            }
            return isValid;
        }
    }
}
