using Examples.Enums.Models;

namespace Examples.Lists;

public static class Example001 {
    public static void Run() {
        const int numberOfSuits = 4;
        const int numberOfRanks = 14;
        var cards = new List<Card>();

        for (int i = 1; i < numberOfRanks; i++) {
            for (int j = 0; j < numberOfSuits; j++) {
                var rank = (Ranks)i;
                var suit = (Suits)j;
                var card = new Card(rank, suit);
                cards.Add(card);
            }
        }

        Console.WriteLine("Deck of cards:\n");

        foreach (Card card in cards) {
            Console.WriteLine(card.Name);
        }
    }
}