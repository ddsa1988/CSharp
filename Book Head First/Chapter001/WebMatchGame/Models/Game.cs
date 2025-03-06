namespace WebMatchGame.Models;

public static class Game {
    public static List<string> Emojis { get; private set; }

    static Game() {
        SetUpGame();
    }

    private static void SetUpGame() {
        var random = new Random();

        Emojis = Emoji.GetEmojis().OrderBy(item => random.Next()).ToList();
    }
}