using Card.Models;

namespace Card.Examples;

public static class UsingCardClass {
    public static void Run() {
        var random = new Random();

        var value = (Values)random.Next(1, 14);
        var suit = (Suits)random.Next(4);
        var card = new Models.Card(value, suit);

        Console.WriteLine(card);
        Console.WriteLine(card.Value);
        Console.WriteLine(card.Suit);
    }
}