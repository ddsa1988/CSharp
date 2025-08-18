namespace PickRandomCards.Models;

public static class CardPicker {
    private static readonly Random Random = new Random();

    public static IEnumerable<string> GetRandomCards(int numberOfCards) {
        string[] randomCards = new string[numberOfCards];

        for (int i = 0; i < numberOfCards; i++) {
            string value = GetRandomValue();
            string suit = GetRandomSuit();
            randomCards[i] = value + " of " + suit;
        }

        return randomCards;
    }

    private static string GetRandomValue() {
        string[] values = ["Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"];
        int index = Random.Next(0, values.Length);

        return values[index];
    }

    private static string GetRandomSuit() {
        string[] suits = ["Diamonds", "Spades", "Hearts", "Clubs"];
        int index = Random.Next(suits.Length);

        return suits[index];
    }
}