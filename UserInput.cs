namespace GuessTheNumber
{
    public class UserInput
    {
        public static int GetUserGuess()
        {
            Console.Write("Введите ваше число: ");
            return int.Parse(Console.ReadLine()!);
        }
    }
}
