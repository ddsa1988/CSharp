using Examples.LinqTest.Models;

namespace Examples.LinqTest;

public static class Example004 {
    public static void Run() {
        IEnumerable<Comic> mostExpensive =
            from comic in Comic.Catalog
            where Comic.Prices[comic.Issue] > 500
            orderby Comic.Prices[comic.Issue] descending
            select comic;

        Console.WriteLine("Most expensive:\n");

        foreach (Comic comic in mostExpensive) {
            Console.WriteLine($"{comic} is worth {Comic.Prices[comic.Issue]:C}");
        }
    }
}