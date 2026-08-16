namespace BasicDataTypes.Examples;

internal static class DateTimeAndTimeSpan {
    internal static void Run() {
        UseDateAndTimes();
        Console.WriteLine();

        Console.WriteLine("My age: {0}", GetAge(new DateTime(1988, 1, 22)));
    }

    private static void UseDateAndTimes() {
        Console.WriteLine("=> Dates and Times:\n");

        var dt = new DateTime(2015, 10, 17);

        Console.WriteLine($"The day of {dt.Date} is {dt.DayOfWeek}");
        Console.WriteLine($"Add two months: {dt.AddMonths(2)}");
        Console.WriteLine($"Daylight savings: {dt.IsDaylightSavingTime()}");
        Console.WriteLine();

        var ts = new TimeSpan(4, 30, 0);
        Console.WriteLine(ts);
        Console.WriteLine($"Subtract 15 minutes from the current TimeSpan: {ts.Subtract(new TimeSpan(0, 15, 0))}");
        Console.WriteLine();

        var dateOnly = new DateOnly(1988, 1, 22);
        var timeOnly = new TimeOnly(23, 37, 15);
        Console.WriteLine($"Date only: {dateOnly}");
        Console.WriteLine($"Time only: {timeOnly}");
    }

    private static int GetAge(DateTime birthdate) {
        DateTime now = DateTime.Now;

        int age = now.Subtract(birthdate).Days / 365;

        return age >= 0 ? age : 0;
    }
}