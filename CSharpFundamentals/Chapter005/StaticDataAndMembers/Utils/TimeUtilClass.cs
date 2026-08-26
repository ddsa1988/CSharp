namespace StaticDataAndMembers.Utils;

internal static class TimeUtilClass {
    internal static void PrintTime() {
        Console.WriteLine(DateTime.Now.ToShortTimeString());
    }

    internal static void PrintDate() {
        Console.WriteLine(DateTime.Now.ToShortDateString());
    }
}