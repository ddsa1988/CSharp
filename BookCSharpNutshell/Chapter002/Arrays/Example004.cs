namespace Chapter002.Arrays;

public static class Example004 {
    public static void UserMain() {
        // Ranges let you “slice” an array by using the .. operator

        char[] vowels = ['a', 'e', 'i', 'o', 'u'];

        char[] firstTwo = vowels[..2];
        char[] lastThree = vowels[2..];
        char[] middleOne = vowels[2..3];

        Console.WriteLine(string.Join(" ", firstTwo));
        Console.WriteLine(string.Join(" ", lastThree));
        Console.WriteLine(string.Join(" ", middleOne));
    }
}