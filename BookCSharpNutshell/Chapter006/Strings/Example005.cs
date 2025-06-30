namespace Chapter006.Strings;

public static class Example005 {
    public static void Run() {
        // Searching within strings

        const string text = "This is a text used as example.";

        Console.WriteLine("The text end with '.' => " + text.EndsWith('.'));
        Console.WriteLine("The text start with 'This' => " +
                          text.StartsWith("this", StringComparison.InvariantCultureIgnoreCase));
        Console.WriteLine("The char 'a' was found at index " + text.IndexOf('a') + ".");

        int index = -1;

        while (true) {
            const string word = "is";

            index = text.IndexOf(word, index + 1, StringComparison.InvariantCultureIgnoreCase);

            if (index == -1) break;

            Console.WriteLine("The word '{0}' was found at index {1}.", word, index);
        }

        Console.WriteLine(text.IndexOfAny(['a', 'b', 'c', ' ']));
    }
}