namespace Chapter006.Strings;

public static class Example009 {
    public static void Run() {
        // Comparing Strings: Ordinal versus culture comparison

        {
            // The ordinal algorithm puts all the uppercase characters first, and then all
            // lowercase characters (A...Z, a...z). This is essentially a throwback to the ASCII.

            string[] words = ["Atom", "atom", "Zamia"];
            Array.Sort(words, StringComparer.Ordinal);
            Console.WriteLine(string.Join(", ", words));
        }

        Console.WriteLine();

        {
            // Invariant culture encapsulates an alphabet, which considers uppercase
            // characters adjacent to their lowercase counterparts (aAbBcCdD...). 

            string[] words = ["Atom", "atom", "Zamia"];
            Array.Sort(words, StringComparer.InvariantCulture);
            Console.WriteLine(string.Join(", ", words));
        }
    }
}