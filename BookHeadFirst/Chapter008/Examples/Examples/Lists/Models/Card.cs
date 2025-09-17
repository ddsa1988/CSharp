namespace Examples.Lists.Models;

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

public class Card {
    public readonly Suits Suit;
    public readonly Ranks Rank;

    public Card(Ranks rank, Suits suits) {
        Rank = rank;
        Suit = suits;
    }

    public string Name => $"{Rank} of {Suit}";
}