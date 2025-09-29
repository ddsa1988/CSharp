namespace Examples.LambdaExpressions;

public static class Example004 {
    public static void Run() {
        int[] numbers = [0, 12, 44, 36, 92, 54, 13, 8];

        // IEnumerable<IGrouping<string, int>> groups =
        //     from number in numbers
        //     orderby number
        //     group number by number < 40 ? "Low" : "High"
        //     into numberGroup
        //     select numberGroup;

        IEnumerable<IGrouping<string, int>> groups =
            numbers.OrderBy(number => number).GroupBy(number => number < 40 ? "Low" : "High");

        foreach (IGrouping<string, int> group in groups) {
            Console.WriteLine($"{group.Key}: {string.Join(", ", group.ToList())}");
        }
    }
}