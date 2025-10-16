namespace TwoDecksBlazor.Models;

public class TwoDecks {
    public readonly Deck LeftDeck = new Deck();
    public readonly Deck RightDeck = new Deck();

    public TwoDecks() {
        Clear();
    }

    public void Shuffle() {
        LeftDeck.Shuffle();
    }

    public void Reset() {
        LeftDeck.Reset();
    }

    public void Clear() {
        RightDeck.Clear();
    }

    public void Sort() {
        RightDeck.Sort(new CardComparer());
    }

    public void MoveCard(int index, bool leftToRight) {
        if (leftToRight) {
            Card card = LeftDeck[index];
            LeftDeck.RemoveAt(index);
            RightDeck.Add(card);
        } else {
            Card card = RightDeck[index];
            RightDeck.RemoveAt(index);
            LeftDeck.Add(card);
        }
    }
}