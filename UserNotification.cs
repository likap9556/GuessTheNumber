namespace GuessTheNumber
{
    public class UserNotification
    {
        public static void SendSuccess()
        {
            Console.WriteLine("Поздравляем! Вы угадали число!");
        }

        public static void SendNumberGreater()
        {
            Console.WriteLine("Загаданное число больше.");
        }

        public static void SendNumberLess()
        {
            Console.WriteLine("Загаданное число меньше.");
        }

        public static void SendLoss(int numberToGuess)
        {
            Console.WriteLine($"Вы исчерпали попытки! Загаданное число было: {numberToGuess}.");
        }
    }
}