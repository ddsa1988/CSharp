using System;
using System.Collections.Generic;
using System.Linq;
using Avalonia.Controls;

namespace MatchGame.Models;

public static class Game {
    private const int NumberEmojis = 16;

    private static readonly string[] SourceEmojis =
        ["🐦", "🐥", "🐌", "🦂", "🦊", "🐯", "🐻", "🐠", "🐼", "🐞", "🦖", "🦋", "🦈", "🐉", "🦜", "🐫"];

    private static readonly List<string> Emojis = [];

    public static void SetUpGame(Grid grid) {
        var random = new Random();

        while (Emojis.Count < NumberEmojis) {
            int randomIndex = random.Next(0, SourceEmojis.Length);
            string emoji = SourceEmojis[randomIndex];

            if (Emojis.Contains(emoji)) continue;

            Emojis.AddRange(emoji, emoji);
        }

        foreach (TextBlock textBlock in grid.Children.OfType<TextBlock>()) {
            int randomIndex = random.Next(0, Emojis.Count);
            string emoji = Emojis[randomIndex];
            textBlock.Text = emoji;
            // textBlock.Opacity = 0;
            Emojis.RemoveAt(randomIndex);
        }
    }
}