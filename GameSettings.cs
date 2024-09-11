namespace GuessTheNumber
{
    public class GameSettings
    {
        public int MinNumber { get; set; }

        public int MaxNumber { get; set; }

        public int MaxAttempts { get; set; }

        public GameSettings(int min, int max, int attempts)
        {
            MinNumber = min;
            MaxNumber = max;
            MaxAttempts = attempts;
        }
    }
}
