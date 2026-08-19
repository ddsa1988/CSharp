namespace UsingArrays.Examples;

internal static class ArrayInitialization {
    internal static void Run() {
        Console.WriteLine("=>  Array initialization:\n");

        string[] stringArray = new string[] { "one", "two", "three" };
        bool[] boolArray = { false, true, false };
        int[] intArray = new int[4] { 20, 22, 23, 0 };
        float[] floatArray = [10, 12, 13.5f, 36.7f, -10.75f];


        Console.WriteLine($"String array has {stringArray.Length} elements.");
        Console.WriteLine($"Bool array has {boolArray.Length} elements.");
        Console.WriteLine($"Int array has {intArray.Length} elements.");
        Console.WriteLine($"Float array has {floatArray.Length} elements.");
    }
}