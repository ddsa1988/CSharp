using System.Diagnostics;
using Examples.LinqTest.Models;

namespace Examples.LambdaExpressions;

public static class Example005 {
    public static void Run() {
        var deck = new Deck();

        foreach (Card card in deck) {
            int score = card.Suit switch {
                Suits.Diamonds => (int)Suits.Diamonds,
                Suits.Spades => (int)Suits.Spades,
                Suits.Hearts => (int)Suits.Hearts,
                Suits.Clubs => (int)Suits.Clubs,
                _ => throw new ArgumentOutOfRangeException()
            };

            Console.WriteLine($"{card.Suit} score: {score}");
        }
    }
}