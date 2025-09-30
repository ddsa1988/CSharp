namespace Examples.Refactoring.Models;

public enum Suits {
    Diamonds,
    Spades,
    Hearts,
    Clubs,
}

public enum Ranks {
    Ace = 1,
    Two = 2,
    Three = 3,
    Four = 4,
    Five = 5,
    Six = 6,
    Seven = 7,
    Eight = 8,
    Nine = 9,
    Ten = 10,
    Jack = 11,
    Queen = 12,
    King = 13,
}

public class Card : IComparable<Card> {
    public Suits Suit { get; }
    public Ranks Rank { get; }

    public Card(Ranks rank, Suits suit) {
        Rank = rank;
        Suit = suit;
    }

    public int CompareTo(Card? other) => new CardComparerByValue().Compare(this, other);

    public override string ToString() {
        string[] facedCards = [nameof(Ranks.Ace), nameof(Ranks.Jack), nameof(Ranks.Queen), nameof(Ranks.King)];
        string rankString = facedCards.Contains(Rank.ToString()) ? Rank.ToString() : ((int)Rank).ToString();

        return $"{rankString} of {Suit}";
    }
}