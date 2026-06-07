namespace Card.Models;

public class Card {
    public Values Value { get; init; }
    public Suits Suit { get; init; }

    public Card(Values value, Suits suit) {
        Value = value;
        Suit = suit;
    }

    public string Name => $"{Value} of {Suit}";

    public override string ToString() {
        return $"{Value} of {Suit}";
    }
}