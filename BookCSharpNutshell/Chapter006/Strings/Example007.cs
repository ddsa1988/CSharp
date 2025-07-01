namespace Chapter006.Strings;

public static class Example007 {
    public static void Run() {
        // Splitting and joining strings

        const string text = """
                            This is a text, with some words.
                            Here, we have some more word.
                            However, we can have more words. 
                            """;


        string[] words = text.Split(',');

        foreach (string word in words) Console.WriteLine(word.Trim());
    }
}