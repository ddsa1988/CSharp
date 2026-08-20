namespace UsingArrays.Examples;

internal static class IndicesAndRanges {
    internal static void Run() {
        WorkingWithIndices();
        Console.WriteLine("\n");

        WorkingWithRanges();
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

        string[] gothicBands = ["Tones on Tail", "Bauhaus", "Sisters of Mercy"];

        Index idx1 = 0;
        Index idx2 = 2;

        Range r1 = 0..2;
        Range r2 = idx1..idx2;

        Console.WriteLine(string.Join(", ", gothicBands[0..2]));
        Console.WriteLine(string.Join(", ", gothicBands[r1]));
        Console.WriteLine(string.Join(", ", gothicBands[r2]));
    }
}