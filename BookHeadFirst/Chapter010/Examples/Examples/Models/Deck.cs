using System.Collections.ObjectModel;

namespace Examples.Models;

public class Deck : Collection<Card> {
    private const int MinValueRanks = 1;
    private const int MaxValueRanks = 13;
    private const int MinValueSuits = 1;
    private const int MaxValueSuits = 4;
    private static readonly Random Random = new();

    public Deck() {
        Reset();
    }

    public Deck(string fileName) {
        if (ReadCards(fileName)) {
            return;
        }

        Reset();
    }

    public void Reset() {
        Clear();

        for (int rank = MinValueRanks; rank <= MaxValueRanks; rank++) {
            for (int suit = MinValueSuits; suit <= MaxValueSuits; suit++) {
                var card = new Card((Ranks)rank, (Suits)suit);
                Add(card);
            }
        }
    }

    public Card Deal(int index) {
        if (index < 0 || index >= Count) {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        Card card = base[index];
        RemoveAt(index);

        return card;
    }

    public Deck Shuffle() {
        var copy = new List<Card>(this);
        Clear();

        while (copy.Count > 0) {
            int index = Random.Next(0, copy.Count);
            Card card = copy[index];
            copy.RemoveAt(index);
            Add(card);
        }

        return this;
    }

    public Deck Sort() {
        var copy = new List<Card>(this);
        Clear();

        copy.Sort(new CardComparer());

        while (copy.Count > 0) {
            const int index = 0;
            Add(copy[index]);
            copy.RemoveAt(index);
        }

        return this;
    }

    public bool WriteCards(string fileName) {
        string directoryName = Path.GetDirectoryName(fileName) ?? string.Empty;

        if (!Directory.Exists(directoryName)) return false;

        if (!File.Exists(fileName)) {
            File.Delete(fileName);
        }

        using var writer = new StreamWriter(fileName);
        foreach (Card card in this) {
            writer.WriteLine(card.ToString());
        }

        return true;
    }

    private bool ReadCards(string fileName) {
        string directoryName = Path.GetDirectoryName(fileName) ?? string.Empty;

        if (!Directory.Exists(directoryName)) return false;
        if (!File.Exists(fileName)) return false;

        Clear();

        using var reader = new StreamReader(fileName);

        while (!reader.EndOfStream) {
            const int cardNameSplitSize = 3;
            const int cardRankIndex = 0;
            const int cardSuitIndex = 2;

            string? line = reader.ReadLine();
            if (line == null) continue;

            string[] values = line.Split(' ');

            if (values.Length < cardNameSplitSize) continue;

            string strRank = values[cardRankIndex];
            string strSuit = values[cardSuitIndex];

            if (!Enum.TryParse(strRank, out Ranks rank)) continue;
            if (!Enum.TryParse(strSuit, out Suits suit)) continue;

            var card = new Card(rank, suit);
            Add(card);
        }

        return true;
    }
}