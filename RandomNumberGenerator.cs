namespace GuessTheNumber
{
    public class RandomNumberGenerator : BaseNumberGenerator
    {
        private readonly Random _random = new();

        public override int GenerateNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
    }
}
