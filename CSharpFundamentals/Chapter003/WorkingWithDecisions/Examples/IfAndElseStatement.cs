namespace WorkingWithDecisions.Examples;

internal static class IfAndElseStatement {
    public static void Run() {
        TernaryConditionalOperator();
    }

    private static void IfElse() {
        Console.WriteLine(" ***** Welcome *****");
        Console.Write("Type something: ");
        string? userInput = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(userInput)) {
            Console.WriteLine("You have typed nothing!");
            Console.WriteLine("Program finished.");
            return;
        }

        Console.WriteLine("You typed: " + userInput);
    }

    private static void IfElsePatherMatching() {
        Console.WriteLine(" ***** Welcome *****");
        Console.Write("Type a number: ");
        string? userInput = Console.ReadLine();

        if (userInput is null) {
            Console.WriteLine("You have typed nothing!");
            Console.WriteLine("Program finished.");
            return;
        }

        if (!double.TryParse(userInput, out double number)) {
            Console.WriteLine("You did not type a number!");
            return;
        }

        if (number is > 0 and < 100) {
            Console.WriteLine("The number you typed is between 0 and 100.");
        }

        if (number is (> 200 and < 400)) {
            Console.WriteLine("The number you typed is between 200 and 400.");
        }

        Console.WriteLine("You typed the number: " + number);
    }

    private static void TernaryConditionalOperator() {
        Console.WriteLine(" ***** Welcome *****");
        Console.Write("Type something: ");
        string? userInput = Console.ReadLine();

        userInput = string.IsNullOrWhiteSpace(userInput) ? "You have typed nothing!" : userInput;

        Console.WriteLine("You typed: " + userInput);
    }
}