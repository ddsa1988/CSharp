using GoFish.Models;

namespace GoFishTests;

[TestClass]
public class PlayerTests {
    [TestMethod]
    public void TestGetNextHand() {
        var player = new Player("Owen", new List<Card>());

        player.GetNextHand(new Deck());

        CollectionAssert.AreEqual(new Deck().Take(5).Select(card => card.ToString()).ToList(),
            player.Hand.Select(card => card.ToString()).ToList());
    }

    [TestMethod]
    public void TestDoYouHaveAny() {
        IEnumerable<Card> cards = new List<Card>() {
            new(Values.Jack, Suits.Spades),
            new(Values.Three, Suits.Clubs),
            new(Values.Three, Suits.Hearts),
            new(Values.Four, Suits.Diamonds),
            new(Values.Three, Suits.Diamonds),
            new(Values.Jack, Suits.Clubs),
        };

        var player = new Player("Owen", cards);

        List<string> threes = player.DoYouHaveAny(Values.Three, new Deck()).Select(card => card.ToString()).ToList();

        CollectionAssert.AreEqual(new List<string>() {
            "Three of Diamonds",
            "Three of Clubs",
            "Three of Hearts",
        }, threes);

        Assert.AreEqual(3, player.Hand.Count());

        List<string> jacks = player.DoYouHaveAny(Values.Jack, new Deck()).Select(card => card.ToString()).ToList();

        CollectionAssert.AreEqual(new List<string>() {
            "Jack of Clubs",
            "Jack of Spades",
        }, jacks);

        List<string> hand = player.Hand.Select(card => card.ToString()).ToList();

        CollectionAssert.AreEqual(new List<string>() {
            "Four of Diamonds",
        }, hand);

        Assert.AreEqual("Owen has 1 card and 0 books", player.Status);
    }

    [TestMethod]
    public void TestAddCardsAndPullOutBooks() {
        IEnumerable<Card> cards = new List<Card>() {
            new(Values.Jack, Suits.Spades),
            new(Values.Three, Suits.Clubs),
            new(Values.Jack, Suits.Hearts),
            new(Values.Three, Suits.Hearts),
            new(Values.Four, Suits.Diamonds),
            new(Values.Jack, Suits.Diamonds),
            new(Values.Jack, Suits.Clubs),
        };

        var player = new Player("Owen", cards);

        Assert.AreEqual(0, player.Books.Count());

        var cardsToAdd = new List<Card>() {
            new(Values.Three, Suits.Diamonds),
            new(Values.Three, Suits.Spades),
        };

        player.AddCardAndPullOutBooks(cardsToAdd);

        List<Values> books = player.Books.ToList();
        CollectionAssert.AreEqual(new List<Values>() { Values.Three, Values.Jack }, books);

        List<string> hand = player.Hand.Select(card => card.ToString()).ToList();
        CollectionAssert.AreEqual(new List<string>() { "Four of Diamonds" }, hand);

        Assert.AreEqual("Owen has 1 card and 2 books", player.Status);
    }

    [TestMethod]
    public void TestDrawCard() {
        var player = new Player("Owen", new List<Card>());
        player.DrawCard(new Deck());

        Assert.AreEqual(1, player.Books.Count());
        Assert.AreEqual("Ace of Diamonds", player.Hand.First().ToString());
    }

    [TestMethod]
    public void TestRandomValueFromHand() {
        var player = new Player("Owen", new Deck());

        Player.Random = new MockRandom() { ValueToReturn = 0 };
        Assert.AreEqual("Ace", player.RandomValueFromHand().ToString());

        Player.Random = new MockRandom() { ValueToReturn = 4 };
        Assert.AreEqual("Two", player.RandomValueFromHand().ToString());

        Player.Random = new MockRandom() { ValueToReturn = 8 };
        Assert.AreEqual("Three", player.RandomValueFromHand().ToString());
    }
}

/// <summary>
/// Mock Random for testing that always returns a specific value
/// </summary>
public class MockRandom : Random {
    public int ValueToReturn { get; set; } = 0;
    public override int Next() => ValueToReturn;
    public override int Next(int maxValue) => ValueToReturn;
    public override int Next(int minValue, int maxValue) => ValueToReturn;
}