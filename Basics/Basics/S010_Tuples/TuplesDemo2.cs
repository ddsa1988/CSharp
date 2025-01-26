namespace Basics.S010_Tuples;

public static class TuplesDemo2 {
    public static void UserMain() {
        (string name, int age, float weight) values = ("Diego", 32, 80.6F);

        Console.WriteLine("Tuple values: " + values);
        Console.WriteLine("Values types: " + values.GetType());
        Console.WriteLine("First item: " + values.name);
        Console.WriteLine("Second item: " + values.age);
        Console.WriteLine("Third item: " + values.weight);
    }
}