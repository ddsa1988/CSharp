namespace WorkingWithStrings.Examples;

internal static class EscapeCharacters {
    internal static void Run() {
        Console.WriteLine("=> Escape characters:\n");

        Console.WriteLine("Model\tColor\tSpeed\tPet Name");
        Console.WriteLine("Everyone loves \"Hello World\" ");
        Console.WriteLine("C:\\MyApp\\bin\\Debug");
        Console.WriteLine("All finished.\n\n\n");
        Console.WriteLine("All finished.{0}{0}{0}", Environment.NewLine);
        Console.WriteLine("End.");
    }
}