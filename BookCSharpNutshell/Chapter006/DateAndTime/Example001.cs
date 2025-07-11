namespace Chapter006.DateAndTime;

public static class Example001 {
    public static void Run() {
        // TimeSpan represents an interval of time—or a time of the day

        var sp1 = new TimeSpan(10, 12, 25, 45, 158, 410);
        var sp2 = new TimeSpan(1837430); // Each tick => 100ns

        Console.WriteLine("{0} => {1}", nameof(sp1), sp1);
        Console.WriteLine("{0} => {1}", nameof(sp2), sp2);
        Console.WriteLine("{0} => {1} milliseconds", nameof(sp2), sp2.Milliseconds);
        Console.WriteLine("{0} => {1} microseconds", nameof(sp2), sp2.Microseconds);

        TimeSpan days = TimeSpan.FromDays(6);
        TimeSpan hours = TimeSpan.FromHours(2.45);

        Console.WriteLine("{0} => {1}", nameof(days), days);
        Console.WriteLine("{0} => {1}", nameof(hours), hours);

        TimeSpan timeOfDay = DateTime.Now.TimeOfDay;
        Console.WriteLine("{0} => {1}", nameof(timeOfDay), timeOfDay);
    }
}