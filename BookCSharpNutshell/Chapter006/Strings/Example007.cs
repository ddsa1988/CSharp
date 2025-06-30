namespace Chapter006.Strings;

public static class Example007 {
    public static void Run() {
        // Splitting and joining strings

        const string text = "This is a text, you can write more.";

        string[] words = text.Split(',');

        Console.WriteLine(words[0]);
    }
}