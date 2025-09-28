using ComicAnalyzerTests.Models;

namespace ComicAnalyzerTests;

[TestClass]
public class LinqUnitTests {
    private readonly IEnumerable<Comic> _testComics = [
        new() { Name = "Issue 1", Issue = 1 },
        new() { Name = "Issue 2", Issue = 2 },
        new() { Name = "Issue 3", Issue = 3, }
    ];

    [TestMethod]
    public void ComicAnalyzer_Should_Group_Comics() {
        var testPrices = new Dictionary<int, decimal>() {
            { 1, 20M },
            { 2, 10M },
            { 3, 1000M },
        };

        IEnumerable<IGrouping<PriceRange, Comic>> groups = ComicAnalyzer.GroupComicsByPrice(_testComics, testPrices)
            .ToList();

        Assert.AreEqual(2, groups.Count());
        Assert.AreEqual(PriceRange.Expensive, groups.First().Key);
        Assert.AreEqual(3, groups.First().First().Issue);
        Assert.AreEqual("Issue 3", groups.First().First().Name);
    }

    [TestMethod]
    public void ComicAnalyzer_Should_Handle_Weird_Review_Scores() {
        IEnumerable<Review> testReviews = [
            new() { Issue = 1, Critic = Critics.MuddyCritic, Score = -12.1212 },
            new() { Issue = 1, Critic = Critics.RottenTornadoes, Score = 391691234.48931 },
            new() { Issue = 2, Critic = Critics.RottenTornadoes, Score = 0 },
            new() { Issue = 2, Critic = Critics.MuddyCritic, Score = 40.3 },
            new() { Issue = 2, Critic = Critics.MuddyCritic, Score = 40.3 },
            new() { Issue = 2, Critic = Critics.MuddyCritic, Score = 40.3 },
            new() { Issue = 2, Critic = Critics.MuddyCritic, Score = 40.3 }
        ];

        string[] expectedResults = [
            "MuddyCritic rated #1 'Issue 1' -12.12",
            "RottenTornadoes rated #1 'Issue 1' 391691234.49",
            "RottenTornadoes rated #2 'Issue 2' 0.00",
            "MuddyCritic rated #2 'Issue 2' 40.30",
            "MuddyCritic rated #2 'Issue 2' 40.30",
            "MuddyCritic rated #2 'Issue 2' 40.30",
            "MuddyCritic rated #2 'Issue 2' 40.30"
        ];

        string[] actualResults = ComicAnalyzer.GetReviews(_testComics, testReviews).ToArray();
        CollectionAssert.AreEqual(expectedResults, actualResults);
    }
}