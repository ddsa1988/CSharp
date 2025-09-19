using System;
using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Interactivity;
using TwoDecks.Models;

namespace TwoDecks;

public partial class MainWindow : Window {
    private List<Card> _leftDeck;
    private List<Card> _rightDeck;

    public MainWindow() {
        InitializeComponent();
        _leftDeck = CreateDeck();
        _rightDeck = [];
        UpdateLeftDeckListBox(_leftDeck);
    }

    private static List<Card> CreateDeck() {
        const int ranksMinValue = 1;
        const int ranksMaxValue = 14;
        const int suitsMinValue = 0;
        const int suitsMaxValue = 4;

        var deck = new List<Card>();

        for (int i = ranksMinValue; i < ranksMaxValue; i++) {
            for (int j = suitsMinValue; j < suitsMaxValue; j++) {
                var card = new Card((Ranks)i, (Suits)j);
                deck.Add(card);
            }
        }

        return deck;
    }

    private void UpdateLeftDeckListBox(IEnumerable<Card> deck) {
        LeftDeckListBox.ItemsSource = deck;
    }

    private void UpdateRightDeckListBox(IEnumerable<Card> deck) {
        RightDeckListBox.ItemsSource = deck;
    }

    private void LeftDeckListBoxSelectionChanged(object? sender, SelectionChangedEventArgs e) {
        string? card = LeftDeckListBox.SelectedItem?.ToString();

        Console.WriteLine(card);
    }

    private void LeftDeckClickShuffle(object? sender, RoutedEventArgs e) {
        var shuffledDeck = new List<Card>();
        var random = new Random();

        while (_leftDeck.Count > 0) {
            int index = random.Next(_leftDeck.Count);
            shuffledDeck.Add(_leftDeck[index]);
            _leftDeck.RemoveAt(index);
        }

        _leftDeck = shuffledDeck;

        UpdateLeftDeckListBox(_leftDeck);
    }

    private void LeftDeckClickReset(object? sender, RoutedEventArgs e) {
        _leftDeck = CreateDeck();
        UpdateLeftDeckListBox(_leftDeck);
    }

    private void RightDeckClickClear(object? sender, RoutedEventArgs e) {
        _rightDeck = [];
        UpdateRightDeckListBox(_rightDeck);
    }

    private void RightDeckClickSort(object? sender, RoutedEventArgs e) {
        _rightDeck.Sort(new CardComparer());
        UpdateRightDeckListBox(_rightDeck);
    }
}