namespace Examples.Enums.Models;

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
    private readonly Suits _suit;
    private readonly Ranks _rank;

    public Card(Ranks rank, Suits suits) {
        _rank = rank;
        _suit = suits;
    }

    public string Name => $"{_rank} of {_suit}";
}