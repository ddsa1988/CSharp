namespace GoFishBlazor.Models;

public enum Suits {
    Diamonds,
    Clubs,
    Hearts,
    Spades,
}

public enum Values {
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
    public Suits Suit { get; }
    public Values Value { get; }

    public Card(Values value, Suits suit) {
        Value = value;
        Suit = suit;
    }

    public override string ToString() {
        return $"{Value} of {Suit}";
    }
}