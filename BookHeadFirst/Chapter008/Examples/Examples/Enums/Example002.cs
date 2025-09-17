using Examples.Enums.Models;

namespace Examples.Enums;

public static class Example002 {
    private static readonly Random Random = new Random();

    public static void Run() {
        for (int i = 0; i < 5; i++) {
            var card = new Card((Ranks)Random.Next(1, 14), (Suits)Random.Next(4));
            Console.WriteLine(card.Name);
        }
    }
}