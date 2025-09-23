using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using TwoDecks.Models;

namespace TwoDecks;

public partial class MainWindow : Window {
    private const string LeftDeckName = "LeftDeck";
    private const string RightDeckName = "RightDeck";

    public MainWindow() {
        InitializeComponent();

        if (Resources[RightDeckName] is not Deck rightDeck) return;
        rightDeck.Clear();
    }

    private void MoveCard(bool leftToRight) {
        if (Resources[RightDeckName] is not Deck rightDeck || Resources[LeftDeckName] is not Deck leftDeck) return;

        if (leftToRight) {
            if (LeftDeckListBox.SelectedItem is not Card card) return;
            leftDeck.Remove(card);
            rightDeck.Add(card);
        } else {
            if (RightDeckListBox.SelectedItem is not Card card) return;
            rightDeck.Remove(card);
            leftDeck.Add(card);
        }
    }

    private void LeftDeckListBox_DoubleTapped(object? sender, TappedEventArgs e) {
        MoveCard(true);
    }

    private void RightDeckListBox_DoubleTapped(object? sender, TappedEventArgs e) {
        MoveCard(false);
    }

    private void LeftDeckListBox_KeyDown(object? sender, KeyEventArgs e) {
        if (e.Key != Key.Enter) return;
        MoveCard(true);
    }

    private void RightDeckListBox_KeyDown(object? sender, KeyEventArgs e) {
        if (e.Key != Key.Enter) return;
        MoveCard(false);
    }

    private void LeftDeckShuffle_Click(object? sender, RoutedEventArgs e) {
        if (Resources[LeftDeckName] is not Deck leftDeck) return;
        leftDeck.Shuffle();
    }

    private void LeftDeckReset_Click(object? sender, RoutedEventArgs e) {
        if (Resources[LeftDeckName] is not Deck leftDeck) return;
        leftDeck.Reset();
    }

    private void RightDeckClear_Click(object? sender, RoutedEventArgs e) {
        if (Resources[RightDeckName] is not Deck rightDeck) return;
        rightDeck.Clear();
    }

    private void RightDeckSort_Click(object? sender, RoutedEventArgs e) {
        if (Resources[RightDeckName] is not Deck rightDeck) return;
        rightDeck.Sort();
    }
}