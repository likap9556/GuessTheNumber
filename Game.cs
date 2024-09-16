namespace GuessTheNumber
{
    public class Game
    {
        private readonly GameSettings _settings;
        private readonly INumberGenerator _numberGenerator;

        public Game(INumberGenerator numberGenerator, GameSettings settings)
        {
            _settings = settings;
            _numberGenerator = numberGenerator;
        }

        public void Play()
        {
            var numberToGuess = _numberGenerator.GenerateNumber(_settings.MinNumber, _settings.MaxNumber);
            var attempts = 0;

            while (attempts < _settings.MaxAttempts)
            {
                var userGuess = UserInput.GetUserGuess();
                attempts++;

                if (userGuess == numberToGuess)
                {
                    UserNotification.SendSuccess();
                }

                else if (userGuess < numberToGuess)
                {
                    UserNotification.SendNumberGreater();
                }

                else
                {
                    UserNotification.SendNumberLess();
                }
            }
            UserNotification.SendLoss(numberToGuess);
        }
    }
}
