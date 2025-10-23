using System.Collections.ObjectModel;

namespace Examples.Models;

public class Deck : Collection<Card> {
    private const int MinValueRanks = 1;
    private const int MaxValueRanks = 13;
    private const int MinValueSuits = 1;
    private const int MaxValueSuits = 4;
    private static readonly Random Random = new();

    public Deck() {
        Reset();
    }

    public void Reset() {
        Clear();

        for (int rank = MinValueRanks; rank <= MaxValueRanks; rank++) {
            for (int suit = MinValueSuits; suit <= MaxValueSuits; suit++) {
                var card = new Card((Ranks)rank, (Suits)suit);
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
            int index = Random.Next(0, copy.Count);
            Card card = copy[index];
            copy.RemoveAt(index);
            Add(card);
        }

        return this;
    }
}