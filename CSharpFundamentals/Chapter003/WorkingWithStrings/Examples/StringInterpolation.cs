namespace WorkingWithStrings.Examples;

internal static class StringInterpolation {
    internal static void Run() {
        const string name = "Soren";
        const int age = 4;

        Console.WriteLine("=> String interpolation:\n");

        // Using curly-bracket syntax
        string greeting1 = string.Format("Hello {0} you are {1} years old.", name, age);
        Console.WriteLine(greeting1);

        // Using string interpolation
        string greeting2 = $"Hello {name} you are {age} years old.";
        Console.WriteLine(greeting2);
    }
}