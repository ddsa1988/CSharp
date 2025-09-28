namespace ComicAnalyzerTests.Models;

public static class ComicAnalyzer {
    private static PriceRange CalculatePriceRange(Comic comic, IReadOnlyDictionary<int, decimal> prices) {
        prices.TryGetValue(comic.Issue, out decimal value);
        return value < 100 ? PriceRange.Cheap : PriceRange.Expensive;
    }

    public static IEnumerable<IGrouping<PriceRange, Comic>> GroupComicsByPrice(IEnumerable<Comic> catalog,
        IReadOnlyDictionary<int, decimal> prices) {
        IEnumerable<IGrouping<PriceRange, Comic>> grouped =
            from comic in catalog
            orderby prices[comic.Issue] descending
            group comic by CalculatePriceRange(comic, prices)
            into priceGroup
            select priceGroup;

        return grouped;
    }

    public static IEnumerable<string> GetReviews(IEnumerable<Comic> catalog, IEnumerable<Review> reviews) {
        IEnumerable<string> joined =
            from comic in catalog
            orderby comic.Issue
            join review in reviews on comic.Issue equals review.Issue
            select $"{review.Critic} rated #{comic.Issue} '{comic.Name}' {review.Score:0.00}";

        return joined;
    }
}