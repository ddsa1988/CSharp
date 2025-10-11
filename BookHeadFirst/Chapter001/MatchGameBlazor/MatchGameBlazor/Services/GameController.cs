using System.Timers;
using MatchGameBlazor.Models;

namespace MatchGameBlazor.Services;

public class GameController {
    private string _lastEmoji = string.Empty;
    private string _lastDescription = string.Empty;
    private const int NumberOfPairs = 8;
    private int _matchesFound;
    private readonly System.Timers.Timer _timer = new();
    private int _actualTime;
    private int _bestTime;
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
        SetUpTimer();
    }

    private void SetUpTimer() {
        _actualTime = 0;
        _timer.Interval = 100; // 100ms
        _timer.Elapsed += TimerTick;
    }

    private void TimerTick(object? sender, ElapsedEventArgs e) {
        _actualTime++;
    }

    public string ActualTimeString => (_actualTime / 10F).ToString("0.0");
    public string BestTimeString => (_bestTime / 10F).ToString("0.0");

    private void IsGameOver() {
        if (_matchesFound < NumberOfPairs) return;

        IsNewGameButtonHidden = null;
        _timer.Stop();

        if (_bestTime != 0 && _actualTime >= _bestTime) return;

        _bestTime = _actualTime;
    }

    private void ChangeEmojiButtonState() {
        IsEmojiButtonDisabled = ShuffledEmojis.Select(emoji => emoji == "").ToList();
    }

    public void ButtonClick(string emoji, string description) {
        if (_lastEmoji == string.Empty) {
            _lastEmoji = emoji;
            _lastDescription = description;

            if (!_timer.Enabled) {
                _timer.Start();
            }

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