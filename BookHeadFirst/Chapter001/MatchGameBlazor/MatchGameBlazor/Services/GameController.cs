using MatchGameBlazor.Models;

namespace MatchGameBlazor.Services;

public class GameController {
    private string _lastEmoji = string.Empty;
    private string _lastDescription = string.Empty;
    private const int NumberOfPairs = 8;
    public List<string> ShuffledEmojis = [];
    public List<bool> ButtonIsDisabled = [];

    public GameController() {
        SetUpGame();
    }

    private void SetUpGame() {
        Random random = new();
        List<string> emojisPairs = Emojis.RandomEmojisPairs(NumberOfPairs);
        ShuffledEmojis = emojisPairs.OrderBy(item => random.Next()).ToList();
        ChangeButtonState();
    }

    private void ChangeButtonState() {
        ButtonIsDisabled = ShuffledEmojis.Select(emoji => emoji == "").ToList();
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
            ChangeButtonState();
            return;
        }

        _lastEmoji = string.Empty;
        _lastDescription = string.Empty;
    }
}