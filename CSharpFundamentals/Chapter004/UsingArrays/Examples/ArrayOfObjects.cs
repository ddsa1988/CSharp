namespace UsingArrays.Examples;

internal static class ArrayOfObjects {
    internal static void Run() {
        Console.WriteLine("=> Array of objects:\n");

        object[] myObjects = [10, false, new DateOnly(1988, 1, 22), "Form & Void"];

        foreach (object obj in myObjects) {
            Console.WriteLine($"Type: {obj.GetType()}, Value: {obj}");
        }
    }
}