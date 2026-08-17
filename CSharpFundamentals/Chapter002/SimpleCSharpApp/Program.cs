namespace SimpleCSharpApp;

public static class Program {
    public static void Main(string[] args) {
        // Setup console UI (CUI)
        const string greeting = "***** Welcome to My First App *****";
        string stars = new string('*', greeting.Length);

        Console.Title = "First App";
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.WriteLine(stars);
        Console.WriteLine(greeting);
        Console.WriteLine(stars);
        Console.BackgroundColor = ConsoleColor.Black;

        // Wait for Enter Key to be pressed
        Console.ReadLine();
    }
}