namespace Examples.LinqTest;

public static class Example002 {
    public static void Run() {
        Console.WriteLine(Enumerable.Range(1, 5).Sum()); // 15
        Console.WriteLine(Enumerable.Range(1, 6).Average()); // 3.5
        Console.WriteLine(new int[] { 3, 7, 9, 1, 10, 2, -3 }.Min()); // -3
        Console.WriteLine(new int[] { 3, 7, 9, 1, 10, 2, -3 }.Max()); // 10
        Console.WriteLine(Enumerable.Range(10, 3721).Count()); // 3712
        Console.WriteLine(Enumerable.Range(5, 100).Last()); // 104
        Console.WriteLine(new List<int> { 3, 8, 7, 6, 8, 6, 2 }.Skip(4).Sum()); // 16
        Console.WriteLine(Enumerable.Range(10, 731).Reverse().Last()); // 10
    }
}