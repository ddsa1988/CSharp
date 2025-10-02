using System.Collections.ObjectModel;

namespace GoFish.Models;

public class Deck : ObservableCollection<Card> {
    private const int RanksMinValue = 1;
    private const int RanksMaxValue = 13;
    private const int SuitsMinValue = 0;
    private const int SuitsMaxValue = 3;
    private readonly Random _random;

    public Deck(Random random) {
        _random = random;
        Reset();
    }

    public void Reset() {
        Clear();

        for (int rank = RanksMinValue; rank <= RanksMaxValue; rank++) {
            for (int suit = SuitsMinValue; suit <= SuitsMaxValue; suit++) {
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