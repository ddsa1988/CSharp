namespace BlazorMatchGame.Models;

public static class Game {
    private static string _lastEmoji = string.Empty;    
    public static List<string> ShuffledEmojis { get; private set; }

    static Game() {
        InitGame();
    }

    public static void InitGame() {
        ShuffledEmojis = Emoji.GetEmojis().OrderBy(item => new Random().Next()).ToList();
    }

    public static void ButtonClick(string emoji) {
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