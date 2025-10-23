namespace Examples.Models;

public class CardComparer : IComparer<Card> {
    public int Compare(Card? x, Card? y) {
        if (ReferenceEquals(x, y)) return 0;
        if (y is null) return 1;
        if (x is null) return -1;
        int rankComparison = x.Rank.CompareTo(y.Rank);
        return rankComparison != 0 ? rankComparison : x.Suit.CompareTo(y.Suit);
    }
}