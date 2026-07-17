using MVVM_Stopwatch.Model;

namespace MVVM_Stopwatch;

public static class Program {
    public static void Main(string[] args) {
        var stopwatch = new StopwatchModel();

        Console.WriteLine(stopwatch.ElapsedTime);
        stopwatch.Running = true;

        Thread.Sleep(5000);

        Console.WriteLine(stopwatch.ElapsedTime);
        stopwatch.Running = false;
    }
}