namespace Basics.S010_Tuples;

public static class TuplesDemo1 {
    public static void UserMain() {
        var values = ("Diego", 32, 80.6F);

        Console.WriteLine("Tuple values: " + values);
        Console.WriteLine("Values types: " + values.GetType());
        Console.WriteLine("First item: " + values.Item1);
        Console.WriteLine("Second item: " + values.Item2);
        Console.WriteLine("Third item: " + values.Item3);
    }
}