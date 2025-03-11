namespace PickRandomCards.Models;

public static class CardPicker {
    public static string[] PickSomeCards(int numberOfCards) {
        ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(numberOfCards, 0, nameof(numberOfCards));

        string[] cards = new string[numberOfCards];

        for (int i = 0; i < numberOfCards; i++) {
            cards[i] = RandomValue() + " of " + RandomSuit();
        }

        return cards;
    }

    public static string RandomValue() {
        string[] values = ["Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"];
        int index = new Random().Next(0, values.Length);
        
        return values[index];
    }

    public static string RandomSuit() {
        string[] suits = ["Diamonds", "Spades", "Hearts", "Clubs"];

        int index = new Random().Next(0, suits.Length);
        
        return suits[index];
    }
}