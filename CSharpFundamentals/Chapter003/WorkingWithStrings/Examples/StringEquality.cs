namespace WorkingWithStrings.Examples;

internal static class StringEquality {
    internal static void Run() {
        const string s1 = "hello";
        const string s2 = "Hello";

        Console.WriteLine("=> String Comparison:\n");

        Console.WriteLine("{0} == {1}: {2}", s1, s2, s1 == s2);
        Console.WriteLine("{0}.ToLower() == {1}.ToLower(): {2}", s1, s2, s1.ToLower() == s2.ToLower());

        Console.WriteLine();

        Console.WriteLine("{0}.Equals({1}): {2}", s1, s2, s1.Equals(s2));
        Console.WriteLine("{0}.ToLower().Equals({1}.ToLower()): {2}", s1, s2, s1.ToLower().Equals(s2.ToLower()));

        Console.WriteLine();

        Console.WriteLine("{0}.Equals({1}, StringComparison.InvariantCultureIgnoreCase): {2}", s1, s2,
            s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase));

        Console.WriteLine("{0}.Equals({1}, CurrentCultureIgnoreCase): {2}", s1, s2,
            s1.Equals(s2, StringComparison.CurrentCultureIgnoreCase));

        Console.WriteLine("{0}.Equals({1}, StringComparison.OrdinalIgnoreCase): {2}", s1, s2,
            s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
    }
}