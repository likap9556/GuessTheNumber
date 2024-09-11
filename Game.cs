namespace GuessTheNumber
{
    public class Game
    {
        private readonly GameSettings _settings;
        private readonly int _numberToGuess;

        public Game(INumberGenerator numberGenerator, GameSettings settings)
        {
            _settings = settings;
            _numberToGuess = numberGenerator.GenerateNumber(_settings.MinNumber, _settings.MaxNumber);
        }

        public void Play()
        {
            var attempts = 0;
            while (attempts < _settings.MaxAttempts)
            {
                var userGuess = new UserInput().GetUserGuess();
                attempts++;

                if (userGuess == _numberToGuess)
                {
                    Console.WriteLine("Поздравляем! Вы угадали число!");
                    return;
                }

                if (userGuess < _numberToGuess)
                {
                    Console.WriteLine("Загаданное число больше.");
                }
                else
                {
                    Console.WriteLine("Загаданное число меньше.");
                }
            }
            Console.WriteLine($"Вы исчерпали попытки! Загаданное число было: {_numberToGuess}.");
        }
    }
}
