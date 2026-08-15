namespace BasicDataTypes.Examples;

internal static class CharTypeFunctionality {
    internal static void Run() {
        const char myChar = 'a';
        const char myOtherChar = '?';
        const string myString = "Hello World!";

        Console.WriteLine("=> char type Functionality:\n");

        Console.WriteLine($"char.IsDigit({myChar}): {char.IsDigit(myChar)}");
        Console.WriteLine($"char.IsLetter({myChar}): {char.IsLetter(myChar)}");
        Console.WriteLine($"char.IsWhiteSpace({myString}, 5): {char.IsWhiteSpace(myString, 5)}");
        Console.WriteLine($"char.IsWhiteSpace({myString}, 6): {char.IsWhiteSpace(myString, 6)}");
        Console.WriteLine($"char.IsPunctuation({myOtherChar}): {char.IsPunctuation(myOtherChar)}");
    }
}