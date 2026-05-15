namespace StatementsAndLoops.Examples;

public static class WordOccurrence {
    public static void Run() {
        string[] words = ["Diego", "Amanda", "Eduarda", "Diego", "Diego", "Amanda"];
        var countWordOccurrence = new Dictionary<string, int>();

        foreach (string word in words) {
            string wordFormatted = word.Trim();

            if (countWordOccurrence.TryGetValue(wordFormatted, out int value)) {
                countWordOccurrence[word] = ++value;
            }
            else {
                countWordOccurrence.Add(wordFormatted, 1);
            }
        }

        foreach ((string word, int occurrence) in countWordOccurrence) {
            string s = occurrence > 1 ? "s" : "";

            Console.WriteLine($"The word '{word}' is occuring in the dictionary {occurrence} time{s}.");
        }

        // foreach (KeyValuePair<string, int> kvp in countWordOccurrence) {
        //     string word = kvp.Key;
        //     int occurrence = kvp.Value;
        //
        //     string s = occurrence > 1 ? "s" : "";
        //
        //     Console.WriteLine($"The word '{word}' is occuring in the dictionary {occurrence} time{s}.");
        // }
    }
}