namespace WorkingWithDecisions.Examples;

internal static class SwitchStatement {
    public static void Run() {
        ExecutePatternMatchingSwitch();
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

    private static void ExecutePatternMatchingSwitch() { }
}