namespace WorkingWithStrings.Examples;

internal static class StringConcatenation {
    internal static void Run() {
        const string firstName = "Diego";
        const string lastName = "Alexander";
        const string fullName1 = firstName + " " + lastName;
        string fullName2 = string.Concat(firstName, " ", lastName);

        Console.WriteLine("=> String Concatenation");

        Console.WriteLine(fullName1);
        Console.WriteLine(fullName2);
    }
}