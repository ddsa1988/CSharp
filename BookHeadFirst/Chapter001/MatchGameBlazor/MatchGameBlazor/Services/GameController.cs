using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Timers;
using MatchGameBlazor.Models;

namespace MatchGameBlazor.Services;

public sealed class GameController : INotifyPropertyChanged {
    private string _lastEmoji = string.Empty;
    private string _lastDescription = string.Empty;
    private int _matchesFound;
    private int _actualTime;
    private int _bestTime;
    private string _actualTimeString = string.Empty;
    private string _bestTimeString = string.Empty;
    private const int NumberOfPairs = 8;
    private readonly System.Timers.Timer _timer = new();
    public bool? IsNewGameButtonHidden { get; private set; }
    public List<string> ShuffledEmojis = [];
    public List<bool> IsEmojiButtonDisabled = [];

    public GameController() {
        SetUpTimer();
        SetUpGame();
    }

    public void SetUpGame() {
        Random random = new();
        List<string> emojisPairs = Emojis.RandomEmojisPairs(NumberOfPairs);
        ShuffledEmojis = emojisPairs.OrderBy(_ => random.Next()).ToList();
        IsNewGameButtonHidden = true;
        ActualTimeString = "0.0";
        BestTimeString = string.IsNullOrWhiteSpace(BestTimeString) ? "0.0" : BestTimeString;
        _actualTime = 0;
        _matchesFound = 0;

        ChangeEmojiButtonState();
    }

    private void SetUpTimer() {
        _timer.Interval = 100;
        _timer.Elapsed += TimerTick;
    }

    private void TimerTick(object? sender, ElapsedEventArgs e) {
        _actualTime++;
        ActualTimeString = (_actualTime / 10F).ToString("0.0");
    }

    public string ActualTimeString {
        get => _actualTimeString;
        private set => SetField(ref _actualTimeString, value);
    }

    public string BestTimeString {
        get => _bestTimeString;
        private set => SetField(ref _bestTimeString, value);
    }

    private void IsGameOver() {
        if (_matchesFound < NumberOfPairs) return;

        IsNewGameButtonHidden = null;
        _timer.Stop();

        if (_bestTime != 0 && _actualTime >= _bestTime) return;

        _bestTime = _actualTime;
        BestTimeString = (_bestTime / 10F).ToString("0.0");
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

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string? propertyName = null) {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null) {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}