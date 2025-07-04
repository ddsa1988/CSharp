using System.Globalization;

namespace Chapter006.Strings;

public static class Example010 {
    public static void Run() {
        // String equality comparison

        {
            const string text1 = "This is a text.";
            const string text2 = "This is a text.";

            Console.WriteLine(text1 == text2);
            Console.WriteLine(ReferenceEquals(text1, text2));
        }

        Console.WriteLine();

        {
            const string text1 = "This is a text.";
            string text2 = new string("This is a text.");

            Console.WriteLine(text1 == text2);
            Console.WriteLine(ReferenceEquals(text1, text2));
        }

        Console.WriteLine();

        {
            const string text1 = "This is a text.";
            const string text2 = "THIS is a text.";

            Console.WriteLine(string.Equals(text1, text2, StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine(ReferenceEquals(text1, text2));
        }
    }
}