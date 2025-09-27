using Examples.LinqTest.Models;

namespace Examples.LinqTest;

public static class Example009 {
    public static void Run() {
        IEnumerable<Card> deck = new Deck().Shuffle().Take(16);

        IOrderedEnumerable<IGrouping<Suits, Card>> grouped =
            from card in deck
            group card by card.Suit
            into suitGrouṕ
            orderby suitGrouṕ.Key descending
            select suitGrouṕ;

        foreach (IGrouping<Suits, Card> group in grouped) {
            Console.WriteLine($"""
                               Group: {group.Key}
                               Count: {group.Count()}
                               Minimum: {group.Min()}
                               Maximum: {group.Max()}            

                               """);
        }
    }
}