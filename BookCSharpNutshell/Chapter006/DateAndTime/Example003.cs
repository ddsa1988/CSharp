namespace Chapter006.DateAndTime;

public static class Example003 {
    public static void Run() {
        // DateTimeOffset

        var date1 = new DateTimeOffset(1988, 1, 22, 10, 38, 45, TimeSpan.Zero);
        var date2 = new DateTimeOffset(1988, 1, 22, 10, 38, 45, TimeSpan.FromHours(7.5));

        Console.WriteLine("{0} => {1}", nameof(date1), date1);
        Console.WriteLine("{0} => {1}", nameof(date2), date2);
    }
}