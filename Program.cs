namespace GuessTheNumber
{
    public class Program
    {
        public static void Main()
        {
            var settings = new GameSettings(1, 100, 5);
            INumberGenerator numberGenerator = new RandomNumberGenerator();
            var game = new Game(numberGenerator, settings);

            game.Play();
        }
    }
}