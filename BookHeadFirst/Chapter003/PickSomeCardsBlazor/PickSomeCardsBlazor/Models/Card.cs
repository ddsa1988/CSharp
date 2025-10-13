namespace PickSomeCardsBlazor.Models;

public class Card {
    public Ranks Rank { get; init; }
    public Suits Suit { get; init; }

    public Card() { }

    public Card(Ranks rank, Suits suit) {
        Rank = rank;
        Suit = suit;
    }

    public override string ToString() => $"{Rank} of {Suit}";
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

public enum Suits {
    Clubs = 1,
    Diamonds = 2,
    Hearts = 3,
    Spades = 4,
}