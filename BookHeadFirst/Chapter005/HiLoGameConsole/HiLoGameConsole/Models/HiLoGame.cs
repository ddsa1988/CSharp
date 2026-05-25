namespace HiLoGameConsole.Models;

public static class HiLoGame {
    private static readonly Random Random = new();
    public const int Minimum = 1;
    public const int Maximum = 10;
    private static int _pot;
    public static int CurrentNumber { get; private set; }

    static HiLoGame() {
        CurrentNumber = Random.Next(Minimum, Maximum + 1);
        _pot = 10;
    }

    public static void Guess(bool isHigher) { }

    public static int GetPot() {
        return _pot;
    }

    public static void Hint() {
        _pot--;
    }
}