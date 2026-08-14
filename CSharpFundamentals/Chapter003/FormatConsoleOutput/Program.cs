namespace FormatConsoleOutput;

public static class Program {
    public static void Main() {
        const string myName = "Diego";
        const int myAge = 38;
        const string myEmail = "diego@outlook.com";

        ConsoleColor previousColor = Console.ForegroundColor;

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Hello, " + myName + "! You are " + myAge + " years old and your e-mail is " + myEmail);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Hello, {0}! You are {1} years old and your e-mail is {2}", myName, myAge, myEmail);

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Hello, {myName}! You are {myAge} years old and your e-mail is {myEmail}");

        Console.ForegroundColor = previousColor;
    }
}