namespace UsingTuples.Examples;

internal static class TupleEquality {
    internal static void Run() {
        (int, string, char) values1 = (10, "diego", 'a');
        (float, string, char) value2 = (10.0f, "diego", 'a');

        Console.WriteLine(values1 == value2);
    }
}