namespace Chapter002.Arrays;

public static class Example003 {
    public static void Run() {
        // Indices let you refer to elements relative to the end of an array, with the ^ operator.
        // ^1 refers to the last element, ^2 refers to the second-to-last element, and so on

        char[] vowels = ['a', 'e', 'i', 'o', 'u'];

        Console.WriteLine(vowels[0]);
        Console.WriteLine(vowels[^1]);

        Console.WriteLine(vowels[1]);
        Console.WriteLine(vowels[^2]);

        Index first = 0;
        Index last = ^1;

        Console.WriteLine(vowels[first]);
        Console.WriteLine(vowels[last]);
    }
}