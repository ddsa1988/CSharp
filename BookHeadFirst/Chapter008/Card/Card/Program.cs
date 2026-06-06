using Card.Models;

namespace Card;

public static class Program {
    public static void Main(string[] args) {
        var card = new Models.Card(Values.Ace, Suits.Clubs);

        Console.WriteLine(card);
    }
}