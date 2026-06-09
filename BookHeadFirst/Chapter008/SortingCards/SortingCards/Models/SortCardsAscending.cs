namespace SortingCards.Models;

public class SortCardsAscending : IComparer<Card> {
    public int Compare(Card? x, Card? y) {
        if (ReferenceEquals(x, y)) return 0;

        if (x is null) return -1;

        if (y is null) return 1;

        if (x.Value > y.Value) return 1;

        if (x.Value < y.Value) return -1;

        if (x.Suit > y.Suit) return 1;

        if (x.Suit < y.Suit) return -1;

        return 0;
    }
}