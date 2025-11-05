using System.Diagnostics;

namespace Examples.ObjectFinalizer;

public static class Example001 {
    public static void Run() {
        var stopwatch = new Stopwatch();
        var clones = new List<Clone>();
        bool loopControl = true;

        stopwatch.Start();

        while (loopControl) {
            Console.Write("Create clone press 'a'; Clear list press 'c'; call GC press 'g': ");
            char input = Console.ReadKey(true).KeyChar;

            switch (input) {
                case 'a':
                    clones.Add(new Clone());

                    break;
                case 'c':
                    Console.WriteLine($"Clearing the list at time: {stopwatch.ElapsedMilliseconds} ms");
                    clones.Clear();
                    break;
                case 'g':
                    Console.WriteLine($"Collecting the list at time: {stopwatch.ElapsedMilliseconds} ms");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    break;
                default:
                    loopControl = false;
                    break;
            }
        }

        stopwatch.Stop();
    }
}

public class Clone {
    private static int _cloneCount;
    public int CloneId { get; } = ++_cloneCount;

    public Clone() {
        Console.WriteLine($"Clone #{CloneId} is wreaking havoc.");
    }

    // Object finalizer
    ~Clone() {
        Console.WriteLine($"Clone #{CloneId} was destroyed.");
    }
}