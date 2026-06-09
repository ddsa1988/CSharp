using SortingCards.Models;

namespace SortingCards;

public static class Program {
    public static void Main(string[] args) {
        var deck = new Deck();

        deck.PrintCards();
        Console.WriteLine();

        deck.ShuffleCards();
        deck.PrintCards();
        Console.WriteLine();

        deck.SortCards();
        deck.PrintCards();
    }
}