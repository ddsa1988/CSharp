using Examples.Models;

namespace Examples.FileStreams;

public static class Example009 {
    public static void Run() {
        const string folderName = "Files";
        const string fileName = "DeckOfCards.txt";
        string directoryPath = AppContext.BaseDirectory + folderName;
        string filePath = Path.Combine(directoryPath, fileName);

        var deck1 = new Deck();

        deck1.Shuffle();
        deck1.WriteCards(filePath);

        var deck2 = new Deck(filePath);

        foreach (Card card in deck2) {
            Console.WriteLine(card);
        }
    }
}