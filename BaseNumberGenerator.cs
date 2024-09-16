namespace GuessTheNumber
{
    public abstract class BaseNumberGenerator : INumberGenerator
    {
        public abstract int GenerateNumber(int min, int max);
    }
}
