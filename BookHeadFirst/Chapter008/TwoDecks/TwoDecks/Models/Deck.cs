using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TwoDecks.Models;

public class Deck : ObservableCollection<Card> {
    private static readonly Random Random = new();
    private readonly List<Card> _cards = [];

    public Deck() {
        Reset();
    }

    public void Reset() {
        _cards.Clear();

        for (int value = 1; value < 14; value++) {
            for (int suit = 0; suit < 4; suit++) {
                var card = new Card((Values)value, (Suits)suit);
                _cards.Add(card);
            }
        }
    }

    public Card? Deal(int index) {
        if (index < 0 || index >= _cards.Count) return null;

        Card card = _cards[index];

        _cards.RemoveAt(index);

        return card;
    }

    public void Shuffle() {
        var randomCards = new List<Card>();

        while (_cards.Count != 0) {
            int randomIndex = Random.Next(_cards.Count);

            randomCards.Add(_cards[randomIndex]);
            _cards.RemoveAt(randomIndex);
        }

        _cards.AddRange(randomCards);
    }

    public void Sort() {
        _cards.Sort(new CardComparer());
    }
}