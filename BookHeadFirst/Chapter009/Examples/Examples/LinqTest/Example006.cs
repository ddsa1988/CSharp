namespace Examples.LinqTest;

public static class Example006 {
    public static void Run() {
        int[] originalNumbers = [36, 5, 91, 3, 41, 69, 8];

        IEnumerable<int> n1 =
            from number in originalNumbers
            where (number != 36 && number < 50)
            orderby number descending
            select number + 5;

        IEnumerable<int> values1 = n1.ToList();

        Console.WriteLine(string.Join(", ", values1));

        IEnumerable<int> n2 = values1.Take(3);

        IEnumerable<int> values2 = n2.ToList();

        Console.WriteLine(string.Join(", ", values2));

        IEnumerable<int> n3 =
            from number in values2
            select number - 1;

        IEnumerable<int> values3 = n3.ToList();

        Console.WriteLine(string.Join(", ", values3));
        Console.WriteLine(values3.Sum());
    }
}