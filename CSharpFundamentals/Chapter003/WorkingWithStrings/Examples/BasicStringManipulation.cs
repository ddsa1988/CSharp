namespace WorkingWithStrings.Examples;

internal static class BasicStringManipulation {
    internal static void Run() {
        const string firstName = "Freddy";

        Console.WriteLine("=> Basic String Functionality:\n");

        Console.WriteLine("Value of {0}: {1}", nameof(firstName), firstName);
        Console.WriteLine("{0} has {1} characters", nameof(firstName), firstName.Length);
        Console.WriteLine("{0} in uppercase: {1}", nameof(firstName), firstName.ToUpper());
        Console.WriteLine("{0} in lowercase: {1}", nameof(firstName), firstName.ToLower());
        Console.WriteLine("{0} contains the letter y?: {1}", nameof(firstName), firstName.Contains('y'));
        Console.WriteLine("New first name: {0}", firstName.Replace("dy", ""));
        Console.WriteLine("Old first name: {0}", firstName);
    }
}