namespace Chapter004.Patterns;

public static class Example003 {
    public static void Run() {
        // Pattern Combinators

        const int min = 80;
        const int max = 120;

        object obj = 100;
        object vowel = 'a';

        bool isBetween = obj is >= min and <= max;
        bool isVowel = vowel is 'a' or 'e' or 'i' or 'o' or 'u';

        if (isBetween) {
            Console.WriteLine("{0} >= {1} and <= {2} => {3}", obj, min, max, isBetween);
        }

        if (isVowel) {
            Console.WriteLine("'{0}' is vowel => {1}", vowel, isVowel);
        }
    }
}