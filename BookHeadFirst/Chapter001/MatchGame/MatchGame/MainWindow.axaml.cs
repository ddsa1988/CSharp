using System;
using System.Collections.Generic;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Input;

namespace MatchGame;

public partial class MainWindow : Window {
    private TextBlock? _lastTextBlockClicked;
    private bool _findingMatch;

    public MainWindow() {
        InitializeComponent();
        SetUpGame();
    }

    private void SetUpGame() {
        string[] originalEmojis = [
            "🐶", "🐶",
            "🐺", "🐺",
            "🐮", "🐮",
            "🦊", "🦊",
            "🐱", "🐱",
            "🦁", "🦁",
            "🐯", "🐯",
            "🐹", "🐹",
        ];

        var random = new Random();
        List<string> emojis = originalEmojis.ToList();

        foreach (TextBlock textBlock in MainGrid.Children.OfType<TextBlock>()) {
            int index = random.Next(emojis.Count);
            string nextEmoji = emojis[index];
            textBlock.Text = nextEmoji;
            emojis.RemoveAt(index);
        }
    }

    private void TextBlock_Pressed(object? sender, PointerPressedEventArgs e) {
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
            return;
        }

        if (_lastTextBlockClicked != null) {
            _lastTextBlockClicked.IsVisible = true;
        }

        _findingMatch = false;
    }
}