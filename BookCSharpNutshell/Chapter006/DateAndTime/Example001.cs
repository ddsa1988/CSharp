namespace Chapter006.DateAndTime;

public static class Example001 {
    public static void Run() {
        // TimeSpan represents an interval of time—or a time of the day

        var sp1 = new TimeSpan(10, 12, 25, 45, 158, 410);
        var sp2 = new TimeSpan(1837430);

        Console.WriteLine("Time span => " + sp1);
        Console.WriteLine("Time span => " + sp2);
        Console.WriteLine("Milliseconds => " + sp2.Milliseconds);
        Console.WriteLine("Microseconds => " + sp2.Microseconds);
    }
}