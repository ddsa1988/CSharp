namespace BasicDataTypes.Examples;

internal static class ParseValuesFromString {
    internal static void Run() {
        ParseFromStrings();
        Console.WriteLine();

        ParseFromStringWithTryParse();
    }

    private static void ParseFromStrings() {
        Console.WriteLine("=> Data type parsing:\n");

        bool myBool = bool.Parse("true");
        Console.WriteLine($"Value of myBool: {myBool}");

        double myDouble = double.Parse("99.884");
        Console.WriteLine($"Value of myDouble: {myDouble}");

        int myInt = int.Parse("8");
        Console.WriteLine($"Value of myInt: {myInt}");

        char myChar = char.Parse("A");
        Console.WriteLine($"Value of myChar: {myChar}");
    }

    private static void ParseFromStringWithTryParse() {
        const string myString = "Hello World!";

        Console.WriteLine(double.TryParse(myString, out double result)
            ? $"Value of result: {result}"
            : $"Failed to convert the input ({myString}) to a double and the variable assigned the default {result}.");
    }
}