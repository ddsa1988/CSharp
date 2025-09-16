namespace Examples.Enums.Models;

public enum Suits {
    Diamond,
    Club,
    Heart,
    Spade
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
    private readonly Suits _suit;
    private readonly Values _value;

    public Card(Values value, Suits suits) {
        _value = value;
        _suit = suits;
    }

    public string Name => $"{_value} of {_suit}";
}