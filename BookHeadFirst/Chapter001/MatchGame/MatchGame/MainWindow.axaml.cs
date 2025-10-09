using System;
using System.Collections.Generic;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Threading;

namespace MatchGame;

public partial class MainWindow : Window {
    private TextBlock? _lastTextBlockClicked;
    private bool _findingMatch;
    private bool _isGameOver;
    private readonly DispatcherTimer _timer = new();
    private int _tenthsOfSecondsElapsed;
    private int _matchesFound;
    private int _maxMatchesFound;
    private float _bestTime = float.MaxValue;
    private const float MaxTime = 30F;

    public MainWindow() {
        InitializeComponent();

        _timer.Interval = TimeSpan.FromSeconds(0.1);
        _timer.Tick += TimerTick;

        CreateLayout();

        SetUpGame();
    }

    private void TimerTick(object? sender, EventArgs e) {
        _tenthsOfSecondsElapsed++;
        float elapsedTime = _tenthsOfSecondsElapsed / 10F;

        TimeTextBlock.Text = elapsedTime.ToString("0.0s");

        if (elapsedTime >= MaxTime) {
            TimeTextBlock.Text += " - Game Over! Play again?";
            _isGameOver = true;
        } else if (_matchesFound == _maxMatchesFound) {
            TimeTextBlock.Text += " - Play again?";
            _isGameOver = true;
        }

        if (!_isGameOver) return;

        if (elapsedTime < _bestTime) {
            _bestTime = elapsedTime;
            BestTimeTextBlock.Text = "Best time: " + elapsedTime.ToString("0.0s");
        }

        _timer.Stop();
    }

    private void CreateLayout() {
        const int rows = 4;
        const int columns = 4;

        for (int row = 0; row < rows; row++) {
            for (int column = 0; column < columns; column++) {
                var textBlock = new TextBlock();
                textBlock.PointerPressed += TextBlockPressed;

                Grid.SetRow(textBlock, row);
                Grid.SetColumn(textBlock, column);

                MainGrid.Children.Add(textBlock);
            }
        }
    }

    private void SetUpGame() {
        string[] originalEmojis = [
            "🐶", "🐺", "🐮", "🦊", "🐱", "🦁", "🐯", "🐹",
            "🌍", "🏜️", "🏟️", "🏔️", "🌋", "🏝️", "🤦‍", "🏞️",
            "🎃", "🎇", "🎈", "🎎", "🎁", "🎄", "🧨", "⚽",
            "😎", "🥶", "🤬", "😈", "🤩", "💩", "🤡", "🤑"
        ];

        var random = new Random();
        int emojisPairs = MainGrid.Children.OfType<TextBlock>().Count() / 2;
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

        foreach (TextBlock textBlock in MainGrid.Children.OfType<TextBlock>()) {
            int index = random.Next(emojis.Count);
            string nextEmoji = emojis[index];

            textBlock.Text = nextEmoji;
            textBlock.IsVisible = true;

            emojis.RemoveAt(index);
        }

        _matchesFound = 0;
        _maxMatchesFound = emojisPairs;
        _tenthsOfSecondsElapsed = 0;
        _isGameOver = false;
        _timer.Start();
    }

    private void TextBlockPressed(object? sender, PointerPressedEventArgs e) {
        var textBlock = sender as TextBlock;

        if (textBlock == null) return;

        if (!_findingMatch) {
            textBlock.IsVisible = false;
            _lastTextBlockClicked = textBlock;
            _findingMatch = true;
            return;
        }

        if (_lastTextBlockClicked?.Text == textBlock.Text) {
            textBlock.IsVisible = false;
            _findingMatch = false;
            _matchesFound++;
            return;
        }

        if (_lastTextBlockClicked != null) {
            _lastTextBlockClicked.IsVisible = true;
        }

        _findingMatch = false;
    }

    private void TimeTextBlockPressed(object? sender, PointerPressedEventArgs e) {
        if (!_isGameOver) return;

        SetUpGame();
    }
}