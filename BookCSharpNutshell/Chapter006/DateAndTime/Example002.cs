namespace Chapter006.DateAndTime;

public static class Example002 {
    public static void Run() {
        // DateTime

        var date1 = new DateTime(1988, 1, 22);
        var date2 = new DateTime(1988, 1, 22, 13, 38, 45);
        DateTime date3 = DateTime.Parse("1988-1-22 13:38:45");

        Console.WriteLine("{0} => {1}", nameof(date1), date1);
        Console.WriteLine("{0} => {1}", nameof(date2), date2);
        Console.WriteLine("{0} => {1}", nameof(date3), date3);
    }
}