namespace UsingArrays.Examples;

internal static class ArrayAsArguments {
    internal static void Run() {
        int[] myInts = [20, 22, 23, 0];

        PrintArray(myInts);
        Console.WriteLine();

        ChangeArrayItems(myInts);
        PrintArray(myInts);
    }

    private static void PrintArray(int[] array) {
        for (int i = 0; i < array.Length; i++) {
            Console.WriteLine($"Item {i}: {array[i]}");
        }
    }

    private static void ChangeArrayItems(int[] array) {
        for (int i = 0; i < array.Length; i++) {
            array[i] += i + 10;
        }
    }
}