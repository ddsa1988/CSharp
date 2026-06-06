namespace Card.Models;

public class Card {
    private readonly Values _value;
    private readonly Suits _suit;

    public Card(Values value, Suits suit) {
        _value = value;
        _suit = suit;
    }

    public override string ToString() {
        return $"{_value} of {_suit}";
    }
}