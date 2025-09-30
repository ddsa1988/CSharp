namespace Examples.Refactoring.Models;

public static class ComicAnalyzer {
    private static PriceRange CalculatePriceRange(Comic comic, IReadOnlyDictionary<int, decimal> prices) {
        prices.TryGetValue(comic.Issue, out decimal value);
        return value < 100 ? PriceRange.Cheap : PriceRange.Expensive;
    }

    public static IEnumerable<IGrouping<PriceRange, Comic>> GroupComicsByPrice(IEnumerable<Comic> comics,
        IReadOnlyDictionary<int, decimal> prices) {
        // IEnumerable<IGrouping<PriceRange, Comic>> grouped =
        //     from comic in comics
        //     orderby prices[comic.Issue] descending
        //     group comic by CalculatePriceRange(comic, prices)
        //     into priceGroup
        //     select priceGroup;

        IEnumerable<IGrouping<PriceRange, Comic>> grouped = comics
            .OrderByDescending(comic => prices[comic.Issue])
            .GroupBy(comic => CalculatePriceRange(comic, prices));

        return grouped;
    }

    public static IEnumerable<string> GetReviews(IEnumerable<Comic> comics, IEnumerable<Review> reviews) {
        // IEnumerable<string> joined =
        //     from comic in comics
        //     orderby comic.Issue
        //     join review in reviews on comic.Issue equals review.Issue
        //     select $"{review.Critic} rated #{comic.Issue} '{comic.Name}' {review.Score:0.00}";

        IEnumerable<string> joined = comics
            .OrderBy(comic => comic.Issue)
            .Join(reviews, comic => comic.Issue, review => review.Issue,
                (comic, review) => $"{review.Critic} rated #{comic.Issue} '{comic.Name}' {review.Score:0.00}");

        return joined;
    }
}