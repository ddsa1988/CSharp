namespace MatchGameBlazor.Models;

public class Game {
    private string? _lastTextBlockClicked;
    private bool _findingMatch;

    private bool _isGameOver;

    // private readonly DispatcherTimer _timer = new();
    private int _tenthsOfSecondsElapsed;
    private int _matchesFound;
    private int _maxMatchesFound;
    private float _bestTime = float.MaxValue;
    private const float MaxTime = 30F;

    public List<string> SetUpGame() {
        string[] originalEmojis = [
            "🐶", "🐺", "🐮", "🦊", "🐱", "🦁", "🐯", "🐹",
            "🌍", "🏜️", "🏟️", "🏔️", "🌋", "🏝️", "🏝️", "🏞️",
            "🎃", "🎇", "🎈", "🎎", "🎁", "🎄", "🧨", "⚽",
            "😎", "🥶", "🤬", "😈", "🤩", "💩", "🤡", "🤑"
        ];

        const int emojisPairs = 8;
        var random = new Random();
        var emojis = new List<string>();
        var indices = new List<int>();

        for (int i = 0; i < emojisPairs; i++) {
            int index;

            do {
                index = random.Next(0, originalEmojis.Length);
            } while (indices.Contains(index));

            indices.Add(index);
            string nextEmoji = originalEmojis[index];
            emojis.AddRange([nextEmoji, nextEmoji]);
        }

        _matchesFound = 0;
        _maxMatchesFound = emojisPairs;
        _tenthsOfSecondsElapsed = 0;
        _isGameOver = false;
        // _timer.Start();

        return emojis;
    }
}