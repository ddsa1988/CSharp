namespace Examples.Models;

public class Deck : List<Card> {
    private static Random _random = new();

    public Deck() {
        Reset();
    }

    public void Reset() {
        throw new NotImplementedException();
    }

    public Card Deal(int index) {
        throw new NotImplementedException();
    }

    public Deck Shuffle() {
        throw new NotImplementedException();
    }
}