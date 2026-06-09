namespace Dictionaries.Examples;

public static class CountLetters {
    public static void Run() {
        const string content = "This a text to be used as a sample";

        var letters = new Dictionary<char, int>();

        foreach (char letter in content) {
            if (letter == ' ') continue;

            if (letters.ContainsKey(letter)) {
                letters[letter]++;
                continue;
            }

            letters.Add(letter, 1);
            // letters[letter] = 1;
        }

        foreach (KeyValuePair<char, int> letter in letters) {
            Console.WriteLine($"{letter.Key} -> {letter.Value}");
        }
    }
}