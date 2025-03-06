namespace WebMatchGame.Models;

public static class Game {
    private static string _lastEmoji = string.Empty;
    public static List<string> ShuffledEmojis { get; private set; }

    static Game() {
        SetUpGame();
    }

    private static void SetUpGame() {
        var random = new Random();

        ShuffledEmojis = Emoji.GetEmojis().OrderBy(item => random.Next()).ToList();
    }

    public static void ButtonClicked(string emoji) {
        if (_lastEmoji == string.Empty) {
            _lastEmoji = emoji;
            return;
        }

        if (_lastEmoji == emoji) {
            _lastEmoji = string.Empty;
            ShuffledEmojis = ShuffledEmojis.Select(item => item.Replace(emoji, string.Empty)).ToList();

            return;
        }

        _lastEmoji = string.Empty;
    }
}