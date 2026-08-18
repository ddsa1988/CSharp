namespace WorkingWithLoops.Examples;

internal static class WhileLoop {
    internal static void Run() {
        string? userIsDone = "";

        while (userIsDone?.ToLower() != "yes") {
            Console.WriteLine("In while loop.");
            Console.Write("Are you done? [yes/no]: ");
            userIsDone = Console.ReadLine();
        }
    }
}