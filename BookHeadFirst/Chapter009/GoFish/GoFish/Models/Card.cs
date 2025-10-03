namespace GoFish.Models;

public enum Suits {
    Diamonds,
    Spades,
    Hearts,
    Clubs,
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
        string[] facedCards = [nameof(Values.Ace), nameof(Values.Jack), nameof(Values.Queen), nameof(Values.King)];
        string rankString = facedCards.Contains(Value.ToString()) ? Value.ToString() : ((int)Value).ToString();

        return $"{rankString} of {Suit}";
    }
}