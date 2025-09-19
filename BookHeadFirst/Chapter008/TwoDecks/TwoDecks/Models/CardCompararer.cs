using System.Collections.Generic;

namespace TwoDecks.Models;

public class CardComparer : IComparer<Card> {
    public int Compare(Card? x, Card? y) {
        if (x == null || y == null) return 0;
        if (x.Rank > y.Rank) return 1;
        if (x.Rank < y.Rank) return -1;
        if (x.Suits > y.Suits) return 1;
        if (x.Suits < y.Suits) return -1;
        return 0;
    }
}