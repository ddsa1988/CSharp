namespace Basics.S011_ObjectOrientedProgramming.Models;

public static class TimeUtilClass {
    public static void PrintTime() {
        Console.WriteLine("Actual time: " + DateTime.Now.ToShortTimeString());
    }

    public static void PrintDate() {
        Console.WriteLine("Actual date: " + DateTime.Now.ToShortDateString());
    }

    public static int GetAge(DateTime birthday) {
        const int daysPerYear = 365;

        DateTime now = DateTime.Now;
        TimeSpan elapsed = now.Subtract(birthday);

        ArgumentOutOfRangeException.ThrowIfLessThan(elapsed.TotalDays, 0, nameof(birthday));

        int age = (int)(elapsed.TotalDays / daysPerYear);

        return age;
    }
}