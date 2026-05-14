using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using Avalonia.Controls;
using Avalonia.Threading;

namespace MatchGame.Models;

public partial class Game {
    private readonly Random _random = new();
    private readonly Grid _gridLayout;
    private TextBlock? _lastTextBlockClicked;
    private bool _findMatch;
    private readonly int _gridRows;
    private readonly int _gridColumns;
    private readonly string[,] _gridEmojis;

    private readonly string[] _sourceEmojis =
        ["🐦", "🐥", "🐌", "🦂", "🦊", "🐯", "🐻", "🐠", "🐼", "🐞", "🦖", "🦋", "🦈", "🐉", "🦜", "🐫"];

    private readonly List<string> _selectedEmojis = [];

    public Game(Grid gridLayout) {
        _gridLayout = gridLayout;
        _gridRows = _gridLayout.RowDefinitions.Count - 1;
        _gridColumns = _gridLayout.ColumnDefinitions.Count;
        _gridEmojis = new string[_gridRows, _gridColumns];
    }

    [GeneratedRegex(@"\d{2}$")]
    private static partial Regex FindLastTwoDigitsRegex();

    private void GenerateSelectedEmojis() {
        int maxNumberEmojis = _gridRows * _gridColumns;

        while (_selectedEmojis.Count < maxNumberEmojis) {
            int randomIndex = _random.Next(0, _sourceEmojis.Length);
            string emoji = _sourceEmojis[randomIndex];

            if (_selectedEmojis.Contains(emoji)) continue;

            _selectedEmojis.AddRange(emoji, emoji);
        }
    }

    private void GenerateGridEmojis() {
        for (int row = 0; row < _gridRows; row++) {
            for (int col = 0; col < _gridColumns; col++) {
                if (_selectedEmojis.Count == 0) return;

                int randomIndex = _random.Next(0, _selectedEmojis.Count);
                string emoji = _selectedEmojis[randomIndex];

                _selectedEmojis.RemoveAt(randomIndex);
                _gridEmojis[row, col] = emoji;
            }
        }
    }

    private void GenerateGridTextBlocksText() {
        foreach (TextBlock textBlock in _gridLayout.Children.OfType<TextBlock>()) {
            textBlock.Text = "?";
            textBlock.IsEnabled = true;
        }
    }

    public void SetUpGame() {
        GenerateGridTextBlocksText();
        GenerateSelectedEmojis();
        GenerateGridEmojis();
    }

    public void CheckGuess(TextBlock textBlock) {
        Match match = FindLastTwoDigitsRegex().Match(textBlock.Name ?? "");

        if (!match.Success) return;

        bool isRowValid = int.TryParse(match.ValueSpan[0].ToString(), out int row);
        bool isColumnValid = int.TryParse(match.ValueSpan[1].ToString(), out int column);

        if (!(isRowValid && row < _gridRows)) return;
        if (!(isColumnValid && column < _gridColumns)) return;

        textBlock.Text = _gridEmojis[row, column];

        if (!_findMatch) {
            _lastTextBlockClicked = textBlock;
            _findMatch = true;
            return;
        }

        if (_lastTextBlockClicked == null) return;

        if (_lastTextBlockClicked.Name == textBlock.Name) return;

        if (_lastTextBlockClicked.Text == textBlock.Text) {
            _findMatch = false;
            _lastTextBlockClicked.IsEnabled = false;
            textBlock.IsEnabled = false;
            return;
        }

        Dispatcher.UIThread.Post(() => {
            Thread.Sleep(1000);
            textBlock.Text = "?";
            _lastTextBlockClicked.Text = "?";
            _findMatch = false;
        });
    }
}