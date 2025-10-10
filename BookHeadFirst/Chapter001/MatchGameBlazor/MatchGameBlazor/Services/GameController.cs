using MatchGameBlazor.Models;

namespace MatchGameBlazor.Services;

public class GameController {
    private string _lastEmoji = string.Empty;
    private string _lastDescription = string.Empty;
    private const int NumberOfPairs = 8;
    private int _matchesFound;
    public List<string> ShuffledEmojis = [];
    public List<bool> IsEmojiButtonDisabled = [];
    public bool? IsNewGameButtonHidden { get; private set; }

    public GameController() {
        SetUpGame();
    }

    public void SetUpGame() {
        Random random = new();
        List<string> emojisPairs = Emojis.RandomEmojisPairs(NumberOfPairs);
        ShuffledEmojis = emojisPairs.OrderBy(item => random.Next()).ToList();
        IsNewGameButtonHidden = true;
        _matchesFound = 0;
        ChangeEmojiButtonState();
    }

    private void ChangeEmojiButtonState() {
        IsEmojiButtonDisabled = ShuffledEmojis.Select(emoji => emoji == "").ToList();
    }

    private void IsGameOver() {
        if (_matchesFound < NumberOfPairs) return;

        IsNewGameButtonHidden = null;
    }

    public void ButtonClick(string emoji, string description) {
        if (_lastEmoji == string.Empty) {
            _lastEmoji = emoji;
            _lastDescription = description;
            return;
        }

        if (_lastEmoji == emoji && _lastDescription != description) {
            _lastEmoji = string.Empty;
            _lastDescription = description;
            ShuffledEmojis = ShuffledEmojis.Select(item => item.Replace(emoji, string.Empty)).ToList();
            ChangeEmojiButtonState();
            _matchesFound++;
            IsGameOver();
            return;
        }

        _lastEmoji = string.Empty;
        _lastDescription = string.Empty;
    }
}