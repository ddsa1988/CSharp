using ObjectOrientedProgramming.Models.Deck;

namespace ObjectOrientedProgramming.Examples;

internal static class Example001 {
    public static void Run() {
        List<Card> cards = [];

        for (int i = 0; i < 5; i++) {
            cards.Add(PickRandomCard());
        }

        Console.WriteLine(string.Join(", ", cards));
        Console.WriteLine();

        cards.Sort(new CardComparerByValue());

        Console.WriteLine(string.Join(", ", cards));
    }

    private static Card PickRandomCard() {
        var value = (Values)Random.Shared.Next(1, 14);
        var suit = (Suits)Random.Shared.Next(1, 5);

        return new Card(value, suit);
    }
}