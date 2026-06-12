using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TwoDecks.Models;

public class Deck : ObservableCollection<Card> {
    private static readonly Random Random = new();

    public Deck() {
        Reset();
    }

    public void Reset() {
        Clear();

        for (int value = 1; value < 14; value++) {
            for (int suit = 0; suit < 4; suit++) {
                var card = new Card((Values)value, (Suits)suit);
                Add(card);
            }
        }
    }

    public Card? Deal(int index) {
        if (index < 0 || index >= Count) return null;

        Card card = base[index];

        RemoveAt(index);

        return card;
    }

    public void Shuffle() {
        var cards = new List<Card>(this);
        Clear();

        while (cards.Count != 0) {
            int randomIndex = Random.Next(cards.Count);

            Add(cards[randomIndex]);
            cards.RemoveAt(randomIndex);
        }
    }

    public void Sort() {
        var cardsSorted = new List<Card>(this);

        cardsSorted.Sort(new CardComparer());

        Clear();

        foreach (Card card in cardsSorted) {
            Add(card);
        }
    }
}