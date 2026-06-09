namespace SortingCards.Models;

public class Deck {
    private readonly Random _random = new();
    private readonly List<Card> _cards = [];

    public Deck() {
        CreateDeck();
    }

    private void CreateDeck() {
        for (int value = 1; value < 14; value++) {
            for (int suit = 0; suit < 4; suit++) {
                var card = new Card((Values)value, (Suits)suit);
                _cards.Add(card);
            }
        }
    }

    public void ShuffleCards() {
        List<Card> shuffledCards = [];

        while (_cards.Count > 0) {
            int randomIndex = _random.Next(0, _cards.Count);
            shuffledCards.Add(_cards[randomIndex]);
            _cards.RemoveAt(randomIndex);
        }

        _cards.AddRange(shuffledCards);
    }

    public void SortCards(bool descending = false) {
        if (descending) {
            _cards.Sort(new SortCardsDescending());
            return;
        }

        _cards.Sort(new SortCardsAscending());
    }

    public void PrintCards() {
        foreach (Card card in _cards) {
            Console.WriteLine(card);
        }
    }
}