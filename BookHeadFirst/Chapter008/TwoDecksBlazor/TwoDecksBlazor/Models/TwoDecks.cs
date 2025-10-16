namespace TwoDecksBlazor.Models;

public class TwoDecks {
    private readonly Deck _leftDeck = new Deck();
    private readonly Deck _rightDeck = new Deck();

    public TwoDecks() {
        Clear();
    }

    public int LeftDeckCount => _leftDeck.Count;
    public int RightDeckCount => _rightDeck.Count;

    public string LeftDeckCardName(int index) {
        if (index < 0 || index >= _leftDeck.Count) {
            return string.Empty;
        }

        return _leftDeck[index].ToString();
    }

    public string RightDeckCardName(int index) {
        if (index < 0 || index >= _rightDeck.Count) {
            return string.Empty;
        }

        return _rightDeck[index].ToString();
    }

    public void Shuffle() {
        _leftDeck.Shuffle();
    }

    public void Reset() {
        _leftDeck.Reset();
    }

    public void Clear() {
        _rightDeck.Clear();
    }

    public void Sort() {
        _rightDeck.Sort(new CardComparer());
    }

    public void MoveCard(int index, bool leftToRight) {
        if (leftToRight) {
            Card card = _leftDeck[index];
            _leftDeck.RemoveAt(index);
            _rightDeck.Add(card);
        } else {
            Card card = _rightDeck[index];
            _rightDeck.RemoveAt(index);
            _leftDeck.Add(card);
        }
    }
}