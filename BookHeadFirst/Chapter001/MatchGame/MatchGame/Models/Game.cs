using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Threading;

namespace MatchGame.Models;

public partial class Game {
    private readonly Random _random = new();
    private readonly Grid _uiGrid;
    private TextBlock? _uiLastTextBlockClicked;
    private bool _findMatch;
    private readonly int _uiTextBlockGridRows;
    private readonly int _uiTextBlockGridColumns;
    private readonly string[,] _textBlocksEmojis;

    private readonly string[] _sourceEmojis =
        ["🐦", "🐥", "🐌", "🦂", "🦊", "🐯", "🐻", "🐠", "🐼", "🐞", "🦖", "🦋", "🦈", "🐉", "🦜", "🐫"];

    private readonly List<string> _randomEmojis = [];

    public Game(Grid uiGrid) {
        _uiGrid = uiGrid;
        _uiTextBlockGridRows = _uiGrid.RowDefinitions.Count - 1;
        _uiTextBlockGridColumns = _uiGrid.ColumnDefinitions.Count;
        _textBlocksEmojis = new string[_uiTextBlockGridRows, _uiTextBlockGridColumns];

        CreateGridTextBlocks();
    }

    [GeneratedRegex(@"\d{2}$")]
    private static partial Regex FindLastTwoDigitsRegex();

    private void CreateGridTextBlocks() {
        for (int row = 0; row < _uiTextBlockGridRows; row++) {
            for (int column = 0; column < _uiTextBlockGridColumns; column++) {
                var border = new Border();
                var textBlock = new TextBlock();

                border.Classes.Add("border-emoji");
                textBlock.Classes.Add("text-emoji");
                textBlock.Name = $"TextBlock{row}{column}";
                textBlock.PointerPressed += CheckGuess;

                border.Child = textBlock;

                Grid.SetRow(border, row);
                Grid.SetColumn(border, column);

                _uiGrid.Children.Add(border);
            }
        }
    }

    private void GenerateRandomEmojis() {
        int maxNumberEmojis = _uiTextBlockGridRows * _uiTextBlockGridColumns;

        while (_randomEmojis.Count < maxNumberEmojis) {
            int randomIndex = _random.Next(0, _sourceEmojis.Length);
            string emoji = _sourceEmojis[randomIndex];

            if (_randomEmojis.Contains(emoji)) continue;

            _randomEmojis.AddRange(emoji, emoji);
        }
    }

    private void GenerateTextBlocksEmojis() {
        for (int row = 0; row < _uiTextBlockGridRows; row++) {
            for (int col = 0; col < _uiTextBlockGridColumns; col++) {
                if (_randomEmojis.Count == 0) return;

                int randomIndex = _random.Next(0, _randomEmojis.Count);
                string emoji = _randomEmojis[randomIndex];

                _randomEmojis.RemoveAt(randomIndex);
                _textBlocksEmojis[row, col] = emoji;
            }
        }
    }

    private void SetTextBlocksStartValues() {
        foreach (Border border in _uiGrid.Children.OfType<Border>()) {
            var textBlock = border.Child as TextBlock;

            if (textBlock == null) return;

            textBlock.Text = "?";
            textBlock.IsEnabled = true;
        }
    }

    public void SetUpGame() {
        SetTextBlocksStartValues();
        GenerateRandomEmojis();
        GenerateTextBlocksEmojis();
    }

    private void CheckGuess(object? sender, PointerPressedEventArgs e) {
        var textBlock = sender as TextBlock;

        if (textBlock == null) return;

        Match match = FindLastTwoDigitsRegex().Match(textBlock.Name ?? "");

        if (!match.Success) return;

        bool isRowValid = int.TryParse(match.ValueSpan[0].ToString(), out int row);
        bool isColumnValid = int.TryParse(match.ValueSpan[1].ToString(), out int column);

        if (!(isRowValid && row < _uiTextBlockGridRows)) return;
        if (!(isColumnValid && column < _uiTextBlockGridColumns)) return;

        textBlock.Text = _textBlocksEmojis[row, column];

        if (!_findMatch) {
            _uiLastTextBlockClicked = textBlock;
            _findMatch = true;
            return;
        }

        if (_uiLastTextBlockClicked == null) return;

        if (_uiLastTextBlockClicked.Name == textBlock.Name) return;

        if (_uiLastTextBlockClicked.Text == textBlock.Text) {
            _findMatch = false;
            _uiLastTextBlockClicked.IsEnabled = false;
            textBlock.IsEnabled = false;
            return;
        }

        Dispatcher.UIThread.Post(() => {
            Thread.Sleep(500);
            textBlock.Text = "?";
            _uiLastTextBlockClicked.Text = "?";
            _findMatch = false;
        });
    }
}