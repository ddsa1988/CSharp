namespace UsingArrays.Examples;

internal static class ArrayBaseClass {
    internal static void Run() {
        Console.WriteLine("=> Working with System.Array:\n");

        string[] gothicBands = ["Tones on Tail", "Bauhaus", "Sisters of Mercy"];

        Console.WriteLine("-> Here is the array: " + string.Join(", ", gothicBands));

        Array.Reverse(gothicBands);
        Console.WriteLine("-> The reversed array: " + string.Join(", ", gothicBands));

        Array.Clear(gothicBands, 1, 2);
        Console.WriteLine("->  Cleared out all but one: " + string.Join(", ", gothicBands));
    }
}