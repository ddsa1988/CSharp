using Examples.LinqTest.Models;

namespace Examples.LinqTest;

public static class Example010 {
    public static void Run() {
        bool done = false;

        while (!done) {
            Console.WriteLine("Press 'G' to group comics by price, 'R' to get review, any other key to quit: ");

            switch (Console.ReadKey(true).KeyChar.ToString().ToUpper()) {
                case "G":
                    done = GroupComicByPrice();
                    break;
                case "R":
                    done = GetReviews();
                    break;
                default:
                    done = true;
                    break;
            }

            Console.WriteLine();
        }
    }

    private static bool GroupComicByPrice() {
        IEnumerable<IGrouping<PriceRange, Comic>> groups =
            ComicAnalyzer.GroupComicsByPrice(Comic.Catalog, Comic.Prices);

        foreach (IGrouping<PriceRange, Comic> group in groups) {
            Console.WriteLine($"{group.Key} comics: ");
            foreach (Comic comic in group) {
                Console.WriteLine($"#{comic.Issue} {comic.Name}: {Comic.Prices[comic.Issue]:c}");
            }

            Console.WriteLine();
        }

        return false;
    }

    private static bool GetReviews() {
        IEnumerable<string> reviews = ComicAnalyzer.GetReviews(Comic.Catalog, Comic.Reviews);

        foreach (string review in reviews) {
            Console.WriteLine(review);
        }

        Console.WriteLine();

        return false;
    }
}