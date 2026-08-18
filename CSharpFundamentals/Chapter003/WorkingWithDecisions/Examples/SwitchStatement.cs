namespace WorkingWithDecisions.Examples;

internal static class SwitchStatement {
    public static void Run() {
        ExecutePatternMatchingSwitchWithWhen();
    }

    private static void SwitchExample() {
        Console.WriteLine("1 [C#], 2 [VB]");
        Console.Write("Pleaser pick your language preference: ");
        string? userInput = Console.ReadLine();

        if (!int.TryParse(userInput, out int languageChoice)) {
            Console.WriteLine("Invalid choice");
            return;
        }

        switch (languageChoice) {
            case 1:
                Console.WriteLine("Good choice, C# is a fine language.");
                break;
            case 2:
                Console.WriteLine("VB: OOP, multithreading, and more!");
                break;
            default:
                Console.WriteLine("Well... good luck with that!");
                break;
        }
    }

    private static void SwitchOnStringExample() {
        Console.WriteLine("1 [C#], 2 [VB]");
        Console.Write("Pleaser pick your language preference: ");
        string? userInput = Console.ReadLine();

        switch (userInput?.ToUpper()) {
            case "C#":
                Console.WriteLine("Good choice, C# is a fine language.");
                break;
            case "VB":
                Console.WriteLine("VB: OOP, multithreading, and more!");
                break;
            default:
                Console.WriteLine("Well... good luck with that!");
                break;
        }
    }

    private static void ExecutePatternMatchingSwitch() {
        Console.WriteLine("1 [Integer (5)], 2 [String (\"Hi\")], 3 [Decimal (2.5)]");
        Console.Write("Please chose an option: ");
        string? userInput = Console.ReadLine();

        if (string.IsNullOrEmpty(userInput)) {
            Console.WriteLine("Invalid option!");
            return;
        }

        object choice;

        // This is a standard constant pattern switch statement
        switch (userInput) {
            case "1":
                choice = 5;
                break;
            case "2":
                choice = "Hi";
                break;
            case "3":
                choice = 2.5M;
                break;
            default:
                choice = 5;
                break;
        }

        // This is the pattern matching switch statement
        switch (choice) {
            case int i:
                Console.WriteLine("Your choice is an integer: " + i);
                break;
            case string s:
                Console.WriteLine("Your choice is a string: " + s);
                break;
            case decimal d:
                Console.WriteLine("Your choice is a decimal: " + d);
                break;
            default:
                Console.WriteLine("Your choice is something else.");
                break;
        }
    }

    private static void ExecutePatternMatchingSwitchWithWhen() {
        Console.WriteLine("1 [C#], 2 [VB]");
        Console.Write("Pleaser pick your language preference: ");

        object? userInput = Console.ReadLine();

        if (userInput == null) return;

        object choice = int.TryParse(userInput.ToString(), out int languageChoice) ? languageChoice : userInput;

        switch (choice) {
            case int i when i == 1:
            case string s when s.Equals("C#", StringComparison.OrdinalIgnoreCase):
                Console.WriteLine("Good choice, C# is a fine language.");
                break;
            case int i when i == 2:
            case string s when s.Equals("VB", StringComparison.OrdinalIgnoreCase):
                Console.WriteLine("VB: OOP, multithreading, and more!");
                break;
            default:
                Console.WriteLine("Well... good luck with that!");
                break;
        }
    }
}