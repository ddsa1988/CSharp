namespace Examples.Models;

public static class HiLoGame {
    private static readonly Random Random = new();
    private static int _currentNumber = Random.Next(1, Maximum + 1);
    public const int Maximum = 10;
    public static int Pot { get; private set; } = 5;

    public static void Guess(bool higher) {
        int nextNumber = Random.Next(1, Maximum + 1);
        bool isGuessRight = (higher && nextNumber >= _currentNumber) || (!higher && nextNumber <= _currentNumber);

        _currentNumber = nextNumber;

        if (isGuessRight) {
            Console.WriteLine("You guessed right!");
            Pot++;
        } else {
            Console.WriteLine("You guessed wrong!");
            Pot--;
        }

        Console.WriteLine($"The current number is {_currentNumber}.");
    }

    public static void Hint() {
        const int half = Maximum / 2;

        Console.WriteLine(_currentNumber >= half ? $"The number is at least {half}." : $"The number at most {half}.");

        Pot--;
    }
}