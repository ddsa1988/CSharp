namespace HighLowGame.Models;

public static class HiLoGame {
    private static readonly Random Random = new();
    public const int Minimum = 1;
    public const int Maximum = 10;
    private static int _pot;
    private static int _currentNumber;

    static HiLoGame() {
        _currentNumber = Random.Next(Minimum, Maximum + 1);
        _pot = 10;
    }

    public static void Guess(bool isHigher) {
        int nextNumber = Random.Next(Minimum, Maximum + 1);

        if (isHigher && nextNumber >= _currentNumber || !isHigher && nextNumber <= _currentNumber) {
            Console.WriteLine("You guessed right!");
            _pot++;
        }
        else {
            Console.WriteLine("Bad luck, you guessed wrong!");
            _pot--;
        }

        _currentNumber = nextNumber;
        Console.WriteLine($"The current number is {_currentNumber}.");
    }

    public static int GetPot() {
        return _pot;
    }

    public static void Hint() {
        const int half = Maximum / 2;

        Console.WriteLine(_currentNumber >= half
            ? $"The number is at least {half}."
            : $"The number is at most {half}.");

        _pot--;
    }
}