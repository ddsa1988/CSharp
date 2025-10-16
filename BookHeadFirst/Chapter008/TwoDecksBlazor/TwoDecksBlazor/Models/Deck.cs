namespace TwoDecksBlazor.Models;

public class Deck : List<Card> {
    private readonly Random _random = new();

    public Deck() {
        Reset();
    }

    public void Reset() {
        Clear();

        for (int rank = 1; rank <= 14; rank++) {
            for (int suit = 1; suit < 5; suit++) {
                var card = new Card((Ranks)rank, (Suits)suit);
                Add(card);
            }
        }
    }

    public Deck Shuffle() {
        var copy = new List<Card>(this);
        Clear();

        while (copy.Count > 0) {
            int index = _random.Next(0, copy.Count);
            Card card = copy[index];
            copy.RemoveAt(index);
            Add(card);
        }

        return this;
    }

    public Card Deal(int index) {
        if (index < 0 || index >= Count) {
            throw new IndexOutOfRangeException();
        }

        Card card = base[index];
        RemoveAt(index);
        return card;
    }
}