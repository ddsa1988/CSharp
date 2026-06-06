namespace Card.Models;

public class Deck {
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

    public void PrintCards() {
        foreach (Card card in _cards) {
            Console.WriteLine(card);
        }
    }
}