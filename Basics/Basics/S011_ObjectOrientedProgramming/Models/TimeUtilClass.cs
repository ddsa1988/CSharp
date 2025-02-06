namespace Basics.S011_ObjectOrientedProgramming.Models;
public static class TimeUtilClass {
    public static void PrintTime() {
        Console.WriteLine("Actual time: " + DateTime.Now.ToShortTimeString());
    }

    public static void PrintDate() {
        Console.WriteLine("Actual date: " + DateTime.Now.ToShortDateString());
    }

    public static int GetAge(DateTime birthday) {
        const int DAYS_PER_YEAR = 365;

        DateTime now = DateTime.Now;
        TimeSpan elapsed = now.Subtract(birthday);

        ArgumentOutOfRangeException.ThrowIfLessThan(elapsed.TotalDays, 0, nameof(birthday));

        int age = (int)(elapsed.TotalDays / DAYS_PER_YEAR);

        return age;
    }
}
