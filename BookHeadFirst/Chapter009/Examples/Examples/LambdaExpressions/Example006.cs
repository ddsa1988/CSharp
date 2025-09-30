using Examples.LinqTest.Models;

namespace Examples.LambdaExpressions;

public static class Example006 {
    public static void Run() {
        var deck = new Deck();

        IEnumerable<string> processedCards = deck
            .Take(3)
            .Concat(deck.TakeLast(3))
            .OrderByDescending(card => card)
            .Select(card => card.Rank switch {
                Ranks.King => Output(card.Suit, 7),
                Ranks.Ace => $"It's an ace! {card.Suit}",
                Ranks.Jack => Output(card.Suit - 1, 9),
                Ranks.Two => Output(card.Suit, 18),
                _ => card.ToString(),
            });

        foreach (string output in processedCards) {
            Console.WriteLine(output);
        }
    }

    private static string Output(Suits suit, int number) => $"Suit is {suit} and number is {number}";
}