using AbilityScoreApp.Models;

namespace AbilityScoreApp.Examples;

public static class UsingAbilityScoreCalculator {
    public static void Run() {
        var calculator = new AbilityScoreCalculator();

        while (true) {
            calculator.RollResult = ReadInt(calculator.RollResult, "Starting 4d6 roll");
            calculator.DivideBy = ReadDouble(calculator.DivideBy, "Divide by");
            calculator.AddAmount = ReadInt(calculator.AddAmount, "Add amount");
            calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");

            calculator.CalculateAbilityScore();

            Console.WriteLine("Calculate ability score: " + calculator.Score);

            Console.Write("\nPress 'Q' to quit' or any other key to continue: ");
            char key = Console.ReadKey(true).KeyChar;

            if (char.ToLower(key) == 'q') {
                return;
            }

            Console.WriteLine("\n");
        }
    }

    /// <summary>
    /// Writes a prompt and reads an int value from the console.
    /// </summary>
    /// <param name="lastUsedValue">The default value.</param>
    /// <param name="prompt">Prompt to print to the console.</param>
    /// <returns>The int value read, or the default value if unable to parse</returns>
    private static int ReadInt(int lastUsedValue, string prompt) {
        Console.Write($"{prompt} [{lastUsedValue}]: ");
        string? userInput = Console.ReadLine();

        bool isNumberValid = int.TryParse(userInput, out int number) && number > 0;

        if (!isNumberValid) {
            Console.WriteLine($"Using default value {lastUsedValue}");
            return lastUsedValue;
        }

        Console.WriteLine($"Using value {number}");

        return number;
    }

    /// <summary>
    /// Writes a prompt and reads an int value from the console.
    /// </summary>
    /// <param name="lastUsedValue">The default value.</param>
    /// <param name="prompt">Prompt to print to the console.</param>
    /// <returns>The int value read, or the default value if unable to parse</returns>
    private static double ReadDouble(double lastUsedValue, string prompt) {
        Console.Write($"{prompt} [{lastUsedValue}]: ");
        string? userInput = Console.ReadLine();

        bool isNumberValid = double.TryParse(userInput, out double number) && number > 0;

        if (!isNumberValid) {
            Console.WriteLine($"Using default value {lastUsedValue}");
            return lastUsedValue;
        }

        Console.WriteLine($"Using value {number}");

        return number;
    }
}