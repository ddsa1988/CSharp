using Avalonia.Controls;
using Avalonia.Input;
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

        _rightDeck?.Clear();
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
        _leftDeck?.Shuffle();
    }

    private void Button_Reset(object? sender, RoutedEventArgs e) {
        _leftDeck?.Reset();
    }

    private void Button_Clear(object? sender, RoutedEventArgs e) {
        _rightDeck?.Clear();
    }

    private void Button_Sort(object? sender, RoutedEventArgs e) {
        _rightDeck?.Sort();
    }

    private void ListBoxLeftDeck_DoubleTapped(object? sender, TappedEventArgs e) {
        MoveCard(true);
    }

    private void ListBoxLeftDeck_KeyDown(object? sender, KeyEventArgs e) {
        if (e.Key != Key.Enter) return;

        MoveCard(true);
    }

    private void ListBoxRightDeck_DoubleTapped(object? sender, TappedEventArgs e) {
        MoveCard(false);
    }

    private void ListBoxRightDeck_KeyDown(object? sender, KeyEventArgs e) {
        if (e.Key != Key.Enter) return;

        MoveCard(false);
    }
}