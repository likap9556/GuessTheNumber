namespace GuessTheNumber
{
    public class RandomNumberGenerator : INumberGenerator
    {
        private readonly Random _random = new();

        public int GenerateNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
    }
}
