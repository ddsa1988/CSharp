namespace UsingArrays.Examples;

internal static class IndicesAndRanges {
    internal static void Run() {
        WorkingWithIndices();
    }

    private static void WorkingWithIndices() {
        Console.WriteLine(" => Working with  indices:\n");

        string[] gothicBands = ["Tones on Tail", "Bauhaus", "Sisters of Mercy"];

        for (int i = 0; i < gothicBands.Length; i++) {
            var idx = new Index(i);

            Console.Write(gothicBands[idx] + ", ");
        }

        Console.WriteLine("\n");

        for (int i = 1; i <= gothicBands.Length; i++) {
            Index idx = ^i;

            Console.Write(gothicBands[idx] + ", ");
        }
    }

    private static void WorkingWithRanges() {
        Console.WriteLine(" => Working with ranges:\n");
    }
}