namespace Examples.LinqTest;

public static class Example011 {
    public static void Run() {
        List<int> numbers = [35, 44, 200, 84, 3987, 4, 199, 329, 446, 208];

        IEnumerable<IGrouping<string, int>> grouped =
            from number in numbers
            group number by number % 2 == 0 ? "even" : "odd"
            into numbersGrouped
            select numbersGrouped;

        foreach (IGrouping<string, int> group in grouped) {
            Console.WriteLine($"{group.Key}: {string.Join(", ", group)}");
        }
    }
}