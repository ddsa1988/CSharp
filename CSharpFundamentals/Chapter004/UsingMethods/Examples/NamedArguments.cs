namespace UsingMethods.Examples;

internal static class NamedArguments {
    internal static void Run() {
        DisplayFancyMessage(message: "Hello, World!", textColor: ConsoleColor.DarkRed, background: ConsoleColor.Green);

        DisplayName(firstName: "Diego");
        DisplayName(middleName: "Santos");
        DisplayName(lastName: "Alexander");
        DisplayName("Diego", "Santos", "Alexander");
    }

    private static void DisplayFancyMessage(ConsoleColor textColor, ConsoleColor background, string message) {
        ConsoleColor oldTextColor = Console.ForegroundColor;
        ConsoleColor oldBackgroundColor = Console.BackgroundColor;

        Console.ForegroundColor = textColor;
        Console.BackgroundColor = background;

        Console.WriteLine(message);

        Console.ForegroundColor = oldTextColor;
        Console.BackgroundColor = oldBackgroundColor;
    }

    private static void DisplayName(string firstName = "", string middleName = "", string lastName = "") {
        string fullName = firstName + " " + middleName + " " + lastName;
        Console.WriteLine(fullName.Trim());
    }
}