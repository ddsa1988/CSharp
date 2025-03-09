namespace BlazorMatchGame.Models;

public static class Game {
    private static string _lastEmoji = string.Empty;
    private static string _lastButton = string.Empty;
    private const int MaxMatches = 8;
    public static int MatchesFound { get; private set; }
    public static List<string> ShuffledEmojis { get; private set; }

    static Game() {
        InitGame();
    }

    public static void InitGame() {
        ShuffledEmojis = Emoji.GetEmojis().OrderBy(item => new Random().Next()).ToList();
        MatchesFound = 0;
    }

    public static void ButtonClick(string emoji, string button) {
        if (emoji != string.Empty && _lastEmoji == emoji && _lastButton != button) {
            _lastEmoji = string.Empty;
            _lastButton = string.Empty;

            ShuffledEmojis = ShuffledEmojis.Select(item => item.Replace(emoji, string.Empty)).ToList();
            MatchesFound++;

            if (MatchesFound == MaxMatches) InitGame();

            return;
        }

        _lastEmoji = emoji;
        _lastButton = button;
    }
}