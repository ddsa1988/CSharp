namespace ObjectOrientedProgramming.Models.Deck;

internal class Card {
    public Values Value { get; init; }
    public Suits Suit { get; init; }

    public Card(Values value, Suits suit) {
        Value = value;
        Suit = suit;
    }

    public override int GetHashCode() {
        return HashCode.Combine((int)Value, (int)Suit);
    }

    public override bool Equals(object? obj) {
        if (obj == null) return false;
        if (ReferenceEquals(this, obj)) return true;

        return obj is Card other && ToString().Equals(other.ToString());
    }

    public override string ToString() {
        return Value + " of " + Suit;
    }
}