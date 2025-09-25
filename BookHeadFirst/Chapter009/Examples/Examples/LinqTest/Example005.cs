using Examples.LinqTest.Models;

namespace Examples.LinqTest;

public static class Example005 {
    public static void Run() {
        IEnumerable<string> mostExpensiveDescription =
            from comic in Comic.Catalog
            where Comic.Prices[comic.Issue] > 500
            orderby Comic.Prices[comic.Issue] descending
            select $"{comic} is worth {Comic.Prices[comic.Issue]:c}";

        foreach (string description in mostExpensiveDescription) {
            Console.WriteLine(description);
        }
    }
}