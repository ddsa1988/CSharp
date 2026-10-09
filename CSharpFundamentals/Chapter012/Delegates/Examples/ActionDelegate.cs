namespace Delegates.Examples;

internal static class ActionDelegate {
    public static void Run() {
        Action<string, ConsoleColor, int> actionTarget = DisplayMessage;

        actionTarget("Action Message!", ConsoleColor.Green, 5);
    }

    private static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount) {
        ConsoleColor previousColor = Console.ForegroundColor;
        Console.ForegroundColor = txtColor;

        for (int i = 0; i < printCount; i++) {
            Console.Write(msg + " ");
        }

        Console.ForegroundColor = previousColor;
    }
}