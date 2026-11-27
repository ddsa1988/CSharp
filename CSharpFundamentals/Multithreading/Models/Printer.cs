namespace Multithreading.Models;

internal class Printer() {
    public void PrintNumbers() {
        const int milliseconds = 2000;

        // Display thread info.
        Console.WriteLine($"-> {Thread.CurrentThread.Name} is executing {nameof(PrintNumbers)}()");

        // Print out numbers.
        Console.Write("Your numbers: ");
        for (int i = 0; i < 10; i++) {
            Console.WriteLine(i + ", ");
            Thread.Sleep(milliseconds);
        }

        Console.WriteLine();
    }
}