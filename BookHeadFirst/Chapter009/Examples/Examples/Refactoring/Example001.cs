using Examples.Refactoring.Models;

namespace Examples.Refactoring;

public static class Example001 {
    public static void Run() {
        bool done = false;

        while (!done) {
            Console.WriteLine("Press 'G' to group comics by price, 'R' to get review, any other key to quit: ");

            done = Console.ReadKey(true).KeyChar.ToString().ToUpper() switch {
                "G" => GroupComicByPrice(),
                "R" => GetReviews(),
                _ => true
            };

            Console.WriteLine();
        }
    }

    private static bool GroupComicByPrice() {
        IEnumerable<IGrouping<PriceRange, Comic>> groups =
            ComicAnalyzer.GroupComicsByPrice(Comic.Catalog, Comic.Prices);

        foreach (IGrouping<PriceRange, Comic> group in groups) {
            Console.WriteLine($"\n{group.Key} comics: ");
            foreach (Comic comic in group) {
                Console.WriteLine($"#{comic.Issue} {comic.Name}: {Comic.Prices[comic.Issue]:c}");
            }
        }

        return false;
    }

    private static bool GetReviews() {
        IEnumerable<string> reviews = ComicAnalyzer.GetReviews(Comic.Catalog, Comic.Reviews);

        Console.WriteLine($"\nComics reviews:");

        foreach (string review in reviews) {
            Console.WriteLine(review);
        }

        return false;
    }
}