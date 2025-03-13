namespace SimpleCasinoBlazor.Models;

public static class Game {
    public static double Odds { get; private set; } = 0.75;
    public static string TextResult { get; set; } 
    public static Account Player { get; set; }

    static Game() {
        InitGame();
    }

    public static void InitGame() {
        Player = new Account("Diego", 200);
        TextResult = string.Empty;
    }
}