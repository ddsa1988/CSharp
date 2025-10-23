using Examples.Models;

namespace Examples.FileStreams;

public static class Example009 {
    public static void Run() {
        var deck = new Deck();
        Console.WriteLine(string.Join("\n", deck) + '\n');

        deck.Shuffle();
        Console.WriteLine(string.Join("\n", deck) + '\n');

        deck.Sort();
        Console.WriteLine(string.Join("\n", deck));
    }
}