namespace GoFish.Models;

public class Player {
    private readonly List<Card> _hand = new List<Card>();
    private readonly List<Values> _books = new List<Values>();
    public static Random Random = new Random();

    /// <summary>
    /// The cards in the player's hand
    /// </summary>
    public IEnumerable<Card> Hand => _hand;

    /// <summary>
    /// The books that the player has pulled out
    /// </summary>
    public IEnumerable<Values> Books => _books;

    public readonly string Name;

    /// <summary>
    /// Pluralize a word, adding 's' if a value isn't equal to 1
    /// </summary>
    public static string S(int s) => s == 1 ? "" : "s";

    /// <summary>
    /// Returns the current status of the player: the number of cards and books
    /// </summary>
    public string Status =>
        $"{Name} has {Hand.Count()} card{S(Hand.Count())} and {Books.Count()} book{S(Books.Count())}";

    /// <summary>
    /// Constructor to create a player
    /// </summary>
    /// <param name="name">Player's name</param>
    public Player(string name) {
        Name = name;
    }

    /// <summary>
    /// Alternate constructor
    /// </summary>
    /// <param name="name">Player's name</param>
    /// <param name="cards">Initial set of cards</param>
    public Player(string name, IEnumerable<Card> cards) {
        Name = name;
        _hand.AddRange(cards);
    }

    /// <summary>
    /// Gets up to five cars from the stock
    /// </summary>
    /// <param name="stock">Stock to get the next hand from</param>
    public void GetNextHand(Deck stock) {
        const int numberOfCards = 5;
        int length = stock.Count < numberOfCards ? stock.Count : numberOfCards;

        _hand.Clear();

        for (int i = 0; i < length; i++) {
            Card card = stock.Deal(0);
            _hand.Add(card);
        }
    }

    /// <summary>
    /// If I have any cards that match the value, return them. If I run out of cards, get
    /// the next hand from the deck.
    /// </summary>
    /// <param name="value">Value I'm asked for</param>
    /// <param name="deck">Deck to draw my next hand from</param>
    /// <returns>The cards that were pulled out of the other player's hand</returns>
    public IEnumerable<Card> DoYouHaveAny(Values value, Deck deck) {
        List<Card> cards = _hand.Where(card => card.Value == value).ToList();
        _hand.RemoveAll(card => card.Value == value);

        if (_hand.Count == 0) {
            GetNextHand(deck);
        }

        return cards;
    }

    /// <summary>
    /// When the player receives cards from another player, adds them to the hand
    /// and pulls out any matching books
    /// </summary>
    /// <param name="cards">Cards from the other player to add</param>
    public void AddCardAndPullOutBooks(IEnumerable<Card> cards) {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Draws a card from the stock and add it to the player's hand
    /// </summary>
    /// <param name="stock">Stock to draw a card from</param>
    public void DrawCard(Deck stock) {
        if (stock.Count <= 0) return;

        Card card = stock.Deal(0);
        _hand.Add(card);
    }

    /// <summary>
    /// Gets a random value from the player's hand
    /// </summary>
    /// <returns>The value of a randomly selected card in the player's hand</returns>
    public Values RandomValueFromHand() {
        int index = Random.Next(0, _hand.Count);
        Card card = _hand[index];
        return card.Value;
    }

    public override string ToString() => Name;
}