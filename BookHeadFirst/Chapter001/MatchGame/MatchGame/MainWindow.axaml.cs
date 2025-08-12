using System;
using System.Collections.Generic;
using System.Linq;
using Avalonia.Controls;

namespace MatchGame;

public partial class MainWindow : Window {
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
}