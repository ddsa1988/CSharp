namespace UsingArrays.Examples;

internal static class ArrayAsReturnValues {
    internal static void Run() {
        string[] strings = GeStringArray();

        foreach (string str in strings) {
            Console.Write(str + " ");
        }
    }

    private static string[] GeStringArray() {
        return ["Hello", "from", "GetStringArray"];
    }
}