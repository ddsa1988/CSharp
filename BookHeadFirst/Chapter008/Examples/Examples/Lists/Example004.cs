using Examples.Lists.Models;

namespace Examples.Lists;

public static class Example004 {
    public static void Run() {
        var random = new Random();
        var cards = new List<Card>();
        var cardComparer = new CardComparer();

        for (int i = 0; i < 10; i++) {
            var card = new Card((Ranks)random.Next(1, 14), (Suits)random.Next(4));
            cards.Add(card);
        }

        Console.WriteLine("Cards before sorting:");
        PrintCards(cards);

        cards.Sort(cardComparer);

        Console.WriteLine("\nCards after sorting:");
        PrintCards(cards);
    }

    private static void PrintCards(IEnumerable<Card> cards) {
        foreach (Card card in cards) {
            Console.WriteLine(card.Name);
        }
    }
}