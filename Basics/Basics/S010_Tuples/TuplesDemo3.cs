namespace Basics.S010_Tuples;

public static class TuplesDemo3 {
    public static void UserMain() {
        var values = (name: "Diego", age: 32, weight: 80.6F);

        Console.WriteLine("Tuple values: " + values);
        Console.WriteLine("Values types: " + values.GetType());
        Console.WriteLine("First item: " + values.name);
        Console.WriteLine("Second item: " + values.age);
        Console.WriteLine("Third item: " + values.weight);
    }
}