using System;

namespace TwoDecks.Models;

public class Card {
    public Values Value { get; init; }
    public Suits Suit { get; init; }

    public Card(Values value, Suits suit) {
        Value = value;
        Suit = suit;
    }

    public override int GetHashCode() {
        return HashCode.Combine((int)Value, (int)Suit);
    }

    public bool Equals(Card? other) {
        if (ReferenceEquals(null, other)) return false;

        if (ReferenceEquals(this, other)) return true;

        return Value == other.Value && Suit == other.Suit;
    }

    public override string ToString() {
        return $"{Value} of {Suit}";
    }
}