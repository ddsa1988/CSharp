namespace UsingArrays.Examples;

internal static class SimpleArrayCreation {
    internal static void Run() {
        Console.WriteLine("=> Simple Array Creation:\n");

        int[] myInts = new int[5];
        string[] myStrings = new string[5];

        Console.WriteLine("Array of ints: Default value of each index.");

        foreach (int value in myInts) {
            Console.Write(value + " ");
        }

        Console.WriteLine("\n");

        Console.WriteLine("Array of strings: Default value of each index.");

        foreach (string value in myStrings) {
            Console.Write(value == null ? "null " : value + " ");
        }

        Console.WriteLine("\n");

        myInts[0] = 5;
        myInts[1] = 10;
        myInts[2] = 20;
        myInts[3] = 30;
        myInts[4] = 40;

        foreach (int value in myInts) {
            Console.Write(value + " ");
        }

        Console.WriteLine("\n");

        myStrings[0] = "Hello";
        myStrings[1] = "House";
        myStrings[2] = "Welcome";
        myStrings[3] = "Book";
        myStrings[4] = "Car";

        foreach (string value in myStrings) {
            Console.Write(value + " ");
        }
    }
}