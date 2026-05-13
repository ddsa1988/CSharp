using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Avalonia.Controls;

namespace MatchGame.Models;

public partial class Game {
    private readonly Grid _gridLayout;
    private readonly string[,] _gridEmojis;

    private readonly string[] _sourceEmojis =
        ["🐦", "🐥", "🐌", "🦂", "🦊", "🐯", "🐻", "🐠", "🐼", "🐞", "🦖", "🦋", "🦈", "🐉", "🦜", "🐫"];

    private readonly List<string> _selectedEmojis = [];

    public Game(Grid gridLayout) {
        _gridLayout = gridLayout;
        _gridEmojis = new string[_gridLayout.RowDefinitions.Count, _gridLayout.ColumnDefinitions.Count];
    }

    [GeneratedRegex(@"\d{2}$")]
    private static partial Regex FindLastTwoDigitsRegex();

    public void SetUpGame() {
        var random = new Random();
        int maxNumberEmojis = _gridLayout.RowDefinitions.Count * _gridLayout.ColumnDefinitions.Count;

        while (_selectedEmojis.Count < maxNumberEmojis) {
            int randomIndex = random.Next(0, _sourceEmojis.Length);
            string emoji = _sourceEmojis[randomIndex];

            if (_selectedEmojis.Contains(emoji)) continue;

            _selectedEmojis.AddRange(emoji, emoji);
        }

        foreach (TextBlock textBlock in _gridLayout.Children.OfType<TextBlock>()) {
            textBlock.Text = "?";
        }

        for (int row = 0; row < _gridLayout.RowDefinitions.Count; row++) {
            for (int col = 0; col < _gridLayout.ColumnDefinitions.Count; col++) {
                int randomIndex = random.Next(0, _selectedEmojis.Count);
                string emoji = _selectedEmojis[randomIndex];

                _selectedEmojis.RemoveAt(randomIndex);
                _gridEmojis[row, col] = emoji;
            }
        }
    }

    public void Test(TextBlock textBlock) {
        Match match = FindLastTwoDigitsRegex().Match(textBlock.Name ?? "");

        Console.WriteLine(match.Value);
    }
}