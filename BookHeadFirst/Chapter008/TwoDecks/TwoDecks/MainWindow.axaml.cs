using Avalonia.Controls;
using Avalonia.Interactivity;
using TwoDecks.Models;

namespace TwoDecks;

public partial class MainWindow : Window {
    private readonly Deck? _leftDeck;
    private readonly Deck? _rightDeck;

    public MainWindow() {
        InitializeComponent();

        _leftDeck = Resources["LeftDeck"] as Deck;
        _rightDeck = Resources["RightDeck"] as Deck;
    }

    private void MoveCard(bool leftToRight) {
        if (_leftDeck == null || _rightDeck == null) return;

        if (ListBoxLeftDeck == null || ListBoxRightDeck == null) return;

        if (leftToRight) {
            if (ListBoxLeftDeck.SelectedItem is not Card card) return;

            _leftDeck.Remove(card);
            _rightDeck.Add(card);
        }
        else {
            if (ListBoxRightDeck.SelectedItem is not Card card) return;

            _rightDeck.Remove(card);
            _leftDeck.Add(card);
        }
    }

    private void Button_Shuffle(object? sender, RoutedEventArgs e) {
        throw new System.NotImplementedException();
    }

    private void Button_Reset(object? sender, RoutedEventArgs e) {
        throw new System.NotImplementedException();
    }

    private void Button_Clear(object? sender, RoutedEventArgs e) {
        throw new System.NotImplementedException();
    }

    private void Button_Sort(object? sender, RoutedEventArgs e) {
        throw new System.NotImplementedException();
    }
}