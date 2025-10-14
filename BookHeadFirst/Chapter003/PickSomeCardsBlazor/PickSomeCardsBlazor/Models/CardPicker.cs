namespace PickSomeCardsBlazor.Models;

public static class CardPicker {
    private static readonly Random Random;

    static CardPicker() {
        Random = new Random();
    }

    public static IEnumerable<Card> GetRandomCards(int numberOfCards) {
        List<Card> cards = [];

        for (int i = 0; i < numberOfCards; i++) {
            Ranks rank = GetRandomRank();
            Suits suit = GetRandomSuit();
            var card = new Card(rank, suit);
            cards.Add(card);
        }

        return cards;
    }

    private static Ranks GetRandomRank() {
        int randomValue = Random.Next(1, 14);
        return (Ranks)randomValue;
    }

    private static Suits GetRandomSuit() {
        int randomValue = Random.Next(1, 5);
        return (Suits)randomValue;
    }
}