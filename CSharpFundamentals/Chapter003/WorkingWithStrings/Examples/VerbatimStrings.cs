namespace WorkingWithStrings.Examples;

internal static class VerbatimStrings {
    internal static void Run() {
        const string myLongString = @"This is a very
            very
                    very
                            long string!";

        Console.WriteLine(@"C:\MyApp\bin\Debug");
        Console.WriteLine(@" ""Hello World!"" ");
        Console.WriteLine(myLongString);
    }
}