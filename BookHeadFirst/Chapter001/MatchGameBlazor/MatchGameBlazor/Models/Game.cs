namespace MatchGameBlazor.Models;

public static class Game {
    private static bool _findingMatch;
    private static string _lastEmojiClicked = string.Empty;
    private static string _lastEmojiDescription = string.Empty;
    private static int _matchesFound;
    public static List<string> Emojis { get; private set; } = [];

    public static void SetupGame() {
        Emojis = GetEmojis();
    }

    private static List<string> GetEmojis() {
        string[] emojiRepository = [
            "🐶", "🐺", "🐮", "🦊", "🐱", "🦁", "🐯", "🐹",
            "🌍", "🏜️", "🏟️", "🏔️", "🌋", "🏝️", "🏝️", "🏞️",
            "🎃", "🎇", "🎈", "🎎", "🎁", "🎄", "🧨", "⚽",
            "😎", "🥶", "🤬", "😈", "🤩", "💩", "🤡", "🤑"
        ];

        const int emojisPairs = 8;
        var random = new Random();
        var indices = new List<int>();
        var emojis = new List<string>();

        for (int i = 0; i < emojisPairs; i++) {
            int index;

            do {
                index = random.Next(0, emojiRepository.Length);
            } while (indices.Contains(index));

            indices.Add(index);
            string nextEmoji = emojiRepository[index];
            emojis.AddRange([nextEmoji, nextEmoji]);
        }

        return emojis.OrderBy(_ => random.Next()).ToList();
    }

    public static void ButtonOnClick(string emoji, string description) {
        if (emoji == string.Empty || description == string.Empty) return;

        if (!_findingMatch) {
            _lastEmojiClicked = emoji;
            _lastEmojiDescription = description;
            _findingMatch = true;
            return;
        }

        if (_lastEmojiClicked == emoji && _lastEmojiDescription != description) {
            Emojis = Emojis.Select(x => x.Replace(emoji, "")).ToList();
            _lastEmojiClicked = string.Empty;
            _lastEmojiDescription = string.Empty;
            _findingMatch = false;
            _matchesFound++;
            return;
        }

        _lastEmojiClicked = string.Empty;
        _lastEmojiDescription = string.Empty;
        _findingMatch = false;
    }
}