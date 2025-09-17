namespace Examples.Lists.Models;

public class CardComparer : IComparer<Card> {
    public int Compare(Card? x, Card? y) {
        if (x == null || y == null) return 0;

        if (x.Rank > y.Rank) return 1;

        if (x.Rank < y.Rank) return -1;

        if (x.Suit > y.Suit) return 1;

        if (x.Suit < y.Suit) return -1;

        return 0;
    }
}