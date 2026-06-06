using Card.Models;

namespace Card.Examples;

public static class UsingDeckClass {
    public static void Run() {
        var deck = new Deck();

        deck.PrintCards();
    }
}