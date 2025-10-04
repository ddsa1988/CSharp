using System.Collections.ObjectModel;

namespace GoFish.Models;

public class Deck : ObservableCollection<Card> {
    private const int MinValue = 1;
    private const int MaxValue = 13;
    private const int MinSuit = 0;
    private const int MaxSuit = 3;
    private readonly Random _random = Player.Random;

    public Deck() {
        Reset();
    }

    public void Reset() {
        Clear();

        for (int value = MinValue; value <= MaxValue; value++) {
            for (int suit = MinSuit; suit <= MaxSuit; suit++) {
                var card = new Card((Values)value, (Suits)suit);
                Add(card);
            }
        }
    }

    public Card Deal(int index) {
        if (index < 0 || index >= Count) {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        Card card = base[index];
        RemoveAt(index);
        return card;
    }

    public Deck Shuffle() {
        var copy = new List<Card>(this);
        Clear();

        while (copy.Count > 0) {
            int index = _random.Next(copy.Count);
            Card card = copy[index];
            copy.RemoveAt(index);
            Add(card);
        }

        return this;
    }

    public void Sort() {
        var sortedCards = new List<Card>(this);
        sortedCards.Sort(new CardComparerByValue());
        Clear();

        foreach (Card card in sortedCards) {
            Add(card);
        }
    }
}