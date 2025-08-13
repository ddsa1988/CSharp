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
    private readonly DispatcherTimer _timer = new();
    private int _tenthsOfSecondsElapsed;
    private int _matchesFound;
    private int _maxMatchesFound;

    public MainWindow() {
        InitializeComponent();

        _timer.Interval = TimeSpan.FromSeconds(0.1);
        _timer.Tick += TimerTick;

        SetUpGame();
    }

    private void TimerTick(object? sender, EventArgs e) {
        _tenthsOfSecondsElapsed++;
        TimeTextBlock.Text = (_tenthsOfSecondsElapsed / 10F).ToString("0.0s");

        if (_matchesFound != _maxMatchesFound) return;

        _timer.Stop();
        TimeTextBlock.Text += " - Play again?";
    }

    private void SetUpGame() {
        string[] originalEmojis = [
            "🐶", "🐶", "🐺", "🐺", "🐮", "🐮", "🦊", "🦊", "🐱", "🐱", "🦁", "🦁", "🐯", "🐯", "🐹", "🐹",
        ];

        var random = new Random();
        List<string> emojis = originalEmojis.ToList();

        foreach (TextBlock textBlock in MainGrid.Children.OfType<TextBlock>()) {
            int index = random.Next(emojis.Count);
            string nextEmoji = emojis[index];
            textBlock.Text = nextEmoji;
            textBlock.IsVisible = true;
            emojis.RemoveAt(index);
        }

        _maxMatchesFound = originalEmojis.Length / 2;
        _tenthsOfSecondsElapsed = 0;
        _matchesFound = 0;
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
        if (_matchesFound != _maxMatchesFound) return;

        SetUpGame();
    }
}